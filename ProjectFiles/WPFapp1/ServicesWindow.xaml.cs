using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace WPFapp1
{
    /// <summary>
    /// Interaction logic for ServicesWindow.xaml
    /// </summary>
    public partial class ServicesWindow : Window
    {
        private SqlConnection? sqlConnection = null;
        public ServicesWindow()
        {
            InitializeComponent();
        }
        private void RegisterService(string ServName, string doctorName)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DbManagSys"].ConnectionString);
            sqlConnection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("DECLARE @userID INT, @doctorID INT " +
            $"SET @userID = {Statics.PersonID} " +
            $"SET @doctorID = (select Doctors.ID from Doctors where Doctors.dName = '{doctorName}') " +
            $"EXEC {ServName} @userID, @doctorID", sqlConnection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlConnection.Close();

            MessageBox.Show($"Operation successful.\nService: {ServName}\nDoctor: {doctorName}");
            ClientWindow clientWindow = new ClientWindow();
            this.Hide();
            clientWindow.Show();
        }
        private void SetConnection(object sender, RoutedEventArgs e)
        {
            if (ServiceRequest.Text == "ArmHilling")
            {
                RegisterService("ArmHilling", "Elithaveta Zayceva");
            }
            else if (ServiceRequest.Text == "BrainDamaging")
            {
                RegisterService("BrainDamaging", "Elithaveta Zayceva");
            }
            else if (ServiceRequest.Text == "BreathCheck")
            {
                RegisterService("BreathCheck", "Leonard Zeus");
            }
            else if (ServiceRequest.Text == "EarsCheck")
            {
                RegisterService("EarsCheck", "Elithaveta Zayceva");
            }
            else if (ServiceRequest.Text == "EmotionalDamage")
            {
                RegisterService("EmotionalDamage", "Elithaveta Zayceva");
            }
            else if (ServiceRequest.Text == "EyesCheck")
            {
                RegisterService("EyesCheck", "Elithaveta Zayceva");
            }
            else if (ServiceRequest.Text == "FamilyTherapy")
            {
                RegisterService("FamilyTherapy", "Leonard Zeus");
            }
            else if (ServiceRequest.Text == "HeartBreaking")
            {
                RegisterService("HeartBreaking", "Anna Staromodova");
            }
            else if (ServiceRequest.Text == "HeartHilling")
            {
                RegisterService("HeartHilling", "Polina Aboznaya");
            }
            else if (ServiceRequest.Text == "PulseCheck")
            {
                RegisterService("PulseCheck", "Polina Aboznaya");
            }
            else if (ServiceRequest.Text == "SMAD")
            {
                RegisterService("SMAD", "Polina Aboznaya");
            }
            else if (ServiceRequest.Text == "TeethCheck")
            {
                RegisterService("TeethCheck", "Elithaveta Zayceva");
            }
            else if (ServiceRequest.Text == "Urinotherapy")
            {
                RegisterService("Urinotherapy", "Leonard Zeus");
            }
            else
            {
                MessageBox.Show("SERVICE NOT FOUND");
            }

        }
        #region animation
        private void CloseApp(object sender, RoutedEventArgs e)
        {
            ClientWindow clientWindow = new ClientWindow();
            this.Hide();
            clientWindow.Show();
        }
        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        private void Button_MouseEnter_1(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                ConnectEffects1.ShadowDepth = -i;
                ConnectEffects1.BlurRadius = i;
            }
            Reload.FontSize = 12;
            Reload.FontSize = 13;
        }
        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            for (int i = 20; i > 0; i--)
            {
                ConnectEffects1.ShadowDepth = -i;
                ConnectEffects1.BlurRadius = i;
            }
            Reload.FontSize = 13;
            Reload.FontSize = 12;
        }
        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            exitButtonBlur.Radius = 0;
        }

        private void ExitButton_MouseLeave(object sender, MouseEventArgs e)
        {
            ExitButton.Foreground = new SolidColorBrush(myColor.Color);
            ExitButton.Background = new SolidColorBrush();
            exitButtonBlur.Radius = 10;
        }
        private void Reload_Click(object sender, RoutedEventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DbManagSys"].ConnectionString);
            sqlConnection.Open();
            string query = "select information_schema.routines.SPECIFIC_NAME as Services " +
                "from information_schema.routines " +
                "where routine_type = 'PROCEDURE' " +
                "and information_schema.routines.SPECIFIC_NAME not in ('NewCard') " +
                "and information_schema.routines.SPECIFIC_NAME not in ('RegisterService') " +
                "and information_schema.routines.SPECIFIC_NAME not in ('DoctorService') " +
                "and information_schema.routines.SPECIFIC_NAME not in ('RegtorServList') " +
                "and information_schema.routines.SPECIFIC_NAME not in ('NewUser') " +
                "and information_schema.routines.SPECIFIC_NAME not in ('CheckUserData') " +
                "and information_schema.routines.SPECIFIC_NAME not in ('GetServices') " +
                "group by information_schema.routines.SPECIFIC_NAME";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = query;
            sqlCommand.Connection = sqlConnection;
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dtGrid1.ItemsSource = dt.DefaultView;

            sqlConnection.Close();
        }

        private void ConnectButton_MouseLeave(object sender, MouseEventArgs e)
        {
            for (int i = 20; i > 0; i--)
            {
                ConnectEffects.ShadowDepth = -i;
                ConnectEffects.BlurRadius = i;
            }
            ConnectButton.FontSize = 13;
            ConnectButton.FontSize = 12;
        }

        private void ConnectButton_MouseEnter(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                ConnectEffects.ShadowDepth = -i;
                ConnectEffects.BlurRadius = i;
            }
            ConnectButton.FontSize = 12;
            ConnectButton.FontSize = 13;
        }
        #endregion
    }
}
