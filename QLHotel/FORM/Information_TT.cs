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
    public partial class Information_TT : Form
    {
        MY_DB mydb = new MY_DB();
        public Information_TT()
        {
            InitializeComponent();
        }

        private void Information_TT_Load(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "SELECT ho,ten ,sdt, gioitinh,ngaysinh,diachi,ngayfirst FROM tieptan WHERE tieptan_id = @ID";
            command.Parameters.Add("@ID", SqlDbType.NVarChar).Value = idTieptanTextBox.Text;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
           
            SqlDataReader sdr = command.ExecuteReader();

            while (sdr.Read())
            {
                hoTieptanTextBox.Text = sdr["ho"].ToString();
                tenTieptantTextBox.Text = sdr["ten"].ToString();
                phoneTieptanTextBox.Text  = sdr["sdt"].ToString();
                string gioitinh = sdr["gioitinh"].ToString();
                if ( gioitinh == "nữ")
                {
                    nuTieptanRadioButton.Checked = true;
                    namTieptanRadioButton.Checked = false;
                }
                else
                {
                    nuTieptanRadioButton.Checked = false;
                    namTieptanRadioButton.Checked = true;

                }
                ngaysinhDateTimePicker.Value = Convert.ToDateTime(sdr["ngaysinh"]);
                addressTextBox.Text = sdr["diachi"].ToString();
                firstdayDateTimePicker.Value = Convert.ToDateTime(sdr["ngayfirst"]);


            }
        }
    }
}
