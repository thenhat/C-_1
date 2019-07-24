using System;
using System.Collections.Generic;

namespace T1809E_C
{
    public class Product
    {
        public int id;
        public string name;
        public int price;
        public int qty;
        public string image;
        public string desc;
        List<string> galary =new List<string>();

        public Product()
        {
            id = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
            price = Convert.ToInt32(Console.ReadLine());
            qty= Convert.ToInt32(Console.ReadLine());
            image = Console.ReadLine();
            desc = Console.ReadLine();
            for (int i = 0; i < 2; i++)
            {
                string a = Console.ReadLine();
                galary.Add(a);
            }

        }

        public Product(int id, string name, int price, int qty, string image, string desc, List<string> galary)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
            this.galary = galary;
        }

        public void getInfo()
        {
            Console.WriteLine("ID:" +id);
            Console.WriteLine("name:" +name);
            Console.WriteLine("price:" +price);
            Console.WriteLine("qty:" +qty);
            Console.WriteLine("image:" +image);
            Console.WriteLine("desc:" +desc);
            foreach (var x in galary)
            {
                Console.WriteLine("galary:" +x);
            }
        }

        public void thongBao()
        {
            Console.WriteLine("---------------------------");
            if (qty == 0)
            {
                Console.WriteLine(" out of stock");
            }
            else
            {
                
                Console.WriteLine("In stock");
            }
        }

        public void AddImage()
        {
            if (galary.Count > 10)
            {
                Console.WriteLine("Xoa bot anh");
            }
            else
            {
                Console.WriteLine("them anh:");
                string add = Console.ReadLine();
                galary.Add(add);
            }
        }

        public void DeleteImage()
        {
            Console.WriteLine("---------------------------");
            foreach (var x in galary)
            {
                Console.WriteLine("galary:" +x);
            }
            Console.WriteLine("Ban muon xoa anh so may:");
            int s = Convert.ToInt32(Console.ReadLine());
            if (s > galary.Count)
            {
                Console.WriteLine("Nhap lai");
                DeleteImage();
            }
            else
            {
                galary.RemoveAt(s);
                foreach (var x in galary)
                {
                    Console.WriteLine("galary:" +x);
                } 
            }
            
        }
    }
}