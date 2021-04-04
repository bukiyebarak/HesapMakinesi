using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class HesapMakinesi : Form
    {
        double Sayi1=0;
        double Sayi2 = 0;
        string Secim;
        public HesapMakinesi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sonucText.Text = null;
        }
        
        private void btn0_Click(object sender, EventArgs e)
        {
            if (sonucText.Text == "0")
                sonucText.Text = "";
            sonucText.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (sonucText.Text == "0")
                sonucText.Text = "";
            sonucText.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (sonucText.Text == "0")
                sonucText.Text = "";
            sonucText.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (sonucText.Text == "0")
                sonucText.Text = "";
            sonucText.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (sonucText.Text == "0")
                sonucText.Text = "";
            sonucText.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (sonucText.Text == "0")
                sonucText.Text = "";
            sonucText.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (sonucText.Text == "0")
                sonucText.Text = "";
            sonucText.Text += "6";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (sonucText.Text == "0")
                sonucText.Text = "";
            sonucText.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (sonucText.Text == "0")
                sonucText.Text = "";
            sonucText.Text += "9";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (sonucText.Text == "0")
                sonucText.Text = "";
            sonucText.Text += "7";
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            sonucText.Text = sonucText.Text + ",";
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            Secim = "+";
            Sayi1 = double.Parse(sonucText.Text);
            sifirla();
        }
        public void sifirla()
        {
            sonucText.Text = "0";
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            Secim = "-";
            Sayi1 = double.Parse(sonucText.Text);
            sifirla();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            Secim = "*";
            Sayi1 = double.Parse(sonucText.Text);
            sifirla();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            Secim ="/";
            Sayi1 = double.Parse(sonucText.Text);
            sifirla();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            sonucText.Text = null;
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            Sayi2 = double.Parse(sonucText.Text);
            sonucText.Text = hesaplama().ToString("#,#.0");
        }

        public double hesaplama()
        {
            double Sonuc = 0;

            if (Secim == "+")
                Sonuc = Sayi1 + Sayi2;
            else if (Secim == "-")
                Sonuc = Sayi1 - Sayi2;
            else if (Secim == "*")
                Sonuc = Sayi1 * Sayi2;
            else if (Secim == "/")
                Sonuc = Sayi1 / Sayi2;
            else
                Sonuc = 0;

            return Sonuc;
        }

        private void sonucText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
