using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace FurnitureStore_Kylosov.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        public delegate void Price(int i);
        Price pr;

        public Item(Classes.Item item)
        {
            InitializeComponent();

            if (item != null)
            {
                if (File.Exists(Directory.GetCurrentDirectory() + "/Images/Items/" + item.src))
                    image.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "/Images/Items/" + item.src));
                else
                    image.Source = new BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "/Images/Items/placeholder.png"));

                price.Content = item.price;
                name.Content = item.name;
            }

            pr = item.AddPrice;
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex r = new Regex("[^0-9]+");
            e.Handled = r.IsMatch(e.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pr(int.Parse(Count.Text));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Count.Text = $"{(1 + int.Parse(Count.Text) > 5 ? 5 : 1 + int.Parse(Count.Text))}";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Count.Text = $"{(int.Parse(Count.Text) - 1 < 0? 0 : int.Parse(Count.Text) - 1)}";
        }
    }
}
