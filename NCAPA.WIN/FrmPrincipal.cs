using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCAPA.WIN
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ofrforms = new Form1();
            ofrforms.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBuscador of = new frmBuscador();
            of.Show();
        }
    }
}
