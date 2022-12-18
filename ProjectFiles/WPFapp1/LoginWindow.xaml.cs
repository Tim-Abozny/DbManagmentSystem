using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace WPFapp1
{
    public static class Statics
    {
        public static int PersonID = 0;
    }
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private SqlConnection? sqlConnection = null;

        private void CheckAccount(int roleID)
        {            
            try
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DbManagSys"].ConnectionString);
                sqlConnection.Open();
            
                SqlDataAdapter sda = new SqlDataAdapter("DECLARE @email varchar(50), @password varchar (255), @roleID INT " +
                    $"SET @email = '{login.Text}' " +
                    $"SET @password = '{password.Password}' " +
                    $"SET @roleID = '{roleID}' " +
                    "EXEC CheckUserData @email, @password, @roleID", sqlConnection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    #region code
                    sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DbManagSys"].ConnectionString);
                    sqlConnection.Open();
                    string query = "select UserAccounts.ID from UserAccounts where uEmail = " +
                    $"'{login.Text}' and uPassword = " +
                    $"'{password.Password}' intersect select UsersRoles.userID from UsersRoles where UsersRoles.roleID = '{roleID}'";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    Statics.PersonID = (int)(command.ExecuteScalar());
                    sqlConnection.Close();
                    #endregion

                    if (EntityWindow.ClientChoosen == 1)
                    {
                        ClientWindow clientWindow = new ClientWindow();
                        this.Hide();
                        clientWindow.Show();
                    }
                    else if (EntityWindow.DoctorChoosen == 1)
                    {
                        DoctorWindow doctorWindow = new DoctorWindow();
                        this.Hide();
                        doctorWindow.Show();
                    }
                    else if (EntityWindow.RegistratorChoosen == 1)
                    {
                        RegistratorWindow registratorWindow = new RegistratorWindow();
                        this.Hide();
                        registratorWindow.Show();
                    }
                    else if (EntityWindow.AccountantChoosen == 1)
                    {
                        AccountantWindow accountantWindow = new AccountantWindow();
                        this.Hide();
                        accountantWindow.Show();
                    }

                    sqlConnection.Close();    
                }
                else
                {
                    MessageBox.Show("WRONG ACCOUNT NUMBER OR PIN CODE");
                    sqlConnection.Close();
                }
            }
            catch (System.Exception)
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }

        }
        
        public LoginWindow()
        {
            InitializeComponent();
        }
        private void SetConnection(object sender, RoutedEventArgs e)
        {
            

            if (EntityWindow.ClientChoosen == 1)
            {
                CheckAccount(1);
            }
            else if (EntityWindow.DoctorChoosen == 1) 
            {
                CheckAccount(2);
            }
            else if (EntityWindow.RegistratorChoosen == 1)
            {
                CheckAccount(3);
            }
            else if (EntityWindow.AccountantChoosen == 1)
            {
                CheckAccount(4);
            }
            else if (EntityWindow.AdminChoosen == 1)
            {
                CheckAccount(5);
            }
        }
        #region DesignFunctions
        private void CloseApp(object sender, RoutedEventArgs e)
        {
            EntityWindow entityWindow = new EntityWindow();

            EntityWindow.ClientChoosen = 0;
            EntityWindow.DoctorChoosen = 0;
            EntityWindow.RegistratorChoosen = 0;
            EntityWindow.AccountantChoosen = 0;
            EntityWindow.AdminChoosen = 0;
            
            this.Hide();
            entityWindow.Show();           
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

        private void registerShadow_MouseEnter(object sender, MouseEventArgs e)
        {
            shadowEffect.ShadowDepth = 2;
        }

        private void registerShadow_MouseLeave(object sender, MouseEventArgs e)
        {
            shadowEffect.ShadowDepth = 0;
        }

        private void registerShadow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RegisterUserAccWindow registrationUser = new RegisterUserAccWindow();
            registrationUser.Show();
            this.Hide();
        }
        #endregion
    }
}
