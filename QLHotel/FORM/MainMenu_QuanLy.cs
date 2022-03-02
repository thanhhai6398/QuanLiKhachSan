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
    public partial class MainMenu_QuanLy : Form
    {
        public MainMenu_QuanLy()
        {
            InitializeComponent();
        }


     
        private void MainMenu_QuanLy_Load(object sender, EventArgs e)
        {

        }

        private void NhanvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Nhanvien main = new QL_Nhanvien();
            main.Show(this);

        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            PhanCongCV main = new PhanCongCV();
            main.Show(this);
        }

        private void BaoCaoCongViecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoCongViec bao = new BaoCaoCongViec();
            bao.Show(this);
        }

        private void QLKhachHangtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_KhachHang kh = new QL_KhachHang();
            kh.Show(this);
        }

        private void QLPhongtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Phong phong = new QL_Phong();
            phong.Show(this);
        }

        private void DatPhongtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatPhongForm datP = new DatPhongForm();
            datP.Show(this);
        }

        private void TraPhongtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraPhong tra = new TraPhong();
            tra.Show(this);
        }

        private void CHECKintoolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckIn_QL ch = new CheckIn_QL();
            ch.Show(this);
        }

        private void CheckOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckOut_QL ch = new CheckOut_QL();
            ch.Show(this);
        }

        private void thongtinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Information_QL dq = new Information_QL();
            dq.Show(this);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTT_QL ed = new EditTT_QL();
            ed.Show(this);
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            TongThu thu = new TongThu();
            thu.Show(this);
        }

        private void tHÔNGBÁOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongBao tb = new ThongBao();
            tb.Show(this);
        }
    }
}
