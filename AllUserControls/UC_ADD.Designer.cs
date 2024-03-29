namespace BanNuoc.AllUserControls
{
    partial class UC_ADD
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textManuoc = new TextBox();
            textTennuoc = new TextBox();
            textSoluong = new TextBox();
            label5 = new Label();
            textLoainuoc = new TextBox();
            label6 = new Label();
            textGia = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(328, 30);
            label1.Name = "label1";
            label1.Size = new Size(134, 31);
            label1.TabIndex = 0;
            label1.Text = "Thêm nước";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Colonna MT", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(96, 67);
            label2.Name = "label2";
            label2.Size = new Size(88, 24);
            label2.TabIndex = 2;
            label2.Text = "Mã nước";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Colonna MT", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(545, 67);
            label3.Name = "label3";
            label3.Size = new Size(99, 24);
            label3.TabIndex = 3;
            label3.Text = "Tên nước";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Colonna MT", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(96, 195);
            label4.Name = "label4";
            label4.Size = new Size(91, 24);
            label4.TabIndex = 4;
            label4.Text = "Số lượng";
            // 
            // textManuoc
            // 
            textManuoc.Location = new Point(96, 108);
            textManuoc.Name = "textManuoc";
            textManuoc.Size = new Size(204, 31);
            textManuoc.TabIndex = 5;
            // 
            // textTennuoc
            // 
            textTennuoc.Location = new Point(545, 108);
            textTennuoc.Name = "textTennuoc";
            textTennuoc.Size = new Size(204, 31);
            textTennuoc.TabIndex = 6;
            // 
            // textSoluong
            // 
            textSoluong.Location = new Point(96, 232);
            textSoluong.Name = "textSoluong";
            textSoluong.Size = new Size(204, 31);
            textSoluong.TabIndex = 7;
            textSoluong.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Colonna MT", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(545, 195);
            label5.Name = "label5";
            label5.Size = new Size(102, 24);
            label5.TabIndex = 8;
            label5.Text = "Loại nước";
            // 
            // textLoainuoc
            // 
            textLoainuoc.Location = new Point(545, 232);
            textLoainuoc.Name = "textLoainuoc";
            textLoainuoc.Size = new Size(204, 31);
            textLoainuoc.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Colonna MT", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(319, 323);
            label6.Name = "label6";
            label6.Size = new Size(41, 24);
            label6.TabIndex = 10;
            label6.Text = "Giá";
            // 
            // textGia
            // 
            textGia.Location = new Point(319, 360);
            textGia.Name = "textGia";
            textGia.Size = new Size(178, 31);
            textGia.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Font = new Font("Colonna MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(343, 457);
            button1.Name = "button1";
            button1.Size = new Size(119, 42);
            button1.TabIndex = 12;
            button1.Text = "Thêm ";
            button1.UseVisualStyleBackColor = false;
            // 
            // UC_ADD
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(button1);
            Controls.Add(textGia);
            Controls.Add(label6);
            Controls.Add(textLoainuoc);
            Controls.Add(label5);
            Controls.Add(textSoluong);
            Controls.Add(textTennuoc);
            Controls.Add(textManuoc);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_ADD";
            Size = new Size(826, 593);
            Load += UC_ADD_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textManuoc;
        private TextBox textTennuoc;
        private TextBox textSoluong;
        private Label label5;
        private TextBox textLoainuoc;
        private Label label6;
        private TextBox textGia;
        public Button button1;
    }
}
