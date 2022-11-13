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
    /// Логика взаимодействия для dealsaddpage.xaml
    /// </summary>
    public partial class dealsaddpage : Page
    {
        private deal _currentClient = new deal();
        public dealsaddpage(deal currentClient)
        {
            InitializeComponent();
            if (currentClient != null)
                _currentClient = currentClient;

            DataContext = _currentClient;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (_currentClient.Demand_Id == null)
                errors.AppendLine("Укажите фамилию");
            if (_currentClient.Supply_Id == null)
                errors.AppendLine("Укажите имя");
           

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentClient.Id == 0)
                esoftEntities.GetContext().deals.Add(_currentClient);

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
