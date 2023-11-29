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

namespace FurnitureStore_Kylosov.Pages
{
    /// <summary>
    /// Логика взаимодействия для Categories.xaml
    /// </summary>
    public partial class Categories : Page
    {
        public delegate void OpenMain();
        public OpenMain openMain;
        public Categories(OpenMain openMain)
        {
            InitializeComponent();
            this.openMain = openMain;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            openMain();
        }
    }
}
