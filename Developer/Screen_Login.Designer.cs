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
            btncalculator = new Button();
            btnexit = new Button();
            btnresize = new Button();
            button2 = new Button();
            button1 = new Button();
            rjButton1 = new Customized_Controls.RJButton();
            rjButton2 = new Customized_Controls.RJButton();
            SuspendLayout();
            // 
            // txtpassword
            // 
            txtpassword.BackColor = SystemColors.Menu;
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Cursor = Cursors.IBeam;
            txtpassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.Location = new Point(88, 325);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '•';
            txtpassword.Size = new Size(253, 27);
            txtpassword.TabIndex = 2;
            // 
            // txtusername
            // 
            txtusername.BackColor = SystemColors.Menu;
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Cursor = Cursors.IBeam;
            txtusername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(88, 252);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(253, 27);
            txtusername.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 229);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 302);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // chshowpassword
            // 
            chshowpassword.AutoSize = true;
            chshowpassword.Cursor = Cursors.Hand;
            chshowpassword.Location = new Point(221, 375);
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
            label3.Location = new Point(79, 89);
            label3.Name = "label3";
            label3.Size = new Size(270, 62);
            label3.TabIndex = 7;
            label3.Text = "Get Started";
            // 
            // btncalculator
            // 
            btncalculator.Cursor = Cursors.Hand;
            btncalculator.Location = new Point(27, 460);
            btncalculator.Name = "btncalculator";
            btncalculator.Size = new Size(46, 41);
            btncalculator.TabIndex = 9;
            btncalculator.Text = "∟";
            btncalculator.UseVisualStyleBackColor = true;
            btncalculator.Click += btncalculator_Click;
            // 
            // btnexit
            // 
            btnexit.BackgroundImage = (Image)resources.GetObject("btnexit.BackgroundImage");
            btnexit.BackgroundImageLayout = ImageLayout.Stretch;
            btnexit.FlatAppearance.BorderSize = 0;
            btnexit.FlatStyle = FlatStyle.Flat;
            btnexit.Location = new Point(381, 12);
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
            btnresize.Location = new Point(355, 12);
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
            button2.Location = new Point(329, 12);
            button2.Name = "button2";
            button2.Size = new Size(20, 20);
            button2.TabIndex = 11;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(329, 12);
            button1.Name = "button1";
            button1.Size = new Size(20, 20);
            button1.TabIndex = 12;
            button1.UseVisualStyleBackColor = true;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.White;
            rjButton1.BackgroundColor = Color.White;
            rjButton1.BorderColor = Color.Red;
            rjButton1.BorderRadius = 15;
            rjButton1.BorderSize = 3;
            rjButton1.FlatAppearance.BorderSize = 2;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjButton1.ForeColor = Color.Red;
            rjButton1.Location = new Point(97, 649);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(206, 46);
            rjButton1.TabIndex = 13;
            rjButton1.Text = "SING IN";
            rjButton1.TextColor = Color.Red;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.LimeGreen;
            rjButton2.BackgroundColor = Color.LimeGreen;
            rjButton2.BorderColor = Color.LimeGreen;
            rjButton2.BorderRadius = 15;
            rjButton2.BorderSize = 3;
            rjButton2.FlatAppearance.BorderSize = 2;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rjButton2.ForeColor = Color.White;
            rjButton2.Location = new Point(97, 581);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(206, 46);
            rjButton2.TabIndex = 14;
            rjButton2.Text = "LOGIN";
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            // 
            // Screen_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(425, 740);
            Controls.Add(rjButton2);
            Controls.Add(rjButton1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(btnresize);
            Controls.Add(btnexit);
            Controls.Add(btncalculator);
            Controls.Add(label3);
            Controls.Add(chshowpassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtusername);
            Controls.Add(txtpassword);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Screen_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Screen Login";
            Load += Screen_Login_Load_1;
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
        private Button btncalculator;
        private Button btnexit;
        private Button btnminimize;
        private Button btnresize;
        private Button button2;
        private Button button1;
        private Customized_Controls.RJButton rjButton1;
        private Customized_Controls.RJButton rjButton2;
    }
}
