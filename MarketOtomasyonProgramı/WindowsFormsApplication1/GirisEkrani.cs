using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Terminal g1 = new Terminal();
            Terminal g2 = new Terminal();
            g1.GorevliNo = "1";
            g1.GorevliSifre = "1234";
            g2.GorevliNo = "2";
            g2.GorevliSifre = "4321";

            

            if(textBox1.Text==g1.GorevliNo&&textBox2.Text==g1.GorevliSifre||textBox1.Text==g2.GorevliNo&&textBox2.Text==g2.GorevliSifre)
            {
                Form1 frm1 = new Form1();
                MessageBox.Show("GİRİŞ BAŞARILI");
                this.Hide();
                frm1.Show();

                
            }
            else
            {
                MessageBox.Show("GÖREVLİ NUMARASI YADA ŞİFRE HATALI!");
            }
            textBox1.Clear();
            textBox2.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox işaretli ise
            if (checkBox1.Checked)
            {
                //karakteri göster.
                textBox2.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}
