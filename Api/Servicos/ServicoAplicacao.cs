using Dominio.Classes;
using Dominio.Interfaces;
using Microsoft.Extensions.Options;

namespace Api.Servicos
{
    /// <summary>
    /// Serviço que retorna as configurações da aplicação
    /// </summary>
    public class ServicoAplicacao : IServicoAplicacao
    {
        private readonly IOptions<Aplicacao> options;


        /// <summary>
        /// Injeta o serviço no construtor
        /// </summary>
        /// <param name="options"></param>
        public ServicoAplicacao(IOptions<Aplicacao> options)
        {
            this.options = options;
        }


        /// <summary>
        /// Retorna as configurações do appsettings
        /// </summary>
        /// <returns></returns>
        public Aplicacao Get()
        {
            return this.options.Value;
        }
    }
}