using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FurnitureStore_Kylosov.Classes
{
    public class Item
    {
        Pages.Main mw;
        public string name { get; set; }
        public int price { get; set; }
        public string src { get; set; }
        public Item(string name, int price, string src, Pages.Main mw)
        {
            this.name = name;
            this.price = price;
            this.src = src;
            this.mw = mw;
        }
        
        public void AddPrice(int i)
        {
            mw.price += this.price * i;
            mw.Trash.Content = $"Корзина ({(i + int.Parse(mw.Trash.Content.ToString().Replace("Корзина (", "").Replace(")", "")))})";
        }
    }
}
