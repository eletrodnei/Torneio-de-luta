using System.Collections.Generic;

namespace Torneio_de_luta.Modelo
{
    public interface ILutadores
    {
        List<string> ArtesMarciais1 { get; set; }
        int Derrotas1 { get; set; }
        int Id1 { get; set; }
        int Idade1 { get; set; }
        int Lutas1 { get; set; }
        string Nome1 { get; set; }
        int Vitorias1 { get; set; }

        public abstract string MountLutador(Lutadores lutador);
    }
}