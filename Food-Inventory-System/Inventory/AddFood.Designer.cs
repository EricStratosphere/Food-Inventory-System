namespace Food_Inventory_System.Inventory
{
    partial class AddFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFood));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.foodNameVal = new Guna.UI2.WinForms.Guna2TextBox();
            this.quantityVal = new Guna.UI2.WinForms.Guna2TextBox();
            this.categoryVal = new Guna.UI2.WinForms.Guna2ComboBox();
            this.storageLocVal = new Guna.UI2.WinForms.Guna2ComboBox();
            this.foodStatusVal = new Guna.UI2.WinForms.Guna2ComboBox();
            this.addFoodBtn = new Guna.UI2.WinForms.Guna2Button();
            this.datePickerVal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(103, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Food Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Storage Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Expiry Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Food\'s Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Add Food\'s Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // foodNameVal
            // 
            this.foodNameVal.BorderRadius = 15;
            this.foodNameVal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.foodNameVal.DefaultText = "";
            this.foodNameVal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.foodNameVal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.foodNameVal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.foodNameVal.DisabledState.Parent = this.foodNameVal;
            this.foodNameVal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.foodNameVal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.foodNameVal.FocusedState.Parent = this.foodNameVal;
            this.foodNameVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodNameVal.ForeColor = System.Drawing.Color.Black;
            this.foodNameVal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.foodNameVal.HoverState.Parent = this.foodNameVal;
            this.foodNameVal.Location = new System.Drawing.Point(102, 120);
            this.foodNameVal.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.foodNameVal.Name = "foodNameVal";
            this.foodNameVal.PasswordChar = '\0';
            this.foodNameVal.PlaceholderText = "";
            this.foodNameVal.SelectedText = "";
            this.foodNameVal.ShadowDecoration.Parent = this.foodNameVal;
            this.foodNameVal.Size = new System.Drawing.Size(334, 40);
            this.foodNameVal.TabIndex = 28;
            this.foodNameVal.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // quantityVal
            // 
            this.quantityVal.BorderRadius = 15;
            this.quantityVal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantityVal.DefaultText = "";
            this.quantityVal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.quantityVal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.quantityVal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantityVal.DisabledState.Parent = this.quantityVal;
            this.quantityVal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantityVal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantityVal.FocusedState.Parent = this.quantityVal;
            this.quantityVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityVal.ForeColor = System.Drawing.Color.Black;
            this.quantityVal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantityVal.HoverState.Parent = this.quantityVal;
            this.quantityVal.Location = new System.Drawing.Point(102, 196);
            this.quantityVal.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.quantityVal.Name = "quantityVal";
            this.quantityVal.PasswordChar = '\0';
            this.quantityVal.PlaceholderText = "";
            this.quantityVal.SelectedText = "";
            this.quantityVal.ShadowDecoration.Parent = this.quantityVal;
            this.quantityVal.Size = new System.Drawing.Size(334, 40);
            this.quantityVal.TabIndex = 29;
            this.quantityVal.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // categoryVal
            // 
            this.categoryVal.BackColor = System.Drawing.Color.Transparent;
            this.categoryVal.BorderRadius = 15;
            this.categoryVal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.categoryVal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryVal.FocusedColor = System.Drawing.Color.Empty;
            this.categoryVal.FocusedState.Parent = this.categoryVal;
            this.categoryVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryVal.ForeColor = System.Drawing.Color.Black;
            this.categoryVal.FormattingEnabled = true;
            this.categoryVal.HoverState.Parent = this.categoryVal;
            this.categoryVal.ItemHeight = 30;
            this.categoryVal.ItemsAppearance.Parent = this.categoryVal;
            this.categoryVal.Location = new System.Drawing.Point(102, 282);
            this.categoryVal.Name = "categoryVal";
            this.categoryVal.ShadowDecoration.Parent = this.categoryVal;
            this.categoryVal.Size = new System.Drawing.Size(334, 36);
            this.categoryVal.TabIndex = 31;
            this.categoryVal.TextOffset = new System.Drawing.Point(10, 0);
            this.categoryVal.SelectedIndexChanged += new System.EventHandler(this.categoryVal_SelectedIndexChanged);
            // 
            // storageLocVal
            // 
            this.storageLocVal.BackColor = System.Drawing.Color.Transparent;
            this.storageLocVal.BorderRadius = 15;
            this.storageLocVal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.storageLocVal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storageLocVal.FocusedColor = System.Drawing.Color.Empty;
            this.storageLocVal.FocusedState.Parent = this.storageLocVal;
            this.storageLocVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storageLocVal.ForeColor = System.Drawing.Color.Black;
            this.storageLocVal.FormattingEnabled = true;
            this.storageLocVal.HoverState.Parent = this.storageLocVal;
            this.storageLocVal.ItemHeight = 30;
            this.storageLocVal.ItemsAppearance.Parent = this.storageLocVal;
            this.storageLocVal.Location = new System.Drawing.Point(102, 367);
            this.storageLocVal.Name = "storageLocVal";
            this.storageLocVal.ShadowDecoration.Parent = this.storageLocVal;
            this.storageLocVal.Size = new System.Drawing.Size(334, 36);
            this.storageLocVal.TabIndex = 32;
            this.storageLocVal.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // foodStatusVal
            // 
            this.foodStatusVal.BackColor = System.Drawing.Color.Transparent;
            this.foodStatusVal.BorderRadius = 15;
            this.foodStatusVal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.foodStatusVal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.foodStatusVal.FocusedColor = System.Drawing.Color.Empty;
            this.foodStatusVal.FocusedState.Parent = this.foodStatusVal;
            this.foodStatusVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodStatusVal.ForeColor = System.Drawing.Color.Black;
            this.foodStatusVal.FormattingEnabled = true;
            this.foodStatusVal.HoverState.Parent = this.foodStatusVal;
            this.foodStatusVal.ItemHeight = 30;
            this.foodStatusVal.ItemsAppearance.Parent = this.foodStatusVal;
            this.foodStatusVal.Location = new System.Drawing.Point(102, 445);
            this.foodStatusVal.Name = "foodStatusVal";
            this.foodStatusVal.ShadowDecoration.Parent = this.foodStatusVal;
            this.foodStatusVal.Size = new System.Drawing.Size(334, 36);
            this.foodStatusVal.TabIndex = 33;
            this.foodStatusVal.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // addFoodBtn
            // 
            this.addFoodBtn.BorderRadius = 12;
            this.addFoodBtn.CheckedState.Parent = this.addFoodBtn;
            this.addFoodBtn.CustomImages.Parent = this.addFoodBtn;
            this.addFoodBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFoodBtn.ForeColor = System.Drawing.Color.White;
            this.addFoodBtn.HoverState.Parent = this.addFoodBtn;
            this.addFoodBtn.Location = new System.Drawing.Point(333, 600);
            this.addFoodBtn.Name = "addFoodBtn";
            this.addFoodBtn.ShadowDecoration.Parent = this.addFoodBtn;
            this.addFoodBtn.Size = new System.Drawing.Size(122, 47);
            this.addFoodBtn.TabIndex = 34;
            this.addFoodBtn.Text = "Add";
            this.addFoodBtn.Click += new System.EventHandler(this.addFoodBtn_Click);
            // 
            // datePickerVal
            // 
            this.datePickerVal.BorderRadius = 15;
            this.datePickerVal.CheckedState.Parent = this.datePickerVal;
            this.datePickerVal.FillColor = System.Drawing.Color.PaleTurquoise;
            this.datePickerVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerVal.ForeColor = System.Drawing.Color.Black;
            this.datePickerVal.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePickerVal.HoverState.Parent = this.datePickerVal;
            this.datePickerVal.Location = new System.Drawing.Point(102, 523);
            this.datePickerVal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePickerVal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePickerVal.Name = "datePickerVal";
            this.datePickerVal.ShadowDecoration.Parent = this.datePickerVal;
            this.datePickerVal.Size = new System.Drawing.Size(334, 46);
            this.datePickerVal.TabIndex = 35;
            this.datePickerVal.TextOffset = new System.Drawing.Point(10, 0);
            this.datePickerVal.Value = new System.DateTime(2025, 2, 6, 14, 36, 11, 36);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(98, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(-1, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 5);
            this.panel1.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(-1, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(630, 10);
            this.panel2.TabIndex = 38;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.CustomIconSize = 20F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(532, 11);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(44, 39);
            this.guna2ControlBox1.TabIndex = 39;
            // 
            // AddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(576, 659);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.datePickerVal);
            this.Controls.Add(this.addFoodBtn);
            this.Controls.Add(this.foodStatusVal);
            this.Controls.Add(this.storageLocVal);
            this.Controls.Add(this.categoryVal);
            this.Controls.Add(this.quantityVal);
            this.Controls.Add(this.foodNameVal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddFood";
            this.Text = "AddFood";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox foodNameVal;
        private Guna.UI2.WinForms.Guna2TextBox quantityVal;
        private Guna.UI2.WinForms.Guna2ComboBox categoryVal;
        private Guna.UI2.WinForms.Guna2ComboBox storageLocVal;
        private Guna.UI2.WinForms.Guna2ComboBox foodStatusVal;
        private Guna.UI2.WinForms.Guna2Button addFoodBtn;
        private Guna.UI2.WinForms.Guna2DateTimePicker datePickerVal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}