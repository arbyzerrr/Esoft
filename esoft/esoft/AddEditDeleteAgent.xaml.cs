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
    /// Логика взаимодействия для AddEditDeleteAgent.xaml
    /// </summary>
    public partial class AddEditDeleteAgent : Page
    {
        private agent _currentAgent = new agent();
        public AddEditDeleteAgent(agent selectagent)
        {
            InitializeComponent();
            if(selectagent != null)
                _currentAgent = selectagent;

            DataContext = _currentAgent;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentAgent.FirstName))
                errors.AppendLine("Укажите фамилию");
            if (string.IsNullOrWhiteSpace(_currentAgent.MiddleName))
                errors.AppendLine("Укажите имя");
            if (string.IsNullOrWhiteSpace(_currentAgent.LastName))
                errors.AppendLine("Укажите отчество");
            if (_currentAgent.DealShare < 1 || _currentAgent.DealShare > 100)
                errors.AppendLine("Количество звёзд - число от 1 до 5");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentAgent.Id == 0)
                esoftEntities.GetContext().agents.Add(_currentAgent);

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
