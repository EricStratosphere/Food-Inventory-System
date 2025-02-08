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
using System.Net.Mail;
using System.Net;
using Food_Inventory_System.Classes;

namespace Food_Inventory_System
{
    public partial class MainForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private ManageDatabase db;
        public MainForm()
        {
            InitializeComponent();
            this.db = new ManageDatabase();
            DashboardUI dashboard = new DashboardUI();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(dashboard);
            UpdateEmail();
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

        private void UpdateEmail()
        {
            List<Food> foods = db.GetAllFoods();
            foreach(Food food in foods)
            {
                if(food.Status == Status.ExpiringSoon)
                {
                    SendEmailNotification(food.FoodName, food.ExpiryDate);
                }
            }
        }

       

        private void SendEmailNotification(string itemName, DateTime expiryDate)
        {/*
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("johnrhuell@gmail.com"); // Your VSU email
                    mail.To.Add("22-1-00109@vsu.edu.ph"); // Recipient email

                    // Email content
                    mail.Subject = $"[ALERT] {itemName} is Expiring Soon!";
                    mail.Body = $"The item {itemName} will expire on {expiryDate:MMMM dd, yyyy}. Please use it soon!";
                    mail.IsBodyHtml = false; // Change to true if you want to send HTML content

                    // Configure SMTP
                    using (SmtpClient smtpServer = new SmtpClient("smtp.gmail.com", 587)) // Gmail SMTP
                    {
                        smtpServer.Credentials = new NetworkCredential("johnrhuell@gmail.com", "abcd efgh ijkl mnop"); // Use App Password
                        smtpServer.EnableSsl = true; // Secure connection
                        smtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtpServer.UseDefaultCredentials = false;

                        // Send email
                        smtpServer.Send(mail);
                    }
                }

                MessageBox.Show($"✅ Email sent for {itemName} expiring on {expiryDate:MMMM dd, yyyy}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Email sending failed: {ex.Message}");
            }*/
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

        private void logOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
