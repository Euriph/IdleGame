namespace IdleGame
{
    partial class Form3
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
            this.textBox2_Password = new System.Windows.Forms.TextBox();
            this.label2_Password = new System.Windows.Forms.Label();
            this.textBox1_Username = new System.Windows.Forms.TextBox();
            this.label1_Username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(145, 299);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(198, 38);
            this.btn_Register.TabIndex = 11;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            // 
            // textBox2_Password
            // 
            this.textBox2_Password.Location = new System.Drawing.Point(217, 199);
            this.textBox2_Password.Name = "textBox2_Password";
            this.textBox2_Password.Size = new System.Drawing.Size(126, 27);
            this.textBox2_Password.TabIndex = 9;
            // 
            // label2_Password
            // 
            this.label2_Password.AutoSize = true;
            this.label2_Password.Location = new System.Drawing.Point(134, 199);
            this.label2_Password.Name = "label2_Password";
            this.label2_Password.Size = new System.Drawing.Size(77, 20);
            this.label2_Password.TabIndex = 8;
            this.label2_Password.Text = "Password :";
            // 
            // textBox1_Username
            // 
            this.textBox1_Username.Location = new System.Drawing.Point(217, 144);
            this.textBox1_Username.Name = "textBox1_Username";
            this.textBox1_Username.Size = new System.Drawing.Size(125, 27);
            this.textBox1_Username.TabIndex = 7;
            // 
            // label1_Username
            // 
            this.label1_Username.AutoSize = true;
            this.label1_Username.Location = new System.Drawing.Point(129, 147);
            this.label1_Username.Name = "label1_Username";
            this.label1_Username.Size = new System.Drawing.Size(82, 20);
            this.label1_Username.TabIndex = 6;
            this.label1_Username.Text = "Username :";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 465);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.textBox2_Password);
            this.Controls.Add(this.label2_Password);
            this.Controls.Add(this.textBox1_Username);
            this.Controls.Add(this.label1_Username);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Register;
        private TextBox textBox2_Password;
        private Label label2_Password;
        private TextBox textBox1_Username;
        private Label label1_Username;
    }
}