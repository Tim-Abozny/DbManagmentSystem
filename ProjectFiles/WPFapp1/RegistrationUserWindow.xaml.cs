﻿using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using WPFapp1.EntityWindows;

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
        private void SetConnection(object sender, RoutedEventArgs e)
        {
            //sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DbManagSys"].ConnectionString);
            //sqlConnection.Open();

            //if (EntityWindow.ClientChoosen == 1)
            //{
            //    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UserAccounts where uEmail = '" + login.Text + "' and uPassword = '" + password.Password + "' ", sqlConnection);
            //    DataTable dt = new DataTable();
            //    sda.Fill(dt);
            //    if (dt.Rows[0][0].ToString() == "1")
            //    {
            //        ClientWindow clientWindow = new ClientWindow();
            //        clientWindow.Show();
            //        this.Hide();

            //        sqlConnection.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("WRONG ACCOUNT NUMBER OR PIN CODE");
            //        sqlConnection.Close();
            //    }
            //}
            //else if (EntityWindow.DoctorChoosen == 1)
            //{

            //}
            //else if (EntityWindow.RegistratorChoosen == 1)
            //{

            //}
            //else if (EntityWindow.AccountantChoosen == 1)
            //{

            //}
            //else if (EntityWindow.AdminChoosen == 1)
            //{

            //}

            //if (sqlConnection.State == ConnectionState.Open)
            //    sqlConnection.Close();
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
