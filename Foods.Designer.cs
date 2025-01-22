namespace Restourant
{
    partial class Foods
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Foods));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            FoodDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            panel2 = new Panel();
            label7 = new Label();
            pictureBox6 = new PictureBox();
            label6 = new Label();
            AddBtn = new Button();
            DeleteBtn = new Button();
            EditBtn = new Button();
            PriceTb = new Guna.UI2.WinForms.Guna2TextBox();
            CategoryTb = new Guna.UI2.WinForms.Guna2TextBox();
            FNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            pictureBox7 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FoodDGV).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(FoodDGV);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(172, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(1078, 708);
            panel1.TabIndex = 0;
            // 
            // FoodDGV
            // 
            FoodDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 0, 160);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            FoodDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(89, 175, 253);
            dataGridViewCellStyle2.Font = new Font("Segoe Print", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(89, 175, 253);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            FoodDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            FoodDGV.ColumnHeadersHeight = 35;
            FoodDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 0, 160);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            FoodDGV.DefaultCellStyle = dataGridViewCellStyle3;
            FoodDGV.GridColor = Color.FromArgb(231, 229, 255);
            FoodDGV.Location = new Point(346, 21);
            FoodDGV.Name = "FoodDGV";
            FoodDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            FoodDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            FoodDGV.RowHeadersVisible = false;
            FoodDGV.RowHeadersWidth = 51;
            FoodDGV.RowTemplate.Height = 30;
            FoodDGV.Size = new Size(713, 667);
            FoodDGV.TabIndex = 1;
            FoodDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            FoodDGV.ThemeStyle.AlternatingRowsStyle.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FoodDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            FoodDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(0, 0, 160);
            FoodDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.White;
            FoodDGV.ThemeStyle.BackColor = Color.White;
            FoodDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            FoodDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(89, 175, 253);
            FoodDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            FoodDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe Print", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FoodDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            FoodDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            FoodDGV.ThemeStyle.HeaderStyle.Height = 35;
            FoodDGV.ThemeStyle.ReadOnly = false;
            FoodDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            FoodDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            FoodDGV.ThemeStyle.RowsStyle.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FoodDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            FoodDGV.ThemeStyle.RowsStyle.Height = 30;
            FoodDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 0, 160);
            FoodDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            FoodDGV.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(AddBtn);
            panel2.Controls.Add(DeleteBtn);
            panel2.Controls.Add(EditBtn);
            panel2.Controls.Add(PriceTb);
            panel2.Controls.Add(CategoryTb);
            panel2.Controls.Add(FNameTb);
            panel2.Location = new Point(22, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(309, 667);
            panel2.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(176, 620);
            label7.Name = "label7";
            label7.Size = new Size(130, 35);
            label7.TabIndex = 15;
            label7.Text = "Reset Fields";
            label7.Click += label7_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(14, 47);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(90, 76);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label6.Location = new Point(3, 9);
            label6.Name = "label6";
            label6.Size = new Size(250, 35);
            label6.TabIndex = 14;
            label6.Text = "Food Items Managment";
            // 
            // AddBtn
            // 
            AddBtn.BackColor = SystemColors.GradientActiveCaption;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.ForeColor = SystemColors.ActiveCaptionText;
            AddBtn.Location = new Point(14, 442);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(282, 44);
            AddBtn.TabIndex = 10;
            AddBtn.Text = "Add Food";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click_1;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = SystemColors.GradientActiveCaption;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.ForeColor = SystemColors.ActiveCaptionText;
            DeleteBtn.Location = new Point(151, 382);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(145, 44);
            DeleteBtn.TabIndex = 9;
            DeleteBtn.Text = "Delete Food";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = SystemColors.GradientActiveCaption;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.ForeColor = SystemColors.ActiveCaptionText;
            EditBtn.Location = new Point(14, 382);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(131, 44);
            EditBtn.TabIndex = 8;
            EditBtn.Text = "Edit Food";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // PriceTb
            // 
            PriceTb.CustomizableEdges = customizableEdges1;
            PriceTb.DefaultText = "";
            PriceTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PriceTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PriceTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PriceTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PriceTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PriceTb.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PriceTb.ForeColor = SystemColors.ActiveCaption;
            PriceTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PriceTb.Location = new Point(14, 297);
            PriceTb.Margin = new Padding(4, 6, 4, 6);
            PriceTb.Name = "PriceTb";
            PriceTb.PasswordChar = '\0';
            PriceTb.PlaceholderText = "Food Price";
            PriceTb.SelectedText = "";
            PriceTb.ShadowDecoration.CustomizableEdges = customizableEdges2;
            PriceTb.Size = new Size(282, 50);
            PriceTb.TabIndex = 6;
            // 
            // CategoryTb
            // 
            CategoryTb.CustomizableEdges = customizableEdges3;
            CategoryTb.DefaultText = "";
            CategoryTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            CategoryTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            CategoryTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            CategoryTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            CategoryTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            CategoryTb.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CategoryTb.ForeColor = SystemColors.ActiveCaption;
            CategoryTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            CategoryTb.Location = new Point(14, 219);
            CategoryTb.Margin = new Padding(4, 6, 4, 6);
            CategoryTb.Name = "CategoryTb";
            CategoryTb.PasswordChar = '\0';
            CategoryTb.PlaceholderText = "Food Category";
            CategoryTb.SelectedText = "";
            CategoryTb.ShadowDecoration.CustomizableEdges = customizableEdges4;
            CategoryTb.Size = new Size(282, 50);
            CategoryTb.TabIndex = 5;
            // 
            // FNameTb
            // 
            FNameTb.CustomizableEdges = customizableEdges5;
            FNameTb.DefaultText = "";
            FNameTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            FNameTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            FNameTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            FNameTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            FNameTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            FNameTb.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FNameTb.ForeColor = SystemColors.ActiveCaption;
            FNameTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            FNameTb.Location = new Point(14, 142);
            FNameTb.Margin = new Padding(4, 6, 4, 6);
            FNameTb.Name = "FNameTb";
            FNameTb.PasswordChar = '\0';
            FNameTb.PlaceholderText = "Food Name";
            FNameTb.SelectedText = "";
            FNameTb.ShadowDecoration.CustomizableEdges = customizableEdges6;
            FNameTb.Size = new Size(282, 50);
            FNameTb.TabIndex = 4;
            FNameTb.TextChanged += guna2TextBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(77, 210);
            label2.Name = "label2";
            label2.Size = new Size(70, 35);
            label2.TabIndex = 5;
            label2.Text = "Foods";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(67, 384);
            label1.Name = "label1";
            label1.Size = new Size(80, 35);
            label1.TabIndex = 7;
            label1.Text = "Drinks";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(22, 259);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 122);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(69, 564);
            label3.Name = "label3";
            label3.Size = new Size(78, 35);
            label3.TabIndex = 9;
            label3.Text = "Billing";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(22, 444);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 117);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(22, 752);
            label4.Name = "label4";
            label4.Size = new Size(90, 35);
            label4.TabIndex = 11;
            label4.Text = "Log out";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(22, 682);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(80, 67);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, -4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(125, 62);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label5.Location = new Point(172, 9);
            label5.Name = "label5";
            label5.Size = new Size(299, 35);
            label5.TabIndex = 13;
            label5.Text = "Restaurant Point of sale 1.0";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(1243, 0);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(58, 49);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 14;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // Foods
            // 
            AutoScaleDimensions = new SizeF(13F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1300, 788);
            Controls.Add(pictureBox7);
            Controls.Add(label5);
            Controls.Add(pictureBox5);
            Controls.Add(label4);
            Controls.Add(pictureBox4);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "Foods";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Foods";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FoodDGV).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label4;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Panel panel2;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox PriceTb;
        private Guna.UI2.WinForms.Guna2TextBox CategoryTb;
        private Guna.UI2.WinForms.Guna2TextBox FNameTb;
        private Button DeleteBtn;
        private Button EditBtn;
        private PictureBox pictureBox6;
        private Label label6;
        private Button AddBtn;
        private Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView FoodDGV;
        private PictureBox pictureBox7;
    }
}