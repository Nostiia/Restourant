namespace Restourant
{
    partial class Billing
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel7 = new Panel();
            GrdTotallbl = new Label();
            BillDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label12 = new Label();
            pictureBox8 = new PictureBox();
            panel3 = new Panel();
            DrinkDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            FoodDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            label11 = new Label();
            label10 = new Label();
            panel4 = new Panel();
            panel2 = new Panel();
            pictureBox6 = new PictureBox();
            AddBtn = new Button();
            Reset = new Button();
            BDateTb = new DateTimePicker();
            label9 = new Label();
            CustomerTb = new TextBox();
            label8 = new Label();
            QtyTb = new TextBox();
            label7 = new Label();
            PriceTb = new TextBox();
            label6 = new Label();
            ItemTb = new TextBox();
            pictureBox5 = new PictureBox();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            pictureBox7 = new PictureBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            payed = new Button();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BillDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DrinkDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FoodDGV).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(171, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(1117, 718);
            panel1.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(payed);
            panel7.Controls.Add(GrdTotallbl);
            panel7.Controls.Add(BillDGV);
            panel7.Controls.Add(label12);
            panel7.Controls.Add(pictureBox8);
            panel7.Location = new Point(333, 391);
            panel7.Name = "panel7";
            panel7.Size = new Size(453, 324);
            panel7.TabIndex = 2;
            // 
            // GrdTotallbl
            // 
            GrdTotallbl.AutoSize = true;
            GrdTotallbl.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            GrdTotallbl.ForeColor = SystemColors.ActiveCaption;
            GrdTotallbl.Location = new Point(292, 289);
            GrdTotallbl.Name = "GrdTotallbl";
            GrdTotallbl.Size = new Size(65, 35);
            GrdTotallbl.TabIndex = 32;
            GrdTotallbl.Text = "Price";
            // 
            // BillDGV
            // 
            BillDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = Color.White;
            dataGridViewCellStyle13.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle13.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(204, 247, 255);
            dataGridViewCellStyle13.SelectionForeColor = Color.FromArgb(71, 69, 94);
            BillDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(105, 192, 214);
            dataGridViewCellStyle14.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(105, 192, 214);
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            BillDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            BillDGV.ColumnHeadersHeight = 28;
            BillDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            BillDGV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.White;
            dataGridViewCellStyle15.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle15.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(204, 247, 255);
            dataGridViewCellStyle15.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            BillDGV.DefaultCellStyle = dataGridViewCellStyle15;
            BillDGV.GridColor = Color.FromArgb(231, 229, 255);
            BillDGV.Location = new Point(3, 59);
            BillDGV.Name = "BillDGV";
            BillDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = Color.White;
            dataGridViewCellStyle16.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle16.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = Color.White;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            BillDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            BillDGV.RowHeadersVisible = false;
            BillDGV.RowHeadersWidth = 51;
            BillDGV.RowTemplate.Height = 25;
            BillDGV.Size = new Size(446, 262);
            BillDGV.TabIndex = 27;
            BillDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            BillDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            BillDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            BillDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            BillDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            BillDGV.ThemeStyle.BackColor = Color.White;
            BillDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            BillDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            BillDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            BillDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BillDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            BillDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            BillDGV.ThemeStyle.HeaderStyle.Height = 28;
            BillDGV.ThemeStyle.ReadOnly = false;
            BillDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            BillDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            BillDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BillDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            BillDGV.ThemeStyle.RowsStyle.Height = 25;
            BillDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            BillDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            BillDGV.CellContentClick += guna2DataGridView3_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Number";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Item";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Price";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Quantity";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Total";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ControlText;
            label12.Location = new Point(76, 18);
            label12.Name = "label12";
            label12.Size = new Size(114, 35);
            label12.TabIndex = 26;
            label12.Text = "Client Bill";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(3, 3);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(67, 50);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 25;
            pictureBox8.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(DrinkDGV);
            panel3.Controls.Add(FoodDGV);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(400, 9);
            panel3.Name = "panel3";
            panel3.Size = new Size(698, 376);
            panel3.TabIndex = 1;
            // 
            // DrinkDGV
            // 
            DrinkDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = Color.White;
            dataGridViewCellStyle17.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle17.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = Color.FromArgb(204, 247, 255);
            dataGridViewCellStyle17.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DrinkDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = Color.FromArgb(105, 192, 214);
            dataGridViewCellStyle18.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle18.ForeColor = Color.White;
            dataGridViewCellStyle18.SelectionBackColor = Color.FromArgb(105, 192, 214);
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            DrinkDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            DrinkDGV.ColumnHeadersHeight = 28;
            DrinkDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = Color.White;
            dataGridViewCellStyle19.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle19.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle19.SelectionBackColor = Color.FromArgb(204, 247, 255);
            dataGridViewCellStyle19.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.False;
            DrinkDGV.DefaultCellStyle = dataGridViewCellStyle19;
            DrinkDGV.GridColor = Color.FromArgb(231, 229, 255);
            DrinkDGV.Location = new Point(359, 58);
            DrinkDGV.Name = "DrinkDGV";
            DrinkDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = Color.White;
            dataGridViewCellStyle20.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle20.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = Color.White;
            dataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.True;
            DrinkDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            DrinkDGV.RowHeadersVisible = false;
            DrinkDGV.RowHeadersWidth = 51;
            DrinkDGV.RowTemplate.Height = 25;
            DrinkDGV.Size = new Size(320, 299);
            DrinkDGV.TabIndex = 26;
            DrinkDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DrinkDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            DrinkDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DrinkDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DrinkDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DrinkDGV.ThemeStyle.BackColor = Color.White;
            DrinkDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DrinkDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DrinkDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DrinkDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DrinkDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DrinkDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DrinkDGV.ThemeStyle.HeaderStyle.Height = 28;
            DrinkDGV.ThemeStyle.ReadOnly = false;
            DrinkDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            DrinkDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DrinkDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DrinkDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DrinkDGV.ThemeStyle.RowsStyle.Height = 25;
            DrinkDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DrinkDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DrinkDGV.CellContentClick += DrinkDGV_CellContentClick;
            // 
            // FoodDGV
            // 
            FoodDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = Color.White;
            dataGridViewCellStyle21.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle21.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = Color.FromArgb(204, 247, 255);
            dataGridViewCellStyle21.SelectionForeColor = Color.FromArgb(71, 69, 94);
            FoodDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = Color.FromArgb(105, 192, 214);
            dataGridViewCellStyle22.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle22.ForeColor = Color.White;
            dataGridViewCellStyle22.SelectionBackColor = Color.FromArgb(105, 192, 214);
            dataGridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.True;
            FoodDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            FoodDGV.ColumnHeadersHeight = 28;
            FoodDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = Color.White;
            dataGridViewCellStyle23.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle23.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle23.SelectionBackColor = Color.FromArgb(204, 247, 255);
            dataGridViewCellStyle23.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.False;
            FoodDGV.DefaultCellStyle = dataGridViewCellStyle23;
            FoodDGV.GridColor = Color.FromArgb(231, 229, 255);
            FoodDGV.Location = new Point(13, 55);
            FoodDGV.Name = "FoodDGV";
            FoodDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = Color.White;
            dataGridViewCellStyle24.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle24.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = Color.White;
            dataGridViewCellStyle24.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = DataGridViewTriState.True;
            FoodDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            FoodDGV.RowHeadersVisible = false;
            FoodDGV.RowHeadersWidth = 51;
            FoodDGV.RowTemplate.Height = 25;
            FoodDGV.Size = new Size(320, 299);
            FoodDGV.TabIndex = 25;
            FoodDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            FoodDGV.ThemeStyle.AlternatingRowsStyle.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FoodDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            FoodDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(204, 247, 255);
            FoodDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            FoodDGV.ThemeStyle.BackColor = Color.White;
            FoodDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            FoodDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(105, 192, 214);
            FoodDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            FoodDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FoodDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            FoodDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            FoodDGV.ThemeStyle.HeaderStyle.Height = 28;
            FoodDGV.ThemeStyle.ReadOnly = false;
            FoodDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            FoodDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            FoodDGV.ThemeStyle.RowsStyle.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FoodDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            FoodDGV.ThemeStyle.RowsStyle.Height = 25;
            FoodDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(204, 247, 255);
            FoodDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            FoodDGV.CellContentClick += FoodDGV_CellContentClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(599, 17);
            label11.Name = "label11";
            label11.Size = new Size(80, 35);
            label11.TabIndex = 24;
            label11.Text = "Drinks";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(19, 17);
            label10.Name = "label10";
            label10.Size = new Size(70, 35);
            label10.TabIndex = 24;
            label10.Text = "Foods";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Navy;
            panel4.Location = new Point(345, 21);
            panel4.Name = "panel4";
            panel4.Size = new Size(6, 345);
            panel4.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(AddBtn);
            panel2.Controls.Add(Reset);
            panel2.Controls.Add(BDateTb);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(CustomerTb);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(QtyTb);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(PriceTb);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(ItemTb);
            panel2.Location = new Point(3, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(378, 376);
            panel2.TabIndex = 0;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(90, 52);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 24;
            pictureBox6.TabStop = false;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = SystemColors.GradientActiveCaption;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.ForeColor = SystemColors.ActiveCaptionText;
            AddBtn.Location = new Point(194, 310);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(173, 44);
            AddBtn.TabIndex = 31;
            AddBtn.Text = "Add To Bill";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += DeleteBtn_Click;
            // 
            // Reset
            // 
            Reset.BackColor = SystemColors.GradientActiveCaption;
            Reset.FlatStyle = FlatStyle.Flat;
            Reset.ForeColor = SystemColors.ActiveCaptionText;
            Reset.Location = new Point(19, 310);
            Reset.Name = "Reset";
            Reset.Size = new Size(169, 44);
            Reset.TabIndex = 30;
            Reset.Text = "Reset Fields";
            Reset.UseVisualStyleBackColor = false;
            Reset.Click += EditBtn_Click;
            // 
            // BDateTb
            // 
            BDateTb.CalendarForeColor = Color.DarkSlateGray;
            BDateTb.CalendarTitleForeColor = Color.Navy;
            BDateTb.Format = DateTimePickerFormat.Short;
            BDateTb.Location = new Point(19, 252);
            BDateTb.Name = "BDateTb";
            BDateTb.Size = new Size(250, 43);
            BDateTb.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(160, 153);
            label9.Name = "label9";
            label9.Size = new Size(109, 35);
            label9.TabIndex = 28;
            label9.Text = "Customer";
            label9.Click += label9_Click;
            // 
            // CustomerTb
            // 
            CustomerTb.Location = new Point(160, 191);
            CustomerTb.Name = "CustomerTb";
            CustomerTb.Size = new Size(208, 43);
            CustomerTb.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(19, 153);
            label8.Name = "label8";
            label8.Size = new Size(104, 35);
            label8.TabIndex = 26;
            label8.Text = "Quantity";
            // 
            // QtyTb
            // 
            QtyTb.Location = new Point(19, 191);
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(135, 43);
            QtyTb.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(233, 58);
            label7.Name = "label7";
            label7.Size = new Size(65, 35);
            label7.TabIndex = 26;
            label7.Text = "Price";
            // 
            // PriceTb
            // 
            PriceTb.Location = new Point(240, 96);
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(135, 43);
            PriceTb.TabIndex = 25;
            PriceTb.TextChanged += textBox2_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(19, 58);
            label6.Name = "label6";
            label6.Size = new Size(60, 35);
            label6.TabIndex = 24;
            label6.Text = "Item";
            // 
            // ItemTb
            // 
            ItemTb.Location = new Point(19, 96);
            ItemTb.Name = "ItemTb";
            ItemTb.Size = new Size(207, 43);
            ItemTb.TabIndex = 0;
            ItemTb.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(125, 62);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(12, 744);
            label4.Name = "label4";
            label4.Size = new Size(90, 35);
            label4.TabIndex = 21;
            label4.Text = "Log out";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 674);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(80, 67);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(59, 556);
            label3.Name = "label3";
            label3.Size = new Size(78, 35);
            label3.TabIndex = 19;
            label3.Text = "Billing";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 436);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 117);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(57, 376);
            label1.Name = "label1";
            label1.Size = new Size(80, 35);
            label1.TabIndex = 17;
            label1.Text = "Drinks";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 251);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 122);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(67, 202);
            label2.Name = "label2";
            label2.Size = new Size(70, 35);
            label2.TabIndex = 15;
            label2.Text = "Foods";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label5.Location = new Point(171, 23);
            label5.Name = "label5";
            label5.Size = new Size(299, 35);
            label5.TabIndex = 22;
            label5.Text = "Restaurant Point of sale 1.0";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(1244, 0);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(58, 49);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 23;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // payed
            // 
            payed.BackColor = SystemColors.GradientActiveCaption;
            payed.FlatStyle = FlatStyle.Flat;
            payed.ForeColor = SystemColors.ActiveCaptionText;
            payed.Location = new Point(280, 9);
            payed.Name = "payed";
            payed.Size = new Size(169, 44);
            payed.TabIndex = 32;
            payed.Text = "Close Bill";
            payed.UseVisualStyleBackColor = false;
            payed.Click += payed_Click;
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(13F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1300, 788);
            Controls.Add(pictureBox7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox4);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox5);
            Controls.Add(panel1);
            Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "Billing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing";
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BillDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DrinkDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)FoodDGV).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox5;
        private Label label4;
        private PictureBox pictureBox4;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label5;
        private PictureBox pictureBox7;
        private Panel panel2;
        private Label label7;
        private TextBox PriceTb;
        private Label label6;
        private TextBox ItemTb;
        private Label label8;
        private TextBox QtyTb;
        private Label label9;
        private TextBox CustomerTb;
        private DateTimePicker BDateTb;
        private Button AddBtn;
        private Button Reset;
        private Panel panel3;
        private PictureBox pictureBox6;
        private Panel panel4;
        private Label label11;
        private Label label10;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Panel panel7;
        private Label label12;
        private PictureBox pictureBox8;
        private Guna.UI2.WinForms.Guna2DataGridView BillDGV;
        private Guna.UI2.WinForms.Guna2DataGridView DrinkDGV;
        private Guna.UI2.WinForms.Guna2DataGridView FoodDGV;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label GrdTotallbl;
        private Button payed;
    }
}