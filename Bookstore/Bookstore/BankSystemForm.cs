using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore
{
    public partial class BankSystemForm : Form
    {
        Double Price;
        CartForm CartForm;


        public BankSystemForm(Double price, CartForm CartForm)
        {
            InitializeComponent();
            Price = price;
            this.CartForm = CartForm;
            label6.Text += price.ToString() + " €";
        }

        private void timer_show_security_Tick(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            label5.Hide();

            timer_show_security.Stop();

            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label6.Show();
            label8.Show();
            textBox1.Show();
            textBox2.Show();
            textBox3.Show();
            textBox4.Show();
            button1.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label8.Hide();
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            button1.Hide();

            label7.Show();
            pictureBox1.Show();
            pictureBox1.Image = Properties.Resources.Purchase_complete;

            CartForm.purchaseCompleted();




            SoundPlayer sound = new SoundPlayer(Properties.Resources.Pay_Success);
            sound.Play();

            

            timer_close.Start();
        }

        private void timer_close_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
