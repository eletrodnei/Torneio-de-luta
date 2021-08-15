using System;
using System.Collections.Generic;
using System.Linq;

namespace Torneio_de_luta.Modelo
{
    class Regras
    {
        //private List<Lutadores> quartasdefinal = new List<Lutadores>();
        //  private List<Lutadores> semifinal = new List<Lutadores>();
        //  private List<Lutadores> final = new List<Lutadores>();
        //  private static Lutadores campeao = new Lutadores();

        public static Lutadores Resultado(List<Lutadores> lutadoresSelecionados)
        {
            List<Lutadores> selecionadosordenados = lutadoresSelecionados.OrderBy(lutadoresSelecionados => lutadoresSelecionados.Idade).ToList();

            List<Lutadores> quartasdefinal = new List<Lutadores>();
            for (int x = 0; x < selecionadosordenados.Count; x += 2)
            {
                quartasdefinal.Add(Luta(selecionadosordenados[x], selecionadosordenados[x + 1]));
            }
            /*VerificaVencedorOitavas(selecionadosordenados[0], selecionadosordenados[1]);
            VerificaVencedorOitavas(selecionadosordenados[2], selecionadosordenados[3]);
            VerificaVencedorOitavas(selecionadosordenados[4], selecionadosordenados[5]);
            VerificaVencedorOitavas(selecionadosordenados[6], selecionadosordenados[7]);
            VerificaVencedorOitavas(selecionadosordenados[8], selecionadosordenados[9]);
            VerificaVencedorOitavas(selecionadosordenados[10], selecionadosordenados[11]);
            VerificaVencedorOitavas(selecionadosordenados[12], selecionadosordenados[13]);
            VerificaVencedorOitavas(selecionadosordenados[14], selecionadosordenados[15]);
            */
            List<Lutadores> quartasdefinalordenada = quartasdefinal.OrderBy(quartasdefinal => quartasdefinal.Idade).ToList();

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

            /*VerificaVencedorQuartas(quartasdefinalordenada[0], quartasdefinalordenada[1]);
            VerificaVencedorQuartas(quartasdefinalordenada[2], quartasdefinalordenada[3]);
            VerificaVencedorQuartas(quartasdefinalordenada[4], quartasdefinalordenada[5]);
            VerificaVencedorQuartas(quartasdefinalordenada[6], quartasdefinalordenada[7]);
            */


            /*VerificaVencedorSemiFinal(semifinal[0], semifinal[1]);
            VerificaVencedorSemiFinal(semifinal[2], semifinal[3]);
            */

            Lutadores campeao = Luta(final[0], final[1]);
            return campeao;
        }

        private static Lutadores Luta(Lutadores lutador1, Lutadores lutador2)
        {
            int Lutador1 = ((int)(((decimal)lutador1.Vitorias / lutador1.Lutas) * 100));
            int Lutador2 = ((int)(((decimal)lutador2.Vitorias / lutador2.Lutas) * 100));

            if (Lutador1 > Lutador2)
            {
                return lutador1;
            }
            else if (Lutador1 < Lutador2)
            {
                return lutador2;
            }
            else if (lutador1.ArtesMarciais.Count > lutador2.ArtesMarciais.Count)
            {
                return lutador1;
            }
            else if (lutador1.ArtesMarciais.Count < lutador2.ArtesMarciais.Count)
            {
                return lutador2;
            }
            else if (lutador1.Lutas > lutador2.Lutas)
            {
                return lutador1;
            }
            else
            {
                return lutador2;
            }
        }

        //    private static void VerificaVencedorOitavas(Lutadores lutador1, Lutadores lutador2)
        //    {
        //        float Lutador1 = (lutador1.Vitorias / lutador1.Lutas) * 100;
        //        float Lutador2 = (lutador2.Vitorias / lutador2.Lutas) * 100;

