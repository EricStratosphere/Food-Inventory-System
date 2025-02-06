namespace Food_Inventory_System
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.leftPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.tipsButton = new Guna.UI2.WinForms.Guna2Button();
            this.inventoryButton = new Guna.UI2.WinForms.Guna2Button();
            this.dashboardButton = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.logOut = new Guna.UI2.WinForms.Guna2Button();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.White;
            this.leftPanel.Controls.Add(this.logOut);
            this.leftPanel.Controls.Add(this.guna2PictureBox1);
            this.leftPanel.Controls.Add(this.tipsButton);
            this.leftPanel.Controls.Add(this.inventoryButton);
            this.leftPanel.Controls.Add(this.dashboardButton);
            this.leftPanel.Controls.Add(this.label1);
            this.leftPanel.Controls.Add(this.pictureBox1);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.ShadowDecoration.Parent = this.leftPanel;
            this.leftPanel.Size = new System.Drawing.Size(238, 1033);
            this.leftPanel.TabIndex = 0;
            // 
            // tipsButton
            // 
            this.tipsButton.CheckedState.BorderColor = System.Drawing.Color.Aqua;
            this.tipsButton.CheckedState.Parent = this.tipsButton;
            this.tipsButton.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.tipsButton.CustomImages.Parent = this.tipsButton;
            this.tipsButton.FillColor = System.Drawing.Color.White;
            this.tipsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipsButton.ForeColor = System.Drawing.Color.Black;
            this.tipsButton.HoverState.FillColor = System.Drawing.Color.PaleTurquoise;
            this.tipsButton.HoverState.Parent = this.tipsButton;
            this.tipsButton.Image = ((System.Drawing.Image)(resources.GetObject("tipsButton.Image")));
            this.tipsButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tipsButton.ImageOffset = new System.Drawing.Point(20, 0);
            this.tipsButton.Location = new System.Drawing.Point(0, 331);
            this.tipsButton.Name = "tipsButton";
            this.tipsButton.ShadowDecoration.Parent = this.tipsButton;
            this.tipsButton.Size = new System.Drawing.Size(238, 65);
            this.tipsButton.TabIndex = 5;
            this.tipsButton.Text = "Tips";
            this.tipsButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tipsButton.TextOffset = new System.Drawing.Point(30, 0);
            this.tipsButton.Click += new System.EventHandler(this.tipsButton_Click);
            // 
            // inventoryButton
            // 
            this.inventoryButton.CheckedState.BorderColor = System.Drawing.Color.Aqua;
            this.inventoryButton.CheckedState.Parent = this.inventoryButton;
            this.inventoryButton.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.inventoryButton.CustomImages.Parent = this.inventoryButton;
            this.inventoryButton.FillColor = System.Drawing.Color.White;
            this.inventoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryButton.ForeColor = System.Drawing.Color.Black;
            this.inventoryButton.HoverState.FillColor = System.Drawing.Color.PaleTurquoise;
            this.inventoryButton.HoverState.Parent = this.inventoryButton;
            this.inventoryButton.Image = ((System.Drawing.Image)(resources.GetObject("inventoryButton.Image")));
            this.inventoryButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.inventoryButton.ImageOffset = new System.Drawing.Point(20, 0);
            this.inventoryButton.Location = new System.Drawing.Point(0, 267);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.ShadowDecoration.Parent = this.inventoryButton;
            this.inventoryButton.Size = new System.Drawing.Size(238, 65);
            this.inventoryButton.TabIndex = 4;
            this.inventoryButton.Text = "Inventory";
            this.inventoryButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.inventoryButton.TextOffset = new System.Drawing.Point(30, 0);
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.CheckedState.BorderColor = System.Drawing.Color.Aqua;
            this.dashboardButton.CheckedState.Parent = this.dashboardButton;
            this.dashboardButton.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.dashboardButton.CustomImages.Parent = this.dashboardButton;
            this.dashboardButton.FillColor = System.Drawing.Color.White;
            this.dashboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.ForeColor = System.Drawing.Color.Black;
            this.dashboardButton.HoverState.FillColor = System.Drawing.Color.PaleTurquoise;
            this.dashboardButton.HoverState.Parent = this.dashboardButton;
            this.dashboardButton.Image = ((System.Drawing.Image)(resources.GetObject("dashboardButton.Image")));
            this.dashboardButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dashboardButton.ImageOffset = new System.Drawing.Point(20, 0);
            this.dashboardButton.Location = new System.Drawing.Point(0, 201);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.ShadowDecoration.Parent = this.dashboardButton;
            this.dashboardButton.Size = new System.Drawing.Size(238, 65);
            this.dashboardButton.TabIndex = 2;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dashboardButton.TextOffset = new System.Drawing.Point(30, 0);
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "User123";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanel.Location = new System.Drawing.Point(238, 56);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1664, 977);
            this.mainPanel.TabIndex = 2;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.CustomIconSize = 20F;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1567, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(44, 39);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Food Inventory System - Save and Savor";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(238, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1664, 56);
            this.guna2Panel2.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.CustomIconSize = 20F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1620, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(44, 39);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(56, 448);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(128, 279);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // logOut
            // 
            this.logOut.BorderRadius = 10;
            this.logOut.CheckedState.Parent = this.logOut;
            this.logOut.CustomImages.Parent = this.logOut;
            this.logOut.FillColor = System.Drawing.Color.DarkCyan;
            this.logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.ForeColor = System.Drawing.Color.White;
            this.logOut.HoverState.Parent = this.logOut;
            this.logOut.Image = ((System.Drawing.Image)(resources.GetObject("logOut.Image")));
            this.logOut.Location = new System.Drawing.Point(25, 786);
            this.logOut.Name = "logOut";
            this.logOut.ShadowDecoration.Parent = this.logOut;
            this.logOut.Size = new System.Drawing.Size(203, 55);
            this.logOut.TabIndex = 0;
            this.logOut.Text = "Log Out";
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel leftPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button dashboardButton;
        private Guna.UI2.WinForms.Guna2Button inventoryButton;
        private Guna.UI2.WinForms.Guna2Button tipsButton;
        private System.Windows.Forms.Panel mainPanel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button logOut;
    }
}

