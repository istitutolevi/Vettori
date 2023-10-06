using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vettori
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Vector v = new Vector(5, 4);
            txtVettore.Text = string.Format("{0}" , v);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vector v = Vector.Parse(txtVettore.Text);
            MessageBox.Show(v.ToString());
        }
    }
}
