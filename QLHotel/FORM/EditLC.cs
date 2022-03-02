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
    public partial class EditLC : Form
    {
        MY_DB mydb = new MY_DB();
        LAOCONG laocong = new LAOCONG();
        public EditLC()
        {
            InitializeComponent();
        }

        private void editLaocongButton_Click(object sender, EventArgs e)
        {
            string idTT = idLaocongTextBox.Text;
            string ho = hoLaocongTextBox.Text;
            string ten = tenLaocongTextBox.Text;
            string sdt = phoneLaocongTextBox.Text;
            string gt = "nam";
            if (nuLaocongRadioButton.Checked == true)
            {
                gt = "nữ";
            }

            DateTime ngsinh = ngaysinhDateTimePicker.Value;
            DateTime ngfirst = ngayfirstDateTimePicker.Value;
            string diachi = addressTextBox.Text;
            if (laocong.updateLC(idTT, ho, ten, sdt, gt, ngsinh, diachi, ngfirst) == true)
            {
                MessageBox.Show(" Cập Nhật Thông tin Thành Công", "Sửa Đổi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thông Tin Không Được Cập Nhật", "Sửa Đổi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditLC_Load(object sender, EventArgs e)
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
