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
using System.Windows.Shapes;

namespace WPFapp1
{
    /// <summary>
    /// Interaction logic for EntityWindow.xaml
    /// </summary>
    public partial class EntityWindow : Window
    {
        public static int ClientChoosen = 0;
        public static int DoctorChoosen = 0;
        public static int RegistratorChoosen = 0;
        public static int AccountantChoosen = 0;
        public static int AdminChoosen = 0;

        public EntityWindow()
        {
            InitializeComponent();
        }
        private void SwitchToLoginWindow()
        {
            LoginWindow clientLogin = new LoginWindow();
            this.Hide();
            clientLogin.Show();
        }
        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        private void CloseApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void AdminImageButton_MouseEnter(object sender, MouseEventArgs e)
        {
            AdminEffects.Radius = 0;
        }
        private void AdminImageButton_MouseLeave(object sender, MouseEventArgs e)
        {
            AdminEffects.Radius = 10;
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

        private void AccountantImage_MouseEnter(object sender, MouseEventArgs e)
        {
            AccountantEffects.BlurRadius = 50;
        }

        private void AccountantImage_MouseLeave(object sender, MouseEventArgs e)
        {
            AccountantEffects.BlurRadius = 0;
        }

        private void ClientImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SwitchToLoginWindow();
            ClientChoosen = 1;
        }

        private void DoctorImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SwitchToLoginWindow();
        }

        private void RegistratorImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SwitchToLoginWindow();
        }

        private void AccountantImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SwitchToLoginWindow();
        }

        private void AdminImageButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SwitchToLoginWindow();
        }
    }
}
