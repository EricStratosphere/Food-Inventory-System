using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Food_Inventory_System.Classes
{
    public class DatabaseManagement
    {
        public List<Food> Food { get; private set; }
        public User User { get; private set; }

        private string server = "localhost";
        private string uid = "root";
        private string pwd = "stratosphere123";
        private string con;
        public DatabaseManagement()
        {
            string server = "localhost";
            string uid = "root";
            string pwd = "stratosphere123";

            Food = new List<Food>();     
        }

       /* public List<Food> FetchAllFoods()
        {
            this.con = $"server={this.server};port=3306;uid={uid};pwd={pwd};database=food";
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using(MySqlCommand command = new MySqlCommand("SELECT * FROM food"))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                
                            }
                        }
                    }
                }
            }
                return this.Food;
        }*/

        public List<Food> GetAllFoodsByExpDesc()
        {
            Food.Clear();
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM application.food ORDER BY ExpiryDate DESC", connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Food.Add(new Food(
                                (string)reader["FoodID"],
                                (string)reader["FoodName"],
                                (int)reader["Quantity"],
                                (Category)Enum.Parse(typeof(Category), reader["Category"].ToString()),
                                (DateTime)reader["ExpiryDate"],
                                (StorageLocation)Enum.Parse(typeof(StorageLocation), reader["StorageLocation"].ToString()),
                                (Status)Enum.Parse(typeof(Status), reader["Status"].ToString())
                            ));
                            }
                        }
                    }
                    return Food;
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
            return Food;

        }

        public List<Food> GetAllFoodsByExpAsc()
        {
            Food.Clear();
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM application.food ORDER BY ExpiryDate ASC", connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Food.Add(new Food(
                                (string)reader["FoodID"],
                                (string)reader["FoodName"],
                                (int)reader["Quantity"],
                                (Category)Enum.Parse(typeof(Category), reader["Category"].ToString()),
                                (DateTime)reader["ExpiryDate"],
                                (StorageLocation)Enum.Parse(typeof(StorageLocation), reader["StorageLocation"].ToString()),
                                (Status)Enum.Parse(typeof(Status), reader["Status"].ToString())
                            ));
                            }
                        }
                    }
                    return Food;
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
            return Food;

        }
    }
}
