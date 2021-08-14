using System.Collections.Generic;
using System.Linq;

namespace Torneio_de_luta.Modelo
{
    class Funcoes
    {
        public static void Ordenar(List<Modelo.Lutadores> lutadoresSelecionados)
        {
            List<Modelo.Lutadores> selecionadosordenados = lutadoresSelecionados.OrderBy(lutadoresSelecionados => lutadoresSelecionados.Idade).ToList();
         
            
        }
    }
}
