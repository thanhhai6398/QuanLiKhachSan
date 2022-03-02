
namespace QLHotel
{
    partial class DatPhongForm
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtMaP = new System.Windows.Forms.TextBox();
            this.dateTimeNgayDi = new System.Windows.Forms.DateTimePicker();
            this.dateTimeNgayDen = new System.Windows.Forms.DateTimePicker();
            this.txtMPDat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDatphong = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbMaKH = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gvPhongTrong = new System.Windows.Forms.DataGridView();
            this.gvPhieuDatPhong = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhongTrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuDatPhong)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Location = new System.Drawing.Point(207, 379);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 40);
            this.btnThoat.TabIndex = 31;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtMaP
            // 
            this.txtMaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaP.Location = new System.Drawing.Point(135, 115);
            this.txtMaP.Name = "txtMaP";
            this.txtMaP.Size = new System.Drawing.Size(187, 26);
            this.txtMaP.TabIndex = 19;
            // 
            // dateTimeNgayDi
            // 
            this.dateTimeNgayDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNgayDi.Location = new System.Drawing.Point(135, 187);
            this.dateTimeNgayDi.Name = "dateTimeNgayDi";
            this.dateTimeNgayDi.Size = new System.Drawing.Size(183, 26);
            this.dateTimeNgayDi.TabIndex = 18;
            // 
            // dateTimeNgayDen
            // 
            this.dateTimeNgayDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNgayDen.Location = new System.Drawing.Point(135, 151);
            this.dateTimeNgayDen.Name = "dateTimeNgayDen";
            this.dateTimeNgayDen.Size = new System.Drawing.Size(183, 26);
            this.dateTimeNgayDen.TabIndex = 17;
            // 
            // txtMPDat
            // 
            this.txtMPDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMPDat.Location = new System.Drawing.Point(135, 51);
            this.txtMPDat.Name = "txtMPDat";
            this.txtMPDat.Size = new System.Drawing.Size(187, 26);
            this.txtMPDat.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(17, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ngày đi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(17, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngày đến:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(17, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã phòng:";
            // 
            // btnDatphong
            // 
            this.btnDatphong.BackColor = System.Drawing.Color.LightSalmon;
            this.btnDatphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnDatphong.Location = new System.Drawing.Point(26, 313);
            this.btnDatphong.Name = "btnDatphong";
            this.btnDatphong.Size = new System.Drawing.Size(114, 39);
            this.btnDatphong.TabIndex = 30;
            this.btnDatphong.Text = "Đặt phòng";
            this.btnDatphong.UseVisualStyleBackColor = false;
            this.btnDatphong.Click += new System.EventHandler(this.btnDatphong_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSua.Location = new System.Drawing.Point(207, 313);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 39);
            this.btnSua.TabIndex = 29;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Lime;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.Location = new System.Drawing.Point(430, 9);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(104, 30);
            this.btnLamMoi.TabIndex = 0;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(17, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(17, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã phiếu đặt:";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Red;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Location = new System.Drawing.Point(26, 379);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(114, 40);
            this.btnHuy.TabIndex = 28;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbMaKH);
            this.groupBox2.Controls.Add(this.txtMaP);
            this.groupBox2.Controls.Add(this.dateTimeNgayDi);
            this.groupBox2.Controls.Add(this.dateTimeNgayDen);
            this.groupBox2.Controls.Add(this.txtMPDat);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 238);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phiếu đặt phòng";
            // 
            // cbMaKH
            // 
            this.cbMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaKH.FormattingEnabled = true;
            this.cbMaKH.Location = new System.Drawing.Point(135, 81);
            this.cbMaKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(187, 28);
            this.cbMaKH.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gvPhongTrong);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(357, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 238);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm phòng trống";
            // 
            // gvPhongTrong
            // 
            this.gvPhongTrong.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gvPhongTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPhongTrong.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.gvPhongTrong.Location = new System.Drawing.Point(23, 45);
            this.gvPhongTrong.Name = "gvPhongTrong";
            this.gvPhongTrong.RowHeadersWidth = 51;
            this.gvPhongTrong.Size = new System.Drawing.Size(511, 171);
            this.gvPhongTrong.TabIndex = 1;
            this.gvPhongTrong.Click += new System.EventHandler(this.gvPhongTrong_Click);
            // 
            // gvPhieuDatPhong
            // 
            this.gvPhieuDatPhong.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gvPhieuDatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPhieuDatPhong.Location = new System.Drawing.Point(23, 21);
            this.gvPhieuDatPhong.Name = "gvPhieuDatPhong";
            this.gvPhieuDatPhong.RowHeadersWidth = 51;
            this.gvPhieuDatPhong.Size = new System.Drawing.Size(511, 230);
            this.gvPhieuDatPhong.TabIndex = 32;
            this.gvPhieuDatPhong.Click += new System.EventHandler(this.gvPhieuDatPhong_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gvPhieuDatPhong);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox3.Location = new System.Drawing.Point(357, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(551, 270);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phiếu đặt phòng";
            // 
            // DatPhongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(981, 547);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDatphong);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DatPhongForm";
            this.Text = "DatPhongForm";
            this.Load += new System.EventHandler(this.DatPhongForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvPhongTrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuDatPhong)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtMaP;
        private System.Windows.Forms.DateTimePicker dateTimeNgayDi;
        private System.Windows.Forms.DateTimePicker dateTimeNgayDen;
        private System.Windows.Forms.TextBox txtMPDat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDatphong;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvPhongTrong;
        private System.Windows.Forms.DataGridView gvPhieuDatPhong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbMaKH;
    }
}