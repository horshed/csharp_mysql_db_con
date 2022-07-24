using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, sif;
            ad = textBox1.Text;
            sif = textBox2.Text;

            if(ad=="alica"&& sif=="35688")
            {
                MessageBox.Show("Giriş Başarılı");
                Form2 fr2=new Form2();
                fr2.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }
    }
}
