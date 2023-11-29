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
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public List<Classes.Item> items = new List<Classes.Item>();
        static Main mw;
        public delegate void OpenCat();
        public OpenCat openCat;
        int Price = 0;

        public int price{ get { return Price; } set { Price = value; PriceNow.Content = $"Текущая стоимость - {value}"; } }
        public Main(OpenCat openCat)
        {
            mw = this;
            InitializeComponent();
            items.Add(new Classes.Item("Шкаф", 20000, "schcaf.jpg", mw));
            items.Add(new Classes.Item("Шкаф-купе", 13000, "schcafkype.jpg", mw));
            items.Add(new Classes.Item("Шкаф-аниме", 11000, "schcafanime.jpg", mw));
            items.Add(new Classes.Item("Кресло для деда", 15000, "dead.jpg", mw));
            items.Add(new Classes.Item("Кресло", 17000, "kreclo.jpg", mw));
            LoadItems();
            this.openCat = openCat;
        }
        public void LoadItems()
        {
            parent.Children.Clear();
            foreach (Classes.Item item in items)
            {
                parent.Children.Add(new Elements.Item(item));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            openCat();
        }
    }
}
