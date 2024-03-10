namespace ebs_Ziyaretci
{
    partial class Form6
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ptsicil = new System.Windows.Forms.TextBox();
            this.txt_ptadif = new System.Windows.Forms.TextBox();
            this.txt_ptunvanif = new System.Windows.Forms.TextBox();
            this.btn_ptekle = new System.Windows.Forms.Button();
            this.btn_ptkapat = new System.Windows.Forms.Button();
            this.btn_ptsil = new System.Windows.Forms.Button();
            this.btn_ptduzenle = new System.Windows.Forms.Button();
            this.pt_veri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pt_veri)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sicil No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(44, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personel Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(44, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personel Unvanı:";
            // 
            // txt_ptsicil
            // 
            this.txt_ptsicil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ptsicil.Location = new System.Drawing.Point(244, 84);
            this.txt_ptsicil.Name = "txt_ptsicil";
            this.txt_ptsicil.Size = new System.Drawing.Size(265, 30);
            this.txt_ptsicil.TabIndex = 3;
            // 
            // txt_ptadif
            // 
            this.txt_ptadif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ptadif.Location = new System.Drawing.Point(244, 133);
            this.txt_ptadif.Name = "txt_ptadif";
            this.txt_ptadif.Size = new System.Drawing.Size(265, 30);
            this.txt_ptadif.TabIndex = 4;
            // 
            // txt_ptunvanif
            // 
            this.txt_ptunvanif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ptunvanif.Location = new System.Drawing.Point(244, 181);
            this.txt_ptunvanif.Name = "txt_ptunvanif";
            this.txt_ptunvanif.Size = new System.Drawing.Size(265, 30);
            this.txt_ptunvanif.TabIndex = 5;
            // 
            // btn_ptekle
            // 
            this.btn_ptekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ptekle.Location = new System.Drawing.Point(545, 73);
            this.btn_ptekle.Name = "btn_ptekle";
            this.btn_ptekle.Size = new System.Drawing.Size(128, 52);
            this.btn_ptekle.TabIndex = 6;
            this.btn_ptekle.Text = "Ekle";
            this.btn_ptekle.UseVisualStyleBackColor = true;
            this.btn_ptekle.Click += new System.EventHandler(this.btn_ptekle_Click);
            // 
            // btn_ptkapat
            // 
            this.btn_ptkapat.BackColor = System.Drawing.Color.IndianRed;
            this.btn_ptkapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ptkapat.Location = new System.Drawing.Point(545, 160);
            this.btn_ptkapat.Name = "btn_ptkapat";
            this.btn_ptkapat.Size = new System.Drawing.Size(128, 57);
            this.btn_ptkapat.TabIndex = 7;
            this.btn_ptkapat.Text = "Kapat";
            this.btn_ptkapat.UseVisualStyleBackColor = false;
            this.btn_ptkapat.Click += new System.EventHandler(this.btn_ptkapat_Click);
            // 
            // btn_ptsil
            // 
            this.btn_ptsil.BackColor = System.Drawing.Color.IndianRed;
            this.btn_ptsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ptsil.Location = new System.Drawing.Point(692, 160);
            this.btn_ptsil.Name = "btn_ptsil";
            this.btn_ptsil.Size = new System.Drawing.Size(128, 57);
            this.btn_ptsil.TabIndex = 8;
            this.btn_ptsil.Text = "Sil";
            this.btn_ptsil.UseVisualStyleBackColor = false;
            this.btn_ptsil.Click += new System.EventHandler(this.btn_ptsil_Click);
            // 
            // btn_ptduzenle
            // 
            this.btn_ptduzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ptduzenle.Location = new System.Drawing.Point(692, 73);
            this.btn_ptduzenle.Name = "btn_ptduzenle";
            this.btn_ptduzenle.Size = new System.Drawing.Size(128, 52);
            this.btn_ptduzenle.TabIndex = 9;
            this.btn_ptduzenle.Text = "Düzenle";
            this.btn_ptduzenle.UseVisualStyleBackColor = true;
            this.btn_ptduzenle.Click += new System.EventHandler(this.btn_ptduzenle_Click);
            // 
            // pt_veri
            // 
            this.pt_veri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pt_veri.Location = new System.Drawing.Point(49, 249);
            this.pt_veri.Name = "pt_veri";
            this.pt_veri.RowTemplate.Height = 24;
            this.pt_veri.Size = new System.Drawing.Size(757, 247);
            this.pt_veri.TabIndex = 10;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 589);
            this.Controls.Add(this.pt_veri);
            this.Controls.Add(this.btn_ptduzenle);
            this.Controls.Add(this.btn_ptsil);
            this.Controls.Add(this.btn_ptkapat);
            this.Controls.Add(this.btn_ptekle);
            this.Controls.Add(this.txt_ptunvanif);
            this.Controls.Add(this.txt_ptadif);
            this.Controls.Add(this.txt_ptsicil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.MaximizeBox = false;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Takip";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pt_veri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ptsicil;
        private System.Windows.Forms.TextBox txt_ptadif;
        private System.Windows.Forms.TextBox txt_ptunvanif;
        private System.Windows.Forms.Button btn_ptekle;
        private System.Windows.Forms.Button btn_ptkapat;
        private System.Windows.Forms.Button btn_ptsil;
        private System.Windows.Forms.Button btn_ptduzenle;
        private System.Windows.Forms.DataGridView pt_veri;
    }
}