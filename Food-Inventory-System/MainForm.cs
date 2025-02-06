using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Food_Inventory_System.Dashboard;
using Food_Inventory_System.Inventory;
using Food_Inventory_System.Tips;

namespace Food_Inventory_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DashboardUI dashboard = new DashboardUI();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(dashboard);


            
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            DashboardUI dashboard = new DashboardUI();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(dashboard);
            foreach (Guna2Button btn in leftPanel.Controls.OfType<Guna2Button>())
            {
                btn.Checked = false;
            }
            dashboardButton.Checked = true;
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            InventoryUI inventoryUI = new InventoryUI();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(inventoryUI);
            foreach (Guna2Button btn in leftPanel.Controls.OfType<Guna2Button>())
            {
                btn.Checked = false;
            }
            inventoryButton.Checked = true;
        }

        private void tipsButton_Click(object sender, EventArgs e)
        {
            TipsUI tips = new TipsUI();
            tips.TopLevel = false;
            mainPanel.Controls.Clear();

            mainPanel.Controls.Add(tips);
            tips.Show();

            foreach (Guna2Button btn in leftPanel.Controls.OfType<Guna2Button>())
            {
                btn.Checked = false;
            }
            tipsButton.Checked = true;

        }
    }
}
