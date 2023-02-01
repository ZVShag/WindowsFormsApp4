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
    public partial class F3 : Form
    {
        public F3()
        {
            InitializeComponent();
        }

        private void F3_Load(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string[] s = new string[100];
            for (int i = 0; i < listBox1.Items.Count; i++)
                s[i] = listBox1.Items[i].ToString();
            string tb = textBox1.Text;
            int l = 0, r = listBox1.Items.Count, c;

        }
    }
}
