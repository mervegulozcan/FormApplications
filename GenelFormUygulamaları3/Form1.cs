using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenelFormUygulamaları3
{
    public partial class Form1 : Form
    {
        string ad, soyad, dTarihi;
        TreeNode nd = new TreeNode();
        int i = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd MMMM yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //int j =treeView1.SelectedNode.Index;
            //txtAd.Text = treeView1.Nodes[j].Text;
            //txtSoyad.Text = treeView1.Nodes[j].Nodes[j-1].Text;
            //dateTimePicker1.Text = treeView1.Nodes[j].Nodes[j-1].Nodes[0].Text;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ad = txtAd.Text;
            soyad = txtSoyad.Text;
            dTarihi = dateTimePicker1.Text;
            
            treeView1.Nodes.Add(ad);
            treeView1.Nodes[i].Nodes.Add(soyad);
            treeView1.Nodes[i].Nodes[0].Nodes.Add(dTarihi);
            i++;




        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
