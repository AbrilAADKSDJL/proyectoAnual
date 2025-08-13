using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logica;

namespace login_ferrando
{
    public partial class vista : Form
    {
        public vista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string usuario = textBox1.Text;
           string contraseña = textBox2.Text;
        }
    }
}
