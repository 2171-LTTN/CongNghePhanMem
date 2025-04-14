using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCNPM.Helpers
{
    public class LoginHistoryLogger
    {
        private string _connectionString;
        public LoginHistoryLogger(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void LogLoginHistory(string username, DateTime thoiGianDangNhap, string diaChiIP)
        {
            string query = "INSERT INTO LichSuDangNhap (username, thoiGianDangNhap, thoiGianDangXuat, diaChiIP) " +
                           "VALUES (@username, @thoiGianDangNhap, @thoiGianDangXuat, @diaChiIP)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@thoiGianDangNhap", thoiGianDangNhap);
                command.Parameters.AddWithValue("@thoiGianDangXuat", DBNull.Value);
                command.Parameters.AddWithValue("@diaChiIP", diaChiIP);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error logging login history: " + ex.Message);
                }
            }
        }
    }
}
