namespace Dominio.DTO
{
    /// <summary>
    /// Mapeamento do serviço Open CEP
    /// https://opencep.com/v1/00000000
    /// </summary>
    public class OpenCep
    {
        public string cep { get; set; } = "";

        public string logradouro { get; set; } = "";

        public string complemento { get; set; } = "";

        public string unidade { get; set; } = "";

        public string bairro { get; set; } = "";

        public string localidade { get; set; } = "";

        public string uf { get; set; } = "";

        public string ibge { get; set; } = "";
    }
}