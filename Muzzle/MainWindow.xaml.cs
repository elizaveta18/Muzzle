using Muzzle.Class;
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

namespace Muzzle
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static class Products
        {
            public static Frame frm;
        }

        
        public MainWindow()
        {
            InitializeComponent();
            BaseConnect.baseConnect = new Entities2();
            Products.frm = frmMain;
            frmMain.Navigate(new Main());
           
        }
    }
}
