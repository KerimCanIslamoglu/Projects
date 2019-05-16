namespace AcibademProje.Printing
{
    partial class frmSorgu
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TumBoyut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KanamaMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patoloji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTumMax = new System.Windows.Forms.TextBox();
            this.txtTumMin = new System.Windows.Forms.TextBox();
            this.txtKanMin = new System.Windows.Forms.TextBox();
            this.txtKanMax = new System.Windows.Forms.TextBox();
            this.cbPatt = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.btnKapat);
            this.splitContainer1.Panel1.Controls.Add(this.btnListele);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox2);
            this.splitContainer1.Panel1.Controls.Add(this.cbPatt);
            this.splitContainer1.Panel1.Controls.Add(this.txtKanMax);
            this.splitContainer1.Panel1.Controls.Add(this.txtKanMin);
            this.splitContainer1.Panel1.Controls.Add(this.txtTumMin);
            this.splitContainer1.Panel1.Controls.Add(this.txtTumMax);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer1.Panel2.Controls.Add(this.Liste);
            this.splitContainer1.Size = new System.Drawing.Size(977, 474);
            this.splitContainer1.SplitterDistance = 182;
            this.splitContainer1.TabIndex = 0;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ProNo,
            this.Hadi,
            this.HSoyad,
            this.OpTarih,
            this.TumBoyut,
            this.KanamaMiktar,
            this.Patoloji,
            this.PKS});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(787, 470);
            this.Liste.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.HeaderText = "HastaID";
            this.ID.Name = "ID";
            this.ID.Width = 71;
            // 
            // ProNo
            // 
            this.ProNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProNo.HeaderText = "Protokol No";
            this.ProNo.Name = "ProNo";
            // 
            // Hadi
            // 
            this.Hadi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Hadi.HeaderText = "Hasta Adı";
            this.Hadi.Name = "Hadi";
            this.Hadi.Width = 78;
            // 
            // HSoyad
            // 
            this.HSoyad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HSoyad.HeaderText = "Hasta Soyadi";
            this.HSoyad.Name = "HSoyad";
            this.HSoyad.Width = 95;
            // 
            // OpTarih
            // 
            this.OpTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.OpTarih.HeaderText = "Operasyon Tarihi";
            this.OpTarih.Name = "OpTarih";
            this.OpTarih.Width = 103;
            // 
            // TumBoyut
            // 
            this.TumBoyut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TumBoyut.HeaderText = "Tümor Boyutu";
            this.TumBoyut.Name = "TumBoyut";
            this.TumBoyut.Width = 90;
            // 
            // KanamaMiktar
            // 
            this.KanamaMiktar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.KanamaMiktar.HeaderText = "Kanama Miktarı";
            this.KanamaMiktar.Name = "KanamaMiktar";
            this.KanamaMiktar.Width = 96;
            // 
            // Patoloji
            // 
            this.Patoloji.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Patoloji.HeaderText = "Patoloji";
            this.Patoloji.Name = "Patoloji";
            this.Patoloji.Width = 66;
            // 
            // PKS
            // 
            this.PKS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PKS.HeaderText = "PKS";
            this.PKS.Name = "PKS";
            this.PKS.Width = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tümör Boyutu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kanama Miktarı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(16, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Patoloji:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "PKS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Min:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Max:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Min:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Max:";
            // 
            // txtTumMax
            // 
            this.txtTumMax.Location = new System.Drawing.Point(125, 116);
            this.txtTumMax.Name = "txtTumMax";
            this.txtTumMax.Size = new System.Drawing.Size(43, 20);
            this.txtTumMax.TabIndex = 6;
            // 
            // txtTumMin
            // 
            this.txtTumMin.Location = new System.Drawing.Point(40, 116);
            this.txtTumMin.Name = "txtTumMin";
            this.txtTumMin.Size = new System.Drawing.Size(43, 20);
            this.txtTumMin.TabIndex = 6;
            // 
            // txtKanMin
            // 
            this.txtKanMin.Location = new System.Drawing.Point(40, 186);
            this.txtKanMin.Name = "txtKanMin";
            this.txtKanMin.Size = new System.Drawing.Size(43, 20);
            this.txtKanMin.TabIndex = 6;
            // 
            // txtKanMax
            // 
            this.txtKanMax.Location = new System.Drawing.Point(125, 186);
            this.txtKanMax.Name = "txtKanMax";
            this.txtKanMax.Size = new System.Drawing.Size(43, 20);
            this.txtKanMax.TabIndex = 6;
            // 
            // cbPatt
            // 
            this.cbPatt.FormattingEnabled = true;
            this.cbPatt.Location = new System.Drawing.Point(19, 246);
            this.cbPatt.Name = "cbPatt";
            this.cbPatt.Size = new System.Drawing.Size(134, 21);
            this.cbPatt.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "EVET",
            "HAYIR"});
            this.comboBox2.Location = new System.Drawing.Point(19, 311);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(134, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // btnListele
            // 
            this.btnListele.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(0, 415);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(178, 55);
            this.btnListele.TabIndex = 9;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(0, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(178, 48);
            this.btnKapat.TabIndex = 10;
            this.btnKapat.Text = "Formu Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // frmSorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 474);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmSorgu";
            this.Text = "frmSorgu";
            this.Load += new System.EventHandler(this.frmSorgu_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cbPatt;
        private System.Windows.Forms.TextBox txtKanMax;
        private System.Windows.Forms.TextBox txtKanMin;
        private System.Windows.Forms.TextBox txtTumMin;
        private System.Windows.Forms.TextBox txtTumMax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn TumBoyut;
        private System.Windows.Forms.DataGridViewTextBoxColumn KanamaMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patoloji;
        private System.Windows.Forms.DataGridViewTextBoxColumn PKS;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnKapat;
    }
}