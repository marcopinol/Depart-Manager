using DepartManagerWebAPI.Data;
using DepartManagerWebAPI.Interfaces;
using DepartManagerWebAPI.Models;


namespace DepartManagerWebAPI.Repository
{
    public class DepartamentoRepository : IDepartamentoRepository
    {
        private readonly DataContext __context;
        public DepartamentoRepository(DataContext context)
        {
            __context = context;
        }
       public List<Departamento> Listar()
        {
            return __context.Departamentos.ToList();
        }
        public bool CreateDepart(Departamento departamento)
        {
            __context.Add(departamento);
            return Save();
        }

        public bool UpdateDepart(Departamento departamento)
        {
            __context.Update(departamento);
            return Save();
        }

        public bool DeleteDepart(Departamento departamento)
        {
            __context.Remove(departamento);
            return Save();
        }

        public bool DepartExist(int id)
        {
            return __context.Departamentos.Any(c => c.Id == id);
        }

        public bool Save()
        {
            var saved = __context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}