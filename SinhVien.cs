using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test008
{
    public class SinhVien:HocSinh
    {
      
       public override void NhapHS()
        {
            base.NhapHS();
        }
        
        public override void XuatHS()
        {
            base.XuatHS();
        }
        public override double TinhDTB()
        {
            return base.TinhDTB();
        }     
    }
}
