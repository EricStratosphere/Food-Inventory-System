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

            foodNameVal.Text = food.FoodName;
            quantityVal.Text = food.Quantity.ToString();
            categoryVal.Text = food.Category.ToString();
            expiryVal.Text = food.ExpiryDate.ToString();
            storageLocVal.Text = food.StorageLocation.ToString();
            foodStatusVal.Text = food.Status.ToString();


        }
    }
}
