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
            if (listageral != null)
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
            if (todoslutadores != null)
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

        private void Checklutador_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is CheckBox checkBox && todoslutadores != null)
            {
                int index = checkBoxes.IndexOf(checkBox);
                if (index >= 0 && index < todoslutadores.Count)
                {
                    lutadoresselecionados.Add(todoslutadores[index]);
                    VerificaSelecionado(todoslutadores[index]);
                }
            }
            else
            {
                MessageBox.Show("Lutador não encontrado");
            }
        }

        private void Checklutador_Unchecked(object sender, RoutedEventArgs e)
        {
            if (sender is CheckBox checkBox && todoslutadores != null)
            {
                int index = checkBoxes.IndexOf(checkBox);
                if (index >= 0 && index < todoslutadores.Count)
                {
                    lutadoresselecionados.Remove(todoslutadores[index]);
                }
            }
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
