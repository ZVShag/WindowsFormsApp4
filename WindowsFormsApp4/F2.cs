using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class F2 : Form
    {
        public F2()
        {
            InitializeComponent();
            Program.fr2 = this;
        }

        private void F2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int i=listBox1.FindString(textBox1.Text);
            listBox1.SelectedIndex = i;
        }
    }
}
