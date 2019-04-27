using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP                 //A.L1.P3/6. Shop Domain Code
{
    class Shop                                  //abstraction
    {
        private string shopName;
        public string NameShop                  //Encapsulation
        {
            get { return shopName; }
        }

        private List<Product> PriceList;

        public Shop(string shopName)
        {
            this.shopName = shopName;
        }

        public void AddProductToShop(Product product)
        {
            PriceList.Add(product);
        }
    }

    class Customer                              //abstraction
    {
        protected List<Product> Orders;
        protected double totalPrice;
        public double TotalPrice                //Encapsulation
        {
            get { return totalPrice; }
        }

        public void AddProductToOrders(Product product)
        {
            Orders.Add(product);
            totalPrice += product.ProductPrice;
        }

        public virtual void Buy()               //Polymorphism
        {
            Orders.Clear();
            totalPrice = 0;
        }
    }

    class Acount : Customer                     //Inheritance
    {
        public int PhoneNumber;
        private List<Product> OrdersHistrory;
        public override void Buy()
        {
            foreach (var x in Orders)
            {
                OrdersHistrory.Add(x);
            }
            Orders.Clear();
            totalPrice = 0;
        }
    }

    class Product                               //abstraction
    {
        private string productName;
        private double productPrice;
        public double ProductPrice              //Encapsulation
        {
            get { return productPrice; }
        }
        public string ProductName               //Encapsulation
        {
            get { return productName; }
        }

        public Product(string productName, double productPrice)
        {
            this.productName = productName;
            this.productPrice = productPrice;
        }

        public static bool operator ==(Product a, Product b)                //A.L1.P6/6*.Shop Operators Overloading
        {
            return a.productPrice == b.productPrice;
        }

        public static bool operator !=(Product a, Product b)                //A.L1.P6/6*.Shop Operators Overloading
        {
            return a.productPrice != b.productPrice;
        }

        public static bool operator >(Product a, Product b)                 //A.L1.P6/6*.Shop Operators Overloading
        {
            return a.productPrice > b.productPrice;
        }

        public static bool operator <(Product a, Product b)                 //A.L1.P6/6*.Shop Operators Overloading
        {
            return a.productPrice < b.productPrice;
        }
    }
}
