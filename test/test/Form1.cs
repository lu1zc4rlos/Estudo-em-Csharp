using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Form2 tela2 = new Form2();
            tela2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) {

            string nome = textBox1.Text;

            MessageBox.Show($"Bem vindo {nome}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

            string nome = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e) {

            MessageBox.Show("Obrigado!");
        }

        private void button4_Click(object sender, EventArgs e) {
            MessageBox.Show("Pedro!");
        }
    }
}
