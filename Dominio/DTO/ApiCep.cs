namespace Dominio.DTO
{
    /// <summary>
    /// Mapeamento do serviço API CEP
    /// https://cdn.apicep.com/file/apicep/00000-000.json
    /// </summary>
    public class ApiCep
    {
        public string status { get; set; } = "";

        public string code { get; set; } = "";

        public string state { get; set; } = "";

        public string city { get; set; } = "";

        public string district { get; set; } = "";

        public string address { get; set; } = "";
    }
}