﻿namespace QLKhachSanVui
{
    partial class FormDatPhong
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
            this.txtMaPhieuDat = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.Label();
            this.cbkh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNgayDen = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtSonguoi = new System.Windows.Forms.TextBox();
            this.txtmapd = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbmp = new System.Windows.Forms.ComboBox();
            this.txtMaPhong = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaPhieuDat
            // 
            this.txtMaPhieuDat.AutoSize = true;
            this.txtMaPhieuDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaPhieuDat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtMaPhieuDat.Location = new System.Drawing.Point(41, 39);
            this.txtMaPhieuDat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMaPhieuDat.Name = "txtMaPhieuDat";
            this.txtMaPhieuDat.Size = new System.Drawing.Size(125, 24);
            this.txtMaPhieuDat.TabIndex = 2;
            this.txtMaPhieuDat.Text = "Mã phiếu đặt:";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.AutoSize = true;
            this.txtKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtKhachHang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtKhachHang.Location = new System.Drawing.Point(43, 117);
            this.txtKhachHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(117, 24);
            this.txtKhachHang.TabIndex = 4;
            this.txtKhachHang.Text = "Khách hàng:";
            // 
            // cbkh
            // 
            this.cbkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbkh.FormattingEnabled = true;
            this.cbkh.Location = new System.Drawing.Point(173, 117);
            this.cbkh.Margin = new System.Windows.Forms.Padding(4);
            this.cbkh.Name = "cbkh";
            this.cbkh.Size = new System.Drawing.Size(349, 32);
            this.cbkh.TabIndex = 5;
            this.cbkh.SelectedIndexChanged += new System.EventHandler(this.cbkh_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(44, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số người:";
            // 
            // txtNgayDen
            // 
            this.txtNgayDen.AutoSize = true;
            this.txtNgayDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNgayDen.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtNgayDen.Location = new System.Drawing.Point(44, 159);
            this.txtNgayDen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNgayDen.Name = "txtNgayDen";
            this.txtNgayDen.Size = new System.Drawing.Size(98, 24);
            this.txtNgayDen.TabIndex = 10;
            this.txtNgayDen.Text = "Ngày đến:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "hh:mm:ss tt MM/dd/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(173, 157);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(349, 29);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtSonguoi
            // 
            this.txtSonguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSonguoi.Location = new System.Drawing.Point(173, 204);
            this.txtSonguoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSonguoi.Name = "txtSonguoi";
            this.txtSonguoi.Size = new System.Drawing.Size(349, 29);
            this.txtSonguoi.TabIndex = 14;
            this.txtSonguoi.Text = "1";
            this.txtSonguoi.TextChanged += new System.EventHandler(this.txtSonguoi_TextChanged);
            // 
            // txtmapd
            // 
            this.txtmapd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmapd.Location = new System.Drawing.Point(173, 35);
            this.txtmapd.Margin = new System.Windows.Forms.Padding(4);
            this.txtmapd.Name = "txtmapd";
            this.txtmapd.Size = new System.Drawing.Size(349, 29);
            this.txtmapd.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.cbmp);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtMaPhong);
            this.groupBox2.Controls.Add(this.txtmapd);
            this.groupBox2.Controls.Add(this.txtSonguoi);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.txtKhachHang);
            this.groupBox2.Controls.Add(this.cbkh);
            this.groupBox2.Controls.Add(this.txtNgayDen);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMaPhieuDat);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(13, 84);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(759, 273);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phiếu đặt phòng:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cbmp
            // 
            this.cbmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbmp.FormattingEnabled = true;
            this.cbmp.Location = new System.Drawing.Point(173, 75);
            this.cbmp.Margin = new System.Windows.Forms.Padding(4);
            this.cbmp.Name = "cbmp";
            this.cbmp.Size = new System.Drawing.Size(349, 32);
            this.cbmp.TabIndex = 18;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.AutoSize = true;
            this.txtMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaPhong.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtMaPhong.Location = new System.Drawing.Point(41, 75);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(101, 24);
            this.txtMaPhong.TabIndex = 17;
            this.txtMaPhong.Text = "Mã phòng:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(199)))));
            this.label5.Location = new System.Drawing.Point(179, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(412, 50);
            this.label5.TabIndex = 18;
            this.label5.Text = "ĐẶT PHÒNG";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 375);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(760, 240);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "matp";
            this.Column1.HeaderText = "Mã phiếu đặt";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "maphong";
            this.Column2.HeaderText = "Mã phòng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "makh";
            this.Column3.HeaderText = "Khách hàng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "ngaythue";
            this.Column4.HeaderText = "Ngày đến";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "soluong";
            this.Column5.HeaderText = "Số người";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(581, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 43);
            this.button1.TabIndex = 20;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(581, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 40);
            this.button2.TabIndex = 21;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button3.Location = new System.Drawing.Point(581, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 43);
            this.button3.TabIndex = 22;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 690);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDatPhong";
            this.Text = "FormDatPhong";
            this.Load += new System.EventHandler(this.FormDatPhong_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label txtMaPhieuDat;
        private System.Windows.Forms.Label txtKhachHang;
        private System.Windows.Forms.ComboBox cbkh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtNgayDen;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtSonguoi;
        private System.Windows.Forms.TextBox txtmapd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbmp;
        private System.Windows.Forms.Label txtMaPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button3;
    }
}