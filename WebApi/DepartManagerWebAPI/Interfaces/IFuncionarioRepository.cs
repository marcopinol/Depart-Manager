using DepartManagerWebAPI.Models;

namespace DepartManagerWebAPI.Interfaces
{
    public interface IFuncionarioRepository
    {
        bool RegisterFuncionario(int departId, Funcionario funcionario);
        List<Funcionario> ListarFuncionarios(int departId);
        bool FuncionarioExiste(int id);

    }
}
