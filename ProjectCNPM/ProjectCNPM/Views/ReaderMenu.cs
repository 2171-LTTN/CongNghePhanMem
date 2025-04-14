using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCNPM.Views
{
    public partial class ReaderMenu : Form
    {
        public ReaderMenu()
        {
            InitializeComponent();
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            this.Hide();

            ReaderInfo f = new ReaderInfo();
            f.ShowDialog();

            this.Show();
               
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLichSuMuon_Click(object sender, EventArgs e)
        {

        }
    }
}
