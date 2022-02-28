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

namespace Dashboard1
{
    /// <summary>
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Consumo consumo = new Consumo();
            DataContext = new ConsumoViewModel(consumo);

            Consume consume = new Consume();
            DataContext = new ConsumeViewModel(consume);


        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridBarraTitulo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }


    }

    internal class ConsumoViewModel
    {
        public List<Consumo> Consumo { get; private set; }

        public ConsumoViewModel(Consumo consumo)
        {
            Consumo = new List<Consumo>();
            Consumo.Add(consumo);
        }
    }

    internal class ConsumeViewModel
    {
        public List<Consume> Consume { get; private set; }

        public ConsumeViewModel(Consume consume)
        {
            Consume = new List<Consume>();
            Consume.Add(consume);
        }
    }

    internal class Consumo
    {
        public string Titulo { get; private set; }
        public int Porcentagem { get; private set; }

        public Consumo()
        {
            Titulo = "Vaksinasi Pertama";
            Porcentagem = CalcularPorcentagem();

        }

        private int CalcularPorcentagem()
        {
            return 65; //Calculo da porcentagem de consumo
        }
    }

    internal class Consume
    {
        public string Titulo { get; private set; }
        public int Percentage { get; private set; }

        public Consume()
        {
            Titulo = "Persentase";
            Percentage = CalcularPercentage();

        }

        private int CalcularPercentage()
        {
            return 85; //Calculo da porcentagem de consumo
        }
    }


}
