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
    /// Логика взаимодействия для demandsaddpage.xaml
    /// </summary>
    public partial class demandsaddpage : Page
    {
        private Demand _currentClient = new Demand();
        public demandsaddpage(Demand currentClient)
        {
            InitializeComponent();
            if (currentClient != null)
                _currentClient = currentClient;

            DataContext = _currentClient;
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (_currentClient.IdClient == null)
                errors.AppendLine("Укажите фамилию");
            if (_currentClient.IdAgent == null)
                errors.AppendLine("Укажите имя");
            if (_currentClient.Type == null)
                errors.AppendLine("Укажите отчество");
            if (string.IsNullOrWhiteSpace(_currentClient.Adress))
                errors.AppendLine("Укажите номер телефона");
            if (_currentClient.MinPrice == null)
                errors.AppendLine("Укажите электронную почту");
            if (_currentClient.MaxPrice == null)
                errors.AppendLine("Укажите электронную почту");
            if (_currentClient.MinArea == null)
                errors.AppendLine("Укажите электронную почту");
            if (_currentClient.MaxArea == null)
                errors.AppendLine("Укажите электронную почту");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentClient.Id == 0)
                esoftEntities.GetContext().Demands.Add(_currentClient);

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
