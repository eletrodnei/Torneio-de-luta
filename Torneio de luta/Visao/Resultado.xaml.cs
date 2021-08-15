using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Torneio_de_luta.Modelo;

namespace Torneio_de_luta.Visao
{
    /// <summary>
    /// Lógica interna para Resultado.xaml
    /// </summary>
    /// 

    public partial class Resultado : Window
    {
        private Lutadores campeao;

        public Resultado(Lutadores campeao)
        {
            InitializeComponent();
            this.campeao = campeao;
            
        }

        



        private void LabResultado_Loaded(object sender, RoutedEventArgs e)
        {

            LabResultado.Content = "O vencedor é : \n"+ campeao.Nome;

            
        }
    }
}
