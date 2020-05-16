using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore2.Models
{
    public class HinhHoc
    {
        public static string RandomKey()
        {
            return $"NN-{new Random().Next(000000,1000000)}";
        }
        public double Dientich { get; set; }
        public double Chuvi { get; set; }

        public virtual void TinhDienTichChuVi ()
        {

        }
        public override string ToString()
        {
            return $"S={Dientich}, P={Chuvi}";
        }
    }
    public class HinhChuNhat : HinhHoc
    {
        public double Dai { get; set; }
        public double Rong { get; set; }

        public override void TinhDienTichChuVi()
        {
            Dientich = Dai * Rong;
            Chuvi = (Dai + Rong) * 2;
        }
    }
    public class HinhTron : HinhHoc
    {
        public double DuongKinh { get; set; }
        public double BanKinh { get; set; }
        public override void TinhDienTichChuVi()
        {
            Dientich = Math.Pow(BanKinh, 2) * Math.PI;
            Chuvi = 2 * BanKinh * Math.PI;
        }
        public override string ToString()
        {
            return $"R={BanKinh},{base.ToString()}";
        }

       
    }
}
