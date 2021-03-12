
namespace KitleIndexForm
{
    partial class KitleIndexHesaplama
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
            this.lblBoy = new System.Windows.Forms.Label();
            this.lblKılo = new System.Windows.Forms.Label();
            this.textBoy = new System.Windows.Forms.TextBox();
            this.textKilo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblVki = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblVkiSonuc = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBoy
            // 
            this.lblBoy.AutoSize = true;
            this.lblBoy.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBoy.Location = new System.Drawing.Point(12, 58);
            this.lblBoy.Name = "lblBoy";
            this.lblBoy.Size = new System.Drawing.Size(246, 35);
            this.lblBoy.TabIndex = 0;
            this.lblBoy.Text = "Boyunuz(Ör:1.58):";
            // 
            // lblKılo
            // 
            this.lblKılo.AutoSize = true;
            this.lblKılo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKılo.Location = new System.Drawing.Point(52, 122);
            this.lblKılo.Name = "lblKılo";
            this.lblKılo.Size = new System.Drawing.Size(206, 35);
            this.lblKılo.TabIndex = 1;
            this.lblKılo.Text = "Kilonuz(Ör:54):";
            // 
            // textBoy
            // 
            this.textBoy.Location = new System.Drawing.Point(264, 58);
            this.textBoy.Name = "textBoy";
            this.textBoy.Size = new System.Drawing.Size(118, 43);
            this.textBoy.TabIndex = 2;
            // 
            // textKilo
            // 
            this.textKilo.Location = new System.Drawing.Point(264, 114);
            this.textKilo.Name = "textKilo";
            this.textKilo.Size = new System.Drawing.Size(118, 43);
            this.textKilo.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(192, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblVki
            // 
            this.lblVki.AutoSize = true;
            this.lblVki.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblVki.Location = new System.Drawing.Point(163, 268);
            this.lblVki.Name = "lblVki";
            this.lblVki.Size = new System.Drawing.Size(65, 35);
            this.lblVki.TabIndex = 5;
            this.lblVki.Text = "VKI:";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSonuc.Location = new System.Drawing.Point(52, 326);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(176, 35);
            this.lblSonuc.TabIndex = 6;
            this.lblSonuc.Text = "Durumunuz:";
            // 
            // lblVkiSonuc
            // 
            this.lblVkiSonuc.AutoSize = true;
            this.lblVkiSonuc.Location = new System.Drawing.Point(234, 268);
            this.lblVkiSonuc.Name = "lblVkiSonuc";
            this.lblVkiSonuc.Size = new System.Drawing.Size(0, 35);
            this.lblVkiSonuc.TabIndex = 7;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(234, 326);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(0, 35);
            this.lblDurum.TabIndex = 8;
            // 
            // KitleIndexHesaplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(577, 426);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblVkiSonuc);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lblVki);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textKilo);
            this.Controls.Add(this.textBoy);
            this.Controls.Add(this.lblKılo);
            this.Controls.Add(this.lblBoy);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "KitleIndexHesaplama";
            this.Text = "Kitle Index Hesaplama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBoy;
        private System.Windows.Forms.Label lblKılo;
        private System.Windows.Forms.TextBox textBoy;
        private System.Windows.Forms.TextBox textKilo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblVki;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblVkiSonuc;
        private System.Windows.Forms.Label lblDurum;
    }
}

