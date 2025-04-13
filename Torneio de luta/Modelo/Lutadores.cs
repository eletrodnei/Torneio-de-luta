using System.Collections.Generic;

namespace Torneio_de_luta.Modelo
{
    public class Lutadores : ILutadores
    {
        private int Id;
        private string Nome;
        private int Idade;
        private List<string> ArtesMarciais;
        private int Lutas;
        private int Derrotas;
        private int Vitorias;

        public int Id1 { get => Id; set => Id = value; }
        public string Nome1 { get => Nome; set => Nome = value; }
        public int Idade1 { get => Idade; set => Idade = value; }
        public List<string> ArtesMarciais1 { get => ArtesMarciais; set => ArtesMarciais = value; }
        public int Lutas1 { get => Lutas; set => Lutas = value; }
        public int Derrotas1 { get => Derrotas; set => Derrotas = value; }
        public int Vitorias1 { get => Vitorias; set => Vitorias = value; }

        string ILutadores.MountLutador(Lutadores lutador)
        {
            return "ID - " + lutador.Id1.ToString() +
              "\n" + "Idade - " + lutador.Idade1.ToString() + "\n" +
            "Artes Marciais - " + lutador.ArtesMarciais1.Count + "\n" +
            "Total de lutas - " + lutador.Lutas1.ToString() + "\n" +
            "Derrotas - " + lutador.Derrotas1.ToString() + "\n" +
             "Vitórias - " + lutador.Vitorias1.ToString() + "\n";
        }
    }

}
