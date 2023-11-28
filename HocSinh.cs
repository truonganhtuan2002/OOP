using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test008
{
    public class HocSinh
    {
        //Khai bao thuoc tinh
        private int maHS { get; set; } // nên dùng ntn
        string tenHS { get; set; }
        int ns { get; set; }
        string diaChi { get; set; }
        double diemT, diemV, diemA, DTB;
        // Xay dung ham khoi tao doi tuong Constructor 1
        public HocSinh()
        {
        }
        //Xay dung ham Constructor 2
        public HocSinh(int ma, string ten, int ns, string diaChi)
        {
            this.maHS = maHS;
            this.tenHS = tenHS;
            this.ns = ns;
            this.diaChi = diaChi;
        }

        public virtual void NhapHS()
        {
            Console.Write("Nhap ma HS: ");
            maHS = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap ten hoc sinh: ");
            tenHS = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            ns = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap dia chi: ");
            diaChi = Console.ReadLine();
            Console.Write("Nhap diem toan: ");
            diemT = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem van: ");
            diemV = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem anh: ");
            diemA = Convert.ToDouble(Console.ReadLine());
        }
        // Viet ham tinh diem trung binh
        //NEu viet ham ghi de thi can them tu khoa virtual public virtual sniDouble
 
        public virtual Double TinhDTB()
        {
            DTB = Math.Round((diemA + diemT + diemV) / 3, 1);
            return DTB;
        }
        public virtual void XuatHS()
        {

           // Console.WriteLine("Thong tin sinh vien la: ");
           // Console.WriteLine("Ma HS | Ten HS | Nam Sinh | Dia Chi | DTB");
            Console.WriteLine( "      "+maHS + "      " + tenHS + "      " + ns + "       "+ diaChi + "        "+TinhDTB());
        }
    }
}
