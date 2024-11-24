using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTHPT.DAO
{
    internal class NguoiDung
    {
        public static DataTable DangNhap(string tk, string mk)
        {
            string sql = "Select * from NguoiDung where TenDAngNhap='"+tk+"' and MatKhau='"+mk+"'";
            DataTable dt=new DataTable();
            dt=KNCSDL.Docdulieu(sql);
            return dt;
        }
    }
}
