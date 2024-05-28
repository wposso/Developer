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
            btnminisize = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            btnlogin = new Button();
            label6 = new Label();
            label7 = new Label();
            pnlmove = new Panel();
            pnlload = new Panel();
            pnlload.SuspendLayout();
            SuspendLayout();
            // 
            // txtpassword
            // 
            txtpassword.BackColor = SystemColors.Menu;
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Cursor = Cursors.IBeam;
            txtpassword.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            txtpassword.Location = new Point(57, 128);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '•';
            txtpassword.Size = new Size(253, 36);
            txtpassword.TabIndex = 2;
            // 
            // txtusername
            // 
            txtusername.BackColor = SystemColors.Menu;
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Cursor = Cursors.IBeam;
            txtusername.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            txtusername.Location = new Point(57, 55);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(253, 36);
            txtusername.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(57, 32);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(57, 105);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // chshowpassword
            // 
            chshowpassword.AutoSize = true;
            chshowpassword.Cursor = Cursors.Hand;
            chshowpassword.Location = new Point(178, 181);
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
            label3.Location = new Point(824, 35);
            label3.Name = "label3";
            label3.Size = new Size(270, 62);
            label3.TabIndex = 7;
            label3.Text = "Get Started";
            // 
            // btnexit
            // 
            btnexit.BackgroundImage = (Image)resources.GetObject("btnexit.BackgroundImage");
            btnexit.BackgroundImageLayout = ImageLayout.Stretch;
            btnexit.FlatAppearance.BorderSize = 0;
            btnexit.FlatStyle = FlatStyle.Flat;
            btnexit.Location = new Point(1206, 12);
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
            btnresize.FlatAppearance.BorderSize = 0;
            btnresize.FlatStyle = FlatStyle.Flat;
            btnresize.Location = new Point(1180, 12);
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
            button2.Location = new Point(1154, 12);
            button2.Name = "button2";
            button2.Size = new Size(20, 20);
            button2.TabIndex = 11;
            button2.UseVisualStyleBackColor = true;
            // 
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
            // 
            // label5
            // 
            label5.AutoSize = true;
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
            // 
            // label7
            // 
            label7.AutoSize = true;
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
            pnlload.Controls.Add(chshowpassword);
            pnlload.Controls.Add(label2);
            pnlload.Controls.Add(label1);
            pnlload.Controls.Add(txtusername);
            pnlload.Controls.Add(txtpassword);
            pnlload.Location = new Point(784, 260);
            pnlload.Name = "pnlload";
            pnlload.Size = new Size(376, 402);
            pnlload.TabIndex = 23;
            pnlload.Paint += pnlload_Paint;
            // 
            // Screen_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1251, 672);
            Controls.Add(pnlload);
            Controls.Add(pnlmove);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(btnminisize);
            Controls.Add(button2);
            Controls.Add(btnresize);
            Controls.Add(btnexit);
            Controls.Add(label3);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Screen_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Screen Login";
            Load += Screen_Login_Load_1;
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
    }
}
