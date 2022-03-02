using Syncfusion.Windows.Forms.Schedule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHotel
{
   
    public partial class PhanCongCV : Form
    {
        int templc = 0;
        int temptt = 0;
        int tempql = 0;
        LAOCONG laocong = new LAOCONG();
        TIEPTAN tieptan = new TIEPTAN();
        QUANLY quanly = new QUANLY();
        public PhanCongCV()
        {
            InitializeComponent();

        }
        private int GetWeekNumber(DateTime date)
        {
            GregorianCalendar calendar = new GregorianCalendar(GregorianCalendarTypes.USEnglish);
            return calendar.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
        }
        private void PhanCongCV_Load(object sender, EventArgs e)
        {
            DateTime ngay = monthCalendar1.SelectionRange.Start;
            int numWeek = GetWeekNumber(ngay);
            weekLabel.Text = "Tuần :" + numWeek.ToString();
            FirstDateTimePicker.Value = FirstDayOfWeek(ngay);
            LastDateTimePicker.Value = LastDayOfWeek(ngay);

        }
        public void week()
        {
            DateTime ngay = monthCalendar1.SelectionRange.Start;
            int numWeek = GetWeekNumber(ngay);
            weekLabel.Text = "Tuần :" + numWeek.ToString();
            FirstDateTimePicker.Value = FirstDayOfWeek(ngay);
            LastDateTimePicker.Value = LastDayOfWeek(ngay);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime ngay = monthCalendar1.SelectionRange.Start;
            week();
        }
        public static DateTime FirstDayOfWeek(DateTime date)
        {
            DayOfWeek fdow = CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek;
            int offset = fdow - date.DayOfWeek;
            DateTime fdowDate = date.AddDays(offset);
            return fdowDate;
        }

        public static DateTime LastDayOfWeek(DateTime date)
        {
            DateTime ldowDate = FirstDayOfWeek(date).AddDays(6);
            return ldowDate;
        }

        private void laocongbutton_Click(object sender, EventArgs e)
        {
            DateTime date = monthCalendar1.SelectionRange.Start;
            DateTime firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            //Tuan ma ban muon xep lich

            DateTime ngay = monthCalendar1.SelectionRange.Start;
            int numWeek = GetWeekNumber(ngay);
            weekLabel.Text = "Tuần : " + numWeek.ToString();
            FirstDateTimePicker.Value = FirstDayOfWeek(ngay);
            LastDateTimePicker.Value = LastDayOfWeek(ngay);

            //so nhan Vien
            int conut = (int)laocong.totalNhanVien();
            DataTable dt = new DataTable();
            //
            DataTable table = laocong.layNhanvien();
            dt.Columns.Add("Employee Id");

            dt.Columns.Add("Employee FistName");
            dt.Columns.Add("Employee LnameName");

            dt.Columns.Add("Time Work");
            dt.Columns.Add("Day Work");
   
            DataRow dr;
            for (int i = 0; i < 7; i++)
            {
                int soCa = 0 ;
                DateTime day = FirstDateTimePicker.Value;
                day = day.AddDays(+i);

                if (day.DayOfWeek == DayOfWeek.Monday || day.DayOfWeek == DayOfWeek.Tuesday ||
                     day.DayOfWeek == DayOfWeek.Wednesday || day.DayOfWeek == DayOfWeek.Thursday ||
                     day.DayOfWeek == DayOfWeek.Friday)
                {
                    while (soCa != 6)
                    {

                        dr = dt.NewRow();

                        dr["Employee Id"]       = table.Rows[templc]["laocong_id"].ToString();
                        dr["Employee FistName"]  = table.Rows[templc]["ho"].ToString();
                        dr["Employee LnameName"] = table.Rows[templc]["ten"].ToString();

                        if (soCa >= 0 && soCa <= 3)
                        {
                            dr["Time Work"] = "Ca Sáng";
                        }
                        else if (soCa == 4 )
                        {
                            dr["Time Work"] = "Ca Chiều";

                        }
                        else 
                        {
                            dr["Time Work"] = "Ca Tối";
                        }
                        dr["Day Work"] = day.ToString("dd/MM/yyyy");
                        templc++;
                        if (templc == conut)
                        {
                            templc = 0;
                        }
                        soCa++;
                        dt.Rows.Add(dr);
                    }


                }
                else
                {
                    while (soCa != 8)
                    {

                        dr = dt.NewRow();

                        dr["Employee Id"] = table.Rows[templc]["laocong_id"].ToString();
                        dr["Employee FistName"] = table.Rows[templc]["ho"].ToString();
                        dr["Employee LnameName"] = table.Rows[templc]["ten"].ToString();

                        if (soCa >= 0 && soCa <= 3)
                        {
                            dr["Time Work"] = "Ca Sáng";
                        }
                        else if (soCa == 4)
                        {
                            dr["Time Work"] = "Ca Chiều";

                        }
                        else
                        {
                            dr["Time Work"] = "Ca Tối";
                        }
                        dr["Day Work"] = day.ToString("dd/MM/yyyy");
                        templc++;
                        if( templc == conut)
                        {
                            templc = 0;
                        }
                        soCa++;
                        dt.Rows.Add(dr);
                    }
                }



                dataGridView1.AllowUserToAddRows = false;

                dataGridView1.AllowUserToDeleteRows = false;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView1.DataSource = dt;



            }

   


        }

        private void tieptanbutton_Click(object sender, EventArgs e)
        {
            DateTime date = monthCalendar1.SelectionRange.Start;
            DateTime firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            //Tuan ma ban muon xep lich

            DateTime ngay = monthCalendar1.SelectionRange.Start;
            int numWeek = GetWeekNumber(ngay);
            weekLabel.Text = "Tuần : " + numWeek.ToString();
            FirstDateTimePicker.Value = FirstDayOfWeek(ngay);
            LastDateTimePicker.Value = LastDayOfWeek(ngay);

            //so nhan Vien
            int conut = (int)tieptan.totalNhanVien();
            DataTable dt = new DataTable();
            //
            DataTable table = tieptan.layNhanvien();
            dt.Columns.Add("Employee Id");

            dt.Columns.Add("Employee FistName");
            dt.Columns.Add("Employee LnameName");

            dt.Columns.Add("Time Work");
            dt.Columns.Add("Day Work");

            DataRow dr;
            for (int i = 0; i < 7; i++)
            {
                
                int soCa = 0;
                DateTime day = FirstDateTimePicker.Value;
                day = day.AddDays(+i);

                if (day.DayOfWeek == DayOfWeek.Monday ||
                     day.DayOfWeek == DayOfWeek.Wednesday ||
                     day.DayOfWeek == DayOfWeek.Friday||
                     day.DayOfWeek == DayOfWeek.Sunday )
                {
                    while (soCa != 4)
                    {

                        dr = dt.NewRow();

                        dr["Employee Id"] = table.Rows[temptt]["tieptan_id"].ToString();
                        dr["Employee FistName"] = table.Rows[temptt]["ho"].ToString();
                        dr["Employee LnameName"] = table.Rows[temptt]["ten"].ToString();

                        if (soCa >= 0 && soCa <= 1)
                        {
                            dr["Time Work"] = "Ca Sáng";
                        }
                        else if (soCa == 2)
                        {
                            dr["Time Work"] = "Ca Chiều";

                        }
                        else
                        {
                            dr["Time Work"] = "Ca Tối";
                        }
                        dr["Day Work"] = day.ToString("dd/MM/yyyy");
                        temptt++;
                        if (temptt == conut)
                        {
                            temptt = 0;
                        }
                        soCa++;
                        dt.Rows.Add(dr);
                    }


                }
                else
                {
                    while (soCa != 3)
                    {

                        dr = dt.NewRow();

                        dr["Employee Id"] = table.Rows[temptt]["tieptan_id"].ToString();
                        dr["Employee FistName"] = table.Rows[temptt]["ho"].ToString();
                        dr["Employee LnameName"] = table.Rows[temptt]["ten"].ToString();

                        if (soCa >= 0 && soCa <= 1)
                        {
                            dr["Time Work"] = "Ca Sáng";
                        }
                        else if (soCa == 2)
                        {
                            dr["Time Work"] = "Ca Chiều";

                        }
                        
                        dr["Day Work"] = day.ToString("dd/MM/yyyy");
                        temptt++;
                        if (temptt == conut)
                        {
                            temptt = 0;
                        }
                        soCa++;
                        dt.Rows.Add(dr);
                    }
                }



                dataGridView1.AllowUserToAddRows = false;

                dataGridView1.AllowUserToDeleteRows = false;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView1.DataSource = dt;



            }




        }

        private void quanlybutton_Click(object sender, EventArgs e)
        {
            DateTime date = monthCalendar1.SelectionRange.Start;
            DateTime firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            //Tuan ma ban muon xep lich

            DateTime ngay = monthCalendar1.SelectionRange.Start;
            int numWeek = GetWeekNumber(ngay);
            weekLabel.Text = "Tuần : " + numWeek.ToString();
            FirstDateTimePicker.Value = FirstDayOfWeek(ngay);
            LastDateTimePicker.Value = LastDayOfWeek(ngay);

            //so nhan Vien
            int conut = (int)quanly.totalNhanVien();
            DataTable dt = new DataTable();
            //
            DataTable table = quanly.layNhanvien();
            dt.Columns.Add("Employee Id");

            dt.Columns.Add("Employee FistName");
            dt.Columns.Add("Employee LnameName");

            dt.Columns.Add("Time Work");
            dt.Columns.Add("Day Work");

            DataRow dr;
            for (int i = 0; i < 7; i++)
            {
                int soCa = 0;
                DateTime day = FirstDateTimePicker.Value;
                day = day.AddDays(+i);

                if (day.DayOfWeek == DayOfWeek.Tuesday||
                     day.DayOfWeek == DayOfWeek.Thursday ||
                     day.DayOfWeek == DayOfWeek.Saturday)
                {
                    while (soCa != 3)
                    {

                        dr = dt.NewRow();

                        dr["Employee Id"] = table.Rows[tempql]["quanly_id"].ToString();
                        dr["Employee FistName"] = table.Rows[tempql]["ho"].ToString();
                        dr["Employee LnameName"] = table.Rows[tempql]["ten"].ToString();

                        if (soCa == 0)
                        {
                            dr["Time Work"] = "Ca Sáng";
                        }
                        else if (soCa == 1)
                        {
                            dr["Time Work"] = "Ca Chiều";

                        }
                        else
                        {
                            dr["Time Work"] = "Ca Tối";
                        }
                        dr["Day Work"] = day.ToString("dd/MM/yyyy");
                        tempql++;
                        if (tempql == conut)
                        {
                            tempql = 0;
                        }
                        soCa++;
                        dt.Rows.Add(dr);
                    }


                }
                else
                {
                    while (soCa != 2)
                    {

                        dr = dt.NewRow();

                        dr["Employee Id"] = table.Rows[tempql]["quanly_id"].ToString();
                        dr["Employee FistName"] = table.Rows[tempql]["ho"].ToString();
                        dr["Employee LnameName"] = table.Rows[tempql]["ten"].ToString();

                        if (soCa == 0)
                        {
                            dr["Time Work"] = "Ca Sáng";
                        }
                        else if (soCa == 1)
                        {
                            dr["Time Work"] = "Ca Chiều";

                        }

                        dr["Day Work"] = day.ToString("dd/MM/yyyy");
                        tempql++;
                        if (tempql == conut)
                        {
                            tempql = 0;
                        }
                        soCa++;
                        dt.Rows.Add(dr);
                    }
                }



                dataGridView1.AllowUserToAddRows = false;

                dataGridView1.AllowUserToDeleteRows = false;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView1.DataSource = dt;



            }



        }
    }
  
}
