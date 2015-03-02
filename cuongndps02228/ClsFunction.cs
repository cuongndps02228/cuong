using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuongndps02228
{
    class ClsFunction
    {
          public static DataTable DLDN(string username, string password)
        {
            string query = "select * from Login Where Taikhoan = '" + username + "' and Matkhau ='" + password + "'";
            DataTable dt = SQLConnection.executeQuery(query);
            return dt;
        }

        public static void themnhanvien(string MaNV, string TenNV, string Diachi, string SDT, string Gioitinh, string Chucvu)
        {
            string strQuery = "set dateformat dmy insert into Nhanvien(MaNV, TenNV, Diachi, SDT, Gioitinh, MaCV) values('" + MaNV + "',N'" + TenNV + "',N'" + Diachi + "','" + SDT + "',N'" + Gioitinh + "',N'" + Chucvu + "')";
            SQLConnection.executeNonquery(strQuery);
        }
        public static DataTable loadnhanvien()
        {
            string strQuery = "Select * from Nhanvien";
            DataTable dt = SQLConnection.executeQuery(strQuery);
            return dt;
        }
        public static DataTable loadchucvu()
        {
            string strQuery = "Select * from Chucvu";
            DataTable dt = SQLConnection.executeQuery(strQuery);
            return dt;
        }
        public static string laychucvu(string machucvu)
        {
            string strQuery = "Select TenCV from Chucvu where MaCV='" + machucvu+"'";
            DataTable dt = SQLConnection.executeQuery(strQuery);
            return dt.Rows[0].ItemArray[0].ToString();
        }
        
        public static void sua(string MaNV, string TenNV, string Diachi, string SDT, string Gioitinh, string Chucvu)
        {
            string strQuery = "set dateformat dmy Update Nhanvien set MaNV = '" + MaNV + "',TenNV = N'" + TenNV + "', Diachi = N'" + Diachi + "', SDT = N'" + SDT + "', Gioitinh = N'" + Gioitinh + "', MaCV = '" + Chucvu + "' where MaNV = '" + MaNV + "'";
            SQLConnection.executeNonquery(strQuery);

        }
        public static void xoa(string manv)
        {
            string strQuery = "delete from Nhanvien where MaNV = '" + manv + "'";
            SQLConnection.executeNonquery(strQuery);
        }
        public static void themkhachhang(string makh, string tenkh, string diachi, string sdt)
        {
            string strQuery = "set dateformat dmy insert into Khachhang(MaKH, TenKH, Diachi_Kh, SDT_Kh) values('" + makh + "',N'" + tenkh + "',N'" + diachi + "','" + sdt + "')";
            SQLConnection.executeNonquery(strQuery);

        }

        public static DataTable loadkhachhang()
        {
            string strQuery = "Select * from Khachhang";
            DataTable dt = SQLConnection.executeQuery(strQuery);
            return dt;
        }
        public static void suakh(string Makh, string Tenkh, string Diachi, string SDT)
        {
            string strQuery = "set dateformat dmy Update Khachhang set MaKH = '" + Makh + "',TenKH = N'" + Tenkh + "', Diachi_Kh = N'" + Diachi + "', SDT_Kh = '" + SDT + "' where MaKH = '" + Makh + "'";
            SQLConnection.executeNonquery(strQuery);

        }
        public static void xoakh(string Makh)
        {
            string strQuery = "delete from Khachhang where MaKH = '" + Makh + "'";
            SQLConnection.executeNonquery(strQuery);
        }



        public static string layMaSP(string maSP)
        {
            string strQuery = "Select MaMH from Mathang where MaMH='" + maSP + "'";
            DataTable dt = SQLConnection.executeQuery(strQuery);
            return dt.Rows[0].ItemArray[0].ToString();
        }
        public static DataTable loadsanpham()
        {
            string strQuery = "Select * from Mathang";
            DataTable dt = SQLConnection.executeQuery(strQuery);
            return dt;
        }       
        public static DataTable loadphanloai()
        {
            string strQuery = "Select * from Phanloai";
            DataTable dt = SQLConnection.executeQuery(strQuery);
            return dt;
        }
        public static string layphanloai(string maloai)
        {
            string strQuery = "Select Tenloai from Phanloai where Maloai='" + maloai + "'";
            DataTable dt = SQLConnection.executeQuery(strQuery);
            return dt.Rows[0].ItemArray[0].ToString();
        }
        public static DataTable loadkho()
        {
            string strQuery = "Select * from Khohang";
            DataTable dt = SQLConnection.executeQuery(strQuery);
            return dt;
        }
        public static DataTable loadchamcong()
        {
            string strQuery = "Select * from Chamcong";
            DataTable dt = SQLConnection.executeQuery(strQuery);
            return dt;
        }
        public static DataTable loadhoadon()
        {
            string strQuery = "Select * from Hoadon";
            DataTable dt = SQLConnection.executeQuery(strQuery);
            return dt;
        }
        public static DataTable loadCT()
        {
            string strQuery = "Select * from CT_Hoadon";
            DataTable dt = SQLConnection.executeQuery(strQuery);
            return dt;
        }


        public static DataTable TimTheoHoTen(string Hoten)
        {
            string strQuery = "Select * from Nhanvien where TenNV like N'%" + Hoten + "%'";
            DataTable dt = SQLConnection.executeQuery(strQuery);

            return dt;
        }
        public static DataTable TimTheotenkh(string Hoten)
        {
            string strQuery = "Select * from Khachhang where TenKH like N'%" + Hoten + "%'";
            DataTable dt = SQLConnection.executeQuery(strQuery);

            return dt;
        }
        public static DataTable TimTheotenSP(string Hoten)
        {
            string strQuery = "Select * from Mathang where TenMH like N'%" + Hoten + "%'";
            DataTable dt = SQLConnection.executeQuery(strQuery);

            return dt;
        }
    }
    }

