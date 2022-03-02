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
    public partial class MainMenu_LaoCong : Form
    {
        public MainMenu_LaoCong()
        {
            InitializeComponent();
        }

        private void MainMenu_LaoCong_Load(object sender, EventArgs e)
        {

        }

        private void thongtincanhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Information_LC main = new Information_LC();
            main.idLaocongTextBox.Text = LaocongIDTextBox.Text;
            main.Show(this);
        }

        private void editLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditLC edit = new EditLC();
            edit.idLaocongTextBox.Text = LaocongIDTextBox.Text;
            edit.Show(this);
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckIn_LC ch = new CheckIn_LC();
            ch.Show(this);
        }

        private void checkOuttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckOut_LC ne = new CheckOut_LC();
            ne.Show(this);
        }
    }
}
