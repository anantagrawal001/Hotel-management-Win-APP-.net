namespace hotelmanagement
{
    partial class MAINMENU
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSERLOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDMINLOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHECKAVAILABLITYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(551, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 225);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO\r\n\r\nHOTEL MANAGEMENT\r\n\r\nROOM BOOKING SERVER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGINToolStripMenuItem,
            this.rEGISTERToolStripMenuItem,
            this.cHECKAVAILABLITYToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1704, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lOGINToolStripMenuItem
            // 
            this.lOGINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSERLOGINToolStripMenuItem,
            this.aDMINLOGINToolStripMenuItem});
            this.lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            this.lOGINToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.lOGINToolStripMenuItem.Text = "LOGIN";
            this.lOGINToolStripMenuItem.Click += new System.EventHandler(this.lOGINToolStripMenuItem_Click);
            // 
            // uSERLOGINToolStripMenuItem
            // 
            this.uSERLOGINToolStripMenuItem.Name = "uSERLOGINToolStripMenuItem";
            this.uSERLOGINToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.uSERLOGINToolStripMenuItem.Text = "USER LOGIN";
            this.uSERLOGINToolStripMenuItem.Click += new System.EventHandler(this.uSERLOGINToolStripMenuItem_Click);
            // 
            // aDMINLOGINToolStripMenuItem
            // 
            this.aDMINLOGINToolStripMenuItem.Name = "aDMINLOGINToolStripMenuItem";
            this.aDMINLOGINToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aDMINLOGINToolStripMenuItem.Text = "ADMIN LOGIN";
            this.aDMINLOGINToolStripMenuItem.Click += new System.EventHandler(this.aDMINLOGINToolStripMenuItem_Click);
            // 
            // rEGISTERToolStripMenuItem
            // 
            this.rEGISTERToolStripMenuItem.Name = "rEGISTERToolStripMenuItem";
            this.rEGISTERToolStripMenuItem.Size = new System.Drawing.Size(104, 29);
            this.rEGISTERToolStripMenuItem.Text = "REGISTER";
            this.rEGISTERToolStripMenuItem.Click += new System.EventHandler(this.rEGISTERToolStripMenuItem_Click);
            // 
            // cHECKAVAILABLITYToolStripMenuItem
            // 
            this.cHECKAVAILABLITYToolStripMenuItem.Name = "cHECKAVAILABLITYToolStripMenuItem";
            this.cHECKAVAILABLITYToolStripMenuItem.Size = new System.Drawing.Size(188, 29);
            this.cHECKAVAILABLITYToolStripMenuItem.Text = "CHECK AVAILABLITY";
            this.cHECKAVAILABLITYToolStripMenuItem.Click += new System.EventHandler(this.cHECKAVAILABLITYToolStripMenuItem_Click);
            // 
            // MAINMENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1704, 822);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MAINMENU";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEGISTERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cHECKAVAILABLITYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSERLOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDMINLOGINToolStripMenuItem;
    }
}

