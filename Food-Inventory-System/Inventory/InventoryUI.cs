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
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
using Mysqlx.Crud;

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
            categoryList.Items.Clear();
            categoryList.Items.Add("All");
            foreach (var category in Enum.GetValues(typeof(Category)))
            {
                categoryList.Items.Add(category.ToString());
            }

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


           
            foodTableView.Columns["FoodName"].HeaderText = "Name";
            foodTableView.Columns["Quantity"].HeaderText = "Quantity";
            foodTableView.Columns["Category"].HeaderText = "Category";
            foodTableView.Columns["ExpiryDate"].HeaderText = "Expiration";
            foodTableView.Columns["StorageLocation"].HeaderText = "Storage";
            foodTableView.Columns["Status"].HeaderText = "Status";

            foodTableView.Columns["FoodName"].DisplayIndex = 0; // First column
            foodTableView.Columns["Quantity"].DisplayIndex = 1;
            foodTableView.Columns["Category"].DisplayIndex = 2;
            foodTableView.Columns["ExpiryDate"].DisplayIndex = 3;
            foodTableView.Columns["StorageLocation"].DisplayIndex = 4;
            foodTableView.Columns["Status"].DisplayIndex = 5;

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
                    Update update = new Update(this);
                    SetFormLocation(update);
                    update.SetInformation(foods, i);
                    update.Owner = form;
                    update.Show();
                }
                else if (cb.SelectedItem.ToString() == "View")
                {
                    ViewFood viewFood = new ViewFood();
                    SetFormLocation(viewFood);
                    viewFood.SetInformation(foods, i);
                    viewFood.Owner = form;
                    viewFood.Show();
                }
                else if (cb.SelectedItem.ToString() == "Delete")
                {
                    DialogResult result = MessageBox.Show("Do you want to delete " + foods[i].FoodName + "" +
                        "'s Information?\nThis action is irreversible.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show(foods[i].FoodName + "'s information was sucesfully deleted.", "Sucessfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.DeleteFoodItem(foods[i].FoodID);
                        foods = db.GetAllFoods();
                        RefreshTable(foods);
                        guna2PictureBox1_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Deletion was cancelled", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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

      

        private void addFoodBtn2_Click_1(object sender, EventArgs e)
        {
            AddFood addFood = new AddFood(this);
            SetFormLocation(addFood);
            addFood.Owner = form;
            addFood.Show();

        }

        public void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            searchBar.Text = "";
            this.foods = db.GetAllFoods();
            RefreshTable(foods);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            categoryList.Text = "All";
            sortListType.Text = "All";
            String name = searchBar.Text;
            if (string.IsNullOrWhiteSpace(name) || name == "Search...")
            {
                RefreshTable(foods);
                return;
            }
            List<Food> u2 = foods.Select(u => u).ToList();
            foods.Clear();
            foreach (Food u in u2)
            {
                if (u.FoodName.ToLower().Contains(name.ToLower()))
                    foods.Add(u);
            }
            if (foods.Count == 0)
            {
                foods = db.GetAllFoods();
            }
            RefreshTable(foods);
        }

        private void categoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchBar.Text = "Search...";
            sortListType.Text = "All";
            String categoryType = categoryList.SelectedItem.ToString();
            if (categoryType == "All")
            {
                foods = db.GetAllFoods();
                RefreshTable(foods);
            }
            else
            {
                foods = db.GetAllFoods();
                List<Food> u2 = foods.Select(u => u).ToList();

                foods.Clear();
                foreach (Food u in u2)
                {
                    if (u.Category.ToString().Equals(categoryType))
                        foods.Add(u);
                }
                if (foods.Count == 0)
                {
                    MessageBox.Show("No " + categoryType + " was Found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foods = db.GetAllFoods();
                    RefreshTable(foods);
                }
                else
                    RefreshTable(foods);

            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchBar.Text = "Search...";
            categoryList.Text = "All";
            String sortList = sortListType.SelectedItem.ToString();
            if (sortList == "Expiration Date")
            {
                foods = foods.OrderBy(u => u.ExpiryDate).ToList();
            }
            else
            {
                foods = foods.OrderBy(u => u.Quantity).ToList();
            }
            RefreshTable(foods);
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            DGVPrinterHelper.DGVPrinter printer = new DGVPrinterHelper.DGVPrinter();
            printer.FooterFont = new Font("Arial", 8, FontStyle.Bold);
            printer.TitleFont = new Font("Century Gothic", 16, FontStyle.Bold);
            printer.SubTitleFont = new Font("Century Gothic", 10, FontStyle.Regular);
            printer.Title = "Food Inventory List\n";
            printer.SubTitle = string.Format("Date: {0}\n", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitle += string.Format("Time: {0}\n\n", DateTime.Now.ToString("HH:mm:ss"));

            printer.printDocument.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50);
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Mabolo Dormitory System";
            printer.FooterSpacing = 15;
            try
            {
                printer.PrintPreviewDataGridView(foodTableView);
                printer.PrintDataGridView(foodTableView);
            }
            catch
            {
                MessageBox.Show("An error occured while printing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
