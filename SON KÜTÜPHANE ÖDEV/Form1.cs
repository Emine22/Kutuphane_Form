﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SON_KÜTÜPHANE_ÖDEV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uyeadi = textBox1.Text;
            string uyesifresi = textBox2.Text;

            if (uyeadi == "Emine" && uyesifresi == "1234")
            {
                MessageBox.Show("Hesabınız doğrulandı.");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("uye adınız veya uye sifreniz yanlış.");
            }
        }
    }
}
