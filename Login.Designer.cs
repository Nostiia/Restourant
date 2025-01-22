namespace Restourant
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            UnameTb = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            label3 = new Label();
            PasswordTb = new Guna.UI2.WinForms.Guna2TextBox();
            LoginBtn = new Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 12);
            label1.Name = "label1";
            label1.Size = new Size(256, 35);
            label1.TabIndex = 0;
            label1.Text = "Restaurant Point of sale";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(825, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // UnameTb
            // 
            UnameTb.CustomizableEdges = customizableEdges1;
            UnameTb.DefaultText = "";
            UnameTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            UnameTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            UnameTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            UnameTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            UnameTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            UnameTb.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UnameTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            UnameTb.Location = new Point(231, 130);
            UnameTb.Margin = new Padding(4, 6, 4, 6);
            UnameTb.Name = "UnameTb";
            UnameTb.PasswordChar = '\0';
            UnameTb.PlaceholderText = "";
            UnameTb.SelectedText = "";
            UnameTb.ShadowDecoration.CustomizableEdges = customizableEdges2;
            UnameTb.Size = new Size(518, 93);
            UnameTb.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(231, 89);
            label2.Name = "label2";
            label2.Size = new Size(124, 35);
            label2.TabIndex = 4;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(231, 239);
            label3.Name = "label3";
            label3.Size = new Size(109, 35);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // PasswordTb
            // 
            PasswordTb.CustomizableEdges = customizableEdges3;
            PasswordTb.DefaultText = "";
            PasswordTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PasswordTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PasswordTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PasswordTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PasswordTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTb.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTb.Location = new Point(231, 280);
            PasswordTb.Margin = new Padding(4, 6, 4, 6);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.PasswordChar = '^';
            PasswordTb.PlaceholderText = "";
            PasswordTb.SelectedText = "";
            PasswordTb.ShadowDecoration.CustomizableEdges = customizableEdges4;
            PasswordTb.Size = new Size(518, 93);
            PasswordTb.TabIndex = 5;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.GradientActiveCaption;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.ForeColor = SystemColors.ActiveCaptionText;
            LoginBtn.Location = new Point(599, 399);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(122, 44);
            LoginBtn.TabIndex = 7;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += button1_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(882, 472);
            Controls.Add(LoginBtn);
            Controls.Add(label3);
            Controls.Add(PasswordTb);
            Controls.Add(label2);
            Controls.Add(UnameTb);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox UnameTb;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTb;
        private Button LoginBtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
