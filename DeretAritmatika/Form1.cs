using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeretAritmatika
{
    public partial class Form1 : Form
    {
        int pertama;
        int suku;
        int b;
        int[] bantu;


        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnproses_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            pertama = Convert.ToInt32(txtpertama.Text);
            suku = Convert.ToInt32(txtbanyak.Text);

            
            b = 0;
            for (int i = 1; i <= suku; i++)
            {
                bantu[i] = pertama * i;
                listBox1.Items.Add(bantu[i]);
                b = b + 1;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtpertama_TextChanged(object sender, EventArgs e)
        {
            string tp = txtpertama.Text;
            if (tp.Trim() == "") return;

            for (int j = 0; j < tp.Length; j++)
            {
                if (!char.IsNumber(tp[j]))
                {
                    MessageBox.Show("Silakan Inputkan Angka Saja!");
                    txtpertama.Text = "";
                    return;
                }
                
            }
        }

        private void txtbanyak_TextChanged(object sender, EventArgs e)
        {
            string by = txtbanyak.Text;
            if (by.Trim() == "") return;

            for (int j = 0; j < by.Length; j++)
            {
                if (!char.IsNumber(by[j]))
                {
                    MessageBox.Show("Silakan Inputkan Angka Saja!");
                    txtbanyak.Text = "";
                    return;
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bantu = new int[99];
        }

        private void btncari_Click(object sender, EventArgs e)
        {

            double tengah;
            int hasil;

            if (b % 2 == 1)
            {
                tengah = (b / 2) + 1;
            }
            else
            {
                tengah = b / 2;
            }

            hasil= Convert.ToInt32(tengah);

            txttengah.Text = Convert.ToString(bantu[hasil]);
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            txttengah.Clear();
            txtpertama.Clear();
            txtbanyak.Clear();

            listBox1.Items.Clear();

            txtpertama.Focus();

        }
    }
}

