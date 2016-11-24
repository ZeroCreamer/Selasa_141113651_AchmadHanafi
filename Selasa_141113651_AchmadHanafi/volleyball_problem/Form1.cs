using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace volleyball_problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const long mds = 1000000007;

        private void tmblHitung_Click(object sender, EventArgs e)
        {

            long a, b, hasilnya;
            a = Convert.ToInt64(inputA.Text);
            b = Convert.ToInt64(inputB.Text);
            if (a < b)
            {
                long temp = a;
                a = b;
                b = temp;
            }

            if ((a > 25 && a - b != 2) || (a - b < 2) || (a < 25))
            {
                hasilnya = 0;
            }
            else
            {
                hasilnya = campur(Math.Min(a + b - 1, 47), Math.Min(a - 1, 24));
                hasilnya *= smds(2, a - 25);
                hasilnya %= mds;
            }
            TmpyHasil.Text = hasilnya.ToString();
        }

        private long campur(long n, long r)
        {
            if (n < r) return 0;
            long hasil = 1;
            hasil *= faktorial(n);
            hasil %= mds;
            hasil *= InverseEuler(faktorial(n - r));
            hasil %= mds;
            hasil *= InverseEuler(faktorial(r));
            hasil %= mds;
            return hasil;
        }

        private long InverseEuler(long n)
        {
            return smds(n, mds - 2);
        }

        private long faktorial(long n)
        {
            long hasil = 1;
            for (int i = 1; i <= n; i++)
            {
                hasil *= i;
                hasil %= mds;
            }
            return hasil;
        }

        private long smds(long b, long e)
        {
            long res = 1;
            while (e > 0)
            {
                if (e % 2 == 1)
                {
                    res = (res * b) % mds;
                }
                b = (b * b) % mds;
                e /= 2;
            }
            return res % mds;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
