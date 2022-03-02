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
    public partial class MainMenu_TiepTan : Form
    {
        public MainMenu_TiepTan()
        {
            InitializeComponent();
        }

        private void thongtincanhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Information_TT infor = new Information_TT();
            infor.idTieptanTextBox.Text = tieptanIDTextBox.Text;
            infor.Show(this);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            EditTT edit = new EditTT();
            edit.idTieptanTextBox.Text = tieptanIDTextBox.Text;
            edit.Show(this);
        }

        private void CheckInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckIn_TT ne = new CheckIn_TT();
            ne.ShowDialog();
        }

        private void CheckOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckOut_TT ne = new CheckOut_TT();
            ne.ShowDialog();
        }

        private void đặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatPhongForm datP = new DatPhongForm();
            datP.Show(this);
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraPhong tra = new TraPhong();
            tra.Show(this);
        }

        private void TongThutoolStripMenuItem_Click(object sender, EventArgs e)
        {
            TongThu thu = new TongThu();
            thu.Show(this);
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Phong phong = new QL_Phong();
            phong.Show(this);
        }

        private void tHÔNGBÁOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongBao tb = new ThongBao();
            tb.Show(this);
        }
    }
}
