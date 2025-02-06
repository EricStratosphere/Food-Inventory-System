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
using Microsoft.VisualBasic.ApplicationServices;

namespace Food_Inventory_System.Inventory
{
    public partial class InventoryUI : UserControl
    {
        private ManageDatabase db;
        private List<Food> foods;
        private Form form;
        public InventoryUI()
        {
            this.db = new ManageDatabase();
            this.form = form;
            this.foods = new List<Food>();
            InitializeComponent();
            this.foods = db.GetAllFoods();
            RefreshTable(foods);

        }

        private void InventoryUI_Load(object sender, EventArgs e)
        {

        }

        public void RefreshTable(List<Food> foods, int n = 60)
        {
            // Reset Textboxes
          //  userTypeCB.Text = viewCountCB.Text = "";

            // Reset Table
            if (foodTableView.Columns.Contains("Action"))
            {
                foodTableView.Columns["Action"].Visible = false;
                foodTableView.Columns.Remove("Action");
            }
            foodTableView.DataSource = null;
            List<Food> u2 = foods;
            if (n == 60)
                u2 = foods.GetRange(0, foods.Count);
            else
                u2 = foods.GetRange(0, n);

            // Set up Table Style
            foodTableView.DataSource = u2;
            foodTableView.DefaultCellStyle.Font = new Font("Century Gothic", 12);
            foodTableView.DefaultCellStyle.ForeColor = Color.Black;
            foodTableView.AllowUserToResizeRows = false;
            foodTableView.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            foodTableView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(40, 167, 69);
            foodTableView.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            foodTableView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foodTableView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foodTableView.RowTemplate.Height = 40;
            foodTableView.Columns["FoodID"].Visible = false;
            foodTableView.Columns[0].Visible = false;


            // Add Action Column
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.Items.AddRange("Update", "View", "Delete");
            comboBoxColumn.Name = "Action";
            comboBoxColumn.HeaderText = "Action";
            comboBoxColumn.ValueType = typeof(String);
            foodTableView.Columns.Add(comboBoxColumn);
            foodTableView.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(foodTableView_EditingControlShowing);


            // Set up Column Header
           
            foodTableView.Columns["FoodName"].HeaderText = "Name";
            foodTableView.Columns["Quantity"].HeaderText = "Quantity";
            foodTableView.Columns["Category"].HeaderText = "Category";
            foodTableView.Columns["ExpiryDate"].HeaderText = "Expiration";
            foodTableView.Columns["StorageLocation"].HeaderText = "Storage";
            foodTableView.Columns["Status"].HeaderText = "Status";
        }

        private void foodTableView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox combo = e.Control as ComboBox;
            if (combo != null)
            {
                combo.SelectedIndexChanged -= new EventHandler(ComboBoxAction_SelectedIndexChanged);
                combo.SelectedIndexChanged += new EventHandler(ComboBoxAction_SelectedIndexChanged);
            }
        }

        private void ComboBoxAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedItem != null)
            {
                int i = foodTableView.CurrentRow.Index;
                if (cb.SelectedItem.ToString() == "Update")
                {
                   /* UpdateForm update = new UpdateForm();
                    SetFormLocation(update);
                    update.SetInformation(users, i);
                    update.Owner = form;
                    update.Show();*/
                }
                else if (cb.SelectedItem.ToString() == "View")
                {
                    ViewFood viewFood = new ViewFood();
                    SetFormLocation(viewFood);
                    viewFood.SetInformation(foods, i);
                    viewFood.Owner = form;
                    viewFood.Show();
                    /* ViewForm viewForm = new ViewForm();
                     SetFormLocation(viewForm);
                     viewForm.SetInformation(users, i);
                     viewForm.Owner = form;
                     viewForm.Show();*/
                }
                else if (cb.SelectedItem.ToString() == "Delete")
                {
                    /*DialogResult result = MessageBox.Show("Do you want to delete " + users[i].FirstName + " " + users[i].LastName + "" +
                        "'s Information?\nThis action is irreversible.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show(users[i].FirstName + " " + users[i].LastName + "'s information was sucesfully deleted.", "Sucessfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.DeleteUser(users[i].UserId);
                        RefreshTable(users);
                        refreshButtton_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Deletion was cancelled", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }*/
                }
               
            }

        }
        private void SetFormLocation(Form form)
        {
            form.StartPosition = FormStartPosition.Manual;
            int x = Screen.PrimaryScreen.Bounds.Width - form.Width - Convert.ToInt32(10 * 96 / 2.54);
            int y = ((Screen.PrimaryScreen.Bounds.Height - form.Height) / 2);
            form.Location = new Point(x, y);
        }

      

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            AddFood addFood = new AddFood(this);
            SetFormLocation(addFood);
            addFood.Owner = form;
            addFood.Show();

        }

        public void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text = "";
            this.foods = db.GetAllFoods();
            RefreshTable(foods);
        }
    }
}
