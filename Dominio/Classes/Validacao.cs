namespace Dominio.Classes
{
    /// <summary>
    /// Classe para validações
    /// </summary>
    public static class Validacao
    {
        /// <summary>
        /// Valida um cep
        /// </summary>
        /// <param name="cep"></param>
        /// <returns></returns>
        public static bool IsCep(string cep)
        {
            if (String.IsNullOrEmpty(cep))
            {
                return false;
            }

            cep = Conversao.RemoverMascara(cep);

            if (cep.Length != 8 || !cep.All(char.IsDigit))
            {
                return false;
            }

            return true;
        }
    }
}