using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_NguyenThanhDo
{
    class student
    {
        private int SID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;
        public student()
        {
            SID = 1;
            TenSV = "Nguyen Van Nam";
            Khoa = "CNTT";
            DiemTB = 8;
        }
        public student(student stu)
        {
            SID = stu.SID;
            TenSV = stu.TenSV;
            Khoa = stu.Khoa;
            DiemTB = stu.DiemTB;
        }
        public student(int id, string ten, string kh, float dtb)
        {
            SID = id;
            TenSV = ten;
            Khoa = kh;
            DiemTB = dtb;
        }

        public int StudentID
        {
            get
            {
                return SID;
            }

            set
            {
                SID = value;
            }
        }

        public string Name
        {
            get
            {
                return TenSV;
            }

            set
            {
                TenSV = value;
            }
        }

        public string Faculty
        {
            get
            {
                return Khoa;
            }

            set
            {
                Khoa = value;
            }
        }

        public float Mark
        {
            get
            {
                return DiemTB;
            }

            set
            {
                DiemTB = value;
            }
        }
        public void Nhap1SV()
        {
            Console.Write("Nhap MaSV {0}:");
            StudentID = int.Parse(Console.ReadLine());
            Console.Write("Ho ten SV:");
            Name = Console.ReadLine();
            Console.Write("Nhap Khoa:");
            Faculty = Console.ReadLine();
            Console.Write("Nhap Diem TB:");
            Mark = float.Parse(Console.ReadLine());
        }
        public static student[] NhapDanhSachSV()
        {
            student[] DSSV;
            int n;
            Console.Write("Nhap so luong SV: ");
            n = int.Parse(Console.ReadLine());
            DSSV = new student[n];
            Console.WriteLine("\n===NHAP DS SINH VIEN===");
            for (int i = 0; i < n; i++)
            {
                DSSV[i] = new student();
                Console.WriteLine("Nhap sinh vien thu {0}", i + 1);
                DSSV[i].Nhap1SV();
            }
            return DSSV;
        }
        public static void XuatDanhSachSV(student[] DSSV)
        {
            Console.WriteLine("\n ===XUAT DS SINH VIEN===");
            foreach (student sv in DSSV)
                sv.Show();
            Console.ReadLine();
        }
        public void Show()
        {
            Console.WriteLine("MSSV:{0}", this.SID);
            Console.WriteLine("Ten SV:{0}", this.TenSV);
            Console.WriteLine("Khoa:{0}", this.Khoa);
            Console.WriteLine("Diem TB:{0}", this.DiemTB);
        }


    }
    class tester
    {
        public static void Main()
        {
            
            student.XuatDanhSachSV(student.NhapDanhSachSV());
        }

    }
}
