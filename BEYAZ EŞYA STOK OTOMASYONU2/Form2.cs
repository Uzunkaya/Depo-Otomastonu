﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BEYAZ_EŞYA_STOK_OTOMASYONU2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmYönetici yönetici = new frmYönetici();
            yönetici.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPersonel personel = new frmPersonel();
            personel.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
