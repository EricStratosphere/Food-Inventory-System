namespace Food_Inventory_System.Inventory
{
    partial class InventoryUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.printButton = new Guna.UI2.WinForms.Guna2Button();
            this.searchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.foodTableView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.def = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addFoodBtn2 = new Guna.UI2.WinForms.Guna2Button();
            this.categoryList = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sortListType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.refresehBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.foodTableView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printButton
            // 
            this.printButton.BorderRadius = 12;
            this.printButton.CheckedState.Parent = this.printButton;
            this.printButton.CustomImages.Parent = this.printButton;
            this.printButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(150)))), ((int)(((byte)(62)))));
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.Color.White;
            this.printButton.HoverState.Parent = this.printButton;
            this.printButton.Image = ((System.Drawing.Image)(resources.GetObject("printButton.Image")));
            this.printButton.ImageSize = new System.Drawing.Size(30, 30);
            this.printButton.Location = new System.Drawing.Point(956, 9);
            this.printButton.Name = "printButton";
            this.printButton.ShadowDecoration.Parent = this.printButton;
            this.printButton.Size = new System.Drawing.Size(153, 57);
            this.printButton.TabIndex = 1;
            this.printButton.Text = "Export";
            this.printButton.TextOffset = new System.Drawing.Point(2, 0);
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // searchBar
            // 
            this.searchBar.BorderRadius = 20;
            this.searchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBar.DefaultText = "";
            this.searchBar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBar.DisabledState.Parent = this.searchBar;
            this.searchBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBar.FillColor = System.Drawing.Color.WhiteSmoke;
            this.searchBar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBar.FocusedState.Parent = this.searchBar;
            this.searchBar.ForeColor = System.Drawing.Color.Black;
            this.searchBar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBar.HoverState.Parent = this.searchBar;
            this.searchBar.IconLeft = ((System.Drawing.Image)(resources.GetObject("searchBar.IconLeft")));
            this.searchBar.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.searchBar.Location = new System.Drawing.Point(20, 74);
            this.searchBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchBar.Name = "searchBar";
            this.searchBar.PasswordChar = '\0';
            this.searchBar.PlaceholderForeColor = System.Drawing.Color.Black;
            this.searchBar.PlaceholderText = "Search...";
            this.searchBar.SelectedText = "";
            this.searchBar.ShadowDecoration.Parent = this.searchBar;
            this.searchBar.Size = new System.Drawing.Size(258, 44);
            this.searchBar.TabIndex = 2;
            this.searchBar.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // foodTableView
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.foodTableView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.foodTableView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.foodTableView.BackgroundColor = System.Drawing.Color.White;
            this.foodTableView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.foodTableView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.foodTableView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.foodTableView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.foodTableView.ColumnHeadersHeight = 27;
            this.foodTableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.def});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.foodTableView.DefaultCellStyle = dataGridViewCellStyle9;
            this.foodTableView.EnableHeadersVisualStyles = false;
            this.foodTableView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.foodTableView.Location = new System.Drawing.Point(3, 3);
            this.foodTableView.Name = "foodTableView";
            this.foodTableView.RowHeadersVisible = false;
            this.foodTableView.RowHeadersWidth = 51;
            this.foodTableView.RowTemplate.Height = 24;
            this.foodTableView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.foodTableView.Size = new System.Drawing.Size(1275, 677);
            this.foodTableView.TabIndex = 3;
            this.foodTableView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Emerald;
            this.foodTableView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.foodTableView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.foodTableView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.foodTableView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.foodTableView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.foodTableView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.foodTableView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.foodTableView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.foodTableView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.foodTableView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.foodTableView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.foodTableView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.foodTableView.ThemeStyle.HeaderStyle.Height = 27;
            this.foodTableView.ThemeStyle.ReadOnly = false;
            this.foodTableView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            this.foodTableView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.foodTableView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.foodTableView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.foodTableView.ThemeStyle.RowsStyle.Height = 24;
            this.foodTableView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            this.foodTableView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // def
            // 
            this.def.HeaderText = "Column1";
            this.def.MinimumWidth = 6;
            this.def.Name = "def";
            // 
            // addFoodBtn2
            // 
            this.addFoodBtn2.BorderRadius = 12;
            this.addFoodBtn2.CheckedState.Parent = this.addFoodBtn2;
            this.addFoodBtn2.CustomImages.Parent = this.addFoodBtn2;
            this.addFoodBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFoodBtn2.ForeColor = System.Drawing.Color.White;
            this.addFoodBtn2.HoverState.Parent = this.addFoodBtn2;
            this.addFoodBtn2.Image = ((System.Drawing.Image)(resources.GetObject("addFoodBtn2.Image")));
            this.addFoodBtn2.ImageSize = new System.Drawing.Size(30, 30);
            this.addFoodBtn2.Location = new System.Drawing.Point(1123, 9);
            this.addFoodBtn2.Name = "addFoodBtn2";
            this.addFoodBtn2.ShadowDecoration.Parent = this.addFoodBtn2;
            this.addFoodBtn2.Size = new System.Drawing.Size(162, 57);
            this.addFoodBtn2.TabIndex = 35;
            this.addFoodBtn2.Text = "Add";
            this.addFoodBtn2.TextOffset = new System.Drawing.Point(2, 0);
            this.addFoodBtn2.Click += new System.EventHandler(this.addFoodBtn2_Click_1);
            // 
            // categoryList
            // 
            this.categoryList.BackColor = System.Drawing.Color.Transparent;
            this.categoryList.BorderRadius = 15;
            this.categoryList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.categoryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryList.FocusedColor = System.Drawing.Color.Empty;
            this.categoryList.FocusedState.Parent = this.categoryList;
            this.categoryList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.categoryList.ForeColor = System.Drawing.Color.Black;
            this.categoryList.FormattingEnabled = true;
            this.categoryList.HoverState.Parent = this.categoryList;
            this.categoryList.ItemHeight = 30;
            this.categoryList.ItemsAppearance.Parent = this.categoryList;
            this.categoryList.Location = new System.Drawing.Point(1052, 78);
            this.categoryList.Name = "categoryList";
            this.categoryList.ShadowDecoration.Parent = this.categoryList;
            this.categoryList.Size = new System.Drawing.Size(174, 36);
            this.categoryList.TabIndex = 37;
            this.categoryList.SelectedIndexChanged += new System.EventHandler(this.categoryList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(950, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(680, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Sort by:";
            // 
            // sortListType
            // 
            this.sortListType.BackColor = System.Drawing.Color.Transparent;
            this.sortListType.BorderRadius = 15;
            this.sortListType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sortListType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortListType.FocusedColor = System.Drawing.Color.Empty;
            this.sortListType.FocusedState.Parent = this.sortListType;
            this.sortListType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sortListType.ForeColor = System.Drawing.Color.Black;
            this.sortListType.FormattingEnabled = true;
            this.sortListType.HoverState.Parent = this.sortListType;
            this.sortListType.ItemHeight = 30;
            this.sortListType.Items.AddRange(new object[] {
            "Quantity",
            "Expiration Date",
            "All"});
            this.sortListType.ItemsAppearance.Parent = this.sortListType;
            this.sortListType.Location = new System.Drawing.Point(770, 78);
            this.sortListType.Name = "sortListType";
            this.sortListType.ShadowDecoration.Parent = this.sortListType;
            this.sortListType.Size = new System.Drawing.Size(174, 36);
            this.sortListType.TabIndex = 40;
            this.sortListType.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.foodTableView);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 134);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1266, 681);
            this.flowLayoutPanel1.TabIndex = 41;
            // 
            // refresehBtn
            // 
            this.refresehBtn.BackColor = System.Drawing.Color.Transparent;
            this.refresehBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refresehBtn.BackgroundImage")));
            this.refresehBtn.CheckedState.Parent = this.refresehBtn;
            this.refresehBtn.HoverState.Parent = this.refresehBtn;
            this.refresehBtn.Image = ((System.Drawing.Image)(resources.GetObject("refresehBtn.Image")));
            this.refresehBtn.Location = new System.Drawing.Point(1232, 79);
            this.refresehBtn.Name = "refresehBtn";
            this.refresehBtn.PressedState.Parent = this.refresehBtn;
            this.refresehBtn.Size = new System.Drawing.Size(44, 39);
            this.refresehBtn.TabIndex = 42;
            this.refresehBtn.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // InventoryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.refresehBtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.sortListType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryList);
            this.Controls.Add(this.addFoodBtn2);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.printButton);
            this.Name = "InventoryUI";
            this.Size = new System.Drawing.Size(1324, 833);
            this.Load += new System.EventHandler(this.InventoryUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodTableView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button printButton;
        private Guna.UI2.WinForms.Guna2TextBox searchBar;
        private Guna.UI2.WinForms.Guna2DataGridView foodTableView;
        private System.Windows.Forms.DataGridViewTextBoxColumn def;
        private Guna.UI2.WinForms.Guna2Button addFoodBtn2;
        private Guna.UI2.WinForms.Guna2ComboBox categoryList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox sortListType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton refresehBtn;
    }
}
