using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LYConverter
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startBtn.Text = "start";
			this.Hide();
            Converter form2 = new Converter();
			form2.FormClosed += (s, args) => this.Close();
			form2.Show();
		}

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void welcomeText_Click(object sender, EventArgs e)
        {

        }
    }
}
