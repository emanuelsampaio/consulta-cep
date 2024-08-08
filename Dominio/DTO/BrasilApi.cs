namespace Dominio.DTO
{
    /// <summary>
    /// Mapeamento do serviço Brasil API
    /// https://brasilapi.com.br/api/cep/v2/00000000
    /// </summary>
    public class BrasilApi
    {
        public string cep { get; set; } = "";

        public string state { get; set; } = "";

        public string city { get; set; } = "";

        public string neighborhood { get; set; } = "";

        public string street { get; set; } = "";

        public string service { get; set; } = "";

        public Location? location { get; set; }
    }


    public class Location
    {
        public string type { get; set; } = "";

        public Coordinates? coordinates { get; set; }
    }


    public class Coordinates
    {
        public string longitude { get; set; } = "";

        public string latitude { get; set; } = "";
    }
}