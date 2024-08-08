using Dominio.Classes;

namespace Dominio.Interfaces
{
    public interface IServicoAplicacao
    {
        /// <summary>
        /// Retorna as infomações de configuração da aplicação
        /// </summary>
        /// <returns></returns>
        public Aplicacao Get();
    }
}