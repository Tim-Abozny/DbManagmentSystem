using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WPFapp1
{
    /// <summary>
    /// Interaction logic for RegisterUserAccWindow.xaml
    /// </summary>
    public partial class RegisterUserAccWindow : Window
    {
        private SqlConnection? sqlConnection = null;
        public RegisterUserAccWindow()
        {
            InitializeComponent();
        }
        private void RegUser()
        {
            try
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DbManagSys"].ConnectionString);
                sqlConnection.Open();

                SqlDataAdapter sda = new SqlDataAdapter("DECLARE @email varchar(50), @password varchar (255)" +
                    $"SET @email = '{login.Text}' " +
                    $"SET @password = '{password.Password}' " +
                    "EXEC NewUser @email, @password", sqlConnection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("completed.");
                sqlConnection.Close();
                
                LoginWindow loginWindow = new LoginWindow();
                this.Hide();
                loginWindow.Show();
            }
            catch (System.Exception)
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }
        }
        private void SetConnection(object sender, RoutedEventArgs e)
        {
            if (password.Password == confirmPass.Password
                && login.Text.Contains('@')
                && login.Text.Length > 3
                && password.Password.Length > 3)
            {
                RegUser();
            }
        }
        private void CloseApp(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            this.Hide();
            loginWindow.Show();
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
        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            loginBlur.Radius = 10;
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            loginBlur.Radius = 0;
        }

        private void Button_MouseEnter_1(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                ConnectEffects.ShadowDepth = -i;
                ConnectEffects.BlurRadius = i;
            }
            ConnectButton.FontSize = 12;
            ConnectButton.FontSize = 13;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            for (int i = 20; i > 0; i--)
            {
                ConnectEffects.ShadowDepth = -i;
                ConnectEffects.BlurRadius = i;
            }
            ConnectButton.FontSize = 13;
            ConnectButton.FontSize = 12;
        }
    }
}
