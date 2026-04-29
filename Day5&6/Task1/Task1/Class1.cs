using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task1
{
    public class Product
    {
        private string name;
        private int quantity;
        private int price;

        public void setName(string name)
        {
            this.name = name;
        }
        public void setQuantity(int quantity)
        {
            if (quantity < 0)
            {
                quantity = 0;
            }

            this.quantity = quantity;
        }
        public void setPrice(int price)
        {
            if (price < 0)
            {
                price = 0;
            }

            this.price = price;
        }
        public string getName()
        {
            return name;
        }
        public int getQuantity()
        {
            return quantity;
        }
        public int getPrice()
        {
            return price;
        }
        public virtual int GetTotalPrice()
        {
            return price * quantity;
        }
    }


    public class ShoppingCart
    {
        private List<Product> items = new List<Product>();

        public void AddProduct(Product product)
        {
            items.Add(product);
        }
        public void RemoveProduct(Product product)
        {
            items.Remove(product);
        }
        public int CalculateTotal()
        {
            int total = 0;

            foreach (Product product in items)
            {
                total += product.GetTotalPrice();
            }

            return total;
        }
    }
}

public class DigitalProduct : Product
{
    private string link;

    public void setLink(string link)
    {
        this.link = link;
    }

    public override int GetTotalPrice()
    {
        return getPrice() * getQuantity();
    }
}


public class PhysicalProduct : Product
{
    private int shippingCost;

    public void setShippingCost(int cost)
    {
        shippingCost = cost;
    }

    public override int GetTotalPrice()
    {
        return (getPrice() * getQuantity()) + shippingCost;
    }
}