
namespace QLHotel
{
    partial class BaoCaoCongViec
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.quanlyButton = new System.Windows.Forms.Button();
            this.tieptanButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.laocongButton = new System.Windows.Forms.Button();
            this.totallabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1, 63);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(39, 240);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 28);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Báo Cáo Công Việc ";
            // 
            // quanlyButton
            // 
            this.quanlyButton.AutoSize = true;
            this.quanlyButton.BackColor = System.Drawing.Color.LightSalmon;
            this.quanlyButton.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.quanlyButton.Location = new System.Drawing.Point(236, 132);
            this.quanlyButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quanlyButton.Name = "quanlyButton";
            this.quanlyButton.Size = new System.Drawing.Size(119, 46);
            this.quanlyButton.TabIndex = 3;
            this.quanlyButton.Text = "NV Quản Lý";
            this.quanlyButton.UseVisualStyleBackColor = false;
            this.quanlyButton.Click += new System.EventHandler(this.quanlyButton_Click);
            // 
            // tieptanButton
            // 
            this.tieptanButton.AutoSize = true;
            this.tieptanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tieptanButton.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.tieptanButton.Location = new System.Drawing.Point(387, 132);
            this.tieptanButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tieptanButton.Name = "tieptanButton";
            this.tieptanButton.Size = new System.Drawing.Size(119, 46);
            this.tieptanButton.TabIndex = 4;
            this.tieptanButton.Text = "NV Tiếp Tân";
            this.tieptanButton.UseVisualStyleBackColor = false;
            this.tieptanButton.Click += new System.EventHandler(this.tieptanButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 272);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(670, 302);
            this.dataGridView1.TabIndex = 5;
            // 
            // laocongButton
            // 
            this.laocongButton.AutoSize = true;
            this.laocongButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.laocongButton.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.laocongButton.Location = new System.Drawing.Point(536, 132);
            this.laocongButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.laocongButton.Name = "laocongButton";
            this.laocongButton.Size = new System.Drawing.Size(127, 46);
            this.laocongButton.TabIndex = 6;
            this.laocongButton.Text = "NV Lao Công";
            this.laocongButton.UseVisualStyleBackColor = false;
            this.laocongButton.Click += new System.EventHandler(this.laocongButton_Click);
            // 
            // totallabel
            // 
            this.totallabel.AutoSize = true;
            this.totallabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.totallabel.Location = new System.Drawing.Point(234, 209);
            this.totallabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totallabel.Name = "totallabel";
            this.totallabel.Size = new System.Drawing.Size(185, 20);
            this.totallabel.TabIndex = 7;
            this.totallabel.Text = "Tổng Số Ca Làm Việc:";
            // 
            // BaoCaoCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(674, 580);
            this.Controls.Add(this.totallabel);
            this.Controls.Add(this.laocongButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tieptanButton);
            this.Controls.Add(this.quanlyButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.monthCalendar1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BaoCaoCongViec";
            this.Text = "BaoCaoCongViec";
            this.Load += new System.EventHandler(this.BaoCaoCongViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button quanlyButton;
        private System.Windows.Forms.Button tieptanButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button laocongButton;
        private System.Windows.Forms.Label totallabel;
    }
}