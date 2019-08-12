using System;
using System.Collections.Generic;

namespace T1809E_C
{
    public  class Product
    {
        public int id;
        public string name;
        public decimal price;
        public int qty;
        public string image;
        public string desc;
        public List<string> gallery;

        private event Notification ShowNotifyWhenChangePrice;
        private event Notification ShowNotifyWhenChangeQty;
        
        public Product()
        {
            this.gallery = new List<string>();
        }

        public Product(int id, string name, decimal price, int qty, 
            string image, string desc)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
            this.gallery = new List<string>();
        }

        public string this[int index]
        {
            get
            {
                return "aaaa"+gallery[index];
            }
            set
            {
                if (value.Length > 10)
                {
                    gallery[index] = value;
                }
            }
        }
            
        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public decimal Price
        {
            get => price;
            set
            {
                
                if (ShowNotifyWhenChangePrice == null)
                {
                    ShowNotifyWhenChangePrice += Cart.ShowNotification;
                }

                if (this.Price != value && this.Price != 0)
                {
                    ShowNotifyWhenChangePrice("Gia da duoc cap nhat");
                }
                price = value;
            }
        }

        public int Qty
        {
            get => qty;
            set
            {
                if (ShowNotifyWhenChangeQty == null)
                {
                    ShowNotifyWhenChangeQty += Cart.ShowNotification;
                }

                if (this.Qty != value && this.Qty != 0)
                {
                    ShowNotifyWhenChangeQty("So luong sp moi duoc cap nhat");
                }
                qty = value;
            }
        }

        public string Image
        {
            get => image;
            set => image = value;
        }

        public string Desc
        {
            get => desc;
            set => desc = value;
        }

        public virtual void TinhTien()
        {
            Product p = new Product();
            p.gallery.Add("helloworld");
            p.gallery.Add("goodmorning");
            
            Console.WriteLine(p.gallery[0]);
            Console.WriteLine(p[0]);
            p.gallery[1] = "hahaha";
            p[1] = "abcxyz";
        }

        public virtual void GetInfo()
        {
            
            Console.WriteLine("id: "+id);
            Console.WriteLine("name: "+name);
            Console.WriteLine("price: "+price);
            Console.WriteLine("qty: "+qty);
            Console.WriteLine("image: "+ this.Image);
            Console.WriteLine("desc: "+desc);
            this.Image = "abcxyz";
            foreach (string s in gallery)
            {
                Console.WriteLine(s);
            }
        }

        public bool CheckQty()
        {
            if (qty > 0)
            {
                return true;
            }
            return false;
        }

        public bool AddGallery(string img)
        {
            if (gallery.Count < 10)
            {
                gallery.Add(img);
                return true;
            }
            Console.WriteLine("Vuot qua so anh cho phep");
            return false;
        }

        public void AddGallery2()
        {
            if (gallery.Count < 10)
            {
                string img = Console.ReadLine();
                gallery.Add(img);
                return;
            }
            Console.WriteLine("Vuot qua so anh cho phep");
        }

        public void RemoveGallery()
        {
            int i = 0;
            foreach (string s in gallery)
            {
                Console.WriteLine(i+". "+ s);
                i++;
            }
            Console.WriteLine("Nhap vi tri anh muon xoa:");
            int n = Convert.ToInt16(Console.ReadLine());
            gallery.RemoveAt(n);
        }

        public bool RemoveGallery(int n)
        {
            if (n < gallery.Count)
            {
                gallery.RemoveAt(n);
                //gallery.Remove("afafaafa");
                return true;
            }
            Console.WriteLine("Khong tim thay anh hoac khong the xoa");
            return false;
        }
        
    }

}