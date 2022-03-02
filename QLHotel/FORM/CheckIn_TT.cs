using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHotel
{
    public partial class CheckIn_TT : Form
    {
        MY_DB db = new MY_DB();
        CHECK check = new CHECK();
        public CheckIn_TT()
        {
            InitializeComponent();
        }

        private void CheckIn_TT_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            DataTable dt = new DataTable();

            dt.Columns.Add("Employee Id");

            dt.Columns.Add("Employee FistName");
            dt.Columns.Add("Employee LnameName");

            dt.Columns.Add("Select", System.Type.GetType("System.Boolean"));

            dt.Columns.Add("Join Date");

            DataRow dr;
            dr = dt.NewRow();

            dr["Select"] = false;
            dr["Employee Id"] = Global.GlobalUserId;

            //get fname,lname   
            SqlCommand com = new SqlCommand();
            com.Connection = db.getConnection;
            com.CommandText = "SELECT ho,ten FROM tieptan WHERE tieptan_id=@id";
            com.Parameters.Add("@id", SqlDbType.NVarChar).Value = Global.GlobalUserId;
            db.openConnection();
            SqlDataAdapter adap = new SqlDataAdapter(com);

            SqlDataReader sdr = com.ExecuteReader();

            while (sdr.Read())
            {

                dr["Employee FistName"] = sdr["ho"].ToString();
                dr["Employee LnameName"] = sdr["ten"].ToString();
            }
            db.closeConnection();

            //"dd/MM/yyyy"
            dr["Join Date"] = DateTime.Now.ToString();
            dt.Rows.Add(dr);
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.AllowUserToDeleteRows = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Select"].Index)

            {

                dataGridView1.EndEdit();  //Stop editing of cell.

                if ((bool)dataGridView1.Rows[e.RowIndex].Cells["Select"].Value)
                {


                    if (check.insertCheckIn(Global.GlobalUserId, DateTime.Now) == true)
                    {
                        MessageBox.Show("The Value is Checked", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("UnChecked", "Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}
