using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyThuVien
{
     class Connection
     {
          private SqlConnection connection;
          private SqlDataAdapter adapter;
          private DataTable data;
          public Connection()
          {
               Connect();
          }

          public void Connect()
          {
               string strConn = System.Configuration.ConfigurationSettings.AppSettings["Main.ConnectionString"];

               try
               {
                    connection = new SqlConnection(strConn);
                    connection.Open();
                    connection.Close();
               }
               catch (Exception ex)
               {
                    MessageBox.Show("Lỗi do kết nối" + ex.Message);
               }
          }
     }
}
