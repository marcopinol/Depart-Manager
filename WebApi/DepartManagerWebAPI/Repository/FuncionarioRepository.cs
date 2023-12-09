using DepartManagerWebAPI.Data;
using DepartManagerWebAPI.Interfaces;
using DepartManagerWebAPI.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace DepartManagerWebAPI.Repository
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly DataContext __context;

        public FuncionarioRepository(DataContext context)
        {
            __context = context;
        }

        public List<Funcionario> ListarFuncionarios(int departId)
        {
            return __context.Funcionarios.Where(f => f.departamentoId == departId).ToList();
        }

        public bool RegisterFuncionario(int departId, Funcionario funcionario)
        {
            __context.Add(funcionario);
            return Save();
        }

        public bool FuncionarioExiste(int id)
        {
            return __context.Funcionarios.Any(f => f.Id == id);
        }

        public bool Save()
        {
            var saved = __context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
