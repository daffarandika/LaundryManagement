using Laundry_Management.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry_Management
{
    internal class Helper
    {
        public static string hash(string input)
        {
            using (var sha256 = SHA256Managed.Create())
            {
                byte[] res = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));
                StringBuilder sb = new StringBuilder(); 
                foreach (byte b in res)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
        
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(Vars.connectionString);
        }

        public static bool CheckRow(string sql)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                return sdr.HasRows;
            }
        }
        public static DataTable GetDataTable(string query)
        {
            using (var conn = GetConnection())
            {
                DataTable dt = new DataTable();
                conn.Open();
                SqlCommand sql = conn.CreateCommand();
                sql.CommandText = query;
                SqlDataAdapter adapter = new SqlDataAdapter(sql);
                adapter.Fill(dt);
                return dt;
            }
        }

        public static DataTable MakeDataTable(string[] columns)
        {
            DataTable dt = new DataTable();
            foreach (var col in columns)
            {
                dt.Columns.Add(col);
            }
            return dt;
        }

        public static void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void RunQuery(string query)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
        }
        public static string GetValueFromQuery(string query, string value)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                return reader[value].ToString();
            }
        }

    }
}
