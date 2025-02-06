using Food_Inventory_System.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Inventory_System.Inventory
{
    public partial class AddFood : Form
    {
        private ManageDatabase db;
        private InventoryUI foodTab;
        public AddFood(InventoryUI foodTab)
        {
            this.foodTab = foodTab;
            InitializeComponent();
            this.db = new ManageDatabase();
            datePickerVal.MinDate = DateTime.Today;

            categoryVal.Items.Clear(); 
            foreach (var category in Enum.GetValues(typeof(Category)))
            {
                categoryVal.Items.Add(category.ToString());
            }

            storageLocVal.Items.Clear();
            foreach(var locc in Enum.GetValues(typeof(StorageLocation)))
            {
                storageLocVal.Items.Add(locc.ToString());
            }

            foodStatusVal.Items.Clear();
            foreach (var st in Enum.GetValues(typeof(Status)))
            {
                foodStatusVal.Items.Add(st.ToString());
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addFoodBtn_Click(object sender, EventArgs e)
        {
            GenerateID generate = new GenerateID();
            string foodID = generate.GenID();
            Food newFood = new Food(
            foodID,  
            foodNameVal.Text,  
            int.Parse(quantityVal.Text), 
            (Category)Enum.Parse(typeof(Category), categoryVal.SelectedItem.ToString()),  
            DateTime.Parse(datePickerVal.Text),  
            (StorageLocation)Enum.Parse(typeof(StorageLocation), storageLocVal.SelectedItem.ToString()),  
            (Status)Enum.Parse(typeof(Status), foodStatusVal.SelectedItem.ToString())  
            );

            string message = "Add " + newFood.FoodName + "'s Information?";
            string title = "Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            if (MessageBox.Show(message, title, buttons, MessageBoxIcon.Question) == DialogResult.Yes && db.addFood(newFood))
            {
                
                MessageBox.Show("Sucesfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foodTab.guna2PictureBox1_Click(sender, e);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Cancelled!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foodTab.guna2PictureBox1_Click(sender, e);
                this.Dispose();
            }
        }
    }
}
