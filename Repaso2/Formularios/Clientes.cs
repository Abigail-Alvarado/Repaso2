using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Repaso2

{
    public partial class Clientes : Form
    {
       
        List<clientes> clientes = new List<clientes>();
        string archivoC = "RegistroClientes.txt";
        clientes cliv = new clientes();

        public Clientes()

        {
            InitializeComponent();
        }
        public void guardar()
        {
            FileStream stream = new FileStream(archivoC, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            for (int i = 0; i < clientes.Count; i++)
            {
                writer.WriteLine(clientes[i].Nit);
                writer.WriteLine(clientes[i].Nombre);
                writer.WriteLine(clientes[i].Direccion);
            }
            writer.Close();
        }
        void Leer()
        {
            FileStream stream = new FileStream(archivoC, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                clientes tempcliente = new clientes();
                tempcliente.Nit = reader.ReadLine();
                tempcliente.Nombre = reader.ReadLine();
                tempcliente.Direccion = reader.ReadLine();
                clientes.Add(tempcliente);

            }
            reader.Close();
        }
        void limpiar()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                clientes tempcliente = new clientes();
                tempcliente.Nit = textBox1.Text;
                tempcliente.Nombre = textBox2.Text;
                tempcliente.Direccion = textBox3.Text;
                clientes.Add(tempcliente);
                guardar();
                limpiar();
                MessageBox.Show("Cliente agregado correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("No se han llenado todos los datos", "Mi Mesaje Predeterminado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            Leer();
        }
    }
}
