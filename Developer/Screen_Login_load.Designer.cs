namespace Developer
{
    partial class Screen_Login_load
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
            pnlload = new Panel();
            button3 = new Button();
            chshowpassword = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            pnlload.SuspendLayout();
            SuspendLayout();
            // 
            // pnlload
            // 
            pnlload.BackColor = Color.White;
            pnlload.Controls.Add(button3);
            pnlload.Controls.Add(chshowpassword);
            pnlload.Controls.Add(label2);
            pnlload.Controls.Add(label1);
            pnlload.Controls.Add(txtusername);
            pnlload.Controls.Add(txtpassword);
            pnlload.Location = new Point(-1, -1);
            pnlload.Name = "pnlload";
            pnlload.Size = new Size(392, 582);
            pnlload.TabIndex = 20;
            pnlload.Paint += pnlload_Paint;
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
            // 
            // chshowpassword
            // 
            chshowpassword.AutoSize = true;
            chshowpassword.Cursor = Cursors.Hand;
            chshowpassword.Location = new Point(177, 230);
            chshowpassword.Name = "chshowpassword";
            chshowpassword.Size = new Size(132, 24);
            chshowpassword.TabIndex = 6;
            chshowpassword.Text = "Show Password";
            chshowpassword.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 160);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 87);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // txtusername
            // 
            txtusername.BackColor = SystemColors.Menu;
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Cursor = Cursors.IBeam;
            txtusername.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(76, 110);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(233, 31);
            txtusername.TabIndex = 3;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = SystemColors.Menu;
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Cursor = Cursors.IBeam;
            txtpassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.Location = new Point(76, 183);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '•';
            txtpassword.Size = new Size(233, 31);
            txtpassword.TabIndex = 2;
            // 
            // Screen_Login_load
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(389, 581);
            Controls.Add(pnlload);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Screen_Login_load";
            Text = "Screen_Login_load";
            pnlload.ResumeLayout(false);
            pnlload.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlload;
        private Button button3;
        private CheckBox chshowpassword;
        private Label label2;
        private Label label1;
        private TextBox txtusername;
        private TextBox txtpassword;
    }
}