
namespace project1
{
    partial class Controls
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
            this.banpanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnadmin = new System.Windows.Forms.Button();
            this.btnban = new System.Windows.Forms.Button();
            this.Adminpanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.banpanel.SuspendLayout();
            this.Adminpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // banpanel
            // 
            this.banpanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.banpanel.Controls.Add(this.button1);
            this.banpanel.Location = new System.Drawing.Point(9, 59);
            this.banpanel.Name = "banpanel";
            this.banpanel.Size = new System.Drawing.Size(267, 249);
            this.banpanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Admin";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnadmin
            // 
            this.btnadmin.Location = new System.Drawing.Point(89, 30);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(75, 23);
            this.btnadmin.TabIndex = 1;
            this.btnadmin.Text = "Admin";
            this.btnadmin.UseVisualStyleBackColor = true;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // btnban
            // 
            this.btnban.Location = new System.Drawing.Point(310, 30);
            this.btnban.Name = "btnban";
            this.btnban.Size = new System.Drawing.Size(75, 23);
            this.btnban.TabIndex = 2;
            this.btnban.Text = "BanUser";
            this.btnban.UseVisualStyleBackColor = true;
            this.btnban.Click += new System.EventHandler(this.btnban_Click);
            // 
            // Adminpanel
            // 
            this.Adminpanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Adminpanel.Controls.Add(this.button2);
            this.Adminpanel.Location = new System.Drawing.Point(9, 59);
            this.Adminpanel.Name = "Adminpanel";
            this.Adminpanel.Size = new System.Drawing.Size(267, 249);
            this.Adminpanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(9, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 249);
            this.panel1.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(83, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "rsst";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Admin";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 398);
            this.Controls.Add(this.banpanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Adminpanel);
            this.Controls.Add(this.btnban);
            this.Controls.Add(this.btnadmin);
            this.Name = "Controls";
            this.Text = "Controls";
            this.Load += new System.EventHandler(this.Controls_Load);
            this.banpanel.ResumeLayout(false);
            this.Adminpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel banpanel;
        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.Button btnban;
        private System.Windows.Forms.Panel Adminpanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
    }
}