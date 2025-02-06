using Food_Inventory_System.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Inventory_System.Inventory
{
    public partial class Update : Form
    {
        private Food food;
        private InventoryUI foodTab;
        private ManageDatabase db;
        public Update(InventoryUI foodTab)
        {
            this.db = new ManageDatabase();
            InitializeComponent();
            expiryDatePicker.MinDate = DateTime.Today;

            foreach (var category in Enum.GetValues(typeof(Category)))
            {
                categoryName.Items.Add(category.ToString());
            }

            storageLoc.Items.Clear();
            foreach (var locc in Enum.GetValues(typeof(StorageLocation)))
            {
                storageLoc.Items.Add(locc.ToString());
            }

            foodStat.Items.Clear();
            foreach (var st in Enum.GetValues(typeof(Status)))
            {
                foodStat.Items.Add(st.ToString());
            }

            this.foodTab = foodTab;
        }

        public void SetInformation(List<Food> foods, int index)
        {
            food = foods[index];
            Food fd = foods[index];
            foodName.Text = fd.FoodName;
            quantityName.Text = fd.Quantity.ToString();
            categoryName.Text = fd.Category.ToString();
            expiryDatePicker.Text = fd.ExpiryDate.ToString();
            storageLoc.Text = fd.StorageLocation.ToString();
            foodStat.Text = fd.Status.ToString();

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (db.UpdateFoodItem(food.FoodID, foodName.Text,
            int.Parse(quantityName.Text),
            (Category)Enum.Parse(typeof(Category), categoryName.SelectedItem.ToString()),
            DateTime.Parse(expiryDatePicker.Text),
            (StorageLocation)Enum.Parse(typeof(StorageLocation), storageLoc.SelectedItem.ToString()),
            (Status)Enum.Parse(typeof(Status), foodStat.SelectedItem.ToString())
            ))
            {
                MessageBox.Show("Food Item Updated Successfully");
                foodTab.guna2PictureBox1_Click(sender, e);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Failed to Update Food Item");
                foodTab.guna2PictureBox1_Click(sender, e);
                this.Dispose();
            }
        }

    }
}
