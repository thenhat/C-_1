using System;
using System.Collections.Generic;

namespace T1809E_C
{
    
    
    public class KhachHang {
    public int MaKH, SoLuong;
    public double DonGia, ThanhTien;
    public string NgayHD, HoTenKH;

    public KhachHang() {
        this.MaKH = 0;
        this.DonGia = 0;
        this.NgayHD = "";
        this.HoTenKH = "";
        this.SoLuong = 0;
    }

    public KhachHang(int ma, double dgia, string ngay, string hoten, int sl, double ttien) {
        this.MaKH = ma;
        this.DonGia = dgia;
        this.NgayHD = ngay;
        this.HoTenKH = hoten;
        this.SoLuong = sl;
        this.ThanhTien = ttien;
    }

    public int getMaKH() {
        return MaKH;
    }

    public void setMaKH(int maKH) {
        MaKH = maKH;
    }

    public double getDonGia() {
        return DonGia;
    }

    public void setDonGia(double donGia) {
        DonGia = donGia;
    }

    public string getNgayHD() {
        return NgayHD;
    }

    public void setNgayHD(string ngayHD) {
        NgayHD = ngayHD;
    }

    public string getHoTenKH() {
        return HoTenKH;
    }

    public void setHoTenKH(string hoTenKH) {
        HoTenKH = hoTenKH;
    }

    public int getSoLuong() {
        return SoLuong;
    }

    public void setSoLuong(int sl) {
        SoLuong = sl;
    }

    public double getThanhTien() {
        return ThanhTien;
    }

    public void setThanhTien(double thanhTien) {
        ThanhTien = thanhTien;
    }

    public void nhap() {
        
        Console.WriteLine("Nhap Ma Khach Hang: ");
        MaKH = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Nhap Ten Khach Hang: ");
        HoTenKH = Console.ReadLine();
        Console.WriteLine("Ngay Lap Hoa Don: ");
        NgayHD = Console.ReadLine();
        Console.WriteLine("So Luong(KW): ");
        SoLuong = Convert.ToInt32(Console.ReadLine());
    }

    public string toString() {
        return "[MaKH: " + MaKH + ", HoTenKH: " + HoTenKH + ", NgayHD: " + NgayHD + ", DonGia: " + DonGia + ", SoLuong: " + SoLuong;
    }
}
    
    public class KhachHangVN  : KhachHang
    {
        public  int LoaiKH;
        public KhachHangVN() {
            this.LoaiKH = 0;

        }

        public KhachHangVN(int ma, double dgia, string ngay, string hoten, int sl, double ttien, int loai) {

            this.LoaiKH = loai;
        }

        public int getLoaiKH() {
            return LoaiKH;
        }

        public void setLoaiKH(int loaiKH) {
            LoaiKH = loaiKH;
        }


        public void nhap()
        {
            KhachHang lf=new KhachHang();
            lf.nhap();
            Console.WriteLine("Loai KH: ");
            LoaiKH = Convert.ToInt32(Console.ReadLine());
        }

        public double TTien() {
            if (SoLuong < 50) {
                this.DonGia = 1000;
            } else if (SoLuong >= 50 && SoLuong < 100) {
                this.DonGia = 1200;
            } else if (SoLuong >= 100 && SoLuong < 200) {
                this.DonGia = 1500;
            } else if (SoLuong > 200) {
                this.DonGia = 2000;
            }
            return this.ThanhTien = this.DonGia * this.SoLuong;
        }

        public string toString() {
            string temp;
            if (LoaiKH == 1) temp = "Sinh Hoat";
            else if (LoaiKH == 2) temp = "Kinh Doanh";
            else temp = "San Xuat";
            return "Khach Hang Viet: " + toString() + ", LoaiKH: " + temp + ", Thanh Tien: " + ThanhTien;
        }
    }
    
    class KhachHangNuocNgoai : KhachHang {
    public string QuocTich;

    public KhachHangNuocNgoai() {
        this.QuocTich = "";
    }

