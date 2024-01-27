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
        string path;

        public Page1()
        {
            InitializeComponent();
        }
        public BitmapImage ImageConvert()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            path = ofd.FileName;
            BitmapImage ima = new BitmapImage();
            ima.BeginInit();
            ima.UriSource = new Uri(path);
            ima.EndInit();
            return ima;
            
        }

        private void ChoseImg_Click(object sender, RoutedEventArgs e)
        {
            LogoShow.Source = ImageConvert();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Class1 cq = new Class1();
            cq.sqlC(ChoseNam.Text, path);
        }
    }
}
