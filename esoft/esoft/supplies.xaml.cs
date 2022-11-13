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
    /// Логика взаимодействия для supplies.xaml
    /// </summary>
    public partial class supplies : Page
    {
        public supplies()
        {
            InitializeComponent();
            dataGridSupplier.ItemsSource = esoftEntities.GetContext().supplies.ToList();
            ComboboxFilter.ItemsSource = new List<string> { "Выбрать все","По убыванию", "По возрастанию" };
            ComboboxFilter.SelectedIndex = 0;
        }

        private void dataGridSupplier_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void UpdateMaterials()
        {
            var _currentMaterials = esoftEntities.GetContext().supplies.ToList();

            if (ComboboxFilter.SelectedIndex > 0)
            {

                if (ComboboxFilter.SelectedItem.ToString() == "Выбрать все")
                {
                    _currentMaterials = _currentMaterials.OrderBy(p => p.Price).ToList();
                }
                else if (ComboboxFilter.SelectedItem.ToString() == "По убыванию")
                {
                    _currentMaterials = _currentMaterials.OrderBy(p => p.Price).ToList();
                }
                else if (ComboboxFilter.SelectedItem.ToString() == "По возрастанию")
                {
                    _currentMaterials = _currentMaterials.OrderByDescending(p => p.Price).ToList();
                }

            }

            dataGridSupplier.ItemsSource = _currentMaterials;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new suppliesaddpage(null));
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            var SupplierForRemoving = dataGridSupplier.SelectedItems.Cast<supply>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {SupplierForRemoving.Count()} элементов?", "Внимание",
               MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    esoftEntities.GetContext().supplies.RemoveRange(SupplierForRemoving);
                    esoftEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    dataGridSupplier.ItemsSource = esoftEntities.GetContext().supplies.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new suppliesaddpage((sender as Button).DataContext as supply));
        }

        private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateMaterials();
        }
    }
}
