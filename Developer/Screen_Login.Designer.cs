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
            btnlogin = new Button();
            btnsingin = new Button();
            txtpassword = new TextBox();
            txtusername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            chshowpassword = new CheckBox();
            label3 = new Label();
            pnlheader = new Panel();
            btnminimize = new Button();
            btnexit = new Button();
            pnlheader.SuspendLayout();
            SuspendLayout();
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.LimeGreen;
            btnlogin.Cursor = Cursors.Hand;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(79, 580);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(265, 44);
            btnlogin.TabIndex = 0;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += button1_Click;
            // 
            // btnsingin
            // 
            btnsingin.Cursor = Cursors.Hand;
            btnsingin.FlatAppearance.BorderSize = 2;
            btnsingin.FlatStyle = FlatStyle.Flat;
            btnsingin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsingin.ForeColor = Color.Red;
            btnsingin.Location = new Point(79, 640);
            btnsingin.Name = "btnsingin";
            btnsingin.Size = new Size(265, 44);
            btnsingin.TabIndex = 1;
            btnsingin.Text = "SING IN";
            btnsingin.UseVisualStyleBackColor = true;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = SystemColors.ScrollBar;
            txtpassword.Cursor = Cursors.IBeam;
            txtpassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.Location = new Point(79, 323);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '•';
            txtpassword.Size = new Size(265, 34);
            txtpassword.TabIndex = 2;
            // 
            // txtusername
            // 
            txtusername.BackColor = SystemColors.ScrollBar;
            txtusername.Cursor = Cursors.IBeam;
            txtusername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(79, 250);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(265, 34);
            txtusername.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 227);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 300);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // chshowpassword
            // 
            chshowpassword.AutoSize = true;
            chshowpassword.Cursor = Cursors.Hand;
            chshowpassword.Location = new Point(212, 373);
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
            // pnlheader
            // 
            pnlheader.BackColor = Color.LimeGreen;
            pnlheader.Controls.Add(btnminimize);
            pnlheader.Controls.Add(btnexit);
            pnlheader.Location = new Point(-24, -6);
            pnlheader.Name = "pnlheader";
            pnlheader.Size = new Size(455, 54);
            pnlheader.TabIndex = 8;
            // 
            // btnminimize
            // 
            btnminimize.BackgroundImage = (Image)resources.GetObject("btnminimize.BackgroundImage");
            btnminimize.BackgroundImageLayout = ImageLayout.Stretch;
            btnminimize.FlatAppearance.BorderSize = 0;
            btnminimize.FlatStyle = FlatStyle.Flat;
            btnminimize.Location = new Point(367, 18);
            btnminimize.Name = "btnminimize";
            btnminimize.Size = new Size(31, 24);
            btnminimize.TabIndex = 1;
            btnminimize.UseVisualStyleBackColor = true;
            btnminimize.Click += btnminimize_Click;
            // 
            // btnexit
            // 
            btnexit.BackgroundImage = (Image)resources.GetObject("btnexit.BackgroundImage");
            btnexit.BackgroundImageLayout = ImageLayout.Stretch;
            btnexit.FlatAppearance.BorderSize = 0;
            btnexit.FlatStyle = FlatStyle.Flat;
            btnexit.Location = new Point(404, 18);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(31, 24);
            btnexit.TabIndex = 0;
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // Screen_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(423, 740);
            Controls.Add(pnlheader);
            Controls.Add(label3);
            Controls.Add(chshowpassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtusername);
            Controls.Add(txtpassword);
            Controls.Add(btnsingin);
            Controls.Add(btnlogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Screen_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Screen Login";
            pnlheader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnlogin;
        private Button btnsingin;
        private TextBox txtpassword;
        private TextBox txtusername;
        private Label label1;
        private Label label2;
        private CheckBox chshowpassword;
        private Label label3;
        private Panel pnlheader;
        private Button btnminimize;
        private Button btnexit;
    }
}
