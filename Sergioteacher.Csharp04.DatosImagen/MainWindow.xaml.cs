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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;

//        Sergioteacher.Csharp04.Datos01Items
namespace Sergioteacher.Csharp04.DatosImagen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BCarga_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fichero = new OpenFileDialog();
            if (fichero.ShowDialog() == true )
            {
                Uri fileImg = new Uri(fichero.FileName);
                ICarga1.Source = new BitmapImage(fileImg);
                ICarga2.Source = new BitmapImage(fileImg);
                ICarga3.Source = new BitmapImage(fileImg);
                ICarga4.Source = new BitmapImage(fileImg);
            }
        }

        private void Ipeque_MouseMove(object sender, MouseEventArgs e)
        {
            ICarga1.Source = null;
            ICarga2.Source = null;
            ICarga3.Source = null;
            ICarga4.Source = null;
        }

        private void Tpeque_MouseMove(object sender, MouseEventArgs e)
        {
            Ipeque.Visibility = Visibility.Visible;
        }
    }
}
