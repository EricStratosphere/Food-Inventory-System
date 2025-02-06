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
        public Update()
        {
            InitializeComponent();
            foreach (var category in Enum.GetValues(typeof(Category)))
            {
                guna2ComboBox1.Items.Add(category.ToString());
            }

            guna2ComboBox2.Items.Clear();
            foreach (var locc in Enum.GetValues(typeof(StorageLocation)))
            {
                guna2ComboBox2.Items.Add(locc.ToString());
            }

            guna2ComboBox3.Items.Clear();
            foreach (var st in Enum.GetValues(typeof(Status)))
            {
                guna2ComboBox3.Items.Add(st.ToString());
            }
        }

        public void SetInformation(List<Food> foods, int index)
        {
            Food fd = foods[index];
            guna2TextBox1.Text = fd.FoodName;
            guna2TextBox2.Text = fd.Quantity.ToString();
            guna2ComboBox1.Text = fd.Category.ToString();
            guna2TextBox3.Text = fd.ExpiryDate.ToString();
            guna2ComboBox2.Text = fd.StorageLocation.ToString();
            guna2ComboBox3.Text = fd.Status.ToString();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Food food = new Food()
        }
    }
}
