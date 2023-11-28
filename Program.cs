using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test008
{
    public class Program
    {
        static void Main(string[] args)
        {

            //nhap so luong sinh vien

            int n;
            do {
                Console.Write("Nhap so luong sinh vien : "); n = int.Parse(Console.ReadLine());
            } while (n < 0 && n > 5);

            // tao mang sinh vien 
            SinhVien[] sv = new SinhVien[n];
            for (int i = 0; i< n; i++){
                Console.WriteLine("Nhap Thong Tin SV THU " + (i + 1));
                sv[i] = new SinhVien();
                sv[i].NhapHS();
            }
            Console.WriteLine("=========> Danh sach SV <========");
            Console.WriteLine("|  Ma HS  |  Ten HS  |  Nam Sinh   |  Dia Chi  |   DTB   |");
            for (int i = 0; i < n; i++)
            {
                sv[i].XuatHS();
            }
            Console.WriteLine("=========================><===============================");
            Console.WriteLine("=========> Sap xep sinh vien theo diem <========");
            Console.WriteLine("|  Ma HS  |  Ten HS  |  Nam Sinh   |  Dia Chi  |   DTB   |");

            for (int i = 0; i < n; i++)
            {
                for(int j = i+1; j < n                                                                                       ; j++)
                {
                    if (sv[i].TinhDTB() < sv[j].TinhDTB())
                    {
                        SinhVien tg;
                        tg = sv[i];
                        sv[i] = sv[j];
                        sv[j] = tg;
                    }
                }
            }
            for(int i = 0; i < n; i++)
            {
                sv[i].XuatHS();
            }

            Console.WriteLine("=========================><===============================");


            Console.ReadKey();
        }
    }
}
