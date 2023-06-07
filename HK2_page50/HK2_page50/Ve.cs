using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HK2_page50
{
    abstract class Ve
    {
        protected string maVe;
        protected string hoTenChu;
        protected int namSinh;
        protected int soTroChoiThamDu;
        protected int giaVe;
        protected int loai;

        public virtual void nhapVe()
        {
            Console.WriteLine("Nhap ma ve: ");
            this.maVe = Console.ReadLine();
            Console.WriteLine("Nhap ho ten chu ve: ");
            this.hoTenChu = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh: ");
            this.namSinh = Convert.ToInt32(Console.ReadLine());
        }

        public void xuatVe()
        {
            Console.WriteLine("------Xuat thong tin ve------");
            Console.WriteLine($"Ma ve: {this.maVe}");
            Console.WriteLine($"Ho ten: {this.hoTenChu}");
            Console.WriteLine($"Nam sinh: {this.namSinh}");
            Console.WriteLine($"So tro choi tham du: {this.soTroChoiThamDu}");
            Console.WriteLine($"Loai ve: {this.loaiVe()}");
            Console.WriteLine($"Gia ve: {this.tinhGiaVe()}");
        }

        public abstract int tinhGiaVe();
        public abstract int loaiVe();
    }
}
