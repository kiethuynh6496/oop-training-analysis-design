using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HK2_page50
{
    class VeTungPhan : Ve
    {
        public override void nhapVe()
        {
            base.nhapVe();
            Console.WriteLine("So tro choi tham du: ");
            this.soTroChoiThamDu = Convert.ToInt32(Console.ReadLine());
            this.giaVe = tinhGiaVe();
            Console.WriteLine($"Loai ve: {loaiVe()}");
            Console.WriteLine("Gia ve: {0}", giaVe);
        }

        //public override void xuatVe()
        //{
        //    base.xuatVe();
        //    Console.WriteLine($"So tro choi tham du: {this.soTroChoiThamDu}");
        //}

        public override int tinhGiaVe()
        {
            this.giaVe = 70000 + this.soTroChoiThamDu * 20000;
            return this.giaVe;
        }

        public override int loaiVe()
        {
            this.loai = 2;
            return this.loai;
        }
    }
}
