using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Food_Inventory_System.Classes;

namespace Food_Inventory_System.Inventory
{
    public partial class ViewFood : Form
    {
        private ManageDatabase db;
        public ViewFood()
        {
            InitializeComponent();
            this.db = new ManageDatabase();

        }
        public void SetInformation(List<Food> foods, int index)
        {
            Food food = foods[index];

            label8.Text = food.FoodName;
            label9.Text = food.Quantity.ToString();
            label10.Text = food.Category.ToString();
            label11.Text = food.ExpiryDate.ToString();
            label12.Text = food.StorageLocation.ToString();
            label13.Text = food.Status.ToString();


        }
    }
}
