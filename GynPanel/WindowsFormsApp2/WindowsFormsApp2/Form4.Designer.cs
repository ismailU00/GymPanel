﻿namespace WindowsFormsApp2
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kul_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kul_soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kul_cinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kul_yas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kul_kilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kul_boy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kul_uye_baslangic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kul_uye_bitis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login_dbDataSet = new WindowsFormsApp2.Login_dbDataSet();
            this.logindbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindbDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(123, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kong GYM Admin Panel";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kul_ad,
            this.kul_soyad,
            this.kul_cinsiyet,
            this.kul_yas,
            this.kul_kilo,
            this.kul_boy,
            this.kul_uye_baslangic,
            this.kul_uye_bitis});
            this.dataGridView1.DataSource = this.login_dbDataSet;
            this.dataGridView1.Location = new System.Drawing.Point(12, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 169);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kul_ad
            // 
            this.kul_ad.DataPropertyName = "kul_ad";
            this.kul_ad.HeaderText = "kul_ad";
            this.kul_ad.MinimumWidth = 6;
            this.kul_ad.Name = "kul_ad";
            this.kul_ad.Width = 125;
            // 
            // kul_soyad
            // 
            this.kul_soyad.DataPropertyName = "kul_soyad";
            this.kul_soyad.HeaderText = "kul_soyad";
            this.kul_soyad.MinimumWidth = 6;
            this.kul_soyad.Name = "kul_soyad";
            this.kul_soyad.Width = 125;
            // 
            // kul_cinsiyet
            // 
            this.kul_cinsiyet.DataPropertyName = "kul_cinsiyet";
            this.kul_cinsiyet.HeaderText = "kul_cinsiyet";
            this.kul_cinsiyet.MinimumWidth = 6;
            this.kul_cinsiyet.Name = "kul_cinsiyet";
            this.kul_cinsiyet.Width = 125;
            // 
            // kul_yas
            // 
            this.kul_yas.DataPropertyName = "kul_yas";
            this.kul_yas.HeaderText = "kul_yas";
            this.kul_yas.MinimumWidth = 6;
            this.kul_yas.Name = "kul_yas";
            this.kul_yas.Width = 125;
            // 
            // kul_kilo
            // 
            this.kul_kilo.DataPropertyName = "kul_kilo";
            this.kul_kilo.HeaderText = "kul_kilo";
            this.kul_kilo.MinimumWidth = 6;
            this.kul_kilo.Name = "kul_kilo";
            this.kul_kilo.Width = 125;
            // 
            // kul_boy
            // 
            this.kul_boy.DataPropertyName = "kul_boy";
            this.kul_boy.HeaderText = "kul_boy";
            this.kul_boy.MinimumWidth = 6;
            this.kul_boy.Name = "kul_boy";
            this.kul_boy.Width = 125;
            // 
            // kul_uye_baslangic
            // 
            this.kul_uye_baslangic.DataPropertyName = "kul_uye_baslangic";
            this.kul_uye_baslangic.HeaderText = "kul_uye_baslangic";
            this.kul_uye_baslangic.MinimumWidth = 6;
            this.kul_uye_baslangic.Name = "kul_uye_baslangic";
            this.kul_uye_baslangic.Width = 125;
            // 
            // kul_uye_bitis
            // 
            this.kul_uye_bitis.DataPropertyName = "kul_uye_bitis";
            this.kul_uye_bitis.HeaderText = "kul_uye_bitis";
            this.kul_uye_bitis.MinimumWidth = 6;
            this.kul_uye_bitis.Name = "kul_uye_bitis";
            this.kul_uye_bitis.Width = 125;
            // 
            // login_dbDataSet
            // 
            this.login_dbDataSet.DataSetName = "Login_dbDataSet";
            this.login_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logindbDataSetBindingSource
            // 
            this.logindbDataSetBindingSource.DataSource = this.login_dbDataSet;
            this.logindbDataSetBindingSource.Position = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(57, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Verileri Gör";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(334, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Veri Sil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(570, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Veri Güncelle";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = ".";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = ".";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(627, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 43);
            this.button3.TabIndex = 7;
            this.button3.Text = ".";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1063, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindbDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource logindbDataSetBindingSource;
        private Login_dbDataSet login_dbDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn kul_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn kul_soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn kul_cinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn kul_yas;
        private System.Windows.Forms.DataGridViewTextBoxColumn kul_kilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn kul_boy;
        private System.Windows.Forms.DataGridViewTextBoxColumn kul_uye_baslangic;
        private System.Windows.Forms.DataGridViewTextBoxColumn kul_uye_bitis;
    }
}