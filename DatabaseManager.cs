using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace QuanLyThuVien
{
    public class DatabaseManager : IDisposable
    {
        private MySqlConnection cnn;

        public DatabaseManager()
        {
            string connectionString = "server=free02.123host.vn; Database=otuitleg_book; Uid=otuitleg_book; Pwd=anhtytv123; CharSet=utf8";
            cnn = new MySqlConnection(connectionString);
        }

        public void myconnect()
        {
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                    Console.WriteLine("Kết nối thành công!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi kết nối: " + ex.Message);
            }
        }

        public void myclose()
        {
            try
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                    Console.WriteLine("Đóng kết nối thành công!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi đóng kết nối: " + ex.Message);
            }
        }

        public DataTable taobang(string sql, params MySqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi tạo bảng: " + ex.Message);
            }
            return dt;
        }

        public int ExecuteNonQuery(string query)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thực hiện truy vấn: " + ex.Message);
                return -1;
            }
        }

        public void Dispose()
        {
            myclose();
            if (cnn != null)
            {
                cnn.Dispose();
            }
        }
    }
}
