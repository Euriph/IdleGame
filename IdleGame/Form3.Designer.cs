namespace IdleGame
{
    partial class FrmRegister
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
            this.btn_Register = new System.Windows.Forms.Button();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblLastname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.lblNickname = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(134, 358);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(198, 38);
            this.btn_Register.TabIndex = 11;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(218, 177);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(126, 27);
            this.txtLastname.TabIndex = 9;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(131, 180);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(79, 20);
            this.lblLastname.TabIndex = 8;
            this.lblLastname.Text = "Lastname :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(218, 144);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(126, 27);
            this.txtName.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(131, 147);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 20);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(218, 243);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(126, 27);
            this.txtPassword.TabIndex = 15;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(131, 243);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 20);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Password :";
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(218, 210);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(126, 27);
            this.txtNickname.TabIndex = 13;
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Location = new System.Drawing.Point(131, 213);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(82, 20);
            this.lblNickname.TabIndex = 12;
            this.lblNickname.Text = "Nickname :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(218, 276);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(126, 27);
            this.txtEmail.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(131, 279);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 20);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "E-mail :";
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 465);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.lblNickname);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "FrmRegister";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Register;
        private TextBox txtLastname;
        private Label lblLastname;
        private TextBox txtName;
        private Label lblName;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtNickname;
        private Label lblNickname;
        private TextBox txtEmail;
        private Label lblEmail;
    }
}