using System;
using System.Collections.Generic;
using System.Windows;

namespace Torneio_de_luta
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Modelo.Lutadores> todoslutadores;
        static List<Modelo.Lutadores> lutadoresselecionados;
        public MainWindow()
        {
            todoslutadores = Controle.Apidata.Lutadoresget();

            InitializeComponent();
            Insercao();
            lutadoresselecionados = new List<Modelo.Lutadores>();

        }
        private void Insercao()
        {
            
            PopulateChecks(checklutador1, Lablutador1, todoslutadores[0]);
            PopulateChecks(checklutador2, Lablutador2, todoslutadores[1]);
            PopulateChecks(checklutador3, Lablutador3, todoslutadores[2]);
            PopulateChecks(checklutador4, Lablutador4, todoslutadores[3]);
            PopulateChecks(checklutador5, Lablutador5, todoslutadores[4]);
            PopulateChecks(checklutador6, Lablutador6, todoslutadores[5]);
            PopulateChecks(checklutador7, Lablutador7, todoslutadores[6]);
            PopulateChecks(checklutador8, Lablutador8, todoslutadores[7]);
            PopulateChecks(checklutador9, Lablutador9, todoslutadores[8]);
            PopulateChecks(checklutador10, Lablutador10, todoslutadores[9]);
            PopulateChecks(checklutador11, Lablutador11, todoslutadores[10]);
            PopulateChecks(checklutador12, Lablutador12, todoslutadores[11]);
            PopulateChecks(checklutador13, Lablutador13, todoslutadores[12]);
            PopulateChecks(checklutador14, Lablutador14, todoslutadores[13]);
            PopulateChecks(checklutador15, Lablutador15, todoslutadores[14]);
            PopulateChecks(checklutador16, Lablutador16, todoslutadores[15]);
            PopulateChecks(checklutador17, Lablutador17, todoslutadores[16]);
            PopulateChecks(checklutador18, Lablutador18, todoslutadores[17]);
            PopulateChecks(checklutador19, Lablutador19, todoslutadores[18]);
            PopulateChecks(checklutador20, Lablutador20, todoslutadores[19]);
            PopulateChecks(checklutador21, Lablutador21, todoslutadores[20]);
            PopulateChecks(checklutador22, Lablutador22, todoslutadores[21]);
            PopulateChecks(checklutador23, Lablutador23, todoslutadores[22]);
            PopulateChecks(checklutador24, Lablutador24, todoslutadores[23]);
            PopulateChecks(checklutador25, Lablutador25, todoslutadores[24]);
            PopulateChecks(checklutador26, Lablutador26, todoslutadores[25]);
            PopulateChecks(checklutador27, Lablutador27, todoslutadores[26]);
            PopulateChecks(checklutador28, Lablutador28, todoslutadores[27]);
            PopulateChecks(checklutador29, Lablutador29, todoslutadores[28]);
            PopulateChecks(checklutador30, Lablutador30, todoslutadores[29]);
            PopulateChecks(checklutador31, Lablutador31, todoslutadores[30]);
            PopulateChecks(checklutador32, Lablutador32, todoslutadores[31]);
            PopulateChecks(checklutador33, Lablutador33, todoslutadores[32]);
            PopulateChecks(checklutador34, Lablutador34, todoslutadores[33]);
            PopulateChecks(checklutador35, Lablutador35, todoslutadores[34]);
            PopulateChecks(checklutador36, Lablutador36, todoslutadores[35]);
            PopulateChecks(checklutador37, Lablutador37, todoslutadores[36]);
        }

        private void PopulateChecks(System.Windows.Controls.CheckBox checkBoxLutadorx, System.Windows.Controls.Label labelBoxLutadorx, Modelo.Lutadores lutador)
        {
            checkBoxLutadorx.Content = (lutador.Nome);
            labelBoxLutadorx.Content = "";
            labelBoxLutadorx.Content = Modelo.Lutadores.MountLutador(lutador);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var janela = new Visao.Resultado();
            //if (lutadoresselecionados.Count == 16)
            //{
            Modelo.Regras.InicioDosJogos(lutadoresselecionados);
            Principal.Close();
            janela.ShowDialog();
            //}
            //else
            //{
            //MessageBox.Show("Permitido somente 16 lutadores !!!\n" +
            //" Atualmente temos  "+lutadoresselecionados.Count+" lutadores selecionados !!!");
            //}
            
        }

        private void Checklutador2_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[1]);
        }

        private void Checklutador2_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[1]);
        }

        private void Checklutador3_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[2]);
        }

        private void Checklutador3_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[2]);
        }

        private void Checklutador4_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[3]);
        }

        private void Checklutador4_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[3]);
        }

        private void Checklutador1_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[0]);
        }

        private void Checklutador1_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[0]);
        }

        private void Checklutador5_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[4]);
        }

        private void Checklutador5_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[4]);
        }

        private void Checklutador6_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[5]);
        }

        private void Checklutador7_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[6]);
        }

        private void Checklutador7_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[6]);
        }

        private void Checklutador6_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[5]);
        }

        private void checklutador8_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[7]);
        }

        private void checklutador8_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[7]);
        }

        private void checklutador9_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[8]);
        }

        private void checklutador9_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[8]);
        }

        private void checklutador12_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[11]);
        }

        private void checklutador12_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[11]);
        }

        private void checklutador11_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[10]);
        }

        private void checklutador11_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[10]);
        }

        private void checklutador10_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[9]);
        }

        private void checklutador10_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[9]);
        }

        private void checklutador13_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[12]);
        }

        private void checklutador13_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[12]);
        }

        private void checklutador14_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[13]);
        }

        private void checklutador14_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[13]);
        }

        private void checklutador15_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[14]);
        }

        private void checklutador15_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[14]);
        }

        private void checklutador16_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[15]);
        }

        private void checklutador16_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[15]);
        }

        private void checklutador17_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[16]);
        }

        private void checklutador17_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[16]);
        }

        private void checklutador18_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[17]);
        }

        private void checklutador18_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[17]);
        }

        private void checklutador19_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[18]);
        }

        private void checklutador19_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[18]);
        }

        private void checklutador20_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[19]);
        }

        private void checklutador20_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[19]);
        }

        private void checklutador21_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[20]);
        }

        private void checklutador21_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[20]);
        }

        
        private void checklutador22_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[21]);
        }

        private void checklutador22_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[21]);
        }

        private void checklutador23_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[22]);
        }

        private void checklutador23_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[22]);
        }

        private void checklutador24_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[23]);
        }

        private void checklutador24_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[23]);
        }

        private void checklutador25_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[24]);
        }

        private void checklutador25_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[24]);
        }

        private void checklutador26_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[25]);
        }

        private void checklutador26_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[25]);
        }

        private void checklutador27_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[26]);
        }

        private void checklutador27_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[26]);
        }

        
        private void checklutador28_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[27]);
        }

        private void checklutador28_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[27]);
        }

        
        private void checklutador29_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[28]);
        }

        private void checklutador29_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[28]);
        }

        
        private void checklutador30_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[29]);
        }

        private void checklutador30_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[29]);
        }


        private void checklutador31_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[30]);
        }

        private void checklutador31_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[30]);
        }


        private void checklutador32_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[31]);
        }

        private void checklutador32_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[31]);
        }


        private void checklutador33_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[32]);
        }

        private void checklutador33_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[32]);
        }


        private void checklutador34_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[33]);
        }

        private void checklutador34_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[33]);
        }


        private void checklutador35_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[34]);
        }

        private void checklutador35_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[34]);
        }


        private void checklutador36_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[35]);
        }

        private void checklutador36_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[35]);
        }


        private void checklutador37_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[36]);
        }

        private void checklutador37_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[36]);
        }

        private void VerificaSelecionado(Modelo.Lutadores selecionado)
        {
            Boolean exist = false;
            foreach (Modelo.Lutadores lutador in lutadoresselecionados)
            {
                if (lutador.Id == selecionado.Id)
                {
                    exist = true;
                }
            }
            if (!exist)
            {
                lutadoresselecionados.Add(selecionado);
            }
        }
    }
}
