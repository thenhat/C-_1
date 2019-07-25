using System;
using System.Collections.Generic;

namespace T1809E_C
{
    public class Cart
    {
        public int id;
        public string customer;
        public double grandTotal;
        public string city;
        public string country;
        List<Product> productList =new List<Product>();

        public Cart()
        {
            id = Convert.ToInt32(Console.ReadLine());
            customer = Console.ReadLine();
            city = Console.ReadLine();
            country = Console.ReadLine();
        }

        public void addProduct()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Them hang");
            productList.Add(new Product());
            
            Console.WriteLine("-----------------");
            Console.WriteLine("ban muon them san pham nua(Y/N):");
            string check = Console.ReadLine();
            if (check == "y" || check == "Y")
            {
                addProduct();
            }
            else
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("List Product");

            
                foreach (var x in productList)
                {
                    x.getInfo();
                    Console.WriteLine("-------------------");
                } 
            }
        }

        public void deleteProduct()
        {
            foreach (var x in productList)
            {
                x.getInfo();
                Console.WriteLine("-------------------");
            } 
            
            Console.WriteLine("Ban muon xoa san pham thu may:");
            int s = Convert.ToInt32(Console.ReadLine());
            if (s > productList.Count)
            {
                Console.WriteLine("Nhap lai");
                deleteProduct();
            }
            else
            {
                productList.RemoveAt(s);
                foreach (var x in productList)
                {
                    x.getInfo();
                    Double Total = x.qty * x.price;
                    grandTotal += Total;
                    Console.WriteLine("-------------------");
                } 
            }
        }
       public void getGrandTotal()
        {
            if (country == "vietnam" || country == "Việt Nam" || country =="Viet Nam")
            {
                if (city == "HN" || city == "hanoi" || city == "Hà Nội" || city == "HCM" || city == "hcm" ||
                    city == "Hồ Chí Minh")
                {
                    grandTotal = grandTotal + grandTotal * 0.01;
                }
                else
                {
                    grandTotal = grandTotal + grandTotal * 0.02;
                }
            }else
            {
                grandTotal = grandTotal + grandTotal * 0.05;
            }
            
            Console.WriteLine("Tong tien la: " +grandTotal);
        }
    }
}