namespace IdleGame
{
    partial class FrmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picBuilding = new System.Windows.Forms.PictureBox();
            this.lblWorker = new System.Windows.Forms.Label();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblClickCount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuilding)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.picBuilding);
            this.groupBox1.Controls.Add(this.lblWorker);
            this.groupBox1.Controls.Add(this.btnAddWorker);
            this.groupBox1.Controls.Add(this.lblLevel);
            this.groupBox1.Controls.Add(this.lblClickCount);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 533);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // picBuilding
            // 
            this.picBuilding.BackgroundImage = global::IdleGame.Properties.Resources.building1;
            this.picBuilding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBuilding.Location = new System.Drawing.Point(24, 118);
            this.picBuilding.Name = "picBuilding";
            this.picBuilding.Size = new System.Drawing.Size(600, 277);
            this.picBuilding.TabIndex = 6;
            this.picBuilding.TabStop = false;
            this.picBuilding.Click += new System.EventHandler(this.picBuilding_Click);
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Location = new System.Drawing.Point(273, 25);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(59, 20);
            this.lblWorker.TabIndex = 4;
            this.lblWorker.Text = "Worker:";
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.Location = new System.Drawing.Point(15, 488);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(94, 29);
            this.btnAddWorker.TabIndex = 3;
            this.btnAddWorker.Text = "Buy Worker";
            this.btnAddWorker.UseVisualStyleBackColor = true;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(553, 23);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(46, 20);
            this.lblLevel.TabIndex = 2;
            this.lblLevel.Text = "Level:";
            // 
            // lblClickCount
            // 
            this.lblClickCount.AutoSize = true;
            this.lblClickCount.Location = new System.Drawing.Point(15, 23);
            this.lblClickCount.Name = "lblClickCount";
            this.lblClickCount.Size = new System.Drawing.Size(20, 20);
            this.lblClickCount.TabIndex = 1;
            this.lblClickCount.Text = "$:";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 557);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuilding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label lblClickCount;
        private Label lblLevel;
        private Button btnAddWorker;
        private Label lblWorker;
        private PictureBox picBuilding;
    }
}