namespace Developer
{
    partial class Screen_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen_Login));
            txtpassword = new TextBox();
            txtusername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            chshowpassword = new CheckBox();
            label3 = new Label();
            btnexit = new Button();
            btnresize = new Button();
            button2 = new Button();
<<<<<<< HEAD
            btnminimized = new Button();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            button3 = new Button();
            label7 = new Label();
            lblaccount = new Label();
            pnlload = new Panel();
            lblloginhere = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
=======
            btnminisize = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            btnlogin = new Button();
            label6 = new Label();
            label7 = new Label();
            pnlmove = new Panel();
            pnlload = new Panel();
>>>>>>> 63add42f44987fddc114424c8c0141ae242c2ff9
            pnlload.SuspendLayout();
            SuspendLayout();
            // 
            // txtpassword
            // 
            txtpassword.BackColor = SystemColors.Menu;
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Cursor = Cursors.IBeam;
<<<<<<< HEAD
            txtpassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.Location = new Point(76, 183);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '•';
            txtpassword.Size = new Size(233, 31);
=======
            txtpassword.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            txtpassword.Location = new Point(57, 128);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '•';
            txtpassword.Size = new Size(253, 36);
>>>>>>> 63add42f44987fddc114424c8c0141ae242c2ff9
            txtpassword.TabIndex = 2;
            // 
            // txtusername
            // 
            txtusername.BackColor = SystemColors.Menu;
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Cursor = Cursors.IBeam;
<<<<<<< HEAD
            txtusername.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(76, 110);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(233, 31);
=======
            txtusername.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            txtusername.Location = new Point(57, 55);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(253, 36);
>>>>>>> 63add42f44987fddc114424c8c0141ae242c2ff9
            txtusername.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
<<<<<<< HEAD
            label1.Location = new Point(76, 87);
=======
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(57, 32);
>>>>>>> 63add42f44987fddc114424c8c0141ae242c2ff9
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
<<<<<<< HEAD
            label2.Location = new Point(76, 160);
=======
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(57, 105);
>>>>>>> 63add42f44987fddc114424c8c0141ae242c2ff9
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // chshowpassword
            // 
            chshowpassword.AutoSize = true;
            chshowpassword.Cursor = Cursors.Hand;
<<<<<<< HEAD
            chshowpassword.Location = new Point(177, 230);
=======
            chshowpassword.Location = new Point(178, 181);
>>>>>>> 63add42f44987fddc114424c8c0141ae242c2ff9
            chshowpassword.Name = "chshowpassword";
            chshowpassword.Size = new Size(132, 24);
            chshowpassword.TabIndex = 6;
            chshowpassword.Text = "Show Password";
            chshowpassword.UseVisualStyleBackColor = true;
            chshowpassword.CheckedChanged += chshowpassword_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
<<<<<<< HEAD
            label3.Location = new Point(946, 83);
=======
            label3.Location = new Point(824, 35);
>>>>>>> 63add42f44987fddc114424c8c0141ae242c2ff9
            label3.Name = "label3";
            label3.Size = new Size(270, 62);
            label3.TabIndex = 7;
            label3.Text = "Get Started";
            // 
            // btnexit
            // 
            btnexit.BackgroundImage = (Image)resources.GetObject("btnexit.BackgroundImage");
            btnexit.BackgroundImageLayout = ImageLayout.Stretch;
            btnexit.Cursor = Cursors.Hand;
            btnexit.FlatAppearance.BorderSize = 0;
            btnexit.FlatStyle = FlatStyle.Flat;
<<<<<<< HEAD
            btnexit.Location = new Point(1274, 12);
=======
            btnexit.Location = new Point(1206, 12);
>>>>>>> 63add42f44987fddc114424c8c0141ae242c2ff9
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(20, 20);
            btnexit.TabIndex = 0;
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // btnresize
            // 
            btnresize.BackgroundImage = (Image)resources.GetObject("btnresize.BackgroundImage");
            btnresize.BackgroundImageLayout = ImageLayout.Stretch;
            btnresize.Cursor = Cursors.Hand;
            btnresize.FlatAppearance.BorderSize = 0;
            btnresize.FlatStyle = FlatStyle.Flat;
<<<<<<< HEAD
            btnresize.Location = new Point(1248, 12);
=======
            btnresize.Location = new Point(1180, 12);
