using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordAndPDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PTOW a = new PTOW();
            a.ShowDialog();
            this.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            WTOP a = new WTOP();
            a.ShowDialog();
            this.Dispose();
        }

     
    }
}
