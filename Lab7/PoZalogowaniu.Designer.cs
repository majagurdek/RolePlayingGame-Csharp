namespace Lab7
{
    partial class PoZalogowaniu
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
            this.bt_dodajpostac = new System.Windows.Forms.Button();
            this.bt_usunpostac = new System.Windows.Forms.Button();
            this.bt_przegladaj = new System.Windows.Forms.Button();
            this.bt_ranking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(244, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Co chcesz teraz zrobić?";
            // 
            // bt_dodajpostac
            // 
            this.bt_dodajpostac.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_dodajpostac.Location = new System.Drawing.Point(290, 109);
            this.bt_dodajpostac.Name = "bt_dodajpostac";
            this.bt_dodajpostac.Size = new System.Drawing.Size(226, 48);
            this.bt_dodajpostac.TabIndex = 1;
            this.bt_dodajpostac.Text = "Dodaj postać";
            this.bt_dodajpostac.UseVisualStyleBackColor = true;
            this.bt_dodajpostac.Click += new System.EventHandler(this.bt_dodajpostac_Click);
            // 
            // bt_usunpostac
            // 
            this.bt_usunpostac.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_usunpostac.Location = new System.Drawing.Point(290, 182);
            this.bt_usunpostac.Name = "bt_usunpostac";
            this.bt_usunpostac.Size = new System.Drawing.Size(226, 48);
            this.bt_usunpostac.TabIndex = 2;
            this.bt_usunpostac.Text = "Usuń postać";
            this.bt_usunpostac.UseVisualStyleBackColor = true;
            this.bt_usunpostac.Click += new System.EventHandler(this.bt_usunpostac_Click);
            // 
            // bt_przegladaj
            // 
            this.bt_przegladaj.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_przegladaj.Location = new System.Drawing.Point(290, 259);
            this.bt_przegladaj.Name = "bt_przegladaj";
            this.bt_przegladaj.Size = new System.Drawing.Size(226, 48);
            this.bt_przegladaj.TabIndex = 3;
            this.bt_przegladaj.Text = "Przeglądaj postacie";
            this.bt_przegladaj.UseVisualStyleBackColor = true;
            this.bt_przegladaj.Click += new System.EventHandler(this.bt_przegladaj_Click);
            // 
            // bt_ranking
            // 
            this.bt_ranking.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_ranking.Location = new System.Drawing.Point(290, 334);
            this.bt_ranking.Name = "bt_ranking";
            this.bt_ranking.Size = new System.Drawing.Size(226, 48);
            this.bt_ranking.TabIndex = 4;
            this.bt_ranking.Text = "Zobacz ranking";
            this.bt_ranking.UseVisualStyleBackColor = true;
            this.bt_ranking.Click += new System.EventHandler(this.bt_ranking_Click);
            // 
            // PoZalogowaniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_ranking);
            this.Controls.Add(this.bt_przegladaj);
            this.Controls.Add(this.bt_usunpostac);
            this.Controls.Add(this.bt_dodajpostac);
            this.Controls.Add(this.label1);
            this.Name = "PoZalogowaniu";
            this.Text = "PoZalogowaniu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_dodajpostac;
        private System.Windows.Forms.Button bt_usunpostac;
        private System.Windows.Forms.Button bt_przegladaj;
        private System.Windows.Forms.Button bt_ranking;
    }
}