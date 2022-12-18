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
    /// Interaction logic for RegistratorWindow.xaml
    /// </summary>
    public partial class RegistratorWindow : Window
    {
        public RegistratorWindow()
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
        private void DoctorImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            RegServWindow regServ = new RegServWindow();
            this.Hide();
            regServ.Show();

        }
        private void DoctorImage_MouseEnter(object sender, MouseEventArgs e)
        {
            DoctorEffects.BlurRadius = 50;
        }

        private void DoctorImage_MouseLeave(object sender, MouseEventArgs e)
        {
            DoctorEffects.BlurRadius = 0;
        }
    }
}
