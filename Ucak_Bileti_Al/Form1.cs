using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ucak_Bileti_Al
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label13.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label13.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add("Kullanıcı Bilgileri");
            listBox1.Items.Add(textBox1.Text + "  " + textBox2.Text + "  " + maskedTextBox1.Text);
            MessageBox.Show("Kaydınız Başarıyla Oluşturuldu, Uçuş Bilet Panelinde Biletinizi Alabilirsiniz.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Uçuş bilgileri");
            listBox1.Items.Add(comboBox1.Text + " - " + comboBox2.Text + "    " + dateTimePicker1.Text + "    " + maskedTextBox3.Text);
            MessageBox.Show("Uçak Biletiniz Başarıyla Oluşturuldu.");
        }
    }
}
