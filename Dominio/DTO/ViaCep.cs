namespace Dominio.DTO
{
    /// <summary>
    /// Mapeamento do serviço Via CEP
    /// https://viacep.com.br/ws/00000000/json
    /// </summary>
    public class ViaCep
    {
        public string cep { get; set; } = "";

        public string logradouro { get; set; } = "";

        public string complemento { get; set; } = "";

        public string unidade { get; set; } = "";

        public string bairro { get; set; } = "";

        public string localidade { get; set; } = "";

        public string uf { get; set; } = "";

        public string ibge { get; set; } = "";

        public string gia { get; set; } = "";

        public string ddd { get; set; } = "";

        public string siafi { get; set; } = "";
    }
}