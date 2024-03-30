namespace BanNuoc.AllUserControls
{
    partial class UC_Menu
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            MenuGridview = new Guna.UI2.WinForms.Guna2DataGridView();
            label2 = new Label();
            label3 = new Label();
            txtCustomername = new Guna.UI2.WinForms.Guna2TextBox();
            txtDrinkname = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            label5 = new Label();
            txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            btnHoadon = new Guna.UI2.WinForms.Guna2Button();
            txtQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)MenuGridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(288, 10);
            label1.Name = "label1";
            label1.Size = new Size(146, 29);
            label1.TabIndex = 0;
            label1.Text = "Menu Quán";
            label1.Click += label1_Click;
            // 
            // MenuGridview
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            MenuGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            MenuGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            MenuGridview.ColumnHeadersHeight = 22;
            MenuGridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            MenuGridview.DefaultCellStyle = dataGridViewCellStyle3;
            MenuGridview.GridColor = Color.FromArgb(231, 229, 255);
            MenuGridview.Location = new Point(3, 54);
            MenuGridview.Name = "MenuGridview";
            MenuGridview.RowHeadersVisible = false;
            MenuGridview.RowHeadersWidth = 51;
            MenuGridview.Size = new Size(778, 217);
            MenuGridview.TabIndex = 1;
            MenuGridview.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            MenuGridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            MenuGridview.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            MenuGridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            MenuGridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            MenuGridview.ThemeStyle.BackColor = Color.White;
            MenuGridview.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            MenuGridview.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            MenuGridview.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            MenuGridview.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            MenuGridview.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            MenuGridview.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            MenuGridview.ThemeStyle.HeaderStyle.Height = 22;
            MenuGridview.ThemeStyle.ReadOnly = false;
            MenuGridview.ThemeStyle.RowsStyle.BackColor = Color.White;
            MenuGridview.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            MenuGridview.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            MenuGridview.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            MenuGridview.ThemeStyle.RowsStyle.Height = 29;
            MenuGridview.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            MenuGridview.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            MenuGridview.CellClick += MenuGridview_CellClick;
            MenuGridview.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 286);
            label2.Name = "label2";
            label2.Size = new Size(132, 18);
            label2.TabIndex = 2;
            label2.Text = "Tên Khách Hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 368);
            label3.Name = "label3";
            label3.Size = new Size(81, 18);
            label3.TabIndex = 4;
            label3.Text = "Tên Nước";
            // 
            // txtCustomername
            // 
            txtCustomername.CustomizableEdges = customizableEdges1;
            txtCustomername.DefaultText = "";
            txtCustomername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCustomername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCustomername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCustomername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCustomername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCustomername.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCustomername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCustomername.Location = new Point(35, 308);
            txtCustomername.Margin = new Padding(4);
            txtCustomername.Name = "txtCustomername";
            txtCustomername.PasswordChar = '\0';
            txtCustomername.PlaceholderText = "";
            txtCustomername.SelectedText = "";
            txtCustomername.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtCustomername.Size = new Size(279, 32);
            txtCustomername.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtCustomername.TabIndex = 3;
            // 
            // txtDrinkname
            // 
            txtDrinkname.CustomizableEdges = customizableEdges3;
            txtDrinkname.DefaultText = "";
            txtDrinkname.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDrinkname.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDrinkname.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDrinkname.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDrinkname.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDrinkname.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDrinkname.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDrinkname.Location = new Point(35, 390);
            txtDrinkname.Margin = new Padding(4);
            txtDrinkname.Name = "txtDrinkname";
            txtDrinkname.PasswordChar = '\0';
            txtDrinkname.PlaceholderText = "";
            txtDrinkname.SelectedText = "";
            txtDrinkname.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtDrinkname.Size = new Size(279, 32);
            txtDrinkname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtDrinkname.TabIndex = 5;
            txtDrinkname.TextChanged += guna2TextBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(391, 286);
            label4.Name = "label4";
            label4.Size = new Size(75, 18);
            label4.TabIndex = 6;
            label4.Text = "Số lượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(390, 368);
            label5.Name = "label5";
            label5.Size = new Size(76, 18);
            label5.TabIndex = 8;
            label5.Text = "Giá nước";
            label5.Click += label5_Click;
            // 
            // txtPrice
            // 
            txtPrice.CustomizableEdges = customizableEdges5;
            txtPrice.DefaultText = "";
            txtPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrice.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrice.Location = new Point(390, 390);
            txtPrice.Margin = new Padding(4);
            txtPrice.Name = "txtPrice";
            txtPrice.PasswordChar = '\0';
            txtPrice.PlaceholderText = "";
            txtPrice.SelectedText = "";
            txtPrice.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPrice.Size = new Size(279, 32);
            txtPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtPrice.TabIndex = 9;
            // 
            // btnHoadon
            // 
            btnHoadon.BorderRadius = 30;
            btnHoadon.CustomizableEdges = customizableEdges7;
            btnHoadon.DisabledState.BorderColor = Color.DarkGray;
            btnHoadon.DisabledState.CustomBorderColor = Color.DarkGray;
            btnHoadon.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnHoadon.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnHoadon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHoadon.ForeColor = Color.White;
            btnHoadon.Location = new Point(279, 468);
            btnHoadon.Name = "btnHoadon";
            btnHoadon.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnHoadon.Size = new Size(135, 56);
            btnHoadon.TabIndex = 10;
            btnHoadon.Text = "Thêm hóa đơn";
            btnHoadon.Click += btnHoadon_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.Transparent;
            txtQuantity.CustomizableEdges = customizableEdges9;
            txtQuantity.Font = new Font("Segoe UI", 9F);
            txtQuantity.Location = new Point(391, 308);
            txtQuantity.Margin = new Padding(3, 4, 3, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtQuantity.Size = new Size(279, 32);
            txtQuantity.TabIndex = 11;
            // 
            // UC_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtQuantity);
            Controls.Add(btnHoadon);
            Controls.Add(txtPrice);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtDrinkname);
            Controls.Add(label3);
            Controls.Add(txtCustomername);
            Controls.Add(label2);
            Controls.Add(MenuGridview);
            Controls.Add(label1);
            Name = "UC_Menu";
            Size = new Size(704, 557);
            Load += UC_Menu_Load;
            ((System.ComponentModel.ISupportInitialize)MenuGridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView MenuGridview;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomername;
        private Guna.UI2.WinForms.Guna2TextBox txtDrinkname;
        private Label label4;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2Button btnHoadon;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtQuantity;
    }
}
