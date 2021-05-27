
namespace LawyerDiaryUI
{
    partial class RandevuIslemleri
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.RandevuLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.backwardBtn = new FontAwesome.Sharp.IconButton();
            this.anaMenuyeDon = new FontAwesome.Sharp.IconButton();
            this.cikis = new FontAwesome.Sharp.IconButton();
            this.RandevuKonu = new System.Windows.Forms.TextBox();
            this.müsteriId = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAcıklama = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kaydetBtn = new FontAwesome.Sharp.IconButton();
            this.ıconButton3 = new FontAwesome.Sharp.IconButton();
            this.textBoxTarih = new System.Windows.Forms.TextBox();
            this.CB_musteriIdleri = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.RandevuLabel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 39);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDownEvent);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMovementEvent);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUpEvent);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(1145, -3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 39);
            this.button3.TabIndex = 12;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RandevuLabel
            // 
            this.RandevuLabel.AutoSize = true;
            this.RandevuLabel.BackColor = System.Drawing.Color.Navy;
            this.RandevuLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RandevuLabel.ForeColor = System.Drawing.Color.Silver;
            this.RandevuLabel.Location = new System.Drawing.Point(139, 8);
            this.RandevuLabel.Name = "RandevuLabel";
            this.RandevuLabel.Size = new System.Drawing.Size(172, 27);
            this.RandevuLabel.TabIndex = 4;
            this.RandevuLabel.Text = "Randevu Kayıt";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(88, 485);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.backwardBtn);
            this.panel3.Controls.Add(this.anaMenuyeDon);
            this.panel3.Controls.Add(this.cikis);
            this.panel3.Location = new System.Drawing.Point(-3, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(147, 541);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDownEvent);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMovementEvent);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUpEvent);
            // 
            // backwardBtn
            // 
            this.backwardBtn.FlatAppearance.BorderSize = 0;
            this.backwardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backwardBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backwardBtn.ForeColor = System.Drawing.Color.Silver;
            this.backwardBtn.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.backwardBtn.IconColor = System.Drawing.Color.Silver;
            this.backwardBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.backwardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backwardBtn.Location = new System.Drawing.Point(0, 99);
            this.backwardBtn.Name = "backwardBtn";
            this.backwardBtn.Size = new System.Drawing.Size(146, 92);
            this.backwardBtn.TabIndex = 16;
            this.backwardBtn.Text = "Randevu Ekranına Dön";
            this.backwardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backwardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backwardBtn.UseVisualStyleBackColor = true;
            this.backwardBtn.Click += new System.EventHandler(this.backwardBtn_Click);
            // 
            // anaMenuyeDon
            // 
            this.anaMenuyeDon.FlatAppearance.BorderSize = 0;
            this.anaMenuyeDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anaMenuyeDon.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.anaMenuyeDon.ForeColor = System.Drawing.Color.Silver;
            this.anaMenuyeDon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.anaMenuyeDon.IconColor = System.Drawing.Color.Silver;
            this.anaMenuyeDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.anaMenuyeDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anaMenuyeDon.Location = new System.Drawing.Point(1, 0);
            this.anaMenuyeDon.Name = "anaMenuyeDon";
            this.anaMenuyeDon.Size = new System.Drawing.Size(146, 92);
            this.anaMenuyeDon.TabIndex = 14;
            this.anaMenuyeDon.Text = "Ana Menü";
            this.anaMenuyeDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anaMenuyeDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.anaMenuyeDon.UseVisualStyleBackColor = true;
            this.anaMenuyeDon.Click += new System.EventHandler(this.anaMenuyeDon_Click);
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.Navy;
            this.cikis.FlatAppearance.BorderSize = 0;
            this.cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikis.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cikis.ForeColor = System.Drawing.Color.Silver;
            this.cikis.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.cikis.IconColor = System.Drawing.Color.Silver;
            this.cikis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cikis.Location = new System.Drawing.Point(-6, 196);
            this.cikis.Name = "cikis";
            this.cikis.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            this.cikis.Size = new System.Drawing.Size(153, 84);
            this.cikis.TabIndex = 15;
            this.cikis.Text = "Çıkış";
            this.cikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // RandevuKonu
            // 
            this.RandevuKonu.Location = new System.Drawing.Point(547, 119);
            this.RandevuKonu.Name = "RandevuKonu";
            this.RandevuKonu.Size = new System.Drawing.Size(373, 27);
            this.RandevuKonu.TabIndex = 2;
            // 
            // müsteriId
            // 
            this.müsteriId.AutoSize = true;
            this.müsteriId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.müsteriId.ForeColor = System.Drawing.Color.Navy;
            this.müsteriId.Location = new System.Drawing.Point(424, 121);
            this.müsteriId.Name = "müsteriId";
            this.müsteriId.Size = new System.Drawing.Size(59, 23);
            this.müsteriId.TabIndex = 3;
            this.müsteriId.Text = "Konu";
            this.müsteriId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tarih
            // 
            this.tarih.AutoSize = true;
            this.tarih.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tarih.ForeColor = System.Drawing.Color.Navy;
            this.tarih.Location = new System.Drawing.Point(422, 189);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(58, 23);
            this.tarih.TabIndex = 3;
            this.tarih.Text = "Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(408, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sanık:";
            // 
            // textBoxAcıklama
            // 
            this.textBoxAcıklama.Location = new System.Drawing.Point(547, 335);
            this.textBoxAcıklama.Name = "textBoxAcıklama";
            this.textBoxAcıklama.Size = new System.Drawing.Size(372, 111);
            this.textBoxAcıklama.TabIndex = 4;
            this.textBoxAcıklama.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(370, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Açıklama:";
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.FlatAppearance.BorderSize = 0;
            this.kaydetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kaydetBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kaydetBtn.ForeColor = System.Drawing.Color.Navy;
            this.kaydetBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.kaydetBtn.IconColor = System.Drawing.Color.Navy;
            this.kaydetBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.kaydetBtn.Location = new System.Drawing.Point(543, 477);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(139, 76);
            this.kaydetBtn.TabIndex = 5;
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kaydetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.kaydetBtn.UseVisualStyleBackColor = true;
            this.kaydetBtn.Click += new System.EventHandler(this.kaydetBtn_Click);
            // 
            // ıconButton3
            // 
            this.ıconButton3.FlatAppearance.BorderSize = 0;
            this.ıconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ıconButton3.ForeColor = System.Drawing.Color.Navy;
            this.ıconButton3.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.ıconButton3.IconColor = System.Drawing.Color.Navy;
            this.ıconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton3.Location = new System.Drawing.Point(774, 477);
            this.ıconButton3.Name = "ıconButton3";
            this.ıconButton3.Size = new System.Drawing.Size(146, 76);
            this.ıconButton3.TabIndex = 5;
            this.ıconButton3.Text = "Vazgeç";
            this.ıconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton3.UseVisualStyleBackColor = true;
            this.ıconButton3.Click += new System.EventHandler(this.ıconButton3_Click);
            // 
            // textBoxTarih
            // 
            this.textBoxTarih.Location = new System.Drawing.Point(547, 192);
            this.textBoxTarih.Name = "textBoxTarih";
            this.textBoxTarih.Size = new System.Drawing.Size(373, 27);
            this.textBoxTarih.TabIndex = 6;
            // 
            // CB_musteriIdleri
            // 
            this.CB_musteriIdleri.FormattingEnabled = true;
            this.CB_musteriIdleri.Location = new System.Drawing.Point(547, 260);
            this.CB_musteriIdleri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CB_musteriIdleri.Name = "CB_musteriIdleri";
            this.CB_musteriIdleri.Size = new System.Drawing.Size(237, 28);
            this.CB_musteriIdleri.TabIndex = 7;
            // 
            // RandevuIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 579);
            this.Controls.Add(this.CB_musteriIdleri);
            this.Controls.Add(this.textBoxTarih);
            this.Controls.Add(this.ıconButton3);
            this.Controls.Add(this.kaydetBtn);
            this.Controls.Add(this.textBoxAcıklama);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.müsteriId);
            this.Controls.Add(this.RandevuKonu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RandevuIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A";
            this.Load += new System.EventHandler(this.RandevuIslemleri_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton anaMenuyeDon;
        private FontAwesome.Sharp.IconButton cikis;
        private System.Windows.Forms.Label RandevuLabel;
        private FontAwesome.Sharp.IconButton backwardBtn;
        private System.Windows.Forms.TextBox RandevuKonu;
        private System.Windows.Forms.Label müsteriId;
        private System.Windows.Forms.Label tarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox textBoxAcıklama;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton kaydetBtn;
        private FontAwesome.Sharp.IconButton ıconButton3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxTarih;
        private System.Windows.Forms.ComboBox CB_musteriIdleri;
    }
}