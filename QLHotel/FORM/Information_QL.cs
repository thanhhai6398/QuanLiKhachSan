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
    public partial class Information_QL : Form
    {
        public Information_QL()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        private void Information_QL_Load(object sender, EventArgs e)
        {
            idTextBox.Text = Global.GlobalUserId;
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "SELECT ho,ten ,SDT, gioitinh,ngaysinh,diachi,ngayfirst FROM quanly WHERE quanly_id = @ID";
            command.Parameters.Add("@ID", SqlDbType.NVarChar).Value = Global.GlobalUserId;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            SqlDataReader sdr = command.ExecuteReader();

            while (sdr.Read())
            {
                hoTextBox.Text = sdr["ho"].ToString();
                tenTextBox.Text = sdr["ten"].ToString();
                phoneTextBox.Text = sdr["sdt"].ToString();
                string gioitinh = sdr["gioitinh"].ToString();
                if (gioitinh == "nữ")
                {
                    nuRadioButton.Checked = true;
                    namRadioButton.Checked = false;
                }
                else
                {
                    nuRadioButton.Checked = false;
                    namRadioButton.Checked = true;

                }
                ngaysinhDateTimePicker.Value = Convert.ToDateTime(sdr["ngaysinh"]);
                addressTextBox.Text = sdr["diachi"].ToString();
                ngayfirstDateTimePicker.Value = Convert.ToDateTime(sdr["ngayfirst"]);

            }
        }
        
    }
}
