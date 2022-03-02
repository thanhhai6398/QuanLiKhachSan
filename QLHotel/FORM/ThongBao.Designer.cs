
namespace QLHotel
{
    partial class ThongBao
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
            this.gvTB = new System.Windows.Forms.DataGridView();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvTB)).BeginInit();
            this.SuspendLayout();
            // 
            // gvTB
            // 
            this.gvTB.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gvTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTB.Location = new System.Drawing.Point(44, 52);
            this.gvTB.Name = "gvTB";
            this.gvTB.Size = new System.Drawing.Size(374, 223);
            this.gvTB.TabIndex = 0;
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.buttonThoat.Location = new System.Drawing.Point(159, 300);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(109, 26);
            this.buttonThoat.TabIndex = 1;
            this.buttonThoat.Text = "THOÁT";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh Sách Khách Hàng Chưa Trả Phòng";
            // 
            // ThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(467, 338);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.gvTB);
            this.Name = "ThongBao";
            this.Text = "ThongBao";
            this.Load += new System.EventHandler(this.ThongBao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvTB;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Label label1;
    }
}