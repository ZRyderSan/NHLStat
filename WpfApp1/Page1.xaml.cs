using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        Array buf;
        public Page1()
        {
            InitializeComponent();
        }
        public void ImageConvert()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string path = ofd.FileName;
            BitmapImage ima = new BitmapImage();
            ima.BeginInit();
            ima.UriSource = new Uri(path);
            ima.EndInit();
            LogoShow.Source = ima;
            
        }

        private void ChoseImg_Click(object sender, RoutedEventArgs e)
        {
            ImageConvert();
        }
    }
}
