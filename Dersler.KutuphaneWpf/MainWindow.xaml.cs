using Dersler.KutuphaneWpf.Classlar;
using Dersler.KutuphaneWpf.uKontroller;
using System.IO;
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
            btnOk_Click(null, null);
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            this.MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth;
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if(Mouse.LeftButton==MouseButtonState.Pressed)
            {
                
              //  if (this.WindowState == WindowState.Maximized) this.WindowState = WindowState.Normal;
                this.DragMove();
            }
        }

        private void btn_kapat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();   
        }

        private void btn_kucult_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState != WindowState.Minimized) { this.WindowState = WindowState.Minimized; grid.Margin = new Thickness(0, 0, 0, 0); }
            else if (this.WindowState == WindowState.Minimized) { this.WindowState = WindowState.Normal;
                grid.Margin = new Thickness(5,5,5,5);
            }

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

        private void btn_kitaplistesi_Click(object sender, RoutedEventArgs e)
        {
            uc_cagir.uc_ekle(this.content, new ucKitapEkle());
         /*   MessageBox.Show(Environment.CurrentDirectory);
            MessageBox.Show($"{Environment.CurrentDirectory}\\..\\..\\..\\Database\\kutphaneDb.db");
           var sonuc= System.IO.Path.Combine(Environment.CurrentDirectory, "\\..\\..\\Database\\kutuphaneDb.db");
            MessageBox.Show(sonuc);
           */ 
            // MessageBox.Show(DbBaglanti.Dbadres+"-----"+ @"C:\Projeler\Dersler\Dersler.KutuphaneWpf\Database\kutuphaneDb.db");
           
            MessageBox.Show(DbBaglanti.VeriTabaninaBaglanti);
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (DbBaglanti.VeriTabaninaBaglanti == "OK") btnOk.Background = Brushes.Green;
            else btnOk.Background = Brushes.Red;
        }

        private void Logo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ismenuOpen = !ismenuOpen;
            MenuVisible(ismenuOpen);
        }

        bool ismenuOpen = true;
        void MenuVisible(bool goster = true)
        {

            if (goster)
            {

                lbl_EmanetListesi.Visibility = Visibility.Visible;
                lbl_Hakkinda.Visibility = Visibility.Visible;
                lbl_KitapListesi.Visibility = Visibility.Visible;
                lbl_OkuyucuListesi.Visibility = Visibility.Visible;
                lbl_programadi.Visibility = Visibility.Visible;
                lbl_ZamaniDolanlar.Visibility = Visibility.Visible;
                lbl_verison.Visibility = Visibility.Visible;
                logoBorder.Width = 240;
                Logo.Width = 100;
                btnPanel.Width = 240;
                menuCol.Width = new GridLength(240, GridUnitType.Pixel);

            }
            else
            {
                lbl_EmanetListesi.Visibility = Visibility.Hidden;
                lbl_Hakkinda.Visibility = Visibility.Hidden;
                lbl_KitapListesi.Visibility = Visibility.Hidden;
                lbl_OkuyucuListesi.Visibility = Visibility.Hidden;
                lbl_programadi.Visibility = Visibility.Hidden;
                lbl_ZamaniDolanlar.Visibility = Visibility.Hidden;
                lbl_verison.Visibility = Visibility.Hidden;
                logoBorder.Width = 80;
                Logo.Width = 80;
                btnPanel.Width = 80;
                menuCol.Width = new GridLength(80, GridUnitType.Pixel);
            }
        }
    }
}