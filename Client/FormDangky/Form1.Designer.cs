namespace FormDangky
{
    partial class Dangky
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
            this.f = new System.Windows.Forms.Label();
            this.lll = new System.Windows.Forms.Label();
            this.ff = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNhaplai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Location = new System.Drawing.Point(12, 51);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(53, 13);
            this.f.TabIndex = 0;
            this.f.Text = "Password";
            // 
            // lll
            // 
            this.lll.AutoSize = true;
            this.lll.Location = new System.Drawing.Point(12, 23);
            this.lll.Name = "lll";
            this.lll.Size = new System.Drawing.Size(58, 13);
            this.lll.TabIndex = 1;
            this.lll.Text = "User name";
            // 
            // ff
            // 
            this.ff.AutoSize = true;
            this.ff.Location = new System.Drawing.Point(12, 113);
            this.ff.Name = "ff";
            this.ff.Size = new System.Drawing.Size(52, 13);
            this.ff.TabIndex = 2;
            this.ff.Text = "Full name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(114, 48);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(126, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(114, 113);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(126, 20);
            this.txtTen.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(114, 151);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(126, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(114, 186);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(126, 20);
            this.txtPhone.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(114, 22);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(126, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sign up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNhaplai
            // 
            this.txtNhaplai.Location = new System.Drawing.Point(114, 77);
            this.txtNhaplai.Name = "txtNhaplai";
            this.txtNhaplai.PasswordChar = '*';
            this.txtNhaplai.Size = new System.Drawing.Size(126, 20);
            this.txtNhaplai.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nhập lại mật khẩu";
            // 
            // Dangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 288);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNhaplai);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ff);
            this.Controls.Add(this.lll);
            this.Controls.Add(this.f);
            this.Name = "Dangky";
            this.Text = "Đăng ký";
            this.Load += new System.EventHandler(this.Dangky_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label f;
        private System.Windows.Forms.Label lll;
        private System.Windows.Forms.Label ff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhaplai;
    }
}

