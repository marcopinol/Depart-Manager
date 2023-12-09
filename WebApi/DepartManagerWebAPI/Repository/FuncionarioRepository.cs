using DepartManagerWebAPI.Data;
using DepartManagerWebAPI.Dto;
using DepartManagerWebAPI.Interfaces;
using DepartManagerWebAPI.Models;


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

        public bool DepartExists(int id)
        {
            return __context.Departamentos.Any(d => d.Id == id);
        }

        public Funcionario GetEmploye(int employeId)
        {
            return __context.Funcionarios.Where(f => f.Id == employeId).FirstOrDefault();
        }

        public bool DeleteEmploye(Funcionario employe)
        {
            __context.Remove(employe);
            return Save();
        }

        public bool Save()
        {
            var saved = __context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
