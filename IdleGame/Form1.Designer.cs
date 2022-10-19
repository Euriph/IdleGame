namespace IdleGame
{
    partial class FrmLogin
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
            this.label1_Username = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2_Password = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1_Username
            // 
            this.label1_Username.AutoSize = true;
            this.label1_Username.Location = new System.Drawing.Point(113, 129);
            this.label1_Username.Name = "label1_Username";
            this.label1_Username.Size = new System.Drawing.Size(82, 20);
            this.label1_Username.TabIndex = 0;
            this.label1_Username.Text = "Username :";
            this.label1_Username.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(201, 126);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(125, 27);
            this.txtUsername.TabIndex = 1;
            // 
            // label2_Password
            // 
            this.label2_Password.AutoSize = true;
            this.label2_Password.Location = new System.Drawing.Point(118, 181);
            this.label2_Password.Name = "label2_Password";
            this.label2_Password.Size = new System.Drawing.Size(77, 20);
            this.label2_Password.TabIndex = 2;
            this.label2_Password.Text = "Password :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(201, 181);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(126, 27);
            this.txtPassword.TabIndex = 3;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(129, 237);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(198, 38);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(129, 281);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(198, 38);
            this.btn_Register.TabIndex = 5;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 469);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2_Password);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1_Username);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1_Username;
        private TextBox txtUsername;
        private Label label2_Password;
        private TextBox txtPassword;
        private Button btn_Login;
        private Button btn_Register;
    }
}