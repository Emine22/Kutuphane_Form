namespace SON_KÜTÜPHANE_ÖDEV
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitapFormuDataSet = new SON_KÜTÜPHANE_ÖDEV.KitapFormuDataSet();
            this.tblKitapFormuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_KitapFormuTableAdapter = new SON_KÜTÜPHANE_ÖDEV.KitapFormuDataSetTableAdapters.Tbl_KitapFormuTableAdapter();
            this.kitapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayinEviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verilisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alinisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kitapAdi = new System.Windows.Forms.TextBox();
            this.kitapTuru = new System.Windows.Forms.TextBox();
            this.yayinEvi = new System.Windows.Forms.TextBox();
            this.verilisTarihi = new System.Windows.Forms.TextBox();
            this.uyeAdi = new System.Windows.Forms.TextBox();
            this.alinisTarihi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapFormuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKitapFormuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Location = new System.Drawing.Point(41, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Pink;
            this.label2.Location = new System.Drawing.Point(41, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Pink;
            this.label3.Location = new System.Drawing.Point(41, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitap Yayın Evi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Pink;
            this.label4.Location = new System.Drawing.Point(41, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Üye Veriliş Tarihi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapAdiDataGridViewTextBoxColumn,
            this.kitapTuruDataGridViewTextBoxColumn,
            this.yayinEviDataGridViewTextBoxColumn,
            this.verilisTarihiDataGridViewTextBoxColumn,
            this.uyeAdiDataGridViewTextBoxColumn,
            this.alinisTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblKitapFormuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(416, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(372, 285);
            this.dataGridView1.TabIndex = 4;
            // 
            // kitapFormuDataSet
            // 
            this.kitapFormuDataSet.DataSetName = "KitapFormuDataSet";
            this.kitapFormuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblKitapFormuBindingSource
            // 
            this.tblKitapFormuBindingSource.DataMember = "Tbl_KitapFormu";
            this.tblKitapFormuBindingSource.DataSource = this.kitapFormuDataSet;
            // 
            // tbl_KitapFormuTableAdapter
            // 
            this.tbl_KitapFormuTableAdapter.ClearBeforeFill = true;
            // 
            // kitapAdiDataGridViewTextBoxColumn
            // 
            this.kitapAdiDataGridViewTextBoxColumn.DataPropertyName = "kitapAdi";
            this.kitapAdiDataGridViewTextBoxColumn.HeaderText = "kitapAdi";
            this.kitapAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapAdiDataGridViewTextBoxColumn.Name = "kitapAdiDataGridViewTextBoxColumn";
            this.kitapAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapTuruDataGridViewTextBoxColumn
            // 
            this.kitapTuruDataGridViewTextBoxColumn.DataPropertyName = "kitapTuru";
            this.kitapTuruDataGridViewTextBoxColumn.HeaderText = "kitapTuru";
            this.kitapTuruDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapTuruDataGridViewTextBoxColumn.Name = "kitapTuruDataGridViewTextBoxColumn";
            this.kitapTuruDataGridViewTextBoxColumn.Width = 125;
            // 
            // yayinEviDataGridViewTextBoxColumn
            // 
            this.yayinEviDataGridViewTextBoxColumn.DataPropertyName = "yayinEvi";
            this.yayinEviDataGridViewTextBoxColumn.HeaderText = "yayinEvi";
            this.yayinEviDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yayinEviDataGridViewTextBoxColumn.Name = "yayinEviDataGridViewTextBoxColumn";
            this.yayinEviDataGridViewTextBoxColumn.Width = 125;
            // 
            // verilisTarihiDataGridViewTextBoxColumn
            // 
            this.verilisTarihiDataGridViewTextBoxColumn.DataPropertyName = "verilisTarihi";
            this.verilisTarihiDataGridViewTextBoxColumn.HeaderText = "verilisTarihi";
            this.verilisTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.verilisTarihiDataGridViewTextBoxColumn.Name = "verilisTarihiDataGridViewTextBoxColumn";
            this.verilisTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // uyeAdiDataGridViewTextBoxColumn
            // 
            this.uyeAdiDataGridViewTextBoxColumn.DataPropertyName = "uyeAdi";
            this.uyeAdiDataGridViewTextBoxColumn.HeaderText = "uyeAdi";
            this.uyeAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uyeAdiDataGridViewTextBoxColumn.Name = "uyeAdiDataGridViewTextBoxColumn";
            this.uyeAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // alinisTarihiDataGridViewTextBoxColumn
            // 
            this.alinisTarihiDataGridViewTextBoxColumn.DataPropertyName = "alinisTarihi";
            this.alinisTarihiDataGridViewTextBoxColumn.HeaderText = "alinisTarihi";
            this.alinisTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alinisTarihiDataGridViewTextBoxColumn.Name = "alinisTarihiDataGridViewTextBoxColumn";
            this.alinisTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.Location = new System.Drawing.Point(86, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 69);
            this.button1.TabIndex = 5;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Pink;
            this.button2.Location = new System.Drawing.Point(268, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 70);
            this.button2.TabIndex = 6;
            this.button2.Text = "SİL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Pink;
            this.button3.Location = new System.Drawing.Point(450, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 70);
            this.button3.TabIndex = 7;
            this.button3.Text = "GÖRÜNTÜLE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Pink;
            this.label5.Location = new System.Drawing.Point(41, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Üye Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Pink;
            this.label6.Location = new System.Drawing.Point(41, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Geri Alınış Tarihi";
            // 
            // kitapAdi
            // 
            this.kitapAdi.Location = new System.Drawing.Point(186, 45);
            this.kitapAdi.Name = "kitapAdi";
            this.kitapAdi.Size = new System.Drawing.Size(124, 22);
            this.kitapAdi.TabIndex = 10;
            // 
            // kitapTuru
            // 
            this.kitapTuru.Location = new System.Drawing.Point(186, 98);
            this.kitapTuru.Name = "kitapTuru";
            this.kitapTuru.Size = new System.Drawing.Size(124, 22);
            this.kitapTuru.TabIndex = 11;
            // 
            // yayinEvi
            // 
            this.yayinEvi.Location = new System.Drawing.Point(186, 142);
            this.yayinEvi.Name = "yayinEvi";
            this.yayinEvi.Size = new System.Drawing.Size(124, 22);
            this.yayinEvi.TabIndex = 12;
            // 
            // verilisTarihi
            // 
            this.verilisTarihi.Location = new System.Drawing.Point(186, 196);
            this.verilisTarihi.Name = "verilisTarihi";
            this.verilisTarihi.Size = new System.Drawing.Size(124, 22);
            this.verilisTarihi.TabIndex = 13;
            // 
            // uyeAdi
            // 
            this.uyeAdi.Location = new System.Drawing.Point(186, 235);
            this.uyeAdi.Name = "uyeAdi";
            this.uyeAdi.Size = new System.Drawing.Size(124, 22);
            this.uyeAdi.TabIndex = 14;
            // 
            // alinisTarihi
            // 
            this.alinisTarihi.Location = new System.Drawing.Point(186, 277);
            this.alinisTarihi.Name = "alinisTarihi";
            this.alinisTarihi.Size = new System.Drawing.Size(124, 22);
            this.alinisTarihi.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.alinisTarihi);
            this.Controls.Add(this.uyeAdi);
            this.Controls.Add(this.verilisTarihi);
            this.Controls.Add(this.yayinEvi);
            this.Controls.Add(this.kitapTuru);
            this.Controls.Add(this.kitapAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapFormuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKitapFormuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KitapFormuDataSet kitapFormuDataSet;
        private System.Windows.Forms.BindingSource tblKitapFormuBindingSource;
        private KitapFormuDataSetTableAdapters.Tbl_KitapFormuTableAdapter tbl_KitapFormuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayinEviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verilisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alinisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kitapAdi;
        private System.Windows.Forms.TextBox kitapTuru;
        private System.Windows.Forms.TextBox yayinEvi;
        private System.Windows.Forms.TextBox verilisTarihi;
        private System.Windows.Forms.TextBox uyeAdi;
        private System.Windows.Forms.TextBox alinisTarihi;
    }
}