    public KhachHangNuocNgoai(int ma, double dgia, string ngay, string hoten, int sl, double ttien, string qt) {
        this.QuocTich = qt;
    }

    public string getQuocTich() {
        return QuocTich;
    }

    public void setQuocTich(string quocTich) {
        QuocTich = quocTich;
    }

    public void nhap() {
        KhachHang lg=new KhachHang();
        lg.nhap();
        Console.WriteLine("Quoc Tich: ");
        QuocTich = Console.ReadLine();
    }

    public double TTien() {
        this.DonGia=2000;
        return this.ThanhTien = this.SoLuong * this.DonGia;
    }

    public void xuat12019(){

    }

    public string toString() {
        return "Khach Hang Nuoc Ngoai: " + toString() + ", QuocTich: " + QuocTich + ", ThanhTien: " + ThanhTien;
    }
    }
    
    public class KhachHangList : KhachHang  {
        public KhachHang[] kh = new KhachHang[100];
        public int CountKH, sum1 = 0, sum2 = 0, dem = 0;
        public double sumtien = 0;
        public KhachHangList() {
            CountKH = 0;
            for (int i = 0; i < 100; i++) kh[i] = new KhachHang();
        }

        public void ThemKH(int temp) {
            if (CountKH > 100) Console.WriteLine("Bo nho day");
            else {
                if (temp == 1) {
                    kh[CountKH] = new KhachHangVN();
                    KhachHangVN khv = new KhachHangVN();
                    khv.nhap();
                    khv.ThanhTien = khv.TTien();
                    kh[CountKH] = khv;
                    sum1 += khv.SoLuong;
                } else {
                    kh[CountKH] = new KhachHangNuocNgoai();
                    KhachHangNuocNgoai khnn = new KhachHangNuocNgoai();
                    khnn.nhap();
                    khnn.ThanhTien = khnn.TTien();
                    kh[CountKH] = khnn;
                    sum2 += khnn.SoLuong;
                    sumtien += khnn.ThanhTien;
                    dem++;
                }
                CountKH++;
            }
        }

        public void HienThiKH() {
            for (int i = 0; i < CountKH; i++) {
                Console.WriteLine("\nSo TT: " + (i + 1));
                Console.WriteLine(kh[i].toString());
            }
        }

        public void TongSL() {
            
            Console.WriteLine(":::->> Tong So Luong(KW) Dien cua KH Viet Nam: " + sum1);
            Console.WriteLine(":::->> Tong So Luong(KW) Dien cua KH Nuoc Ngoai: " + sum2);
        }

        public void TrungBinh() {
            Console.WriteLine("|-->> Trung Binh Thanh Tien cua KH Nuoc Ngoai: " + (sumtien / dem));
        }

    }
    
    public class TienDien: KhachHangList {
        public static void Main(string[] args) {
            KhachHangList lkh = new KhachHangList();
            int x;
            do {
                Console.WriteLine("\t\t----------------------------------");
                Console.WriteLine("\t\t|\t\t\t\tMENU\t\t\t |");
                Console.WriteLine("\t\t----------------------------------");
                Console.WriteLine("\t\t|0. Thoat ung dung");
                Console.WriteLine("\t\t|1. Them Khach Hang Viet");
                Console.WriteLine("\t\t|2. Them Khach Hang Nuoc Ngoai");
                Console.WriteLine("\t\t|3. Hien Thi Danh Sach Khach Hang");
                Console.WriteLine("\t\t|4. Xem Tong (KW)cua cac KH");
                Console.WriteLine("\t\t|5. Xem TB Thanh Tien cua KH NN");
                Console.WriteLine("\t\t----------------------------------");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                switch (x) {
                    case 1:
                        lkh.ThemKH(1);
                        break;
                    case 2:
                        lkh.ThemKH(2);
                        break;
                    case 3:
                        lkh.HienThiKH();
                        break;
                    case 4:
                        lkh.TongSL();
                        break;
                    case 5:
                        lkh.TrungBinh();
                        break;
                }
            } while (x != 0);
            Console.WriteLine(" ");
        }
    }



}