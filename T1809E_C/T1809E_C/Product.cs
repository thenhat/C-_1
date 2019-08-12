using System;
using System.Collections.Generic;

namespace T1809E_C
{
    public class Product
    {
        public string ProductId;
        public string Name;
        public decimal Price;
        
        public void AddProduct()
        {
           Console.WriteLine("ID Product:");
           ProductId = Console.ReadLine();
           Console.WriteLine("Name:");
           Name = Console.ReadLine();
           Console.WriteLine("Price:");
           Price = Convert.ToDecimal(Console.ReadLine());
        }
        
        public void GetProduct()
        {
            Console.WriteLine("ID Product:" +ProductId);
            Console.WriteLine("Name:" +Name);
            Console.WriteLine("Price:" +Price);
        }
    }

    public class ListProduct : Product
    {
        List<Product> productList =new List<Product>();
        public void AddListProduct()
        {
            Console.WriteLine("Them hang");
            Product ll=new Product();
            ll.AddProduct();
            productList.Add(ll);
        }

        public void ShowProduct()
        {
            foreach (var x in productList)
            {
                x.GetProduct();
                Console.WriteLine("-------------------");
            } 
        }

        public void DeleteProduct()
        {
            Console.WriteLine("Enter Product Id Delete:");
            string Id = Console.ReadLine();
            foreach (Product x in productList)
            {
                if (x.ProductId.Equals(Id))
                {
                    productList.Remove(x);
                }
            }
        }
    }

    public class Menu
    {
        public static void Main(string[] args) {
            ListProduct lk=new ListProduct();
            int x;
            do {
                Console.WriteLine("\t\t----------------------------------");
                Console.WriteLine("\t\t|\t\t\t\tMENU\t\t\t |");
                Console.WriteLine("\t\t----------------------------------");
                Console.WriteLine("\t\t|1. Add Product");
                Console.WriteLine("\t\t|2. Show Product");
                Console.WriteLine("\t\t|3. Delete Product");
                Console.WriteLine("\t\t|4. Exit");
                Console.WriteLine("\t\t----------------------------------");
                x = Convert.ToInt32(Console.ReadLine());
                switch (x) {
                    case 1:
                        lk.AddListProduct();
                        break;
                    case 2:
                        lk.ShowProduct();
                        break;
                    case 3:
                        lk.DeleteProduct();
                        break;
                }
            } while (x != 4);
            Console.WriteLine(" ");
        }
    }
    
}