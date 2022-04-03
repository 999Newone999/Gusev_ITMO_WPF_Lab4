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

namespace Gusev_ITMO_WPF_Lab4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Dollar(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(dollarRate.Text);
            double sumDollar = Convert.ToDouble(dollarSum.Text);
            double resDollar = rateDollar*sumDollar;
            dollarResult.Text = resDollar.ToString();
        }

        private void Button_Click_Euro(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(euroRate.Text);
            double sumEuro = Convert.ToDouble(euroSum.Text);
            double resEuro = rateEuro * sumEuro;
            euroResult.Text = resEuro.ToString();
        }

        private void Button_Click_Grivna(object sender, RoutedEventArgs e)
        {
            double rateGrivna = Convert.ToDouble(grivnaRate.Text);
            double sumGrivna = Convert.ToDouble(grivnaSum.Text);
            double resGrivna = rateGrivna * sumGrivna;
            grivnaResult.Text = resGrivna.ToString();
        }

        private void Button_Click_Dram(object sender, RoutedEventArgs e)
        {
            double rateDram = Convert.ToDouble(dramRate.Text);
            double sumDram = Convert.ToDouble(dramSum.Text);
            double resDram = rateDram * sumDram;
            grivnaResult.Text = resDram.ToString();
        }

        private void Button_Click_Inch(object sender, RoutedEventArgs e)
        {
            double countInch = Convert.ToDouble(inchCount.Text);
            double resInch = countInch * 100 / 2.54;
            inchResult.Text = resInch.ToString();
        }

        private void Button_Click_Ft(object sender, RoutedEventArgs e)
        {
            double countFt = Convert.ToDouble(ftCount.Text);
            double resFt = countFt /0.3048;
            ftResult.Text = resFt.ToString();
        }

        private void Button_Click_Miles(object sender, RoutedEventArgs e)
        {
            double countMiles = Convert.ToDouble(mileCount.Text);
            double resMiles = countMiles*1855.3;
            mileResult.Text = resMiles.ToString();
        }

        private void Button_Click_Verst(object sender, RoutedEventArgs e)
        {
            double countVerst = Convert.ToDouble(verstCount.Text);
            double resVerst = countVerst * 1066.8;
            verstResult.Text = resVerst.ToString();
        }
    }
}
