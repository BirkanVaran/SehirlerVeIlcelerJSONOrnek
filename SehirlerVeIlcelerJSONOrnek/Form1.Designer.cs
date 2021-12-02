
namespace SehirlerVeIlcelerJSONOrnek
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SehirlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IlcelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şehirSorgulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IlceSorgulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SehirlerToolStripMenuItem,
            this.IlcelerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SehirlerToolStripMenuItem
            // 
            this.SehirlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şehirSorgulaToolStripMenuItem});
            this.SehirlerToolStripMenuItem.Name = "SehirlerToolStripMenuItem";
            this.SehirlerToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.SehirlerToolStripMenuItem.Text = "Şehirler";
            // 
            // IlcelerToolStripMenuItem
            // 
            this.IlcelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IlceSorgulaToolStripMenuItem});
            this.IlcelerToolStripMenuItem.Name = "IlcelerToolStripMenuItem";
            this.IlcelerToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.IlcelerToolStripMenuItem.Text = "İlçeler";
            // 
            // şehirSorgulaToolStripMenuItem
            // 
            this.şehirSorgulaToolStripMenuItem.Name = "şehirSorgulaToolStripMenuItem";
            this.şehirSorgulaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.şehirSorgulaToolStripMenuItem.Text = "Şehir Sorgula";
            // 
            // IlceSorgulaToolStripMenuItem
            // 
            this.IlceSorgulaToolStripMenuItem.Name = "IlceSorgulaToolStripMenuItem";
            this.IlceSorgulaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.IlceSorgulaToolStripMenuItem.Text = "İlçe Sorgula";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SehirlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IlcelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şehirSorgulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IlceSorgulaToolStripMenuItem;
    }
}

