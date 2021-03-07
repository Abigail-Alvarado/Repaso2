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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes clientesr = new Clientes();
            clientesr.Show();
            this.SetVisibleCore(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vehiculos vehiculosr = new Vehiculos();
            vehiculosr.Show();
            this.SetVisibleCore(false);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Aquiler alquiv = new Aquiler();
            alquiv.Show();
            this.SetVisibleCore(false);
        }
    }
}
