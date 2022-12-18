using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using WPFapp1.Entities;

namespace WPFapp1
{
    /// <summary>
    /// Interaction logic for ClientWindow.xaml
    /// </summary>
    public partial class ClientWindow : Window
    {
        private SqlConnection? sqlConnection = null;
        public ClientWindow()
        {
            InitializeComponent();
        }
        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
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

        private void Card_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            #region code
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DbManagSys"].ConnectionString);
            sqlConnection.Open();
            string query = $"select ClientCards.UserID from ClientCards where UserID = {Statics.PersonID}";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            int? checkID = (int?)(command.ExecuteScalar());
            if (checkID.HasValue)
            {
                MessageBox.Show("Card already exist");
            }
            else
            {
                RegistrationUserWindow registration = new RegistrationUserWindow();
                this.Hide();
                registration.Show();
            }
            sqlConnection.Close();
            #endregion
        }

        private void DoctorImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            #region code
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DbManagSys"].ConnectionString);
            sqlConnection.Open();
            string query = $"select ClientCards.UserID from ClientCards where UserID = {Statics.PersonID}";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            int? checkID = (int?)(command.ExecuteScalar());
            if (checkID.HasValue)
            {
                ServicesWindow servicesWindow = new ServicesWindow();
                this.Hide();
                servicesWindow.Show();
            }
            else
            {
                MessageBox.Show("PERMISSION DENIED\nYOU HAVE NO CARD");
            }
            sqlConnection.Close();
            #endregion
            
        }

        private void RegistratorImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("INFO ABOUT COMPANY\nComing soon ...");
        }
        private void ClientImage_MouseEnter(object sender, MouseEventArgs e)
        {
            ClientEffects.BlurRadius = 50;
        }

        private void ClientImage_MouseLeave(object sender, MouseEventArgs e)
        {
            ClientEffects.BlurRadius = 0;

        }

        private void DoctorImage_MouseEnter(object sender, MouseEventArgs e)
        {
            DoctorEffects.BlurRadius = 50;
        }

        private void DoctorImage_MouseLeave(object sender, MouseEventArgs e)
        {
            DoctorEffects.BlurRadius = 0;
        }

        private void RegistratorImage_MouseEnter(object sender, MouseEventArgs e)
        {
            RegistratorEffects.BlurRadius = 50;
        }

        private void RegistratorImage_MouseLeave(object sender, MouseEventArgs e)
        {
            RegistratorEffects.BlurRadius = 0;
        }
    }
}
