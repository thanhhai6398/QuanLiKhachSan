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
    public partial class EditTT : Form
    {
        TIEPTAN tt = new TIEPTAN();
        MY_DB mydb = new MY_DB();
        public EditTT()
        {
            InitializeComponent();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            string idTT = idTieptanTextBox.Text;
            string ho = hoTieptanTextBox.Text;
            string ten = tenTieptanTextBox.Text;
            string sdt = phoneTextBox.Text;
            string gt = "nam";
            if ( nuTieptanRadioButton.Checked == true)
            {
                 gt = "nữ";
            }
          
            DateTime ngsinh = ngaysinhDateTimePicker.Value;
            DateTime ngfirst = ngayfirstDateTimePicker.Value;
            string diachi = addressTextBox.Text;
            if( tt.updateTT(idTT,ho,ten,sdt,gt,ngsinh,diachi,ngfirst) == true)
            {
                MessageBox.Show(" Cập Nhật Thông tin Thành Công", "Sửa Đổi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thông Tin Không Được Cập Nhật", "Sửa Đổi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
                


           
      
        }

        private void EditTT_Load(object sender, EventArgs e)
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
                tenTieptanTextBox.Text = sdr["ten"].ToString();
                phoneTextBox.Text = sdr["sdt"].ToString();
                string gioitinh = sdr["gioitinh"].ToString();
                if (gioitinh == "nữ")
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
                ngayfirstDateTimePicker.Value = Convert.ToDateTime(sdr["ngayfirst"]);
            }
        }

    }
}
