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
    public partial class Information_LC : Form
    {
        MY_DB mydb = new MY_DB();
        public Information_LC()
        {
            InitializeComponent();
        }

        private void Information_LC_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "SELECT ho,ten ,sdt, gioitinh,ngaysinh,diachi,ngayfirst FROM laocong WHERE laocong_id = @ID";
            command.Parameters.Add("@ID", SqlDbType.NVarChar).Value = idLaocongTextBox.Text;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            SqlDataReader sdr = command.ExecuteReader();

            while (sdr.Read())
            {
                hoLaocongTextBox.Text = sdr["ho"].ToString();
                tenLaocongTextBox.Text = sdr["ten"].ToString();
                phoneLaocongTextBox.Text = sdr["sdt"].ToString();
                string gioitinh = sdr["gioitinh"].ToString();
                if (gioitinh == "nữ")
                {
                    nuLaocongRadioButton.Checked = true;
                    namLaocongRadioButton.Checked = false;
                }
                else
                {
                    nuLaocongRadioButton.Checked = false;
                    namLaocongRadioButton.Checked = true;

                }
                ngaysinhDateTimePicker.Value = Convert.ToDateTime(sdr["ngaysinh"]);
                addressTextBox.Text = sdr["diachi"].ToString();
                ngayfirstDateTimePicker.Value = Convert.ToDateTime(sdr["ngayfirst"]);

            }


        }
    }
}
