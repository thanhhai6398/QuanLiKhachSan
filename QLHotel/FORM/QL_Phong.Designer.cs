
namespace QLHotel
{
    partial class QL_Phong
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
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btnXoaLP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdCoKhach = new System.Windows.Forms.RadioButton();
            this.rdTrong = new System.Windows.Forms.RadioButton();
            this.btnSuaLP = new System.Windows.Forms.Button();
            this.btnThemLP = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoaP = new System.Windows.Forms.Button();
            this.btnSuaP = new System.Windows.Forms.Button();
            this.btnThemP = new System.Windows.Forms.Button();
            this.gvPhong = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gvLoaiPhong = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaloai = new System.Windows.Forms.TextBox();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLoai = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSonguoi = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiPhong)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGia.Location = new System.Drawing.Point(95, 163);
            this.txtGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(190, 26);
            this.txtGia.TabIndex = 18;
            // 
            // btnXoaLP
            // 
            this.btnXoaLP.BackColor = System.Drawing.Color.Red;
            this.btnXoaLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnXoaLP.Location = new System.Drawing.Point(209, 232);
            this.btnXoaLP.Name = "btnXoaLP";
            this.btnXoaLP.Size = new System.Drawing.Size(86, 33);
            this.btnXoaLP.TabIndex = 16;
            this.btnXoaLP.Text = "Xóa";
            this.btnXoaLP.UseVisualStyleBackColor = false;
            this.btnXoaLP.Click += new System.EventHandler(this.btnXoaLP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdCoKhach);
            this.groupBox1.Controls.Add(this.rdTrong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(95, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 41);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // rdCoKhach
            // 
            this.rdCoKhach.AutoSize = true;
            this.rdCoKhach.Location = new System.Drawing.Point(99, 12);
            this.rdCoKhach.Name = "rdCoKhach";
            this.rdCoKhach.Size = new System.Drawing.Size(94, 24);
            this.rdCoKhach.TabIndex = 1;
            this.rdCoKhach.TabStop = true;
            this.rdCoKhach.Text = "Có khách";
            this.rdCoKhach.UseVisualStyleBackColor = true;
            // 
            // rdTrong
            // 
            this.rdTrong.AutoSize = true;
            this.rdTrong.Location = new System.Drawing.Point(6, 12);
            this.rdTrong.Name = "rdTrong";
            this.rdTrong.Size = new System.Drawing.Size(68, 24);
            this.rdTrong.TabIndex = 0;
            this.rdTrong.TabStop = true;
            this.rdTrong.Text = "Trống";
            this.rdTrong.UseVisualStyleBackColor = true;
            // 
            // btnSuaLP
            // 
            this.btnSuaLP.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSuaLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSuaLP.Location = new System.Drawing.Point(113, 232);
            this.btnSuaLP.Name = "btnSuaLP";
            this.btnSuaLP.Size = new System.Drawing.Size(86, 33);
            this.btnSuaLP.TabIndex = 15;
            this.btnSuaLP.Text = "Sửa";
            this.btnSuaLP.UseVisualStyleBackColor = false;
            this.btnSuaLP.Click += new System.EventHandler(this.btnSuaLP_Click);
            // 
            // btnThemLP
            // 
            this.btnThemLP.BackColor = System.Drawing.Color.LightSalmon;
            this.btnThemLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnThemLP.Location = new System.Drawing.Point(17, 232);
            this.btnThemLP.Name = "btnThemLP";
            this.btnThemLP.Size = new System.Drawing.Size(86, 33);
            this.btnThemLP.TabIndex = 14;
            this.btnThemLP.Text = "Thêm";
            this.btnThemLP.UseVisualStyleBackColor = false;
            this.btnThemLP.Click += new System.EventHandler(this.btnThemLP_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(5, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tình trạng:";
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(95, 96);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(199, 28);
            this.cbLoaiPhong.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(214, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Danh sách phòng";
            // 
            // btnXoaP
            // 
            this.btnXoaP.BackColor = System.Drawing.Color.Red;
            this.btnXoaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnXoaP.Location = new System.Drawing.Point(204, 216);
            this.btnXoaP.Name = "btnXoaP";
            this.btnXoaP.Size = new System.Drawing.Size(90, 37);
            this.btnXoaP.TabIndex = 7;
            this.btnXoaP.Text = "Xóa";
            this.btnXoaP.UseVisualStyleBackColor = false;
            this.btnXoaP.Click += new System.EventHandler(this.btnXoaP_Click);
            // 
            // btnSuaP
            // 
            this.btnSuaP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSuaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSuaP.Location = new System.Drawing.Point(108, 216);
            this.btnSuaP.Name = "btnSuaP";
            this.btnSuaP.Size = new System.Drawing.Size(90, 37);
            this.btnSuaP.TabIndex = 6;
            this.btnSuaP.Text = "Sửa";
            this.btnSuaP.UseVisualStyleBackColor = false;
            this.btnSuaP.Click += new System.EventHandler(this.btnSuaP_Click);
            // 
            // btnThemP
            // 
            this.btnThemP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnThemP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnThemP.Location = new System.Drawing.Point(12, 216);
            this.btnThemP.Name = "btnThemP";
            this.btnThemP.Size = new System.Drawing.Size(90, 37);
            this.btnThemP.TabIndex = 5;
            this.btnThemP.Text = "Thêm";
            this.btnThemP.UseVisualStyleBackColor = false;
            this.btnThemP.Click += new System.EventHandler(this.btnThemP_Click);
            // 
            // gvPhong
            // 
            this.gvPhong.AllowUserToAddRows = false;
            this.gvPhong.AllowUserToDeleteRows = false;
            this.gvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvPhong.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPhong.Location = new System.Drawing.Point(333, 60);
            this.gvPhong.MultiSelect = false;
            this.gvPhong.Name = "gvPhong";
            this.gvPhong.ReadOnly = true;
            this.gvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvPhong.Size = new System.Drawing.Size(460, 355);
            this.gvPhong.TabIndex = 4;
            this.gvPhong.Click += new System.EventHandler(this.gvPhong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại phòng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(5, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã phòng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(241, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Loại phòng";
            // 
            // gvLoaiPhong
            // 
            this.gvLoaiPhong.AllowUserToAddRows = false;
            this.gvLoaiPhong.AllowUserToDeleteRows = false;
            this.gvLoaiPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvLoaiPhong.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gvLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLoaiPhong.Location = new System.Drawing.Point(306, 59);
            this.gvLoaiPhong.MultiSelect = false;
            this.gvLoaiPhong.Name = "gvLoaiPhong";
            this.gvLoaiPhong.ReadOnly = true;
            this.gvLoaiPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvLoaiPhong.Size = new System.Drawing.Size(481, 356);
            this.gvLoaiPhong.TabIndex = 13;
            this.gvLoaiPhong.Click += new System.EventHandler(this.gvLoaiPhong_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(6, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số người:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mã loại:";
            // 
            // txtMaloai
            // 
            this.txtMaloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaloai.Location = new System.Drawing.Point(95, 59);
            this.txtMaloai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaloai.Name = "txtMaloai";
            this.txtMaloai.Size = new System.Drawing.Size(190, 26);
            this.txtMaloai.TabIndex = 9;
            // 
            // txtMaphong
            // 
            this.txtMaphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaphong.Location = new System.Drawing.Point(95, 60);
            this.txtMaphong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(199, 26);
            this.txtMaphong.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(6, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Loại:";
            // 
            // txtLoai
            // 
            this.txtLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLoai.Location = new System.Drawing.Point(95, 95);
            this.txtLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLoai.Name = "txtLoai";
            this.txtLoai.Size = new System.Drawing.Size(190, 26);
            this.txtLoai.TabIndex = 20;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtLoai);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtGia);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnXoaLP);
            this.tabPage2.Controls.Add(this.btnSuaLP);
            this.tabPage2.Controls.Add(this.btnThemLP);
            this.tabPage2.Controls.Add(this.gvLoaiPhong);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtSonguoi);
            this.tabPage2.Controls.Add(this.txtMaloai);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(796, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý loại phòng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(3, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Giá:";
            // 
            // txtSonguoi
            // 
            this.txtSonguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSonguoi.Location = new System.Drawing.Point(95, 129);
            this.txtSonguoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSonguoi.Name = "txtSonguoi";
            this.txtSonguoi.Size = new System.Drawing.Size(190, 26);
            this.txtSonguoi.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.cbLoaiPhong);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnXoaP);
            this.tabPage1.Controls.Add(this.btnSuaP);
            this.tabPage1.Controls.Add(this.btnThemP);
            this.tabPage1.Controls.Add(this.gvPhong);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtMaphong);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(796, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý phòng";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 453);
            this.tabControl1.TabIndex = 2;
            // 
            // QL_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "QL_Phong";
            this.Text = "QL_Phong";
            this.Load += new System.EventHandler(this.QLPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiPhong)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btnXoaLP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdCoKhach;
        private System.Windows.Forms.RadioButton rdTrong;
        private System.Windows.Forms.Button btnSuaLP;
        private System.Windows.Forms.Button btnThemLP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoaP;
        private System.Windows.Forms.Button btnSuaP;
        private System.Windows.Forms.Button btnThemP;
        private System.Windows.Forms.DataGridView gvPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gvLoaiPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaloai;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLoai;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSonguoi;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}