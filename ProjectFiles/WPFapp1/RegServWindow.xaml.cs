using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
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
using System.Windows.Shapes;

namespace WPFapp1
{
    /// <summary>
    /// Interaction logic for RegServWindow.xaml
    /// </summary>
    public partial class RegServWindow : Window
    {
        private SqlConnection? sqlConnection = null;
        public RegServWindow()
        {
            InitializeComponent();
        }
        private void SetConnection(object sender, RoutedEventArgs e)
        {
            if (ServiceRequest.Text.Length > 0)
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DbManagSys"].ConnectionString);
                sqlConnection.Open();
                //RegisterService procedure
                string query = $"DECLARE @serviceID INT " +
                    $"SET @serviceID = {ServiceRequest.Text} " +
                    $"EXEC RegisterService @serviceID ";

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = query;
                sqlCommand.Connection = sqlConnection;
                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                da.Fill(dt);

                MessageBox.Show("Operation successful\nGood job!");
                sqlConnection.Close();
                DoctorWindow doctorWindow = new DoctorWindow();
                this.Hide();
                doctorWindow.Show();
            }
            else
            {
                MessageBox.Show("WRITE ANY userID HERE");
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
            string query = "EXEC RegtorServList";

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
