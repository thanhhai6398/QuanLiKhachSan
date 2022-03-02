
namespace QLHotel
{
    partial class TongThu
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
            this.gvTongThu = new System.Windows.Forms.DataGridView();
            this.labelTongThu = new System.Windows.Forms.Label();
            this.labelNgay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvTongThu)).BeginInit();
            this.SuspendLayout();
            // 
            // gvTongThu
            // 
            this.gvTongThu.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gvTongThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTongThu.Location = new System.Drawing.Point(19, 12);
            this.gvTongThu.Name = "gvTongThu";
            this.gvTongThu.Size = new System.Drawing.Size(421, 192);
            this.gvTongThu.TabIndex = 0;
            // 
            // labelTongThu
            // 
            this.labelTongThu.AutoSize = true;
            this.labelTongThu.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.labelTongThu.Location = new System.Drawing.Point(277, 228);
            this.labelTongThu.Name = "labelTongThu";
            this.labelTongThu.Size = new System.Drawing.Size(90, 20);
            this.labelTongThu.TabIndex = 1;
            this.labelTongThu.Text = "Tổng thu: ";
            // 
            // labelNgay
            // 
            this.labelNgay.AutoSize = true;
            this.labelNgay.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.labelNgay.Location = new System.Drawing.Point(15, 228);
            this.labelNgay.Name = "labelNgay";
            this.labelNgay.Size = new System.Drawing.Size(59, 20);
            this.labelNgay.TabIndex = 2;
            this.labelNgay.Text = "Ngày: ";
            // 
            // TongThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(471, 264);
            this.Controls.Add(this.labelNgay);
            this.Controls.Add(this.labelTongThu);
            this.Controls.Add(this.gvTongThu);
            this.Name = "TongThu";
            this.Text = "TongThu";
            this.Load += new System.EventHandler(this.TongThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTongThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvTongThu;
        private System.Windows.Forms.Label labelTongThu;
        private System.Windows.Forms.Label labelNgay;
    }
}