using System;

namespace Lesson7A.Models
{
    public class PhanSo
    {
        private int _tuSo;
        private int _mauSo;

        public int TuSo { get => _tuSo; set => _tuSo = value; }
        public int MauSo { get => _mauSo; set => _mauSo = value; }

        // Hàm khởi tạo
        public PhanSo()
        {
            _tuSo = 1;
            _mauSo = 1;
        }

        public PhanSo(int tuSo, int mauSo)
        {
            // _mauSo = (0 != mauSo)?mauSo:1;
            if (0 == mauSo)
            {
                do
                {
                    Console.WriteLine("Phải nhập mẫu số khác 0: ");
                    _mauSo = int.Parse(Console.ReadLine());
                } while (0 == _mauSo);
            }
            else
            {
                _mauSo = mauSo;
            }
            _tuSo = tuSo;

        }


        public PhanSo(int tuSo, float mauSo)
        {
            _tuSo = tuSo;
            _mauSo = int.Parse(mauSo.ToString());
        }

        public void NhapPhanSo()
        {
            Console.Write("Nhập tử số: ");
            _tuSo = int.Parse(Console.ReadLine());

            Console.Write("Nhập mẫu số: ");
            _mauSo = int.Parse(Console.ReadLine());
        }

        public void XuatPhanSo()
        {
            Console.WriteLine("Phân số: " + _tuSo +"/" + _mauSo);
        }

        public PhanSo CongPhanSo(PhanSo phanSoThuNhat, PhanSo phanSoThuHai)
        {
            PhanSo phanSoKetQua = new PhanSo();
            
            // Đoạn xử lý - Quy đồng cả tử và mẫu

            int mauSoChung = phanSoThuNhat.MauSo * phanSoThuHai.MauSo;

            int tuSoThuNhat = phanSoThuNhat.TuSo * phanSoThuHai.MauSo;

            int tuSoThuHai = phanSoThuHai.TuSo * phanSoThuNhat.MauSo;

            // Gắn giá trị vào kết quả
            phanSoKetQua.TuSo = tuSoThuNhat + tuSoThuHai;
            phanSoKetQua.MauSo = mauSoChung;

            return phanSoKetQua;
        }

        public PhanSo RutGon(PhanSo phanSo)
        {
            int uocChungLonNhat = UCLN(phanSo.TuSo, phanSo.MauSo);
            PhanSo ketQua = new PhanSo();

            ketQua.TuSo = phanSo.TuSo / uocChungLonNhat;
            ketQua.MauSo = phanSo.MauSo / uocChungLonNhat;

            return ketQua;
        }

        public int UCLN(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }

            return a; // or return b; a = b
        }
    }
}
