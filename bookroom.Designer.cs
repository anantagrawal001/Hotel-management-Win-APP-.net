namespace hotelmanagement
{
    partial class bookroom
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bACKTOMAINMENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSERLOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bACKTOMAINMENUToolStripMenuItem,
            this.uSERLOGINToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1532, 33);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bACKTOMAINMENUToolStripMenuItem
            // 
            this.bACKTOMAINMENUToolStripMenuItem.Name = "bACKTOMAINMENUToolStripMenuItem";
            this.bACKTOMAINMENUToolStripMenuItem.Size = new System.Drawing.Size(204, 29);
            this.bACKTOMAINMENUToolStripMenuItem.Text = "BACK TO MAIN MENU";
            this.bACKTOMAINMENUToolStripMenuItem.Click += new System.EventHandler(this.bACKTOMAINMENUToolStripMenuItem_Click);
            // 
            // uSERLOGINToolStripMenuItem
            // 
            this.uSERLOGINToolStripMenuItem.Name = "uSERLOGINToolStripMenuItem";
            this.uSERLOGINToolStripMenuItem.Size = new System.Drawing.Size(127, 29);
            this.uSERLOGINToolStripMenuItem.Text = "USER HOME";
            this.uSERLOGINToolStripMenuItem.Click += new System.EventHandler(this.uSERLOGINToolStripMenuItem_Click);
            // 
            // bookroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 885);
            this.Controls.Add(this.menuStrip1);
            this.Name = "bookroom";
            this.Text = "bookroom";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bACKTOMAINMENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSERLOGINToolStripMenuItem;
    }
}