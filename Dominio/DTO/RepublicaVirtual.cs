namespace Dominio.DTO
{
    /// <summary>
    /// Mapeamento do serviço República Virtual
    /// http://cep.republicavirtual.com.br/web_cep.php?cep=00000000&formato=json
    /// </summary>
    public class RepublicaVirtual
    {
        public string resultado { get; set; } = "";

        public string resultado_txt { get; set; } = "";

        public string uf { get; set; } = "";

        public string cidade { get; set; } = "";

        public string bairro { get; set; } = "";

        public string tipo_logradouro { get; set; } = "";

        public string logradouro { get; set; } = "";
    }
}