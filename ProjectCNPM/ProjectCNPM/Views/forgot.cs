using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCNPM
{
    public partial class forgot : Form
    {
        public forgot()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            forgotpass f = new forgotpass();
            this.Hide();
            f.ShowDialog();
        }
    }
}
