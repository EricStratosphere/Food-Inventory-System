using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public void DeleteFoodItem(string FoodId)
        {
            using (MySqlConnection conn = new MySqlConnection(con))
            {
                conn.Open();
                string query = "DELETE FROM application.food WHERE FoodID = @FoodID";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FoodID", FoodId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        Console.WriteLine("Item deleted successfully.");
                    else
                        Console.WriteLine("No item found with that ID.");
                }
            }
        }

        public bool UpdateFoodItem(String foodID, string foodName, int quantity, Category category, DateTime expiryDate, StorageLocation storageLocation, Status status)
        {

            using (MySqlConnection conn = new MySqlConnection(con))
            {
                conn.Open();
                try
                {
                    string query = "UPDATE application.food SET Name = @Name, Quantity = @Quantity, Category = @Category, ExpiryDate = @ExpiryDate, StorageLocation = @StorageLocation, FoodStatus = @Status WHERE FoodID = @FoodID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", foodName);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@Category", category);
                        cmd.Parameters.AddWithValue("@ExpiryDate", expiryDate);
                        cmd.Parameters.AddWithValue("@StorageLocation", storageLocation);
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@FoodID", foodID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                            return true;
                        else
                            return false;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("There was an error while updating: " + e);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public bool AddFood(Food food)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    string query = "INSERT INTO application.food(FoodID, Name, Quantity, Category, ExpiryDate, Storage Location, Status) VALUES (@FoodID, @Name, @Quantity, @Category, @ExpiryDate, @Storage Location, @Status)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FoodID", food.FoodID);
                        command.Parameters.AddWithValue("@Name", food.FoodName);
                        command.Parameters.AddWithValue("@Quantity", food.Quantity);
                        command.Parameters.AddWithValue("@Category", food.Category);
                        command.Parameters.AddWithValue("@ExpiryDate", food.ExpiryDate);
                        command.Parameters.AddWithValue("@StorageLocation", food.StorageLocation);
                        command.Parameters.AddWithValue("@Status", food.Status);

                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while adding food: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return false;
        }

        public List<Food> FilterByCategory(Category category)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    Food.Clear();
            using (MySqlCommand command = new MySqlCommand("SELECT * FROM application.food WHERE Category = " + category.ToString() + ";", connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Food.Add(new Food((string)reader["FoodID"], (string)reader["Name"], (int)reader["Quantity"], (Category)reader["Category"], (DateTime)reader["ExpiryDate"], (StorageLocation)reader["StorageLocation"], (Status)reader["Status"]));
                            }
                        }
                        return Food;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while filtering by:" + ex.Message);
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public List<Food> FilterByQuantityASC()
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    Food.Clear();
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM application.food ORDER BY Quantity ASC", connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Food.Add(new Food((string)reader["FoodID"], (string)reader["Name"], (int)reader["Quantity"], (Category)reader["Category"], (DateTime)reader["ExpiryDate"], (StorageLocation)reader["StorageLocation"], (Status)reader["Status"]));
                            }
                        }
                        return Food;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while filtering by:" + ex.Message);
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public List<Food> FilterByQuantityDESC()
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    Food.Clear();
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM application.food ORDER BY Quantity DESC", connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Food.Add(new Food((string)reader["FoodID"], (string)reader["Name"], (int)reader["Quantity"], (Category)reader["Category"], (DateTime)reader["ExpiryDate"], (StorageLocation)reader["StorageLocation"], (Status)reader["Status"]));
                            }
                        }
                        return Food;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while filtering by:" + ex.Message);
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}

