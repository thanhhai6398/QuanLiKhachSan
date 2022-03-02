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
    public partial class LoginForm : Form
    {
        MY_DB mydb = new MY_DB();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
           imageLoginPictureBox.Image = Image.FromFile("../../images/hinhanh.png");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Nhan Vien Quan Ly Dang nhap

            if( quanlyRadioButton.Checked == true)
            {
                tieptanRadioButton.Checked = false;
                laocongRadioButton.Checked = false;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT login.username, login.password FROM login,quanly WHERE  login.username = @user AND login.password =@password AND login.username = quanly.quanly_id", mydb.getConnection);
                command.Parameters.Add("@user", SqlDbType.VarChar).Value = usernameTextBox.Text;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = passwordTextBox.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Đăng nhập hệ thống Quản Lý thành công");
                    Global.GlobalUserId = usernameTextBox.Text;
                    MainMenu_QuanLy main = new MainMenu_QuanLy();
                    main.QuanlyIDTextBox.Text = usernameTextBox.Text;
                    main.Show(this);

                }
                else
                {

                    if (string.IsNullOrEmpty(usernameTextBox.Text))
                    {
                        usernameTextBox.Focus();
                        nullUserErrorProvider.SetError(usernameTextBox, "Hãy nhập user name !");
                    }
                    else
                    {
                        nullUserErrorProvider.SetError(usernameTextBox, null);
                    }
                    if (string.IsNullOrEmpty(passwordTextBox.Text))
                    {

                        passwordTextBox.Focus();
                        nullPasswordErrorProvider.SetError(passwordTextBox, "Hãy nhập password !");

                    }
                    else
                    {
                        nullPasswordErrorProvider.SetError(usernameTextBox, null);
                    }

                    if (string.IsNullOrEmpty(usernameTextBox.Text) == false && string.IsNullOrEmpty(passwordTextBox.Text) == false)
                    {
                        MessageBox.Show("Invalid username or password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

            // Nhan vien Tiep tan Dang  nhap
            else if ( tieptanRadioButton.Checked == true)
            {
                quanlyRadioButton.Checked = false;
                laocongRadioButton.Checked = false;
               
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT login.username, login.password FROM login,tieptan WHERE  login.username = @user AND login.password =@password AND login.username = tieptan.tieptan_id", mydb.getConnection);
                command.Parameters.Add("@user", SqlDbType.VarChar).Value = usernameTextBox.Text;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = passwordTextBox.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    Global.GlobalUserId = usernameTextBox.Text;
                    MessageBox.Show("Đăng nhập hệ thống Tiếp Tân thành công");
                    MainMenu_TiepTan main = new MainMenu_TiepTan();
                    main.tieptanIDTextBox.Text = usernameTextBox.Text;

                    main.Show(this);

                }
                else
                {
                    if (string.IsNullOrEmpty(usernameTextBox.Text))
                    {

                        usernameTextBox.Focus();
                        nullUserErrorProvider.SetError(usernameTextBox, "Hãy nhập user name !");

                    }
                    else
                    {
                        nullUserErrorProvider.SetError(usernameTextBox, null);
                    }
                    if (string.IsNullOrEmpty(passwordTextBox.Text))
                    {

                        passwordTextBox.Focus();
                        nullPasswordErrorProvider.SetError(passwordTextBox, "Hãy nhập password !");


                    }
                    else
                    {
                        nullPasswordErrorProvider.SetError(usernameTextBox, null);
                    }

                    if (string.IsNullOrEmpty(usernameTextBox.Text) == false && string.IsNullOrEmpty(passwordTextBox.Text) == false)
                    {
                        MessageBox.Show("Invalid username or password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            // Nhan vien Lao Cong Dang nhap
            else if ( laocongRadioButton.Checked == true)
            {
                quanlyRadioButton.Checked = false;
                tieptanRadioButton.Checked = false;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT login.username, login.password FROM login,laocong WHERE  login.username = @user AND login.password =@password AND login.username = laocong.laocong_id", mydb.getConnection);
                command.Parameters.Add("@user", SqlDbType.VarChar).Value = usernameTextBox.Text;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = passwordTextBox.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    Global.GlobalUserId = usernameTextBox.Text;
                    MessageBox.Show("Đăng nhập hệ thống Lao Công thành công");
                    this.DialogResult = DialogResult.OK;
                    MainMenu_LaoCong main = new MainMenu_LaoCong();
                    main.LaocongIDTextBox.Text = usernameTextBox.Text;
                    main.Show(this);

                }
                else
                {
                    if (string.IsNullOrEmpty(usernameTextBox.Text))
                    {

                        usernameTextBox.Focus();
                        nullUserErrorProvider.SetError(usernameTextBox, "Hãy nhập user name !");

                    }
                    else
                    {
                        nullUserErrorProvider.SetError(usernameTextBox, null);
                    }
                    if (string.IsNullOrEmpty(passwordTextBox.Text))
                    {

                        passwordTextBox.Focus();
                        nullPasswordErrorProvider.SetError(passwordTextBox, "Hãy nhập password !");


                    }
                    else
                    {
                        nullPasswordErrorProvider.SetError(usernameTextBox, null);
                    }

                    if (string.IsNullOrEmpty(usernameTextBox.Text) == false && string.IsNullOrEmpty(passwordTextBox.Text) == false)
                    {
                        MessageBox.Show("Invalid username or password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
