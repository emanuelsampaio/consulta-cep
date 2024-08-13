using System.ComponentModel;

namespace Dominio.Enums
{
    /// <summary>
    /// Define as APIs externas utilizadas para consulta de CEP
    /// </summary>
    public enum ApiExterna
    {
        [Description("Brasil Aberto")]
        BRASIL_ABERTO,

        [Description("Via CEP")]
        VIA_CEP,

        [Description("Open CEP")]
        OPEN_CEP,

        [Description("Brasil API")]
        BRASIL_API,

        [Description("API CEP")]
        API_CEP,

        [Description("República Virtual")]
        REP_VIRTUAL
    }
}