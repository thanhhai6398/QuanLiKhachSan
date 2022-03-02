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
    public partial class QL_Nhanvien : Form
    {
        TIEPTAN tieptan = new TIEPTAN();
        LAOCONG laocong = new LAOCONG();
        MY_DB mydb = new MY_DB();
        string data = "";
        public QL_Nhanvien()
        {
            InitializeComponent();
        }

        private void QLNhanvien_Load(object sender, EventArgs e)
        {

        }

        private void showTTButton_Click(object sender, EventArgs e)
        {
            data = "tieptan";
            listNVdataGridView.ReadOnly = true;
            listNVdataGridView.RowTemplate.Height = 50;
            listNVdataGridView.DataSource = tieptan.getTiepTan();
            listNVdataGridView.AllowUserToAddRows = false;
        }

        private void showLCButton_Click(object sender, EventArgs e)
        {
            data = "laocong";
            listNVdataGridView.ReadOnly = true;
            listNVdataGridView.RowTemplate.Height = 50;
            listNVdataGridView.DataSource = laocong.getLaoCong();
            listNVdataGridView.AllowUserToAddRows = false;
        }

        private void listNVdataGridView_DoubleClick(object sender, EventArgs e)
        {
            nhanvienIDTextBox.Text = listNVdataGridView.CurrentRow.Cells[0].Value.ToString();
            hoTextBox.Text = listNVdataGridView.CurrentRow.Cells[1].Value.ToString();
            tenTextBox.Text = listNVdataGridView.CurrentRow.Cells[2].Value.ToString();
            phoneTextBox.Text = listNVdataGridView.CurrentRow.Cells[3].Value.ToString();
            if( listNVdataGridView.CurrentRow.Cells[4].Value.ToString().Trim() == "nữ")
            {
                nuRadioButton.Checked = true;
            }
            else
            {
                namRadioButton.Checked = true;
            }
          
            ngaysinhDateTimePicker.Value = (DateTime)listNVdataGridView.CurrentRow.Cells[5].Value;
            
            addressTextBox.Text = listNVdataGridView.CurrentRow.Cells[6].Value.ToString();
            ngayfirstDateTimePicker.Value = (DateTime)listNVdataGridView.CurrentRow.Cells[7].Value;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa nhân viên này? ", "Delete NV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string ID = listNVdataGridView.CurrentRow.Cells[0].Value.ToString();
                if( data == "tieptan")
                {
                    if( tieptan.deleteTT(ID) == true)
                    {
                        MessageBox.Show("Xóa Thành Công Nhân Viên", "Deleted NV ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid(new SqlCommand("SELECT * FROM tieptan"));
                    }
                    else
                    {
                        MessageBox.Show("Xóa Không Thành Công", "Deleted NV", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (laocong.deleteLC(ID) == true)
                    {
                        MessageBox.Show("Xóa Thành Công Nhân Viên", "Deleted NV ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid(new SqlCommand("SELECT * FROM laocong"));
                    }
                    else
                    {
                        MessageBox.Show("Xóa Không Thành Công", "Deleted NV", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public void fillGrid(SqlCommand command)
        {
            listNVdataGridView.ReadOnly = true;
            listNVdataGridView.RowTemplate.Height = 50;
            listNVdataGridView.AllowUserToAddRows = false;
            if( data == "tieptan")
            {
                listNVdataGridView.DataSource = tieptan.getTiepTan();
            }
            else
            {
                listNVdataGridView.DataSource = laocong.getLaoCong();
            }
  
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            string idTT = nhanvienIDTextBox.Text;
            string ho = hoTextBox.Text;
            string ten = tenTextBox.Text;
            string sdt = phoneTextBox.Text;
            string gt = "nam";
            if (nuRadioButton.Checked == true)
            {
                gt = "nữ";
            }

            DateTime ngsinh = ngaysinhDateTimePicker.Value;
            DateTime ngfirst = ngayfirstDateTimePicker.Value;
            string diachi = addressTextBox.Text;
            if( data == "tieptan")
            {
                if( tieptan.updateTT(idTT, ho, ten, sdt, gt, ngsinh, diachi, ngfirst) == true)
                {
                    MessageBox.Show(" Cập Nhật Thông tin Thành Công", "Sửa Đổi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillGrid(new SqlCommand("SELECT * FROM tieptan"));
                }
                else
                {
                    MessageBox.Show("Thông Tin Không Được Cập Nhật", "Sửa Đổi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (laocong.updateLC(idTT, ho, ten, sdt, gt, ngsinh, diachi, ngfirst) == true)
                {
                    MessageBox.Show(" Cập Nhật Thông tin Thành Công", "Sửa Đổi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillGrid(new SqlCommand("SELECT * FROM laocong"));
                }
                else
                {
                    MessageBox.Show("Thông Tin Không Được Cập Nhật", "Sửa Đổi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string idTT = nhanvienIDTextBox.Text;
            string ho = hoTextBox.Text;
            string ten = tenTextBox.Text;
            string sdt = phoneTextBox.Text;
            string gt = "nam";
            if (nuRadioButton.Checked == true)
            {
                gt = "nữ";
            }

            DateTime ngsinh = ngaysinhDateTimePicker.Value;
            DateTime ngfirst = ngayfirstDateTimePicker.Value;
            string diachi = addressTextBox.Text;
            if (data == "tieptan")
            {
                if (tieptan.ThemTT(idTT, ho, ten, sdt, gt, ngsinh, diachi, ngfirst) == true)
                {
                    MessageBox.Show(" Thêm nhân viên thành công", "Thêm Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillGrid(new SqlCommand("SELECT * FROM tieptan"));
                }
                else
                {
                    MessageBox.Show("Nhân viên không được thêm", "Thêm Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (laocong.ThemLC(idTT, ho, ten, sdt, gt, ngsinh, diachi, ngfirst) == true)
                {
                    MessageBox.Show(" Thêm nhân viên thành công", "Thêm Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillGrid(new SqlCommand("SELECT * FROM laocong"));
                }
                else
                {
                    MessageBox.Show("Nhân viên không được thêm", "Thêm Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            nhanvienIDTextBox.Text = "";
            hoTextBox.Text = "";
            tenTextBox.Text = "";
            phoneTextBox.Text = "";
            nuRadioButton.Checked = false;
            namRadioButton.Checked = false;
            addressTextBox.Text = "";
            ngaysinhDateTimePicker.Value = DateTime.Now;
            ngayfirstDateTimePicker.Value = DateTime.Now;
        }
    }
}
