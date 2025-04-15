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
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();

            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
        }

        private void button1_Click(object sender, EventArgs e) {
            Form1 tela1 = new Form1();
            tela1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e) {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {

            if (checkBox1.Checked) {

                this.BackColor = Color.Blue;
                checkBox1.ForeColor = Color.White;
            }
            else {

                this.BackColor = Color.WhiteSmoke;
                checkBox1.ForeColor = Color.Black;
            }
        }
    }
}
