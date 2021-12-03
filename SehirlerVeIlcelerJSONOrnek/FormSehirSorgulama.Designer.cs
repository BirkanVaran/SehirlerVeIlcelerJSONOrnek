
namespace SehirlerVeIlcelerJSONOrnek
{
    partial class FormSehirSorgulama
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
            this.lblSehirAdi = new System.Windows.Forms.Label();
            this.comboBoxSehirSecimi = new System.Windows.Forms.ComboBox();
            this.btnSec = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detaylarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSehirBilgileri = new System.Windows.Forms.Label();
            this.groupBoxSehir = new System.Windows.Forms.GroupBox();
            this.richTextBoxSehir = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBoxSehir.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSehirAdi
            // 
            this.lblSehirAdi.AutoSize = true;
            this.lblSehirAdi.Location = new System.Drawing.Point(27, 32);
            this.lblSehirAdi.Name = "lblSehirAdi";
            this.lblSehirAdi.Size = new System.Drawing.Size(76, 20);
            this.lblSehirAdi.TabIndex = 0;
            this.lblSehirAdi.Text = "Şehir Adı: ";
            // 
            // comboBoxSehirSecimi
            // 
            this.comboBoxSehirSecimi.FormattingEnabled = true;
            this.comboBoxSehirSecimi.Location = new System.Drawing.Point(109, 29);
            this.comboBoxSehirSecimi.Name = "comboBoxSehirSecimi";
            this.comboBoxSehirSecimi.Size = new System.Drawing.Size(339, 28);
            this.comboBoxSehirSecimi.TabIndex = 1;
            this.comboBoxSehirSecimi.Text = "Şehir seçiniz...";
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(454, 29);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(65, 29);
            this.btnSec.TabIndex = 2;
            this.btnSec.Text = "SEÇ";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(492, 306);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İsim";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Telefon";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Faks";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mail";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Web";
            this.columnHeader5.Width = 190;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detaylarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 28);
            // 
            // detaylarToolStripMenuItem
            // 
            this.detaylarToolStripMenuItem.Name = "detaylarToolStripMenuItem";
            this.detaylarToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.detaylarToolStripMenuItem.Text = "Detaylar";
            this.detaylarToolStripMenuItem.Click += new System.EventHandler(this.detaylarToolStripMenuItem_Click);
            // 
            // lblSehirBilgileri
            // 
            this.lblSehirBilgileri.AutoSize = true;
            this.lblSehirBilgileri.Location = new System.Drawing.Point(6, 23);
            this.lblSehirBilgileri.Name = "lblSehirBilgileri";
            this.lblSehirBilgileri.Size = new System.Drawing.Size(162, 20);
            this.lblSehirBilgileri.TabIndex = 4;
            this.lblSehirBilgileri.Text = "Şehir Hakkında Bilgiler:";
            // 
            // groupBoxSehir
            // 
            this.groupBoxSehir.Controls.Add(this.richTextBoxSehir);
            this.groupBoxSehir.Controls.Add(this.lblSehirBilgileri);
            this.groupBoxSehir.Location = new System.Drawing.Point(525, 29);
            this.groupBoxSehir.Name = "groupBoxSehir";
            this.groupBoxSehir.Size = new System.Drawing.Size(250, 340);
            this.groupBoxSehir.TabIndex = 6;
            this.groupBoxSehir.TabStop = false;
            // 
            // richTextBoxSehir
            // 
            this.richTextBoxSehir.Location = new System.Drawing.Point(7, 46);
            this.richTextBoxSehir.Name = "richTextBoxSehir";
            this.richTextBoxSehir.ReadOnly = true;
            this.richTextBoxSehir.Size = new System.Drawing.Size(237, 288);
            this.richTextBoxSehir.TabIndex = 5;
            this.richTextBoxSehir.Text = "";
            // 
            // FormSehirSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(788, 383);
            this.Controls.Add(this.groupBoxSehir);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.comboBoxSehirSecimi);
            this.Controls.Add(this.lblSehirAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSehirSorgulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSehirSorgulama";
            this.Load += new System.EventHandler(this.FormSehirSorgulama_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBoxSehir.ResumeLayout(false);
            this.groupBoxSehir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSehirAdi;
        private System.Windows.Forms.ComboBox comboBoxSehirSecimi;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lblSehirBilgileri;
        private System.Windows.Forms.GroupBox groupBoxSehir;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem detaylarToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBoxSehir;
    }
}