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
    /// Логика взаимодействия для deals.xaml
    /// </summary>
    public partial class deals : Page
    {
        public deals()
        {
            InitializeComponent();
            dataGridDeals.ItemsSource = esoftEntities.GetContext().deals.ToList();
        }

        private void dataGridSupplier_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new dealsaddpage(null));
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var dealsForRemoving = dataGridDeals.SelectedItems.Cast<deal>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующиe {(dealsForRemoving.Count())} элементов?", "Внимание",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    esoftEntities.GetContext().deals.RemoveRange(dealsForRemoving);
                    esoftEntities.GetContext().SaveChanges();

                    dataGridDeals.ItemsSource = esoftEntities.GetContext().deals.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }


        private void UpdateAgents()
        {
            var _currentAgents = esoftEntities.GetContext().deals.ToList();



            _currentAgents = _currentAgents.Where(p => p.Demand_Id.ToString().Contains(TextBoxSearch.Text.ToLower())).ToList();
            //_currentAgents = _currentAgents.Where(r => r.MiddleName.ToLower().Contains(TextBoxSearch.Text.ToLower())).ToList();
            //_currentAgents = _currentAgents.Where(p => p.LastName.ToLower().Contains(TextBoxSearch.Text.ToLower())).ToList();
            dataGridDeals.ItemsSource = _currentAgents;

        }

















        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new dealsaddpage((sender as Button).DataContext as deal));
        }

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateAgents();
        }
    }
}
