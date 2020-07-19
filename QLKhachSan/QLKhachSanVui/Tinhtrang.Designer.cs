namespace QLKhachSanVui
{
    partial class Tinhtrang
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
            this.txtMatinhtrang = new System.Windows.Forms.TextBox();
            this.txtTentinhtrang = new System.Windows.Forms.TextBox();
            this.btThemtinhtrang = new System.Windows.Forms.Button();
            this.btSuatinhtrang = new System.Windows.Forms.Button();
            this.btXoatinhtrang = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(44, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tình trạng:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tình trạng:";
            // 
            // txtMatinhtrang
            // 
            this.txtMatinhtrang.Location = new System.Drawing.Point(168, 63);
            this.txtMatinhtrang.Name = "txtMatinhtrang";
            this.txtMatinhtrang.Size = new System.Drawing.Size(277, 22);
            this.txtMatinhtrang.TabIndex = 2;
            this.txtMatinhtrang.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTentinhtrang
            // 
            this.txtTentinhtrang.Location = new System.Drawing.Point(168, 96);
            this.txtTentinhtrang.Name = "txtTentinhtrang";
            this.txtTentinhtrang.Size = new System.Drawing.Size(277, 22);
            this.txtTentinhtrang.TabIndex = 3;
            // 
            // btThemtinhtrang
            // 
            this.btThemtinhtrang.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btThemtinhtrang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btThemtinhtrang.Location = new System.Drawing.Point(29, 143);
            this.btThemtinhtrang.Name = "btThemtinhtrang";
            this.btThemtinhtrang.Size = new System.Drawing.Size(84, 32);
            this.btThemtinhtrang.TabIndex = 4;
            this.btThemtinhtrang.Text = "Thêm";
            this.btThemtinhtrang.UseVisualStyleBackColor = true;
            this.btThemtinhtrang.Click += new System.EventHandler(this.btThemtinhtrang_Click);
            // 
            // btSuatinhtrang
            // 
            this.btSuatinhtrang.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btSuatinhtrang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btSuatinhtrang.Location = new System.Drawing.Point(142, 143);
            this.btSuatinhtrang.Name = "btSuatinhtrang";
            this.btSuatinhtrang.Size = new System.Drawing.Size(84, 32);
            this.btSuatinhtrang.TabIndex = 5;
            this.btSuatinhtrang.Text = "Sửa";
            this.btSuatinhtrang.UseVisualStyleBackColor = true;
            this.btSuatinhtrang.Click += new System.EventHandler(this.btSuatinhtrang_Click);
            // 
            // btXoatinhtrang
            // 
            this.btXoatinhtrang.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btXoatinhtrang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btXoatinhtrang.Location = new System.Drawing.Point(258, 143);
            this.btXoatinhtrang.Name = "btXoatinhtrang";
            this.btXoatinhtrang.Size = new System.Drawing.Size(84, 32);
            this.btXoatinhtrang.TabIndex = 6;
            this.btXoatinhtrang.Text = "Xóa";
            this.btXoatinhtrang.UseVisualStyleBackColor = true;
            this.btXoatinhtrang.Click += new System.EventHandler(this.btXoatinhtrang_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(14, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(464, 236);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "matinhtrang";
            this.Column1.HeaderText = "Mã tình trạng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "tentinhtrang";
            this.Column2.HeaderText = "Tên tình trạng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(137, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "TÌNH TRẠNG PHÒNG";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(376, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tinhtrang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btXoatinhtrang);
            this.Controls.Add(this.btSuatinhtrang);
            this.Controls.Add(this.btThemtinhtrang);
            this.Controls.Add(this.txtTentinhtrang);
            this.Controls.Add(this.txtMatinhtrang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "Tinhtrang";
            this.Text = "Tình Trạng Phòng";
            this.Load += new System.EventHandler(this.Tinhtrang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatinhtrang;
        private System.Windows.Forms.TextBox txtTentinhtrang;
        private System.Windows.Forms.Button btThemtinhtrang;
        private System.Windows.Forms.Button btSuatinhtrang;
        private System.Windows.Forms.Button btXoatinhtrang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button button1;
    }
}