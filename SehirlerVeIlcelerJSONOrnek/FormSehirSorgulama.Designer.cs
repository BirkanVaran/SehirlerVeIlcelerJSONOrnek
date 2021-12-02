
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
            this.lblSehirAdi = new System.Windows.Forms.Label();
            this.comboBoxSehirSecimi = new System.Windows.Forms.ComboBox();
            this.btnSec = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
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
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(492, 375);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FormSehirSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(818, 497);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.comboBoxSehirSecimi);
            this.Controls.Add(this.lblSehirAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSehirSorgulama";
            this.Text = "FormSehirSorgulama";
            this.Load += new System.EventHandler(this.FormSehirSorgulama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSehirAdi;
        private System.Windows.Forms.ComboBox comboBoxSehirSecimi;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.ListView listView1;
    }
}