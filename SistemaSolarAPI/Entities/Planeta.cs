using System.ComponentModel.DataAnnotations;

namespace SistemaSolarAPI.Entities
{
    public class Planeta
    {
        public Planeta(int id, string nome, double massa, int distancia)
        {
            Id = id;
            Nome = nome;
            Massa = massa;
            Distancia = distancia;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Massa { get; set; }
        public int Distancia { get; set; }
        public SistemaSolar SistemaSolar { get; set; }  
    }
}
