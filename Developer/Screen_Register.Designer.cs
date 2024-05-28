namespace Developer
{
    partial class Screen_Register
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
<<<<<<< HEAD
            pnlloadR = new Panel();
            label5 = new Label();
            txtfirstname = new TextBox();
            label4 = new Label();
            txtlastname = new TextBox();
            label3 = new Label();
            txtusernameR = new TextBox();
            btnsave = new Button();
            chshowpasswordR = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            txtemail = new TextBox();
            txtpasswordR = new TextBox();
            pnlloadR.SuspendLayout();
            SuspendLayout();
            // 
            // pnlloadR
            // 
            pnlloadR.BackColor = Color.White;
            pnlloadR.Controls.Add(label5);
            pnlloadR.Controls.Add(txtfirstname);
            pnlloadR.Controls.Add(label4);
            pnlloadR.Controls.Add(txtlastname);
            pnlloadR.Controls.Add(label3);
            pnlloadR.Controls.Add(txtusernameR);
            pnlloadR.Controls.Add(btnsave);
            pnlloadR.Controls.Add(chshowpasswordR);
            pnlloadR.Controls.Add(label2);
            pnlloadR.Controls.Add(label1);
            pnlloadR.Controls.Add(txtemail);
            pnlloadR.Controls.Add(txtpasswordR);
            pnlloadR.Location = new Point(-1, -1);
            pnlloadR.Name = "pnlloadR";
            pnlloadR.Size = new Size(392, 582);
            pnlloadR.TabIndex = 20;
            pnlloadR.Paint += pnlloadR_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 21);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 22;
            label5.Text = "First Name";
            // 
            // txtfirstname
            // 
            txtfirstname.BackColor = SystemColors.Menu;
            txtfirstname.BorderStyle = BorderStyle.None;
            txtfirstname.Cursor = Cursors.IBeam;
            txtfirstname.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtfirstname.Location = new Point(76, 44);
            txtfirstname.Name = "txtfirstname";
            txtfirstname.Size = new Size(233, 31);
            txtfirstname.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 88);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 20;
            label4.Text = "Last Name";
            // 
            // txtlastname
            // 
            txtlastname.BackColor = SystemColors.Menu;
            txtlastname.BorderStyle = BorderStyle.None;
            txtlastname.Cursor = Cursors.IBeam;
            txtlastname.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtlastname.Location = new Point(76, 111);
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(233, 31);
            txtlastname.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 156);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 18;
            label3.Text = "Username";
            // 
            // txtusernameR
            // 
            txtusernameR.BackColor = SystemColors.Menu;
            txtusernameR.BorderStyle = BorderStyle.None;
            txtusernameR.Cursor = Cursors.IBeam;
            txtusernameR.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusernameR.Location = new Point(76, 184);
            txtusernameR.Name = "txtusernameR";
            txtusernameR.Size = new Size(233, 31);
            txtusernameR.TabIndex = 17;
            // 
            // btnsave
            // 
            btnsave.Cursor = Cursors.Hand;
            btnsave.FlatAppearance.BorderSize = 2;
            btnsave.FlatStyle = FlatStyle.Flat;
            btnsave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsave.ForeColor = Color.FromArgb(6, 90, 215);
            btnsave.Location = new Point(76, 484);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(253, 44);
            btnsave.TabIndex = 16;
            btnsave.Text = "SAVE";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // chshowpasswordR
            // 
            chshowpasswordR.AutoSize = true;
            chshowpasswordR.Cursor = Cursors.Hand;
            chshowpasswordR.Location = new Point(177, 372);
            chshowpasswordR.Name = "chshowpasswordR";
            chshowpasswordR.Size = new Size(132, 24);
            chshowpasswordR.TabIndex = 6;
            chshowpasswordR.Text = "Show Password";
            chshowpasswordR.UseVisualStyleBackColor = true;
            chshowpasswordR.CheckedChanged += chshowpasswordR_CheckedChanged;
