using ADS1T1M.TP3.Rodrigo.Presentation.ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ADS1T1M.TP3.Rodrigo.Presentation.WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            limpacampos();
        }

        private void btnBuscarMatricula_Click(object sender, RoutedEventArgs e)
        {
            var AlunoDao = new AlunoDao();

            var pesquisa = AlunoDao.BuscaAluno(EntradaMatricula.Text);
            
            EscreveTela(pesquisa);

        }

        private void EscreveTela(Domain.Entities.Aluno pesquisa)
        {
            tbInfo.Visibility = Visibility.Visible;
            if (pesquisa != null)
            {
                tbNome.Text = pesquisa.Nome.ToString();
                tbMatricula.Text = pesquisa.Matricula.ToString();
                tbDtn.Text = pesquisa.DataDeNascimento.ToString("dd/MM/yyyy");
                tbCpf.Text = pesquisa.Cpf.ToString();

                if (pesquisa.Ativo)
                {
                    tbInfo.Background = Brushes.Green;
                    tbInfo.Foreground = Brushes.White;
                    tbInfo.FontWeight = FontWeights.UltraBold;
                    tbInfo.Text = "Aluno liberado";
                }
                else
                {
                    tbInfo.Background = Brushes.Red;
                    tbInfo.Foreground = Brushes.White;
                    tbInfo.FontWeight = FontWeights.UltraBold;

                    tbInfo.Text = "Aluno suspenso";
                }

            }
            else
            {
                limpacampos();
                tbInfo.Visibility = Visibility.Visible;

                tbInfo.Background = Brushes.Blue;
                tbInfo.Foreground = Brushes.White;
                tbInfo.FontWeight = FontWeights.UltraBold;

                tbInfo.Text = "Aluno não Cadastrado";
            }
        }

        private void limpacampos()
        {
            tbNome.Text = "";
            tbMatricula.Text = "";
            tbDtn.Text = "";
            tbCpf.Text = "";
            tbInfo.Text = "";
            tbInfo.Visibility = System.Windows.Visibility.Hidden;

        }

        private void EntradaMatricula_TextChanged(object sender, TextChangedEventArgs e)
        {
            limpacampos();
        }
    }
}