        //        if (Lutador1 > Lutador2)
        //        {
        //            quartasdefinal.Add(lutador1);
        //        }
        //        else if (Lutador1 < Lutador2)
        //        {
        //            quartasdefinal.Add(lutador2);
        //        }
        //        else if (lutador1.ArtesMarciais.Count > lutador2.ArtesMarciais.Count)
        //        {
        //            quartasdefinal.Add(lutador1);
        //        }
        //        else if (lutador1.ArtesMarciais.Count < lutador2.ArtesMarciais.Count)
        //        {
        //            quartasdefinal.Add(lutador2);
        //        }
        //        else if (lutador1.Lutas > lutador2.Lutas)
        //        {
        //            quartasdefinal.Add(lutador1);
        //        }
        //        else
        //        {
        //            quartasdefinal.Add(lutador2);
        //        }
        //    }

        //    private static void VerificaVencedorQuartas(Lutadores lutador1, Lutadores lutador2)
        //    {
        //        float Lutador1 = (lutador1.Vitorias / lutador1.Lutas) * 100;
        //        float Lutador2 = (lutador2.Vitorias / lutador2.Lutas) * 100;

        //        if (Lutador1 > Lutador2)
        //        {
        //            semifinal.Add(lutador1);
        //        }
        //        else if (Lutador1 < Lutador2)
        //        {
        //            semifinal.Add(lutador2);
        //        }
        //        else if (lutador1.ArtesMarciais.Count > lutador2.ArtesMarciais.Count)
        //        {
        //            semifinal.Add(lutador1);
        //        }
        //        else if (lutador1.ArtesMarciais.Count < lutador2.ArtesMarciais.Count)
        //        {
        //            semifinal.Add(lutador2);
        //        }
        //        else if (lutador1.Lutas > lutador2.Lutas)
        //        {
        //            semifinal.Add(lutador1);
        //        }
        //        else
        //        {
        //            semifinal.Add(lutador2);
        //        }

        //    }

        //    private static void VerificaVencedorSemiFinal(Lutadores lutador1, Lutadores lutador2)
        //    {
        //        float Lutador1 = (lutador1.Vitorias / lutador1.Lutas) * 100;
        //        float Lutador2 = (lutador2.Vitorias / lutador2.Lutas) * 100;

        //        if (Lutador1 > Lutador2)
        //        {
        //            final.Add(lutador1);
        //        }
        //        else if (Lutador1 < Lutador2)
        //        {
        //            final.Add(lutador2);
        //        }
        //        else if (lutador1.ArtesMarciais.Count > lutador2.ArtesMarciais.Count)
        //        {
        //            final.Add(lutador1);
        //        }
        //        else if (lutador1.ArtesMarciais.Count < lutador2.ArtesMarciais.Count)
        //        {
        //            final.Add(lutador2);
        //        }
        //        else if (lutador1.Lutas > lutador2.Lutas)
        //        {
        //            final.Add(lutador1);
        //        }
        //        else
        //        {
        //            final.Add(lutador2);
        //        }

        //    }

        //    private static Lutadores VerificaVencedorFinal(Lutadores lutador1,
        //                                                   Lutadores lutador2)
        //    {
        //        float Lutador1 = (lutador1.Vitorias / lutador1.Lutas) * 100;
        //        float Lutador2 = (lutador2.Vitorias / lutador2.Lutas) * 100;

        //        if (Lutador1 > Lutador2)
        //        {
        //            return lutador1;
        //        }
        //        else if (Lutador1 < Lutador2)
        //        {
        //            return lutador2;
        //        }
        //        else if (lutador1.ArtesMarciais.Count > lutador2.ArtesMarciais.Count)
        //        {
        //            return lutador1;
        //        }
        //        else if (lutador1.ArtesMarciais.Count < lutador2.ArtesMarciais.Count)
        //        {
        //            return lutador2;
        //        }
        //        else if (lutador1.Lutas > lutador2.Lutas)
        //        {
        //            return lutador1;
        //        }
        //        else
        //        {
        //            return lutador2;
        //        }

        //    }
    }
}
