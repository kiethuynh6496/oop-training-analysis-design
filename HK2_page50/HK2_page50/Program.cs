using System;
using System.Collections.Generic;

namespace HK2_page50
{
    class Program
    {
        static void Main(string[] args)
        {
            int soLuongVe;
            List<Ve> danhSachVe = new List<Ve>();
            Console.WriteLine("Nhap so luong ve: ");
            soLuongVe = Convert.ToInt32(Console.ReadLine());
            int loaiVe;
            Ve tempVe;
            // Cau 1
            for (int i = 0; i < soLuongVe; i++)
            {
                Console.WriteLine("Nhap loai ve: 1: tron goi, 2: tung phan");
                loaiVe = Convert.ToInt32(Console.ReadLine());
                if(loaiVe == 1)
                {
                    tempVe = new VeTronGoi(); 
                }
                else
                {
                    tempVe = new VeTungPhan();
                }
                tempVe.nhapVe();
                danhSachVe.Add(tempVe);
            }
            foreach (var ve in danhSachVe)
            {
                ve.xuatVe();
            }
            // Cau 2
            int tongTienVe = 0;
            foreach (var ve in danhSachVe)
            {
                tongTienVe += ve.tinhGiaVe();
            }
            Console.WriteLine($"Tong tien ve thu duoc: {tongTienVe}");
            // Cau 3
            int soLuongVeTungPhan = 0;
            foreach (var ve in danhSachVe)
            {
                if(ve.loaiVe() == 2)
                {
                    ++soLuongVeTungPhan;
                }
            }
            Console.WriteLine($"So luong ve tung phan: {soLuongVeTungPhan}");
            Console.ReadKey();
        }
    }
}
