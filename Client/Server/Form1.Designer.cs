namespace Server
{
    partial class FormServer
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
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMess = new System.Windows.Forms.TextBox();
            this.lsvMess = new System.Windows.Forms.ListView();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(491, 375);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMess
            // 
            this.txtMess.Location = new System.Drawing.Point(21, 375);
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(451, 20);
            this.txtMess.TabIndex = 4;
            // 
            // lsvMess
            // 
            this.lsvMess.Location = new System.Drawing.Point(24, 40);
            this.lsvMess.Name = "lsvMess";
            this.lsvMess.Size = new System.Drawing.Size(552, 314);
            this.lsvMess.TabIndex = 3;
            this.lsvMess.UseCompatibleStateImageBehavior = false;
            this.lsvMess.View = System.Windows.Forms.View.List;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(24, 3);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(110, 31);
            this.btnAddClient.TabIndex = 6;
            this.btnAddClient.Text = "Add more client..";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 439);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.lsvMess);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMess);
            this.Name = "FormServer";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.FormServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMess;
        private System.Windows.Forms.ListView lsvMess;
        private System.Windows.Forms.Button btnAddClient;
    }
}

