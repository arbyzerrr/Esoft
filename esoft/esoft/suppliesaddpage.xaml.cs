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
    /// Логика взаимодействия для suppliesaddpage.xaml
    /// </summary>
    public partial class suppliesaddpage : Page
    {
        private supply _currentSupplies = new supply();

        public suppliesaddpage(supply currentSupplies)
        {
            InitializeComponent();
            if (currentSupplies != null)
                _currentSupplies = currentSupplies;

            DataContext = _currentSupplies;


        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (_currentSupplies.Price == null)
                errors.AppendLine("Цену");
            if (_currentSupplies.AgentId == null)
                errors.AppendLine("Номер Агента");
            if (_currentSupplies.ClientId == null)
                errors.AppendLine("Укажите номер клиента");
            if (_currentSupplies.IdDIstrict == null)
                errors.AppendLine("Укажите номер дистракта");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentSupplies.Id == 0)
                esoftEntities.GetContext().supplies.Add(_currentSupplies);

            try
            {
                esoftEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
    }
}

