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
   
    public partial class Form1 : Form
    {
        public int tmp;
        public Form1()
        {
            InitializeComponent();
            
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            new Form2(this).Show();
            this.Hide();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form3(this).Show();
        }

        public void sss()
        {
           // Convert.ToInt32(this.textBox2.Text) += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
