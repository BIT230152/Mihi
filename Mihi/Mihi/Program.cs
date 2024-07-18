using System;
using System.Data.SqlClient;
using System.Text;
namespace Database_Operation
{
    class DBConn
    {
        // Main Method
        static void Main()
        {
            Connect();
            Console.ReadKey();
        }

        static void Connect()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string constr;
            SqlConnection conn;
            constr = @"Data Source=LAPTOP-89KRFKTN\SQLEXPRESS;Initial Catalog=Demodb;User ID=sa;Password=mihi0912";
            conn = new SqlConnection(constr);
            conn.Open();
            Console.WriteLine("Mở kết nối!");
            // Đóng kết nối
            conn.Close();
        }
    }
}