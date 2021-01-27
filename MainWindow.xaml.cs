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

namespace Kolokvioom
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        string txt1;
        string txt2;
        Telefon x = new Telefon();

        private void Dodaj_sms_button(object sender, RoutedEventArgs e)
        {
            if (Numer.Text != null)
            {
                x.DodajSms(Numer.Text);
            }
        }

        private void Dodaj_polaczenie_button(object sender, RoutedEventArgs e)
        {
            if(Czas.Text != ""){
                if (int.Parse(Czas.Text) > 0)
                {
                    x.DodajPolaczenie(Numer.Text, int.Parse(Czas.Text));
                }
            }
           
        }

        private void Dodaj_internet_button(object sender, RoutedEventArgs e)
        {
            if (Mb.Text != "")
            {
                if (int.Parse(Mb.Text) > 0)
                {
                    x.DodajInternet(int.Parse(Mb.Text));
                }
            }

        }

        private void Zapisz_button(object sender, RoutedEventArgs e)
        {
            x.ZapiszBiling();
        }
    }
}
