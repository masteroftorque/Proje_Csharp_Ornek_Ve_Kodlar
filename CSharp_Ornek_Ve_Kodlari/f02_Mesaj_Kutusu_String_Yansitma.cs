﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Ornek_Ve_Kodlari
{
    public partial class f02_Mesaj_Kutusu_String_Yansitma : Form
    {
        public f02_Mesaj_Kutusu_String_Yansitma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yas = 38;
            string adim_durum = "Umut DEU öğrenci";
            MessageBox.Show("Kişi:" + adim_durum + " Yaşı:" + yas.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek = f03_MSVB_Basvuru_Ekleme
            if (OrtakSinif.GizliFormuAc("f03_MSVB_Basvuru_Ekleme") == 0)
            {
                f03_MSVB_Basvuru_Ekleme YeniForm = new f03_MSVB_Basvuru_Ekleme();
                YeniForm.Show();
            }
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Ana Menü
            OrtakSinif.GizliFormuAc("AnaPencere"); //Application.OpenForms[0].Visible = true;
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Önceki Örnek = f01_Buton_Tiklama
            if (OrtakSinif.GizliFormuAc("f01_Buton_Tiklama") == 0)
            {
                f01_Buton_Tiklama YeniForm = new f01_Buton_Tiklama();
                YeniForm.Show();
            }
            this.Visible = false;
        }

        private void f02_Mesaj_Kutusu_String_Yansitma_Load(object sender, EventArgs e)
        {

        }
    }
}
