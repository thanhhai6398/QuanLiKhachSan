using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHotel
{
    public partial class BaoCaoCongViec : Form
    {
        LAOCONG laocong = new LAOCONG();
        TIEPTAN tieptan = new TIEPTAN();
        QUANLY quanly = new QUANLY();
        public BaoCaoCongViec()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateTimePicker1.Value = monthCalendar1.SelectionRange.Start;
        }

        private void laocongButton_Click(object sender, EventArgs e)
        {
            DateTime ngay = dateTimePicker1.Value;
            int count = (int)tieptan.totalLaoViecTrongNgay(ngay);
            DataTable table = laocong.layNhanvienLamViec(ngay);
            DataTable dt = new DataTable();
            totallabel.Text = "Tổng Số Ca Làm Việc:" + count.ToString();


            dt.Columns.Add("Employee Id");

            dt.Columns.Add("Employee FistName");
            dt.Columns.Add("Employee LnameName");

            dt.Columns.Add("Time Work");
            dt.Columns.Add("Status");

            dt.Columns.Add("Total Hourse");
            dt.Columns.Add("Total Salary");
            DataRow dr;

            for (int i = 0; i < count; i++)
            {

                dr = dt.NewRow();

                dr["Employee Id"] = table.Rows[i]["laocong_id"].ToString();

                dr["Employee FistName"] = table.Rows[i]["ho"].ToString();

                dr["Employee LnameName"] = table.Rows[i]["ten"].ToString();


                string timeIn = table.Rows[i]["start_time"].ToString();
                string timeOut = table.Rows[i]["end_time"].ToString();
                DateTime tIn = Convert.ToDateTime(timeIn);
                DateTime tOut = Convert.ToDateTime(timeOut);

                if (tIn.Hour >= 6 && tIn.Hour <= 13)
                {
                    dr["Time Work"] = "Ca Sáng";
                    if (tIn.Hour == 6)
                    {
                        dr["Status"] = "No Late";
                    }
                    else
                    {
                        dr["Status"] = "Late";
                    }
                }
                else if (tIn.Hour >= 14 && tIn.Hour <= 23)
                {
                    dr["Time Work"] = "Ca Chiều";

                    if (tIn.Hour == 14)
                    {
                        dr["Status"] = "No Late";
                    }
                    else
                    {
                        dr["Status"] = "Late";
                    }
                }
                else if (tIn.Hour >= 22 && tIn.Hour <= 6)
                {
                    dr["Time Work"] = "Ca Tối";
                    if (tIn.Hour == 22)
                    {
                        dr["Status"] = "No Late";
                    }
                    else
                    {
                        dr["Status"] = "Late";
                    }
                }

                dr["Total Hourse"] = tOut.Hour - tIn.Hour - 1;
                dr["Total Salary"] = (tOut.Hour - tIn.Hour - 1) * 40000;
                dt.Rows.Add(dr);


            }

            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.AllowUserToDeleteRows = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.DataSource = dt;
        }

        private void BaoCaoCongViec_Load(object sender, EventArgs e)
        {
            totallabel.Text = "Tổng Số Ca Làm Việc : 0 ";
        }

        private void tieptanButton_Click(object sender, EventArgs e)
        {
            DateTime ngay = dateTimePicker1.Value;
            int count = (int)tieptan.totalLaoViecTrongNgay(ngay);
            DataTable table = tieptan.layNhanvienLamViec(ngay);
            DataTable dt = new DataTable();
            totallabel.Text = "Tổng Số Ca Làm Việc:" + count.ToString();


            dt.Columns.Add("Employee Id");

            dt.Columns.Add("Employee FistName");
            dt.Columns.Add("Employee LnameName");

            dt.Columns.Add("Time Work");
            dt.Columns.Add("Status");

            dt.Columns.Add("Total Hourse");
            dt.Columns.Add("Total Salary");
            DataRow dr;

            for (int i = 0; i < count; i++)
            {

                dr = dt.NewRow();

                dr["Employee Id"] = table.Rows[i]["tieptan_id"].ToString();

                dr["Employee FistName"] = table.Rows[i]["ho"].ToString();

                dr["Employee LnameName"] = table.Rows[i]["ten"].ToString();


                string timeIn = table.Rows[i]["start_time"].ToString();
                string timeOut = table.Rows[i]["end_time"].ToString();
                DateTime tIn = Convert.ToDateTime(timeIn);
                DateTime tOut = Convert.ToDateTime(timeOut);

                if (tIn.Hour >= 6 && tIn.Hour <= 13)
                {
                    dr["Time Work"] = "Ca Sáng";
                    if (tIn.Hour == 6)
                    {
                        dr["Status"] = "No Late";
                    }
                    else
                    {
                        dr["Status"] = "Late";
                    }
                }
                else if (tIn.Hour >= 14 && tIn.Hour <= 23)
                {
                    dr["Time Work"] = "Ca Chiều";

                    if (tIn.Hour == 14)
                    {
                        dr["Status"] = "No Late";
                    }
                    else
                    {
                        dr["Status"] = "Late";
                    }
                }
                else if (tIn.Hour >= 22 && tIn.Hour <= 6)
                {
                    dr["Time Work"] = "Ca Tối";
                    if (tIn.Hour == 22)
                    {
                        dr["Status"] = "No Late";
                    }
                    else
                    {
                        dr["Status"] = "Late";
                    }
                }

                dr["Total Hourse"] = tOut.Hour - tIn.Hour - 1;
                dr["Total Salary"] = (tOut.Hour - tIn.Hour - 1) * 60000;
                dt.Rows.Add(dr);

            }

            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.AllowUserToDeleteRows = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.DataSource = dt;
        }

        private void quanlyButton_Click(object sender, EventArgs e)
        {
            DateTime ngay = dateTimePicker1.Value;
            int count = (int)quanly.totalLaoViecTrongNgay(ngay);
            DataTable table = quanly.layNhanvienLamViec(ngay);
            DataTable dt = new DataTable();
            totallabel.Text = "Tổng Số Ca Làm Việc:" + count.ToString();


            dt.Columns.Add("Employee Id");

            dt.Columns.Add("Employee FistName");
            dt.Columns.Add("Employee LnameName");

            dt.Columns.Add("Time Work");
            dt.Columns.Add("Status");

            dt.Columns.Add("Total Hourse");
            dt.Columns.Add("Total Salary");
            DataRow dr;

            for (int i = 0; i < count; i++)
            {

                dr = dt.NewRow();

                dr["Employee Id"] = table.Rows[i]["quanly_id"].ToString();

                dr["Employee FistName"] = table.Rows[i]["ho"].ToString();

                dr["Employee LnameName"] = table.Rows[i]["ten"].ToString();


                string timeIn = table.Rows[i]["start_time"].ToString();
                string timeOut = table.Rows[i]["end_time"].ToString();
                DateTime tIn = Convert.ToDateTime(timeIn);
                DateTime tOut = Convert.ToDateTime(timeOut);

                if (tIn.Hour >= 6 && tIn.Hour <= 13)
                {
                    dr["Time Work"] = "Ca Sáng";
                    if (tIn.Hour == 6)
                    {
                        dr["Status"] = "No Late";
                    }
                    else
                    {
                        dr["Status"] = "Late";
                    }
                }
                else if (tIn.Hour >= 14 && tIn.Hour <= 23)
                {
                    dr["Time Work"] = "Ca Chiều";

                    if (tIn.Hour == 14)
                    {
                        dr["Status"] = "No Late";
                    }
                    else
                    {
                        dr["Status"] = "Late";
                    }
                }
                else if (tIn.Hour >= 22 && tIn.Hour <= 6)
                {
                    dr["Time Work"] = "Ca Tối";
                    if (tIn.Hour == 22)
                    {
                        dr["Status"] = "No Late";
                    }
                    else
                    {
                        dr["Status"] = "Late";
                    }
                }

                dr["Total Hourse"] = tOut.Hour - tIn.Hour - 1;
                dr["Total Salary"] = (tOut.Hour - tIn.Hour - 1) * 80000;
                dt.Rows.Add(dr);

            }

            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.AllowUserToDeleteRows = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.DataSource = dt;
        }
    }
}
