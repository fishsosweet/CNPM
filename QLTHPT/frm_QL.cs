using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTHPT
{
    public partial class frm_QL : Form
    {
        public frm_QL()
        {
            InitializeComponent();
        }

        private void quanLyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uC_QLHS1.Visible = true;
            uC_QLHS1.BringToFront();

        }

        private void quanLyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            uC_QLTKB1.Visible = true;
            uC_QLTKB1.BringToFront();
        }

        private void frm_QL_Load(object sender, EventArgs e)
        {
            uC_QLHS1.Visible = false;
            uC_QLTKB1.Visible = false;
            uC_QLDiem1.Visible = false;
            uC_QLGV1.Visible = false;        
        }

        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uC_QLDiem1.Visible = true;
            uC_QLDiem1.BringToFront();
        }

        private void quảnLýGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uC_QLGV1.Visible = true;
            uC_QLGV1.BringToFront();
           
        }
    }
}
