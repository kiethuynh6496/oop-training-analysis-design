using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HK2_page50
{
    class VeTronGoi : Ve
    {
        public override void nhapVe()
        {
            base.nhapVe();
            this.soTroChoiThamDu = 30;
            Console.WriteLine("So tro choi tham du: {0}", soTroChoiThamDu);
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
            this.giaVe = 200000;
            return this.giaVe;
        }

        public override int loaiVe()
        {
            this.loai = 1;
            return this.loai;
        }
    }
}
