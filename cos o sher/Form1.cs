using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace cos_o_sher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string AAA = "";
        int counete = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int Acount = 0, Bcount = 0;
        bool Aa = false, Bb = false;
        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100000;
            counete = 1000;
            Thread AA = new Thread(() => mmm());
            Thread BB = new Thread(() => mmm2());
            AA.Start();
            BB.Start();
            timer1.Start();

            //kirrrrrrrrrrrr
            // KIIIIIIIIIIIIIIIIIIIR2
        }
        private void mmm()
        {
           
            for (int i = 0; i < 50000; i++)
            {
                Bcount++;

                Thread.Sleep(10);

                Aa = true;
            }
            if(Aa ==true && Bb == true)
            {
                timer1.Stop();
            }

        }
        private void mmm2()
        {
            for (int i = 0; i < 50000; i++)
            {
                Acount++;
                Thread.Sleep(10);
                Bb = true;
            }
            if (Aa == true && Bb == true)
            {
                timer1.Stop();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int resul = Acount + Bcount;
            progressBar1.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = resul;
            });
            label1.Invoke((Action)delegate
            {
                label1.Text = resul.ToString();
            });
        }
    }
}
