using DepartManagerWebAPI.Models;

namespace DepartManagerWebAPI.Interfaces
{
    public interface IDepartamentoRepository
    {
        List<Departamento> Listar();
        bool CreateDepart(Departamento depart);
        bool DeleteDepart(Departamento depart);
        bool DepartExist(int id);
        Departamento GetDepartamento(int departId);  
    }
}
