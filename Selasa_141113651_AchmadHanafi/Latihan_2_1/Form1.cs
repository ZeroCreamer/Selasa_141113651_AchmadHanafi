using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pilihbulan.SelectedItem = "Maret";

            DateTime mulai = new DateTime(2016, 1, 1);
            DateTime akhir = new DateTime(2017, 12, 31);
            TimeSpan jarak = akhir - mulai;
            int day = jarak.Days;
            for (var i = 0; i <= day; i++)
            {
                var bolddate = mulai.AddDays(i);
                switch (bolddate.DayOfWeek)
                {
                    case DayOfWeek.Saturday:
                        kalenderkeren.AddBoldedDate(bolddate);
                        break;
                    case DayOfWeek.Sunday:
                        kalenderkeren.AddBoldedDate(bolddate);
                        break;
                }
            }
            kalenderkeren.AddAnnuallyBoldedDate(new DateTime(1996, 03, 28));
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void tmbltambah_Click(object sender, EventArgs e)
        {
            kalenderkeren.AddAnnuallyBoldedDate(new DateTime(2016, pilihbulan.SelectedIndex + 1, Convert.ToInt32(pilihtgl.Value)));
            kalenderkeren.UpdateBoldedDates();
        }

        private void tmblhapus_Click(object sender, EventArgs e)
        {
            kalenderkeren.RemoveAnnuallyBoldedDate(new DateTime(2016, pilihbulan.SelectedIndex + 1, Convert.ToInt32(pilihtgl.Value)));
            kalenderkeren.UpdateBoldedDates();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
