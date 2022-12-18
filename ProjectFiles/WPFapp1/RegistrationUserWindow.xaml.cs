using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Data.SqlClient;
using System.Net;
using System.Xml.Linq;
using System.Configuration;
using System.Data;

namespace WPFapp1
{
    /// <summary>
    /// Interaction logic for RegistrationUserWindow.xaml
    /// </summary>
    public partial class RegistrationUserWindow : Window
    {
        private SqlConnection? sqlConnection = null;
        public RegistrationUserWindow()
        {
            InitializeComponent();
        }
        private void CloseApp(object sender, RoutedEventArgs e)
        {
            ClientWindow clientWindow = new ClientWindow();
            this.Hide();
            clientWindow.Show();
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
        private void SetConnection(object sender, RoutedEventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DbManagSys"].ConnectionString);
            sqlConnection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("DECLARE @name varchar(128), @address varchar(50), @phone varchar(13), @birthday date, @userID INT, @storageID INT " +
            $"SET @name = '{FullName.Text}' " +
            $"SET @address = '{Address.Text}' " +
            $"SET @phone = '{Phone.Text}' " +
            $"SET @birthday = '{Birthday.Text}' " +
            $"SET @userID = {Statics.PersonID} " +
            $"SET @storageID = (select CardsStorage.ID from CardsStorage where CardsStorage.Section = 'firstSection') " +
            $"EXEC NewCard @name, @address, @phone, @birthday, @userID, @storageID", sqlConnection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlConnection.Close();

            MessageBox.Show($"Operation successful.\nCongratulations!");
            ClientWindow clientWindow = new ClientWindow();
            this.Hide();
            clientWindow.Show();
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
