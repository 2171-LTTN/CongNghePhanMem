using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectCNPM.Helpers
{
    public class Logger
    {
        private string _connectionString;
        public Logger(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void LogActivity(string username, string hanhDong, string doiTuong, string maDoiTuong, string ghiChu)
        {
            string query = "INSERT INTO LichSuHoatDong (username, thoiGian, hanhDong, doiTuong, maDoiTuong, ghiChu) " +
                           "VALUES (@username, @thoiGian, @hanhDong, @doiTuong, @maDoiTuong, @ghiChu)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@thoiGian", DateTime.Now);
                command.Parameters.AddWithValue("@hanhDong", hanhDong);
                command.Parameters.AddWithValue("@doiTuong", doiTuong);
                command.Parameters.AddWithValue("@maDoiTuong", maDoiTuong);
                command.Parameters.AddWithValue("@ghiChu", ghiChu);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error logging activity: " + ex.Message);
                }
            }
        }
    }
}
