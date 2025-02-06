using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Food_Inventory_System.Classes
{
    public class ManageDatabase
    {
        public List<Food> Foods { get; private set; }
        public User User { get; private set; }

        private string server = "localhost";
        private string uid = "root";
        private string pwd = "Laurente1234.";
        private string con;

        public ManageDatabase()
        {
            string uid = "root";
            string pwd = "stratosphere123";
            con = $"server=localhost;port=3306;uid={uid};pwd={pwd}";
            Foods = new List<Food>();
        }

        public List<Food> GetAllFoods()
        {
            Foods.Clear();
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.user", connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Foods.Add(new Food(
                                (string)reader["FoodID"],
                                (string)reader["FoodName"],
                                (string)reader["Quantity"],
                                (Category)Enum.Parse(typeof(Category), reader["Category"].ToString()),
                                (DateTime)reader["ExpiryDate"],
                                (StorageLocation)Enum.Parse(typeof(StorageLocation), reader["StorageLocation"].ToString()),
                                (Status)Enum.Parse(typeof(Status), reader["Status"].ToString())
                            ));
                            }
                        }
                    }
                    return Foods;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while retrieving users: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return Foods;

        }

    }
}
