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

namespace WpfTask4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rateD.Text);
            double sumDollar = Convert.ToDouble(sumD.Text);
            double resDouble = rateDollar * sumDollar;
            resSumD.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rateE.Text);
            double sumEuro = Convert.ToDouble(sumE.Text);
            double resDoubleEuro = rateEuro * sumEuro;
            resSumE.Text = resDoubleEuro.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateHryvnia = Convert.ToDouble(rateH.Text);
            double sumHryvnia = Convert.ToDouble(sumH.Text);
            double resDoubleHryvnia = rateHryvnia * sumHryvnia;
            resSumH.Text = resDoubleHryvnia.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateArmenianDrama = Convert.ToDouble(rateAD.Text);
            double sumArmenianDrama = Convert.ToDouble(sumAD.Text);
            double resDoubleArmenianDrama = rateArmenianDrama * sumArmenianDrama;
            resSumAD.Text = resDoubleArmenianDrama.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double rateInch = Convert.ToDouble(rateI.Text);            
            double resDoubleInch = rateInch/39.37;
            resSumI.Text = resDoubleInch.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double rateFeet = Convert.ToDouble(rateF.Text);
            double resDoubleFeet = rateFeet / 3.281;
            resSumF.Text = resDoubleFeet.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double rateMiles = Convert.ToDouble(rateM.Text);
            double resDoubleMiles = rateMiles / 1609;
            resSumM.Text = resDoubleMiles.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double rateVerst = Convert.ToDouble(rateV.Text);
            double resDoubleVerst = rateVerst *1066.8;
            resSumV.Text = resDoubleVerst.ToString();
        }
    }
}
