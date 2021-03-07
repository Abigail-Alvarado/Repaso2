using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso2
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 vclientes = new Form1();
            vclientes.Show();
            this.SetVisibleCore(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
