using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace esoft
{
    /// <summary>
    /// Логика взаимодействия для AddEditDeleteClient.xaml
    /// </summary>
    public partial class AddEditDeleteClient : Page
    {
        private client _currentClient = new client();
        public AddEditDeleteClient(client currentClient)
        {
            InitializeComponent();
            if (currentClient != null)
                _currentClient = currentClient;

            DataContext = _currentClient;

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentClient.FirstName))
                errors.AppendLine("Укажите фамилию");
            if (string.IsNullOrWhiteSpace(_currentClient.MiddleName))
                errors.AppendLine("Укажите имя");
            if (string.IsNullOrWhiteSpace(_currentClient.LastName))
                errors.AppendLine("Укажите отчество");
            if (string.IsNullOrWhiteSpace(_currentClient.Phone))
                errors.AppendLine("Укажите номер телефона");
            if (string.IsNullOrWhiteSpace(_currentClient.Email))
                errors.AppendLine("Укажите электронную почту");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentClient.Id == 0)
                esoftEntities.GetContext().clients.Add(_currentClient);

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
