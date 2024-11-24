using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLTHPT.DAO
{
    internal class KNCSDL
    {
        private static SqlConnection cnn = new SqlConnection();
        public static void Moketnoi()
        {
            string sqlcon = @"";
            cnn.ConnectionString = sqlcon;
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
        }
        public static void Dongketnoi()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }
        public static DataTable Docdulieu(string sql)
        {
            Moketnoi();
            SqlCommand cd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            Dongketnoi();
            return dt;
        }
        public static void Dongdulieu(string sql)
        {
            Moketnoi();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            Dongketnoi();
        }
    }
}
