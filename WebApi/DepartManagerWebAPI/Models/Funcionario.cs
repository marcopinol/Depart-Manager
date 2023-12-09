namespace DepartManagerWebAPI.Models
{
    public class Funcionario
    {
        public Funcionario()
        {
            
        }
        public Funcionario(int id, string nome, string rG, int departId)
        {
            this.Id = id;
            this.Nome = nome;
            this.RG = rG;
            this.departamentoId = departId;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public int departamentoId { get; set; }
    }
}
