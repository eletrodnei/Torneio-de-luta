using System.Windows;
using Torneio_de_luta.Modelo;

namespace Torneio_de_luta.Visao
{
    /// <summary>
    /// Lógica interna para Resultado.xaml
    /// </summary>
    /// 
    public partial class Resultado : Window
    {
        private readonly Lutadores campeao;

        public Resultado(Lutadores campeao)
        {
            InitializeComponent();
            this.campeao = campeao;
        }

        private void LabResultado_Loaded(object sender, RoutedEventArgs e)
        {
            LabResultado.Content = "  CAMPEÃO  " + "\n\n" + campeao.Nome1;
        }
    }
}
