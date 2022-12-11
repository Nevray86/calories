using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        Form1 form3;
        public Form3(Form1 owner)
        {
            form3 = owner;  
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form3.tmp += Convert.ToInt32(textBox1.Text);

            form3.textBox2.Text = Convert.ToString(form3.tmp);

        }
    }
}
