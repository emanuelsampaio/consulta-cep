namespace Dominio.Classes
{
    /// <summary>
    /// Mapeia as informações da aplicação constantes no appsettings.json
    /// </summary>
    public class Aplicacao
    {
        public static string APP = "Aplicacao";

        public string NOME { get; set; } = "";

        public string DESCRICAO { get; set; } = "";

        public string AUTOR { get; set; } = "";

        public string VERSAO { get; set; } = "";

        public string URL_BRASIL_ABERTO { get; set; } = "";

        public string URL_VIA_CEP { get; set; } = "";

        public string URL_OPEN_CEP { get; set; } = "";

        public string URL_BRASIL_API { get; set; } = "";

        public string URL_API_CEP { get; set; } = "";

        public string URL_REP_VIRTUAL { get; set; } = "";
    }
}