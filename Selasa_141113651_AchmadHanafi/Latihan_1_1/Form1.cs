using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_1
{
    public partial class Latihan_1_1 : Form
    {
        public Latihan_1_1()
        {
            InitializeComponent();
        }
        static DateTime now = DateTime.Now;
        private void vsmiin_Scroll(object sender, ScrollEventArgs e)
        {
            lblmiin.Text = (vsmiin.Maximum - vsmiin.Value).ToString();
            if (vsmaax.Value > vsmiin.Value)
            {
                vsmaax.Value = vsmiin.Value;
                //vsbMin.Value += 1;
                lblmaax.Text = (vsmaax.Maximum - vsmaax.Value).ToString();
            }
            ambiltanggal.MinDate = now.AddYears(vsmaax.Value - vsmaax.Maximum);
            ambiltanggal.MaxDate = now.AddYears(vsmiin.Value - vsmiin.Maximum);
        }

        private void vsmaax_Scroll(object sender, ScrollEventArgs e)
        {
            lblmaax.Text = (vsmaax.Maximum - vsmaax.Value).ToString();
            //lblMax.Text = vsbMax.Value.ToString();
            if (vsmaax.Value > vsmiin.Value)
            {
                vsmiin.Value = vsmaax.Value;
                lblmiin.Text = (vsmiin.Maximum - vsmiin.Value).ToString();
            }
            ambiltanggal.MaxDate = now.AddYears(vsmiin.Value - vsmiin.Maximum);
            ambiltanggal.MinDate = now.AddYears(vsmaax.Value - vsmaax.Maximum);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ambiltanggal.MaxDate = now.AddYears(vsmiin.Value - vsmiin.Maximum);
            ambiltanggal.MinDate = now.AddYears(vsmaax.Value - vsmaax.Maximum);
        }
    }

}
