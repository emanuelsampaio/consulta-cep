using Api.Servicos;
using Dominio.Classes;
using Dominio.Interfaces;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<Aplicacao>(builder.Configuration.GetSection(Aplicacao.APP));

builder.Services.AddScoped<IServicoAplicacao, ServicoAplicacao>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

Aplicacao? appSettings = builder.Configuration.GetSection(Aplicacao.APP).Get<Aplicacao>();

string nome = "", descricao = "", autor = "", versao = "";

if (appSettings != null)
{
    nome = appSettings.NOME;
    descricao = appSettings.DESCRICAO;
    autor = appSettings.AUTOR;
    versao = appSettings.VERSAO;
}

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = nome,
        Version = versao,
        Description = descricao,
        Contact = new OpenApiContact()
        {
            Name = autor,
            Url = new Uri("http://www.emanuelsampaio.com.br")
        }
    });

    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

    if (File.Exists(xmlPath))
    {
        c.IncludeXmlComments(xmlPath);
    }
});


var app = builder.Build();

app.UseSwagger();

app.UseStaticFiles(); //Necessário para alterar o layout do swagger

app.UseSwaggerUI(c =>
{
    c.DocumentTitle = nome;
    c.HeadContent = "<link rel='shortcut icon' type='image/x-icon' href='/swagger/cep/img/favicon.ico' sizes='16x16' />";
    c.SwaggerEndpoint("/swagger/v1/swagger.json", $"{nome} (v{versao})");
    c.InjectStylesheet("/swagger/cep/css/swagger.css");
    c.InjectJavascript("/swagger/cep/js/swagger.js");
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();