using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenelFormUygulamaları
{
    public partial class Form1 : Form
    {
        string ad, soyad, dTarihi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dateTimePicker1.CustomFormat = "dd MMMM yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ad = txtAd.Text;
            soyad = txtSoyad.Text;
            listBox1.Items.Add(ad);
            listBox1.Items.Add(soyad);
            dTarihi = dateTimePicker1.Text;
            listBox1.Items.Add(dTarihi);
            listBox1.Items.Add(" ");
            txtAd.Clear();
            txtSoyad.Clear();

        }
    }
}
