namespace Dominio.Classes
{
    /// <summary>
    /// Classe para conversão de valores
    /// </summary>
    public static class Conversao
    {
        /// <summary>
        /// Retira a máscara, deixando somente números
        /// </summary>
        /// <param name="campo"></param>
        /// <returns></returns>
        public static String RemoverMascara(String campo)
        {
            return campo.Trim().Replace(".", "").Replace("-", "").Replace("/", "").Replace("\\", "");
        }
    }
}