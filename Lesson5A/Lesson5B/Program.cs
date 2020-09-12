using System;
using System.Collections.Generic;

namespace Lesson5B
{
    public enum LoaiDongVat
    {
        CoVu, KhongCoVu
    }

    public class DongVat
    {
        private string _ten;
        private double _chieuCao;
        private double _canNang;
        private string _mauLong;
        private LoaiDongVat _loaiDongVat;

        public string Ten { get => _ten; set => _ten = value; }
        public double ChieuCao { get => _chieuCao; set => _chieuCao = value; }
        public double CanNang { get => _canNang; set => _canNang = value; }
        public string MauLong { get => _mauLong; set => _mauLong = value; }
        public LoaiDongVat LoaiDongVat { get => _loaiDongVat; set => _loaiDongVat = value; }


        public DongVat()
        {
            _ten = "Khong xac dinh!";
            _chieuCao = 1;
            _canNang = 20;
            _mauLong = "Den";
            _loaiDongVat = LoaiDongVat.KhongCoVu;
        }

        public void NhapDuLieu()
        {
            Console.Write("Ten: ");
            _ten = Console.ReadLine();

            Console.Write("Chieu Cao: ");
            _chieuCao = double.Parse(Console.ReadLine());

            Console.Write("Can Nang: ");
            _canNang = double.Parse(Console.ReadLine());

            Console.Write("Mau Long: ");
            _mauLong = Console.ReadLine();

            Console.Write("Loai Dong Vat: ");
            _loaiDongVat = (LoaiDongVat)int.Parse(Console.ReadLine());
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            

            List<DongVat> dongVats = new List<DongVat>();

            DongVat dongVatSo1 = new DongVat();


            dongVats.Add(dongVatSo1);
            dongVats.Add(dongVatSo1);
            dongVats.Add(dongVatSo1);
            dongVats.Add(dongVatSo1);
            dongVats.Add(dongVatSo1);

            DongVat dongVatSo2 = new DongVat();
            dongVatSo2.Ten = "PHONG";
            dongVatSo2.ChieuCao = 1.75;
            dongVatSo2.CanNang = 54;

            dongVats.Add(dongVatSo2);


            //for (int i = 0; i < dongVats.Count; i = i + 2)
            //{
            //    Console.WriteLine(dongVats[i].Ten);
            //}

            foreach (DongVat dongVat in dongVats)
            {
                Console.WriteLine(dongVat.Ten);
            }


        }
    }
}
