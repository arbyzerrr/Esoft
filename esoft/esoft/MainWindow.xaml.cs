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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace esoft
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Manager.MainFrame = MainFrame;
            MainFrame.Navigate(new EsoftPage());
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void BtnAgent_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new agents());
        }

        private void BtnClient_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new clients());
        }

        private void BtnSupplier_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new supplies());
        }

        private void BtnDemands_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new demands());
        }

        private void BtnDeals_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new deals());
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
              
                BtnBack.Visibility = Visibility.Visible;
              

            }
            else
            {
              
                BtnBack.Visibility = Visibility.Hidden;
               
                //Button_Proizvodstvo.Visibility = Visibility.Visible;
            }

        }
    }
}
