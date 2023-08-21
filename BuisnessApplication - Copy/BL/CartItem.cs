using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessApplication.BL
{
    class CartItem
    {
        private string id;
        private string name;
        private int quantity;
        private int price;
        public CartItem(string id,string name,int quantity,int price)
        {
            Setid(id);
            SetQuantity(quantity);
            SetName(name);
            SetPrice(price);
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void Setid(string id)
        {
            this.id = id;
        }
        public void SetQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public string GetName()
        {
            return name;
        }
        public string Getid()
        {
            return id;
        }
        public int GetQuantity()
        {
            return quantity;
        }
        public int GetPrice()
        {
            return price;
        }
      public void SetPrice(int price)
        {
            this.price = price;
        }
    }
}
