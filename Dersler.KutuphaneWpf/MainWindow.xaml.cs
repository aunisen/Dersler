using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dersler.KutuphaneWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if(Mouse.LeftButton==MouseButtonState.Pressed)
            {
                this.DragMove();    
            }
        }

        private void btn_kapat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();   
        }

        private void btn_kucult_Click(object sender, RoutedEventArgs e)
        {
            if(this.WindowState != WindowState.Minimized) { this.WindowState = WindowState.Minimized; }
            else if(this.WindowState==WindowState.Minimized)this.WindowState= WindowState.Normal;

        }

        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (this.WindowState == WindowState.Normal) { this.WindowState = WindowState.Maximized; }
            else if (this.WindowState == WindowState.Maximized) this.WindowState = WindowState.Normal;
        }

        private void btn_tamekran_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {

               // tamekranImage.Source = new BitmapImage(new Uri("/images/icons/fullscreen.png",UriKind.Relative));
               // kod çalışmadı
                this.WindowState = WindowState.Maximized;
            }
            else if (this.WindowState == WindowState.Maximized) {
              //  tamekranImage.Source = new BitmapImage(new Uri("/images/icons/fullscreen-exit.png", UriKind.Relative));
                //image source çalışmadı.
                this.WindowState = WindowState.Normal; }
        }
    }
}