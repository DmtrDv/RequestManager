using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestManager
{
    public class SqlRequestManager: IRequestManager
    {
        MySqlConnection conn;

        public BindingList<RequestModel> GetAllRequests()
        {
            BindingList<RequestModel> result = new BindingList<RequestModel>();

            try
            {
                conn = new MySqlConnection(AppSettings.ConnectionString);
                conn.Open();
                const string query = "SELECT Id_Request, Сustomer, RequestDate, 'Condition', Description FROM requests";
                MySqlCommand command = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int Id = reader.GetInt32("Id_Request");

                        RequestModel request = new RequestModel(Id);
                        request.Сustomer = reader.GetString("Сustomer");
                        request.RequestDate = reader.GetDateTime("RequestDate");
                        request.Condition = reader.GetString("Condition");
                        request.Description = reader.GetString("Description");

                        result.Add(request);
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Ошибка при загрузке заявок: " + ex.Message);
            }
            return result;
        }

        public string AddRequest(RequestModel request)
        {
            conn = new MySqlConnection(AppSettings.ConnectionString);

            try
            {
                conn.Open();
                const string query = @"INSERT INTO requests 
                                           (Сustomer, RequestDate, Condition, Description )
                                            VALUES (@Сustomer, @RequestDate, @Condition, @Description )";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Сustomer", request.Сustomer);
                    command.Parameters.AddWithValue("@RequestDate", request.RequestDate);
                    command.Parameters.AddWithValue("@Condition", request.Condition);
                    command.Parameters.AddWithValue("@Description", request.Description);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return "Новая заявка успешно добавлена";
                    }
                    else
                    {
                        return "Ошибка: заявка не была добавлена";
                    }
                }
            }
            catch (MySqlException ex)
            {
                return "Ошибка при добавлении: " + ex.Message;
            }
        }
        public string UpdateRequests(RequestModel request)
        {
            conn = new MySqlConnection(AppSettings.ConnectionString);

            try
            {
                conn.Open();
                const string query = @"UPDATE requests 
                                       SET Сustomer = @Сustomer, RequestDate = @RequestDate, Condition = @Condition, Description = @Description
                                       WHERE Id_Request = @Id_Request";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Сustomer", request.Сustomer);
                    command.Parameters.AddWithValue("@RequestDate", request.RequestDate);
                    command.Parameters.AddWithValue("@Condition", request.Condition);
                    command.Parameters.AddWithValue("@Description", request.Description);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return "Заявка успешно обновлена";
                    }
                    else
                    {
                        return "Ошибка: заявка не обновлена";
                    }
                }
            }
            catch (MySqlException ex)
            {
                return "Ошибка при обновлении: " + ex.Message;
            }
        }
    }
}
