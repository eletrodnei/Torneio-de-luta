using System.Collections.Generic;

namespace Torneio_de_luta.Modelo
{
    public class Lutadores
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<string> ArtesMarciais { get; set; }
        public int Lutas { get; set; }
        public int Derrotas { get; set; }
        public int Vitorias { get; set; }

        public static string MountLutador(Lutadores lutador)
        {
            return "ID - " + lutador.Id.ToString() +
              "\n" + "Idade - " + lutador.Idade.ToString() + "\n" +
            "Artes Marciais - " + lutador.ArtesMarciais.Count + "\n" +
            "Total de lutas - " + lutador.Lutas.ToString() + "\n" +
            "Derrotas - " + lutador.Derrotas.ToString() + "\n" +
             "Vitórias - " + lutador.Vitorias.ToString() + "\n";
        }
    }

}
