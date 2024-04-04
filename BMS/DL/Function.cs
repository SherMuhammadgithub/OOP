using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS.DL
{
    internal class Function
    {
        public static string conStr = @"Server=localhost\SQLEXPRESS02;Database=BMS;Trusted_Connection=True";
        public static SqlConnection Con;
        public static SqlCommand Cmd = new SqlCommand();
        public static SqlDataAdapter sda;
        public static DataTable dt;
        public static DataTable GetData(string query)
        {
            Con = new SqlConnection(conStr);
            try
            {
            sda = new SqlDataAdapter(query, Con);
            dt = new DataTable();
            sda.Fill(dt);
                MessageBox.Show("Data Loaded");
            return dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return null;
          
        }
        public static int SetData(string query)
        {
            Con = new SqlConnection(conStr);
            Cmd.Connection = Con;
            int cnt = 0;
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }
                Cmd.CommandText = query;
                cnt = Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Con != null && Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
            return cnt;
        }

    }
}
