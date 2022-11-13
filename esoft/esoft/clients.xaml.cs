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
    /// Логика взаимодействия для clients.xaml
    /// </summary>
    public partial class clients : Page
    {
        public clients()
        {
            InitializeComponent();
            dataGridClient.ItemsSource = esoftEntities.GetContext().clients.ToList();
           
        }

        private void dataGridSupplier_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditDeleteClient(null));
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var clientForRemoving = dataGridClient.SelectedItems.Cast<client>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующиe {(clientForRemoving.Count())} элементов?", "Внимание",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    esoftEntities.GetContext().clients.RemoveRange(clientForRemoving);
                    esoftEntities.GetContext().SaveChanges();

                    dataGridClient.ItemsSource = esoftEntities.GetContext().clients.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditDeleteClient((sender as Button).DataContext as client));
        }


        private void UpdateAgents()
        {
            var _currentAgents = esoftEntities.GetContext().clients.ToList();



            _currentAgents = _currentAgents.Where(p => p.FirstName.ToLower().Contains(TextBoxSearch.Text.ToLower())).ToList();
            //_currentAgents = _currentAgents.Where(r => r.MiddleName.ToLower().Contains(TextBoxSearch.Text.ToLower())).ToList();
            //_currentAgents = _currentAgents.Where(p => p.LastName.ToLower().Contains(TextBoxSearch.Text.ToLower())).ToList();
            dataGridClient.ItemsSource = _currentAgents;

        }


        private void TextBoxSearch_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            

        }

        private void TextBoxSearch_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            

        }

        private void TextBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

            UpdateAgents();
        }

    }
}
