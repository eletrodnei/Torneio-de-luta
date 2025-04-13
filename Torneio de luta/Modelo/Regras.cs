using System.Collections.Generic;
using System.Linq;

namespace Torneio_de_luta.Modelo
{
    class Regras
    {
        public static Lutadores Resultado(List<Lutadores> lutadoresSelecionados)
        {
            List<Lutadores> selecionadosordenados = lutadoresSelecionados.OrderBy(lutadoresSelecionados => lutadoresSelecionados.Idade1).ToList();

            List<Lutadores> quartasdefinal = new List<Lutadores>();
            for (int x = 0; x < selecionadosordenados.Count; x += 2)
            {
                quartasdefinal.Add(Luta(selecionadosordenados[x], selecionadosordenados[x + 1]));
            }

            List<Lutadores> quartasdefinalordenada = quartasdefinal.OrderBy(quartasdefinal => quartasdefinal.Idade1).ToList();

            List<Lutadores> semifinal = new List<Lutadores>();
            for (int x = 0; x < quartasdefinalordenada.Count; x += 2)
            {
                semifinal.Add(Luta(quartasdefinalordenada[x], quartasdefinalordenada[x + 1]));
            }

            List<Lutadores> final = new List<Lutadores>();
            for (int x = 0; x < semifinal.Count; x += 2)
            {
                final.Add(Luta(semifinal[x], semifinal[x + 1]));
            }

            Lutadores campeao = Luta(final[0], final[1]);
            return campeao;
        }

        private static Lutadores Luta(Lutadores lutador1, Lutadores lutador2)
        {
            int Lutador1 = ((int)(((decimal)lutador1.Vitorias1 / lutador1.Lutas1) * 100));
            int Lutador2 = ((int)(((decimal)lutador2.Vitorias1 / lutador2.Lutas1) * 100));

            if (Lutador1 > Lutador2)
            {
                return lutador1;
            }
            else if (Lutador1 < Lutador2)
            {
                return lutador2;
            }
            else if (lutador1.ArtesMarciais1.Count > lutador2.ArtesMarciais1.Count)
            {
                return lutador1;
            }
            else if (lutador1.ArtesMarciais1.Count < lutador2.ArtesMarciais1.Count)
            {
                return lutador2;
            }
            else if (lutador1.Lutas1 > lutador2.Lutas1)
            {
                return lutador1;
            }
            else
            {
                return lutador2;
            }
        }
    }
}
