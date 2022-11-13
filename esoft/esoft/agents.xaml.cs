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
    /// Логика взаимодействия для agents.xaml
    /// </summary>
    public partial class agents : Page
    {
        public agents()
        {
            InitializeComponent();
            dataGridAgent.ItemsSource = esoftEntities.GetContext().agents.ToList();
            UpdateAgents();
        }

        private void dataGridSupplier_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditDeleteAgent((sender as Button).DataContext as agent));
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var agentForRemoving = dataGridAgent.SelectedItems.Cast<agent>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующиe {(agentForRemoving.Count())} элементов?", "Внимание",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    esoftEntities.GetContext().agents.RemoveRange(agentForRemoving);
                    esoftEntities.GetContext().SaveChanges();

                    dataGridAgent.ItemsSource = esoftEntities.GetContext().agents.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditDeleteAgent(null));
        }





        private void UpdateAgents()
        {
            var _currentAgents = esoftEntities.GetContext().agents.ToList();

            

            _currentAgents = _currentAgents.Where(p => p.FirstName.ToLower().Contains(TextBoxSearch.Text.ToLower())).ToList();
            //_currentAgents = _currentAgents.Where(r => r.MiddleName.ToLower().Contains(TextBoxSearch.Text.ToLower())).ToList();
            //_currentAgents = _currentAgents.Where(p => p.LastName.ToLower().Contains(TextBoxSearch.Text.ToLower())).ToList();
            dataGridAgent.ItemsSource = _currentAgents;

        }

       






        private void TextBoxSearch_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            UpdateAgents();
            
        }

        private void TextBoxSearch_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            UpdateAgents();
            
        }

        private void TextBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateAgents();
            
        }
    }
}
