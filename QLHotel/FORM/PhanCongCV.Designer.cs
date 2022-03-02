
namespace QLHotel
{
    partial class PhanCongCV
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.quanlybutton = new System.Windows.Forms.Button();
            this.tieptanbutton = new System.Windows.Forms.Button();
            this.laocongbutton = new System.Windows.Forms.Button();
            this.FirstDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LastDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.weekLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lịch Phân Công";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(5, 37);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // quanlybutton
            // 
            this.quanlybutton.BackColor = System.Drawing.Color.LightSalmon;
            this.quanlybutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.quanlybutton.Location = new System.Drawing.Point(301, 163);
            this.quanlybutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quanlybutton.Name = "quanlybutton";
            this.quanlybutton.Size = new System.Drawing.Size(121, 36);
            this.quanlybutton.TabIndex = 2;
            this.quanlybutton.Text = "Quản Lý";
            this.quanlybutton.UseVisualStyleBackColor = false;
            this.quanlybutton.Click += new System.EventHandler(this.quanlybutton_Click);
            // 
            // tieptanbutton
            // 
            this.tieptanbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tieptanbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.tieptanbutton.Location = new System.Drawing.Point(463, 163);
            this.tieptanbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tieptanbutton.Name = "tieptanbutton";
            this.tieptanbutton.Size = new System.Drawing.Size(121, 36);
            this.tieptanbutton.TabIndex = 3;
            this.tieptanbutton.Text = "Tiếp Tân";
            this.tieptanbutton.UseVisualStyleBackColor = false;
            this.tieptanbutton.Click += new System.EventHandler(this.tieptanbutton_Click);
            // 
            // laocongbutton
            // 
            this.laocongbutton.BackColor = System.Drawing.Color.Khaki;
            this.laocongbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.laocongbutton.Location = new System.Drawing.Point(627, 163);
            this.laocongbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.laocongbutton.Name = "laocongbutton";
            this.laocongbutton.Size = new System.Drawing.Size(121, 36);
            this.laocongbutton.TabIndex = 4;
            this.laocongbutton.Text = "Lao Công";
            this.laocongbutton.UseVisualStyleBackColor = false;
            this.laocongbutton.Click += new System.EventHandler(this.laocongbutton_Click);
            // 
            // FirstDateTimePicker
            // 
            this.FirstDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FirstDateTimePicker.Location = new System.Drawing.Point(301, 73);
            this.FirstDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FirstDateTimePicker.Name = "FirstDateTimePicker";
            this.FirstDateTimePicker.Size = new System.Drawing.Size(151, 37);
            this.FirstDateTimePicker.TabIndex = 5;
            // 
            // LastDateTimePicker
            // 
            this.LastDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.LastDateTimePicker.Location = new System.Drawing.Point(536, 73);
            this.LastDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LastDateTimePicker.Name = "LastDateTimePicker";
            this.LastDateTimePicker.Size = new System.Drawing.Size(151, 37);
            this.LastDateTimePicker.TabIndex = 6;
            // 
            // weekLabel
            // 
            this.weekLabel.AutoSize = true;
            this.weekLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekLabel.Location = new System.Drawing.Point(615, 9);
            this.weekLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weekLabel.Name = "weekLabel";
            this.weekLabel.Size = new System.Drawing.Size(72, 27);
            this.weekLabel.TabIndex = 7;
            this.weekLabel.Text = "Tuần: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 216);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(847, 333);
            this.dataGridView1.TabIndex = 8;
            // 
            // PhanCongCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(865, 559);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.weekLabel);
            this.Controls.Add(this.LastDateTimePicker);
            this.Controls.Add(this.FirstDateTimePicker);
            this.Controls.Add(this.laocongbutton);
            this.Controls.Add(this.tieptanbutton);
            this.Controls.Add(this.quanlybutton);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PhanCongCV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhanCongCV";
            this.Load += new System.EventHandler(this.PhanCongCV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button quanlybutton;
        private System.Windows.Forms.Button tieptanbutton;
        private System.Windows.Forms.Button laocongbutton;
        private System.Windows.Forms.DateTimePicker FirstDateTimePicker;
        private System.Windows.Forms.DateTimePicker LastDateTimePicker;
        private System.Windows.Forms.Label weekLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}