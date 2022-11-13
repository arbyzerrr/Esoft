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

namespace esoft
{
    /// <summary>
    /// Логика взаимодействия для demands.xaml
    /// </summary>
    public partial class demands : Page
    {
        public demands()
        {
            InitializeComponent();
            dataGridSupplier.ItemsSource = esoftEntities.GetContext().Demands.ToList();
        }

        private void dataGridSupplier_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            var clientForRemoving = dataGridSupplier.SelectedItems.Cast<Demand>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующиe {(clientForRemoving.Count())} элементов?", "Внимание",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    esoftEntities.GetContext().Demands.RemoveRange(clientForRemoving);
                    esoftEntities.GetContext().SaveChanges();

                    dataGridSupplier.ItemsSource = esoftEntities.GetContext().Demands.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new demandsaddpage(null));
        }

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new demandsaddpage((sender as Button).DataContext as Demand));
        }





        private void UpdateAgents()
        {
            var _currentAgents = esoftEntities.GetContext().Demands.ToList();



            _currentAgents = _currentAgents.Where(p => p.Adress.ToLower().Contains(TextBoxSearch.Text.ToLower())).ToList();
            //_currentAgents = _currentAgents.Where(r => r.MiddleName.ToLower().Contains(TextBoxSearch.Text.ToLower())).ToList();
            //_currentAgents = _currentAgents.Where(p => p.LastName.ToLower().Contains(TextBoxSearch.Text.ToLower())).ToList();
            dataGridSupplier.ItemsSource = _currentAgents;

        }











        private void TextBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateAgents();
        }
    }
}
