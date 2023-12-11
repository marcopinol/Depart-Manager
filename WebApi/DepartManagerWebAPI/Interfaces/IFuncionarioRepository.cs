using DepartManagerWebAPI.Dto;
using DepartManagerWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DepartManagerWebAPI.Interfaces
{
    public interface IFuncionarioRepository
    {
        bool RegisterFuncionario(Funcionario employe);
        List<Funcionario> ListarFuncionarios(int departId);
        bool FuncionarioExiste(int id);
        bool DepartExists(int departId);
        Funcionario GetEmploye(int employeId);
        bool DeleteEmploye(Funcionario employe);
    }
}
