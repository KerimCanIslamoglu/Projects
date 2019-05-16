namespace AcibademProje.Formlar
{
    partial class dr_ko_op_giris
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
            this.btnDrSil = new System.Windows.Forms.Button();
            this.btnKoSil = new System.Windows.Forms.Button();
            this.btnOpSil = new System.Windows.Forms.Button();
            this.btnDrKaydet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnOpKaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDrGiris = new System.Windows.Forms.TextBox();
            this.txtKOMobGir = new System.Windows.Forms.TextBox();
            this.txtOpTurGir = new System.Windows.Forms.TextBox();
            this.dgvKOMob = new System.Windows.Forms.DataGridView();
            this.KOID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KoMob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDrAdi = new System.Windows.Forms.DataGridView();
            this.DRID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOpTur = new System.Windows.Forms.DataGridView();
            this.OPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperasyonTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKOMob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpTur)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.btnDrSil);
            this.splitContainer1.Panel1.Controls.Add(this.btnKoSil);
            this.splitContainer1.Panel1.Controls.Add(this.btnOpSil);
            this.splitContainer1.Panel1.Controls.Add(this.btnDrKaydet);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.btnOpKaydet);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtDrGiris);
            this.splitContainer1.Panel1.Controls.Add(this.txtKOMobGir);
            this.splitContainer1.Panel1.Controls.Add(this.txtOpTurGir);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvKOMob);
            this.splitContainer1.Panel2.Controls.Add(this.dgvDrAdi);
            this.splitContainer1.Panel2.Controls.Add(this.dgvOpTur);
            this.splitContainer1.Size = new System.Drawing.Size(1052, 602);
            this.splitContainer1.SplitterDistance = 71;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnDrSil
            // 
            this.btnDrSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDrSil.Location = new System.Drawing.Point(942, 36);
            this.btnDrSil.Name = "btnDrSil";
            this.btnDrSil.Size = new System.Drawing.Size(35, 21);
            this.btnDrSil.TabIndex = 5;
            this.btnDrSil.Text = "Sil";
            this.btnDrSil.UseVisualStyleBackColor = true;
            this.btnDrSil.Click += new System.EventHandler(this.btnDrSil_Click);
            // 
            // btnKoSil
            // 
            this.btnKoSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKoSil.Location = new System.Drawing.Point(568, 37);
            this.btnKoSil.Name = "btnKoSil";
            this.btnKoSil.Size = new System.Drawing.Size(34, 21);
            this.btnKoSil.TabIndex = 4;
            this.btnKoSil.Text = "Sil";
            this.btnKoSil.UseVisualStyleBackColor = true;
            this.btnKoSil.Click += new System.EventHandler(this.btnKoSil_Click);
            // 
            // btnOpSil
            // 
            this.btnOpSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOpSil.Location = new System.Drawing.Point(225, 37);
            this.btnOpSil.Name = "btnOpSil";
            this.btnOpSil.Size = new System.Drawing.Size(39, 23);
            this.btnOpSil.TabIndex = 3;
            this.btnOpSil.Text = "Sil";
            this.btnOpSil.UseVisualStyleBackColor = true;
            this.btnOpSil.Click += new System.EventHandler(this.btnOpSil_Click);
            // 
            // btnDrKaydet
            // 
            this.btnDrKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDrKaydet.Location = new System.Drawing.Point(878, 36);
            this.btnDrKaydet.Name = "btnDrKaydet";
            this.btnDrKaydet.Size = new System.Drawing.Size(58, 22);
            this.btnDrKaydet.TabIndex = 2;
            this.btnDrKaydet.Text = "Kaydet";
            this.btnDrKaydet.UseVisualStyleBackColor = true;
            this.btnDrKaydet.Click += new System.EventHandler(this.btnDrKaydet_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(504, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 22);
            this.button2.TabIndex = 2;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnKOKaydet_Click);
            // 
            // btnOpKaydet
            // 
            this.btnOpKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOpKaydet.Location = new System.Drawing.Point(161, 36);
            this.btnOpKaydet.Name = "btnOpKaydet";
            this.btnOpKaydet.Size = new System.Drawing.Size(58, 22);
            this.btnOpKaydet.TabIndex = 2;
            this.btnOpKaydet.Text = "Kaydet";
            this.btnOpKaydet.UseVisualStyleBackColor = true;
            this.btnOpKaydet.Click += new System.EventHandler(this.btnOpKaydet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(737, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dr. Adı Gir:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(363, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "KO-Mobilite Gir:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operasyon Türü Gir:";
            // 
            // txtDrGiris
            // 
            this.txtDrGiris.Location = new System.Drawing.Point(740, 36);
            this.txtDrGiris.Name = "txtDrGiris";
            this.txtDrGiris.Size = new System.Drawing.Size(132, 20);
            this.txtDrGiris.TabIndex = 0;
            // 
            // txtKOMobGir
            // 
            this.txtKOMobGir.Location = new System.Drawing.Point(366, 36);
            this.txtKOMobGir.Name = "txtKOMobGir";
            this.txtKOMobGir.Size = new System.Drawing.Size(132, 20);
            this.txtKOMobGir.TabIndex = 0;
            // 
            // txtOpTurGir
            // 
            this.txtOpTurGir.Location = new System.Drawing.Point(23, 36);
            this.txtOpTurGir.Name = "txtOpTurGir";
            this.txtOpTurGir.Size = new System.Drawing.Size(132, 20);
            this.txtOpTurGir.TabIndex = 0;
            // 
            // dgvKOMob
            // 
            this.dgvKOMob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKOMob.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KOID,
            this.KoMob});
            this.dgvKOMob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKOMob.Location = new System.Drawing.Point(333, 0);
            this.dgvKOMob.Name = "dgvKOMob";
            this.dgvKOMob.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKOMob.Size = new System.Drawing.Size(403, 523);
            this.dgvKOMob.TabIndex = 2;
            this.dgvKOMob.Click += new System.EventHandler(this.dgvKOMob_Click);
            this.dgvKOMob.DoubleClick += new System.EventHandler(this.dgvKOMob_DoubleClick);
            // 
            // KOID
            // 
            this.KOID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.KOID.HeaderText = "ID";
            this.KOID.Name = "KOID";
            this.KOID.Width = 43;
            // 
            // KoMob
            // 
            this.KoMob.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KoMob.HeaderText = "KO-Mobilite";
            this.KoMob.Name = "KoMob";
            // 
            // dgvDrAdi
            // 
            this.dgvDrAdi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrAdi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DRID,
            this.DrAdi});
            this.dgvDrAdi.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvDrAdi.Location = new System.Drawing.Point(736, 0);
            this.dgvDrAdi.Name = "dgvDrAdi";
            this.dgvDrAdi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrAdi.Size = new System.Drawing.Size(312, 523);
            this.dgvDrAdi.TabIndex = 1;
            this.dgvDrAdi.Click += new System.EventHandler(this.dgvDrAdi_Click);
            this.dgvDrAdi.DoubleClick += new System.EventHandler(this.dgvDrAdi_DoubleClick);
            // 
            // DRID
            // 
            this.DRID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DRID.HeaderText = "ID";
            this.DRID.Name = "DRID";
            this.DRID.Width = 43;
            // 
            // DrAdi
            // 
            this.DrAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DrAdi.HeaderText = "Dr. Adı";
            this.DrAdi.Name = "DrAdi";
            // 
            // dgvOpTur
            // 
            this.dgvOpTur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOpTur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OPID,
            this.OperasyonTuru});
            this.dgvOpTur.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvOpTur.Location = new System.Drawing.Point(0, 0);
            this.dgvOpTur.Name = "dgvOpTur";
            this.dgvOpTur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOpTur.Size = new System.Drawing.Size(333, 523);
            this.dgvOpTur.TabIndex = 0;
            this.dgvOpTur.Click += new System.EventHandler(this.dgvOpTur_Click);
            this.dgvOpTur.DoubleClick += new System.EventHandler(this.dgvOpTur_DoubleClick);
            // 
            // OPID
            // 
            this.OPID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.OPID.HeaderText = "ID";
            this.OPID.Name = "OPID";
            this.OPID.Width = 43;
            // 
            // OperasyonTuru
            // 
            this.OperasyonTuru.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OperasyonTuru.HeaderText = "Operasyon Türü";
            this.OperasyonTuru.Name = "OperasyonTuru";
            // 
            // dr_ko_op_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 602);
            this.Controls.Add(this.splitContainer1);
            this.Name = "dr_ko_op_giris";
            this.Text = "dr_ko_op_giris";
            this.Load += new System.EventHandler(this.dr_ko_op_giris_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKOMob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpTur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDrGiris;
        private System.Windows.Forms.TextBox txtKOMobGir;
        private System.Windows.Forms.TextBox txtOpTurGir;
        private System.Windows.Forms.DataGridView dgvKOMob;
        private System.Windows.Forms.DataGridViewTextBoxColumn KOID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KoMob;
        private System.Windows.Forms.DataGridView dgvDrAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DRID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrAdi;
        private System.Windows.Forms.DataGridView dgvOpTur;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperasyonTuru;
        private System.Windows.Forms.Button btnDrKaydet;
        private System.Windows.Forms.Button btnOpKaydet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDrSil;
        private System.Windows.Forms.Button btnKoSil;
        private System.Windows.Forms.Button btnOpSil;
    }
}