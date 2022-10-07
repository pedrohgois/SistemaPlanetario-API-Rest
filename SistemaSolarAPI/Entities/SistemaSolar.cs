using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace SistemaSolarAPI.Entities
{
    public class SistemaSolar
    {
        public SistemaSolar(int id, string nome, int massaEstrela)
        {
            Id = id;
            Nome = nome;
            MassaEstrela = massaEstrela;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int MassaEstrela { get; set; }
        public virtual ICollection<Planeta> Planetas { get; set; }
    }
}
