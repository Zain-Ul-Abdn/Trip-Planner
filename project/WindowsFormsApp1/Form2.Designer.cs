
namespace WindowsFormsApp1
{
    partial class Login_Form
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.signupBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.Login_pan = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.signup_Pan = new System.Windows.Forms.Panel();
            this.txt_conPass = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.signup_btn = new System.Windows.Forms.Button();
            this.EP_name = new System.Windows.Forms.ErrorProvider(this.components);
            this.loginError = new System.Windows.Forms.ErrorProvider(this.components);
            this.Back_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Login_pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.signup_Pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EP_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginError)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.signupBtn);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 66);
            this.panel1.TabIndex = 2;
            // 
            // signupBtn
            // 
            this.signupBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.signupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signupBtn.FlatAppearance.BorderSize = 0;
            this.signupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupBtn.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupBtn.ForeColor = System.Drawing.Color.White;
            this.signupBtn.Location = new System.Drawing.Point(305, 0);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(300, 64);
            this.signupBtn.TabIndex = 1;
            this.signupBtn.Text = "SIGNUP";
            this.signupBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.signupBtn.UseVisualStyleBackColor = false;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(3, 0);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(300, 64);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // Login_pan
            // 
            this.Login_pan.Controls.Add(this.Back_btn);
            this.Login_pan.Controls.Add(this.pictureBox2);
            this.Login_pan.Controls.Add(this.pictureBox1);
            this.Login_pan.Controls.Add(this.txtPass);
            this.Login_pan.Controls.Add(this.label2);
            this.Login_pan.Controls.Add(this.login_btn);
            this.Login_pan.Controls.Add(this.txtEmail);
            this.Login_pan.Controls.Add(this.label1);
            this.Login_pan.Location = new System.Drawing.Point(88, 141);
            this.Login_pan.Name = "Login_pan";
            this.Login_pan.Size = new System.Drawing.Size(392, 327);
            this.Login_pan.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.password_58pin512091y_16;
            this.pictureBox2.Location = new System.Drawing.Point(348, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 19);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.email_ssqnp718px8v_16__1_;
            this.pictureBox1.Location = new System.Drawing.Point(348, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 19);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(147, 103);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(225, 27);
            this.txtPass.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.DimGray;
            this.login_btn.Location = new System.Drawing.Point(31, 198);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(341, 37);
            this.login_btn.TabIndex = 2;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            this.login_btn.MouseLeave += new System.EventHandler(this.login_btn_MouseLeave);
            this.login_btn.MouseHover += new System.EventHandler(this.login_btn_MouseHover);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(147, 57);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(225, 27);
            this.txtEmail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Email";
            // 
            // signup_Pan
            // 
            this.signup_Pan.Controls.Add(this.txt_conPass);
            this.signup_Pan.Controls.Add(this.txt_lname);
            this.signup_Pan.Controls.Add(this.txt_email);
            this.signup_Pan.Controls.Add(this.txt_Pass);
            this.signup_Pan.Controls.Add(this.txt_fname);
            this.signup_Pan.Controls.Add(this.signup_btn);
            this.signup_Pan.Location = new System.Drawing.Point(88, 119);
            this.signup_Pan.Name = "signup_Pan";
            this.signup_Pan.Size = new System.Drawing.Size(436, 405);
            this.signup_Pan.TabIndex = 4;
            this.signup_Pan.Visible = false;
            // 
            // txt_conPass
            // 
            this.txt_conPass.Font = new System.Drawing.Font("Georgia", 12F);
            this.txt_conPass.ForeColor = System.Drawing.Color.DimGray;
            this.txt_conPass.Location = new System.Drawing.Point(63, 262);
            this.txt_conPass.Multiline = true;
            this.txt_conPass.Name = "txt_conPass";
            this.txt_conPass.Size = new System.Drawing.Size(290, 37);
            this.txt_conPass.TabIndex = 4;
            this.txt_conPass.Text = "Confirm Password";
            this.txt_conPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_conPass.MouseEnter += new System.EventHandler(this.txt_conPass_MouseEnter);
            this.txt_conPass.MouseLeave += new System.EventHandler(this.txt_conPass_MouseLeave);
            // 
            // txt_lname
            // 
            this.txt_lname.Font = new System.Drawing.Font("Georgia", 12F);
            this.txt_lname.ForeColor = System.Drawing.Color.DimGray;
            this.txt_lname.Location = new System.Drawing.Point(63, 87);
            this.txt_lname.Multiline = true;
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(290, 37);
            this.txt_lname.TabIndex = 1;
            this.txt_lname.Text = "Enter Last Name";
            this.txt_lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_lname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_lname_KeyPress);
            this.txt_lname.MouseEnter += new System.EventHandler(this.txt_lname_MouseEnter);
            this.txt_lname.MouseLeave += new System.EventHandler(this.txt_lname_MouseLeave);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Georgia", 12F);
            this.txt_email.ForeColor = System.Drawing.Color.DimGray;
            this.txt_email.Location = new System.Drawing.Point(63, 145);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(290, 37);
            this.txt_email.TabIndex = 2;
            this.txt_email.Text = "Enter Email";
            this.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_email.MouseEnter += new System.EventHandler(this.txt_email_MouseEnter);
            this.txt_email.MouseLeave += new System.EventHandler(this.txt_email_MouseLeave);
            // 
            // txt_Pass
            // 
            this.txt_Pass.Font = new System.Drawing.Font("Georgia", 12F);
            this.txt_Pass.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Pass.Location = new System.Drawing.Point(63, 207);
            this.txt_Pass.Multiline = true;
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(290, 37);
            this.txt_Pass.TabIndex = 3;
            this.txt_Pass.Text = "Enter Password";
            this.txt_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Pass.MouseEnter += new System.EventHandler(this.txt_Pass_MouseEnter);
            this.txt_Pass.MouseLeave += new System.EventHandler(this.txt_Pass_MouseLeave);
            // 
            // txt_fname
            // 
            this.txt_fname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fname.ForeColor = System.Drawing.Color.DimGray;
            this.txt_fname.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_fname.Location = new System.Drawing.Point(63, 29);
            this.txt_fname.Multiline = true;
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(290, 37);
            this.txt_fname.TabIndex = 0;
            this.txt_fname.Text = "Enter First Name";
            this.txt_fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fname_KeyPress);
            this.txt_fname.MouseEnter += new System.EventHandler(this.txt_fname_MouseEnter);
            this.txt_fname.MouseLeave += new System.EventHandler(this.txt_fname_MouseLeave);
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.signup_btn.FlatAppearance.BorderSize = 0;
            this.signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_btn.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_btn.ForeColor = System.Drawing.Color.DimGray;
            this.signup_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.signup_btn.Location = new System.Drawing.Point(63, 327);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(290, 37);
            this.signup_btn.TabIndex = 5;
            this.signup_btn.Text = "SIGNUP";
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            this.signup_btn.MouseLeave += new System.EventHandler(this.signup_btn_MouseLeave);
            this.signup_btn.MouseHover += new System.EventHandler(this.signup_btn_MouseHover);
            // 
            // EP_name
            // 
            this.EP_name.ContainerControl = this;
            // 
            // loginError
            // 
            this.loginError.ContainerControl = this;
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.Back_btn.FlatAppearance.BorderSize = 0;
            this.Back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_btn.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.ForeColor = System.Drawing.Color.DimGray;
            this.Back_btn.Location = new System.Drawing.Point(29, 262);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(341, 37);
            this.Back_btn.TabIndex = 6;
            this.Back_btn.Text = "BACK";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(599, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Login_pan);
            this.Controls.Add(this.signup_Pan);
            this.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.Login_pan.ResumeLayout(false);
            this.Login_pan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.signup_Pan.ResumeLayout(false);
            this.signup_Pan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EP_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.TextBox txt_conPass;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_fname;
        protected System.Windows.Forms.Button signupBtn;
        protected System.Windows.Forms.Button loginBtn;
        internal System.Windows.Forms.Panel signup_Pan;
        internal System.Windows.Forms.Panel Login_pan;
        private System.Windows.Forms.ErrorProvider EP_name;
        private System.Windows.Forms.ErrorProvider loginError;
        private System.Windows.Forms.Button Back_btn;
    }
}