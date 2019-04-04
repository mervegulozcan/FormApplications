using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenelFormUygulamaları2
{
    
    public partial class Form1 : Form
    {
        string ad, soyad, dTarihi;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                txtAd.Text = item.SubItems[0].Text;
                txtSoyad.Text = item.SubItems[1].Text;
                dateTimePicker1.Text= item.SubItems[2].Text;
            }
            else
            {
              txtAd.Text = string.Empty;
              txtSoyad.Text = string.Empty;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                item.Remove();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
                ad = txtAd.Text;
                soyad = txtSoyad.Text;
                dTarihi = dateTimePicker1.Text;
                string[] veri = { soyad, dTarihi };
                listView1.Items.Add(ad).SubItems.AddRange(veri);

                txtAd.Clear();
                txtSoyad.Clear();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd MMMM yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }
    }
}
