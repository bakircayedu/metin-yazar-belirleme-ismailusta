using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Klasor İşlemleri icin ek kütüphane

namespace HashTablo
{
    public partial class v : Form
    {
        public v()
        {
            InitializeComponent();
        }
        StreamWriter sw;
        string klasorAd, klasorYolu;
        private void KlasorOlustur_Click(object sender, EventArgs e)
        {
          

        }

        private void btnKlasorSıl_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMetınYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog metinac = new OpenFileDialog();
            metinac.Filter = "Metin Dosyası(*.txt) | *.txt ";
            metinac.FilterIndex = 1;
            metinac.Multiselect = false;
            if (metinac.ShowDialog() == DialogResult.OK)
            {
                txtGoruntule.Text = metinac.SafeFileName;
                try
                {
                    StreamReader oku = new StreamReader(metinac.FileName);
                    txtYazım.Text = oku.ReadToEnd();
                    oku.Close();
                }
                catch (Exception)
                {

                    MessageBox.Show("HATALI DOSYA TİPİ");
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            klasorAd = txtYazım.Text;
            sw = File.CreateText(klasorYolu + "\\" + klasorAd + ".txt");
            sw.Close();
        }

        private void btnListeYaz_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult)
            {
                StreamReader oku = new StreamReader(openFileDialog1.FileName);
                string satir = oku.ReadLine();
                while (satir!= null)
                {
                    listBox1.Items.Add(satir);
                    satir = oku.ReadLine();

                }
            }
        }

        private void btnKlasorYol_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult)
            {
                klasorYolu = folderBrowserDialog1.SelectedPath.ToString();
                txtKlasorYol.Text = klasorYolu;
            }
        }
    }
}
