using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace appTCC
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1  .ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*SerialPort porta = new SerialPort("COM4", 9600);
            porta.Open();
            string port = porta.ReadLine();
            textBox1.Text = port;
            porta.Close();

            i.setTempo(DateTime.Now);
            i.setReg_proximidade(port);
            i.insert_dados();*/

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           /* SerialPort porta = new SerialPort("COM4", 9600);
            porta.Open();
            string port = porta.ReadLine();
            temptxt.Text = port;
            porta.Close();

            i.setTempo(DateTime.Now);
            i.setReg_incendio(port);
            i.insert_dados_incendio();*/
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        insert i = new insert();
        private void button11_Click(object sender, EventArgs e)
        {
            /*SerialPort porta = new SerialPort("COM4", 9600);
            porta.Open();
            string port = porta.ReadLine();
            textBox1.Text = port;
            porta.Close();

            i.setTempo(DateTime.Now);
            i.setReg_proximidade(port);
            i.insert_dados();*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            SerialPort porta = new SerialPort("COM5", 9600);
            porta.Open();
            string port = porta.ReadLine();
            textBox2.Text = port;
            porta.Close();

            i.setTempo(DateTime.Now);
            i.setReg_gas(port);
            i.insert_dados_gas();

        }
    }
}
