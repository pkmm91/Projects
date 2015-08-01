using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmsel : Form
    {
        public frmsel()
        {
            InitializeComponent();
        }

        private void frmsel_Load(object sender, EventArgs e)
        {

        }

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frmalgo fr = new frmalgo();
            frmsel fsel = new frmsel();
            fr.Show();
            fsel.Close();

        }
    }
}
