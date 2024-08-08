namespace Dominio.DTO
{
    /// <summary>
    /// Mapeamento do serviço Brasil Aberto
    /// https://api.brasilaberto.com/v1/zipcode/00000000
    /// </summary>
    public class BrasilAberto
    {
        public Meta? meta { get; set; }

        public Result? result { get; set; }
    }


    public class Meta
    {
        public int currentPage { get; set; }

        public int itemsPerPage { get; set; }

        public int totalOfItems { get; set; }

        public int totalOfPages { get; set; }
    }


    public class Result
    {
        public string street { get; set; } = "";

        public string complement { get; set; } = "";

        public string district { get; set; } = "";

        public string districtId { get; set; } = "";

        public string city { get; set; } = "";

        public string cityId { get; set; } = "";

        public string ibgeId { get; set; } = "";

        public string state { get; set; } = "";

        public string stateIbgeId { get; set; } = "";

        public string stateShortname { get; set; } = "";

        public string zipcode { get; set; } = "";
    }
}