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
        List<Modelo.Lutadores> lutadoresselecionados;
        public MainWindow()
        {
            todoslutadores = Controle.Apidata.Lutadoresget();

            InitializeComponent();
            Insercao();
            lutadoresselecionados = new List<Modelo.Lutadores>();
        }
        private void Insercao()
        {
            PopulateChecks(checklutador1, Txtlutador1, todoslutadores[0]);
            PopulateChecks(checklutador2, Txtlutador2, todoslutadores[1]);
            PopulateChecks(checklutador3, Txtlutador3, todoslutadores[2]);
            PopulateChecks(checklutador4, Txtlutador4, todoslutadores[3]);
            PopulateChecks(checklutador5, Txtlutador5, todoslutadores[4]);
            PopulateChecks(checklutador6, Txtlutador6, todoslutadores[5]);
            PopulateChecks(checklutador7, Txtlutador7, todoslutadores[6]);
            PopulateChecks(checklutador8, Txtlutador8, todoslutadores[7]);
            PopulateChecks(checklutador9, Txtlutador9, todoslutadores[8]);
            PopulateChecks(checklutador10, Txtlutador10, todoslutadores[9]);
            PopulateChecks(checklutador11, Txtlutador11, todoslutadores[10]);
            PopulateChecks(checklutador12, Txtlutador12, todoslutadores[11]);
            PopulateChecks(checklutador13, Txtlutador13, todoslutadores[12]);
            PopulateChecks(checklutador14, Txtlutador14, todoslutadores[13]);
            PopulateChecks(checklutador15, Txtlutador15, todoslutadores[14]);
            PopulateChecks(checklutador16, Txtlutador16, todoslutadores[15]);
            PopulateChecks(checklutador17, Txtlutador17, todoslutadores[16]);
            PopulateChecks(checklutador18, Txtlutador18, todoslutadores[17]);
            PopulateChecks(checklutador19, Txtlutador19, todoslutadores[18]);
            PopulateChecks(checklutador20, Txtlutador20, todoslutadores[19]);
            PopulateChecks(checklutador21, Txtlutador21, todoslutadores[20]);
            PopulateChecks(checklutador22, Txtlutador22, todoslutadores[21]);
            PopulateChecks(checklutador23, Txtlutador23, todoslutadores[22]);
            PopulateChecks(checklutador24, Txtlutador24, todoslutadores[23]);
            PopulateChecks(checklutador25, Txtlutador25, todoslutadores[24]);
            PopulateChecks(checklutador26, Txtlutador26, todoslutadores[25]);
            PopulateChecks(checklutador27, Txtlutador27, todoslutadores[26]);
            PopulateChecks(checklutador28, Txtlutador28, todoslutadores[27]);
            PopulateChecks(checklutador29, Txtlutador29, todoslutadores[28]);
            PopulateChecks(checklutador30, Txtlutador30, todoslutadores[29]);
            PopulateChecks(checklutador31, Txtlutador31, todoslutadores[30]);
            PopulateChecks(checklutador32, Txtlutador32, todoslutadores[31]);
            PopulateChecks(checklutador33, Txtlutador33, todoslutadores[32]);
            PopulateChecks(checklutador34, Txtlutador34, todoslutadores[33]);
            PopulateChecks(checklutador35, Txtlutador35, todoslutadores[34]);
            PopulateChecks(checklutador36, Txtlutador36, todoslutadores[35]);
            PopulateChecks(checklutador37, Txtlutador37, todoslutadores[36]);
        }

        private void PopulateChecks(System.Windows.Controls.CheckBox checkBoxLutadorx, System.Windows.Controls.TextBox textBoxLutadorx, Modelo.Lutadores lutador)
        {
            checkBoxLutadorx.Content = (lutador.Nome);
            textBoxLutadorx.Text = "";
            textBoxLutadorx.Text = Modelo.Lutadores.MountLutador(lutador);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Checklutador2_Checked(object sender, RoutedEventArgs e)
        {
            Boolean exist = false;
            foreach (Modelo.Lutadores lutador in lutadoresselecionados)
            {
                if (lutador.Id == todoslutadores[1].Id)
                {

                    exist = true;
                }

            }

            if (!exist)
            {
                lutadoresselecionados.Add(todoslutadores[1]);
            }
        }

        private void Checklutador2_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador2_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void Checklutador3_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Checklutador3_Checked(object sender, RoutedEventArgs e)
        {
            Boolean exist = false;
            foreach (Modelo.Lutadores lutador in lutadoresselecionados)
            {
                if (lutador.Id == todoslutadores[2].Id)
                {

                    exist = true;
                }

            }

            if (!exist)
            {
                lutadoresselecionados.Add(todoslutadores[2]);
            }
        }

        private void Txtlutador3_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void Checklutador4_Checked(object sender, RoutedEventArgs e)
        {
            Boolean exist = false;
            foreach (Modelo.Lutadores lutador in lutadoresselecionados)
            {
                if (lutador.Id == todoslutadores[3].Id)
                {

                    exist = true;
                }

            }

            if (!exist)
            {
                lutadoresselecionados.Add(todoslutadores[3]);
            }
        }

        private void Checklutador4_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador4_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void Checklutador1_Checked(object sender, RoutedEventArgs e)
        {
            Boolean exist = false;
            foreach (Modelo.Lutadores lutador in lutadoresselecionados)
            {
                if (lutador.Id == todoslutadores[0].Id)
                {

                    exist = true;
                }

            }

            if (!exist)
            {
                lutadoresselecionados.Add(todoslutadores[0]);
            }


        }

        private void Checklutador1_Unchecked(object sender, RoutedEventArgs e)
        {
            lutadoresselecionados.Remove(todoslutadores[0]);
        }

        private void Txtlutador1_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void Checklutador5_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Checklutador5_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador5_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void Checklutador6_Checked(object sender, RoutedEventArgs e)
        {
            Boolean exist = false;
            foreach (Modelo.Lutadores lutador in lutadoresselecionados)
            {
                if (lutador.Id == todoslutadores[5].Id)
                {

                    exist = true;
                }

            }

            if (!exist)
            {
                lutadoresselecionados.Add(todoslutadores[5]);
            }
        }



        private void Txtlutador6_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }



        private void Txtlutador7_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void Checklutador7_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Checklutador7_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Checklutador6_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador8_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador8_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador8_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void checklutador9_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador9_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador9_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void checklutador12_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador12_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador12_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void checklutador11_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador11_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador11_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void checklutador10_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador10_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador10_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void checklutador13_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador13_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador13_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void checklutador14_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador14_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador14_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void checklutador15_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador15_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador15_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void checklutador16_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador16_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador16_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void checklutador17_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador17_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador17_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void checklutador18_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador18_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador18_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void checklutador19_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador19_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador19_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void checklutador20_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador20_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador20_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void checklutador21_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador21_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador21_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void checklutador22_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador22_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador22_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void checklutador23_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador23_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador23_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void checklutador24_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador24_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador24_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void checklutador25_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador25_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador25_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void checklutador26_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador26_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador26_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void checklutador27_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador27_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador27_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void checklutador28_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador28_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador28_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void checklutador29_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador29_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador29_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void checklutador30_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador30_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador30_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void checklutador31_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador31_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador31_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void checklutador32_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador32_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador32_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void checklutador33_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador33_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador33_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void checklutador34_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador34_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador34_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void checklutador35_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador35_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador35_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void checklutador36_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador36_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador36_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void checklutador37_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checklutador37_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Txtlutador37_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}
