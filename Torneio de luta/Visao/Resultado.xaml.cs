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

namespace Torneio_de_luta.Visao
{
    /// <summary>
    /// Lógica interna para Resultado.xaml
    /// </summary>
    public partial class Resultado : Window
    {
        public Resultado()
        {
            InitializeComponent();
            
            
        }


        private void LabResultado_Loaded(object sender, RoutedEventArgs e)
        {
            LabResultado.Content = "O vencedor é :";
        }
    }
}
