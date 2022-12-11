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
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 owner)
        {
            form1 = owner;  
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int f1 = 0;
            form1.tmp += Convert.ToInt32(textBox1.Text);

            form1.textBox2.Text = Convert.ToString(form1.tmp);
            this.Close();   
            form1.Show();
           
        }
    }
}
