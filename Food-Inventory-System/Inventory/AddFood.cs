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
            guna2ComboBox1.Items.Clear(); 
            foreach (var category in Enum.GetValues(typeof(Category)))
            {
                guna2ComboBox1.Items.Add(category.ToString());
            }

            guna2ComboBox2.Items.Clear();
            foreach(var locc in Enum.GetValues(typeof(StorageLocation)))
            {
                guna2ComboBox2.Items.Add(locc.ToString());
            }

            guna2ComboBox3.Items.Clear();
            foreach (var st in Enum.GetValues(typeof(Status)))
            {
                guna2ComboBox3.Items.Add(st.ToString());
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            GenerateID generate = new GenerateID();
            string foodID = generate.GenID();
            Food newFood = new Food(
            foodID,  
            guna2TextBox1.Text,  
            int.Parse(guna2TextBox2.Text), 
            (Category)Enum.Parse(typeof(Category), guna2ComboBox1.SelectedItem.ToString()),  
            DateTime.Parse(guna2TextBox3.Text),  
            (StorageLocation)Enum.Parse(typeof(StorageLocation), guna2ComboBox2.SelectedItem.ToString()),  
            (Status)Enum.Parse(typeof(Status), guna2ComboBox3.SelectedItem.ToString())  
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
