using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Torneio_de_luta
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly List<Modelo.Lutadores> todoslutadores;
        readonly List<Modelo.Lutadores> lutadoresselecionados;
        readonly List<Modelo.Lutadores> listageral;
        readonly List<CheckBox> checkBoxes = new List<CheckBox>();
        readonly List<Label> labels = new List<Label>();
        Modelo.ILutadores lut = new Modelo.Lutadores();
        
        public MainWindow()
        {
            listageral = Controle.Apidata.Lutadoresget();
            todoslutadores = listageral.OrderBy(listageral => listageral.Id1).ToList();
            InitializeComponent();
            ListComponents();
            Insercao();
            lutadoresselecionados = new List<Modelo.Lutadores>();
        }

        private void ListComponents()
        {
            checkBoxes.Add(checklutador1);
            checkBoxes.Add(checklutador2);
            checkBoxes.Add(checklutador3);
            checkBoxes.Add(checklutador4);
            checkBoxes.Add(checklutador5);
            checkBoxes.Add(checklutador6);
            checkBoxes.Add(checklutador7);
            checkBoxes.Add(checklutador8);
            checkBoxes.Add(checklutador9);
            checkBoxes.Add(checklutador10);
            checkBoxes.Add(checklutador11);
            checkBoxes.Add(checklutador12);
            checkBoxes.Add(checklutador13);
            checkBoxes.Add(checklutador14);
            checkBoxes.Add(checklutador15);
            checkBoxes.Add(checklutador16);
            checkBoxes.Add(checklutador17);
            checkBoxes.Add(checklutador18);
            checkBoxes.Add(checklutador19);
            checkBoxes.Add(checklutador20);
            checkBoxes.Add(checklutador21);
            checkBoxes.Add(checklutador22);
            checkBoxes.Add(checklutador23);
            checkBoxes.Add(checklutador24);
            checkBoxes.Add(checklutador25);
            checkBoxes.Add(checklutador26);
            checkBoxes.Add(checklutador27);
            checkBoxes.Add(checklutador28);
            checkBoxes.Add(checklutador29);
            checkBoxes.Add(checklutador30);
            checkBoxes.Add(checklutador31);
            checkBoxes.Add(checklutador32);
            checkBoxes.Add(checklutador33);
            checkBoxes.Add(checklutador34);
            checkBoxes.Add(checklutador35);
            checkBoxes.Add(checklutador36);
            checkBoxes.Add(checklutador37);

            labels.Add(Lablutador1);
            labels.Add(Lablutador2);
            labels.Add(Lablutador3);
            labels.Add(Lablutador4);
            labels.Add(Lablutador5);
            labels.Add(Lablutador6);
            labels.Add(Lablutador7);
            labels.Add(Lablutador8);
            labels.Add(Lablutador9);
            labels.Add(Lablutador10);
            labels.Add(Lablutador11);
            labels.Add(Lablutador12);
            labels.Add(Lablutador13);
            labels.Add(Lablutador14);
            labels.Add(Lablutador15);
            labels.Add(Lablutador16);
            labels.Add(Lablutador17);
            labels.Add(Lablutador18);
            labels.Add(Lablutador19);
            labels.Add(Lablutador20);
            labels.Add(Lablutador21);
            labels.Add(Lablutador22);
            labels.Add(Lablutador23);
            labels.Add(Lablutador24);
            labels.Add(Lablutador25);
            labels.Add(Lablutador26);
            labels.Add(Lablutador27);
            labels.Add(Lablutador28);
            labels.Add(Lablutador29);
            labels.Add(Lablutador30);
            labels.Add(Lablutador31);
            labels.Add(Lablutador32);
            labels.Add(Lablutador33);
            labels.Add(Lablutador34);
            labels.Add(Lablutador35);
            labels.Add(Lablutador36);
            labels.Add(Lablutador37);
        }
        private void Insercao()
        {
            for (int x = 0; x < todoslutadores.Count; x++)
            {
                PopulateChecks(checkBoxes[x], labels[x], todoslutadores[x]);
            }
        }

        private void PopulateChecks(System.Windows.Controls.CheckBox checkBoxLutadorx, System.Windows.Controls.Label labelBoxLutadorx, Modelo.Lutadores lutador)
        {
            checkBoxLutadorx.Content = lutador.Nome1;
            labelBoxLutadorx.Content = "";
            labelBoxLutadorx.Content = lut.MountLutador(lutador);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Visao.Resultado janela;
            if (lutadoresselecionados.Count == 16)
            {
                Modelo.Lutadores campeao = Modelo.Regras.Resultado(lutadoresselecionados);
                janela = new Visao.Resultado(campeao);
                Principal.Close();
                janela.ShowDialog();
            }
            else
            {
                MessageBox.Show("Permitido somente 16 lutadores !!!\n" +
                " Atualmente temos  " + lutadoresselecionados.Count + " lutadores selecionados !!!");
            }
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

        private void Checklutador8_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[7]);
        }

        private void Checklutador8_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[7]);
        }

        private void Checklutador9_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[8]);
        }

        private void Checklutador9_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[8]);
        }

        private void Checklutador12_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[11]);
        }

        private void Checklutador12_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[11]);
        }

        private void Checklutador11_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[10]);
        }

        private void Checklutador11_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[10]);
        }

        private void Checklutador10_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[9]);
        }

        private void Checklutador10_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[9]);
        }

        private void Checklutador13_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[12]);
        }

        private void Checklutador13_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[12]);
        }

        private void Checklutador14_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[13]);
        }

        private void Checklutador14_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[13]);
        }

        private void Checklutador15_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[14]);
        }

        private void Checklutador15_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[14]);
        }

        private void Checklutador16_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[15]);
        }

        private void Checklutador16_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[15]);
        }

        private void Checklutador17_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[16]);
        }

        private void Checklutador17_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[16]);
        }

        private void Checklutador18_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[17]);
        }

        private void Checklutador18_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[17]);
        }

        private void Checklutador19_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[18]);
        }

        private void Checklutador19_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[18]);
        }

        private void Checklutador20_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[19]);
        }

        private void Checklutador20_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[19]);
        }

        private void Checklutador21_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[20]);
        }

        private void Checklutador21_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[20]);
        }

        private void Checklutador22_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[21]);
        }

        private void Checklutador22_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[21]);
        }

        private void Checklutador23_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[22]);
        }

        private void Checklutador23_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[22]);
        }

        private void Checklutador24_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[23]);
        }

        private void Checklutador24_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[23]);
        }

        private void Checklutador25_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[24]);
        }

        private void Checklutador25_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[24]);
        }

        private void Checklutador26_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[25]);
        }

        private void Checklutador26_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[25]);
        }

        private void Checklutador27_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[26]);
        }

        private void Checklutador27_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[26]);
        }

        private void Checklutador28_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[27]);
        }

        private void Checklutador28_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[27]);
        }

        private void Checklutador29_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[28]);
        }

        private void Checklutador29_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[28]);
        }

        private void Checklutador30_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[29]);
        }

        private void Checklutador30_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[29]);
        }


        private void Checklutador31_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[30]);
        }

        private void Checklutador31_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[30]);
        }

        private void Checklutador32_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[31]);
        }

        private void Checklutador32_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[31]);
        }

        private void Checklutador33_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[32]);
        }

        private void Checklutador33_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[32]);
        }

        private void Checklutador34_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[33]);
        }

        private void Checklutador34_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[33]);
        }

        private void Checklutador35_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[34]);
        }

        private void Checklutador35_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[34]);
        }

        private void Checklutador36_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[35]);
        }

        private void Checklutador36_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[35]);
        }

        private void Checklutador37_Checked(object sender, RoutedEventArgs e)
        {
            VerificaSelecionado(todoslutadores[36]);
        }

        private void Checklutador37_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[36]);
        }

        private void VerificaSelecionado(Modelo.Lutadores selecionado)
        {
            bool exist = false;
            foreach (Modelo.Lutadores lutador in lutadoresselecionados)
            {
                if (lutador.Id1 == selecionado.Id1)
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