>>>>>>> 63add42f44987fddc114424c8c0141ae242c2ff9
            btnresize.Name = "btnresize";
            btnresize.Size = new Size(20, 20);
            btnresize.TabIndex = 10;
            btnresize.UseVisualStyleBackColor = true;
            btnresize.Click += btnresize_Click;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
<<<<<<< HEAD
            button2.Location = new Point(1222, 12);
=======
            button2.Location = new Point(1154, 12);
>>>>>>> 63add42f44987fddc114424c8c0141ae242c2ff9
            button2.Name = "button2";
            button2.Size = new Size(20, 20);
            button2.TabIndex = 11;
            button2.UseVisualStyleBackColor = true;
            // 
<<<<<<< HEAD
            // btnminimized
            // 
            btnminimized.BackgroundImage = (Image)resources.GetObject("btnminimized.BackgroundImage");
            btnminimized.BackgroundImageLayout = ImageLayout.Stretch;
            btnminimized.Cursor = Cursors.Hand;
            btnminimized.FlatAppearance.BorderSize = 0;
            btnminimized.FlatStyle = FlatStyle.Flat;
            btnminimized.Location = new Point(1222, 12);
            btnminimized.Name = "btnminimized";
            btnminimized.Size = new Size(20, 20);
            btnminimized.TabIndex = 12;
            btnminimized.UseVisualStyleBackColor = true;
            btnminimized.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(6, 90, 215);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(845, 837);
            panel1.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 18F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(68, 717);
            label6.Name = "label6";
            label6.Size = new Size(438, 34);
            label6.TabIndex = 18;
            label6.Text = " the Csharp programming language.";
=======
            // btnminisize
            // 
            btnminisize.BackgroundImage = (Image)resources.GetObject("btnminisize.BackgroundImage");
            btnminisize.BackgroundImageLayout = ImageLayout.Stretch;
            btnminisize.FlatAppearance.BorderSize = 0;
            btnminisize.FlatStyle = FlatStyle.Flat;
            btnminisize.Location = new Point(1154, 12);
            btnminisize.Name = "btnminisize";
            btnminisize.Size = new Size(20, 20);
            btnminisize.TabIndex = 12;
            btnminisize.UseVisualStyleBackColor = true;
            btnminisize.Click += btnminisize_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(689, 671);
            panel1.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = SystemColors.WindowFrame;
            label4.Location = new Point(838, 133);
            label4.Name = "label4";
            label4.Size = new Size(226, 20);
            label4.TabIndex = 16;
            label4.Text = "Welcome to my project platform";
>>>>>>> 63add42f44987fddc114424c8c0141ae242c2ff9
            // 
            // label5
            // 
            label5.AutoSize = true;
