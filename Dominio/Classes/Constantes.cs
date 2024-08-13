namespace Dominio.Classes
{
    /// <summary>
    /// Constantes que influenciam de alguma forma no negócio
    /// </summary>
    public static class Constantes
    {
        /// <summary>
        /// Máscara do CEP utilizada na URL, padrão 1
        /// </summary>
        public const string MASK_FORMAT_CEP_1 = "00000000";

        /// <summary>
        /// Máscara do CEP utilizada na URL, padrão 2
        /// </summary>
        public const string MASK_FORMAT_CEP_2 = "00000-000";

        /// <summary>
        /// CEP utilizado para verificar disponibilidade da API
        /// </summary>
        public const string CEP_TESTE         = "70070600";


        /// <summary>
        /// Caminho dos templantes para as controllers de API
        /// </summary>
        public class Templates
        {
            public const string Ping         = "ping";
            public const string BrasilAberto = "brasil-aberto";
            public const string ViaCep       = "via-cep";
            public const string OpenCep      = "open-cep";
            public const string BrasilApi    = "brasil-api";
            public const string ApiCep       = "api-cep";
            public const string RepVirtual   = "republica-virtual";
        }


        /// <summary>
        /// Mensagens exibidas no sistema
        /// </summary>
        public class Mensagens
        {
            public const string CEP_INVALIDO = "CEP Inválido.";
            public const string ERRO_CEP     = "Ocorreu um problema ao buscar o CEP.";
            public const string ERRO_PING    = "Ocorreu um problema ao verificar APIs.";
        }
    }
}