=======
            btnlogin = new Button();
            chshowpassword = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.DarkSlateBlue;
            btnlogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(68, 356);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(253, 46);
            btnlogin.TabIndex = 24;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = false;
            // 
            // chshowpassword
            // 
            chshowpassword.AutoSize = true;
            chshowpassword.Cursor = Cursors.Hand;
            chshowpassword.Location = new Point(189, 299);
            chshowpassword.Name = "chshowpassword";
            chshowpassword.Size = new Size(132, 24);
            chshowpassword.TabIndex = 23;
            chshowpassword.Text = "Show Password";
            chshowpassword.UseVisualStyleBackColor = true;
>>>>>>> 63add42f44987fddc114424c8c0141ae242c2ff9
            // 
            // label2
            // 
            label2.AutoSize = true;
<<<<<<< HEAD
            label2.Location = new Point(76, 302);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
=======
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(68, 223);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 22;
>>>>>>> 63add42f44987fddc114424c8c0141ae242c2ff9
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
<<<<<<< HEAD
            label1.Location = new Point(76, 236);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 4;
            label1.Text = "Email";
            // 
            // txtemail
            // 
            txtemail.BackColor = SystemColors.Menu;
            txtemail.BorderStyle = BorderStyle.None;
            txtemail.Cursor = Cursors.IBeam;
            txtemail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtemail.Location = new Point(76, 259);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(233, 31);
            txtemail.TabIndex = 3;
            // 
            // txtpasswordR
            // 
            txtpasswordR.BackColor = SystemColors.Menu;
            txtpasswordR.BorderStyle = BorderStyle.None;
            txtpasswordR.Cursor = Cursors.IBeam;
            txtpasswordR.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpasswordR.Location = new Point(76, 325);
            txtpasswordR.Name = "txtpasswordR";
            txtpasswordR.PasswordChar = '•';
            txtpasswordR.Size = new Size(233, 31);
            txtpasswordR.TabIndex = 2;
=======
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(68, 150);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 21;
            label1.Text = "Email";
            // 
            // txtusername
            // 
            txtusername.BackColor = SystemColors.Menu;
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Cursor = Cursors.IBeam;
            txtusername.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            txtusername.Location = new Point(68, 173);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(253, 36);
            txtusername.TabIndex = 20;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = SystemColors.Menu;
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Cursor = Cursors.IBeam;
            txtpassword.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            txtpassword.Location = new Point(68, 246);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '•';
            txtpassword.Size = new Size(253, 36);
            txtpassword.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(68, 78);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 26;
            label3.Text = "Last name";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            textBox1.Location = new Point(68, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 36);
            textBox1.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(68, 6);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 28;
            label4.Text = "Fist name";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Menu;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            textBox2.Location = new Point(68, 29);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(253, 36);
            textBox2.TabIndex = 27;
>>>>>>> 63add42f44987fddc114424c8c0141ae242c2ff9
            // 
            // Screen_Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
<<<<<<< HEAD
            ClientSize = new Size(390, 581);
            Controls.Add(pnlloadR);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Screen_Register";
            Text = "Screen_Register";
            pnlloadR.ResumeLayout(false);
            pnlloadR.PerformLayout();
            ResumeLayout(false);
=======
            ClientSize = new Size(376, 402);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(btnlogin);
            Controls.Add(chshowpassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtusername);
            Controls.Add(txtpassword);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Screen_Register";
            Text = "Screen_Register";
            ResumeLayout(false);
            PerformLayout();
>>>>>>> 63add42f44987fddc114424c8c0141ae242c2ff9
        }

        #endregion

<<<<<<< HEAD
        private Panel pnlloadR;
        private Button btnsave;
        private CheckBox chshowpasswordR;
        private Label label2;
        private Label label1;
        private TextBox txtemail;
        private TextBox txtpasswordR;
        private Label label5;
        private TextBox txtfirstname;
        private Label label4;
        private TextBox txtlastname;
        private Label label3;
        private TextBox txtusernameR;
=======
        private Button btnlogin;
        private CheckBox chshowpassword;
        private Label label2;
        private Label label1;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
>>>>>>> 63add42f44987fddc114424c8c0141ae242c2ff9
    }
}