<<<<<<< HEAD
            label5.Font = new Font("Times New Roman", 18F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(72, 676);
            label5.Name = "label5";
            label5.Size = new Size(546, 34);
            label5.TabIndex = 17;
            label5.Text = "The purpose of this project is for me to learn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(68, 572);
            label4.Name = "label4";
            label4.Size = new Size(541, 59);
            label4.TabIndex = 16;
            label4.Text = "Welcome to my Project";
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(6, 90, 215);
            button3.Location = new Point(76, 467);
            button3.Name = "button3";
            button3.Size = new Size(253, 44);
            button3.TabIndex = 16;
            button3.Text = "LOGIN";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
=======
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = SystemColors.WindowFrame;
            label5.Location = new Point(838, 151);
            label5.Name = "label5";
            label5.Size = new Size(238, 20);
            label5.TabIndex = 17;
            label5.Text = "register as a menber to experience";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.DarkSlateBlue;
            btnlogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(57, 323);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(253, 46);
            btnlogin.TabIndex = 18;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(851, 209);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 19;
            label6.Text = "Login";
            label6.Click += label6_Click;
>>>>>>> 63add42f44987fddc114424c8c0141ae242c2ff9
            // 
            // label7
            // 
            label7.AutoSize = true;
<<<<<<< HEAD
            label7.Location = new Point(1009, 791);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 17;
            label7.Text = "Don't have an ";
            // 
            // lblaccount
            // 
            lblaccount.AutoSize = true;
            lblaccount.Cursor = Cursors.Hand;
            lblaccount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblaccount.ForeColor = Color.FromArgb(6, 90, 215);
            lblaccount.Location = new Point(1104, 791);
            lblaccount.Name = "lblaccount";
            lblaccount.Size = new Size(72, 20);
            lblaccount.TabIndex = 18;
            lblaccount.Text = "Account?";
            lblaccount.Click += label8_Click;
            // 
            // pnlload
            // 
            pnlload.Controls.Add(button3);
=======
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(1030, 209);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 20;
            label7.Text = "Register";
            label7.Click += label7_Click;
            // 
            // pnlmove
            // 
            pnlmove.BackColor = Color.DarkSlateBlue;
            pnlmove.Location = new Point(813, 232);
            pnlmove.Name = "pnlmove";
            pnlmove.Size = new Size(144, 10);
            pnlmove.TabIndex = 22;
            // 
            // pnlload
            // 
            pnlload.Controls.Add(btnlogin);
>>>>>>> 63add42f44987fddc114424c8c0141ae242c2ff9
            pnlload.Controls.Add(chshowpassword);
            pnlload.Controls.Add(label2);
            pnlload.Controls.Add(label1);
            pnlload.Controls.Add(txtusername);
            pnlload.Controls.Add(txtpassword);
<<<<<<< HEAD
            pnlload.Location = new Point(887, 206);
            pnlload.Name = "pnlload";
            pnlload.Size = new Size(392, 582);
            pnlload.TabIndex = 19;
            pnlload.Paint += pnlload_Paint;
            // 
            // lblloginhere
            // 
            lblloginhere.AutoSize = true;
            lblloginhere.Cursor = Cursors.Hand;
            lblloginhere.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblloginhere.ForeColor = Color.FromArgb(6, 90, 215);
            lblloginhere.Location = new Point(1109, 791);
            lblloginhere.Name = "lblloginhere";
            lblloginhere.Size = new Size(89, 20);
            lblloginhere.TabIndex = 26;
            lblloginhere.Text = "Login here?";
            lblloginhere.Visible = false;
            lblloginhere.Click += lblloginhere1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(986, 791);
            label9.Name = "label9";
            label9.Size = new Size(127, 20);
            label9.TabIndex = 25;
            label9.Text = "Already a menber";
            label9.Visible = false;
=======
            pnlload.Location = new Point(784, 260);
            pnlload.Name = "pnlload";
            pnlload.Size = new Size(376, 402);
            pnlload.TabIndex = 23;
            pnlload.Paint += pnlload_Paint;
>>>>>>> 63add42f44987fddc114424c8c0141ae242c2ff9
            // 
            // Screen_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
<<<<<<< HEAD
            ClientSize = new Size(1323, 829);
            Controls.Add(lblloginhere);
            Controls.Add(lblaccount);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(pnlload);
            Controls.Add(panel1);
            Controls.Add(btnminimized);
=======
            ClientSize = new Size(1251, 672);
            Controls.Add(pnlload);
            Controls.Add(pnlmove);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(btnminisize);
>>>>>>> 63add42f44987fddc114424c8c0141ae242c2ff9
            Controls.Add(button2);
            Controls.Add(btnresize);
            Controls.Add(btnexit);
            Controls.Add(label3);
<<<<<<< HEAD
=======
            Cursor = Cursors.Hand;
>>>>>>> 63add42f44987fddc114424c8c0141ae242c2ff9
            FormBorderStyle = FormBorderStyle.None;
            Name = "Screen_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Screen Login";
            Load += Screen_Login_Load_1;
<<<<<<< HEAD
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
=======
>>>>>>> 63add42f44987fddc114424c8c0141ae242c2ff9
            pnlload.ResumeLayout(false);
            pnlload.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtpassword;
        private TextBox txtusername;
        private Label label1;
        private Label label2;
        private CheckBox chshowpassword;
        private Label label3;
        private Button btnexit;
        private Button btnminimize;
        private Button btnresize;
        private Button button2;
<<<<<<< HEAD
        private Button btnminimized;
        private Panel panel1;
        private Label label4;
        private Label label6;
        private Label label5;
        private Button button3;
        private Label label7;
        private Label lblaccount;
        private Panel pnlload;
        private Label lblloginhere;
        private Label label9;
=======
        private Button btnminisize;
        private Panel panel1;
        private Label label4;
        private Label label5;
        private Button btnlogin;
        private Label label6;
        private Label label7;
        private Panel pnlregister;
        private Panel pnlmove;
        private Panel pnlload;
>>>>>>> 63add42f44987fddc114424c8c0141ae242c2ff9
    }
}
