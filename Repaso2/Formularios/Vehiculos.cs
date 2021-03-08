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
    public partial class Vehiculos : Form
    {
        List<VehiculosH> vehiculos = new List<VehiculosH>();
        VehiculosH cliv = new VehiculosH();
        string archivoV = "Registrovehículos.txt";
        public Vehiculos()
        {
            InitializeComponent();
        }
        public void guardar()
        {
            FileStream stream = new FileStream(archivoV, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            for (int i = 0; i < vehiculos.Count; i++)
            {
                writer.WriteLine(vehiculos[i].Placa);
                writer.WriteLine(vehiculos[i].Marca);
                writer.WriteLine(vehiculos[i].Modelo);
                writer.WriteLine(vehiculos[i].Color);
                writer.WriteLine(vehiculos[i].PrecioK);
            }
            writer.Close();
        }
        void leer_datos()
        {
            FileStream stream = new FileStream(archivoV, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                VehiculosH tempvehiculos = new VehiculosH();
                tempvehiculos.Placa = reader.ReadLine();
                tempvehiculos.Marca = reader.ReadLine();
                tempvehiculos.Modelo = reader.ReadLine();
                tempvehiculos.Color = reader.ReadLine();
                tempvehiculos.PrecioK = float.Parse(reader.ReadLine());
                vehiculos.Add(tempvehiculos);
                reader.Close();
            }
        }
            void limpiar()
            {
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                comboBox1.Text = null;
                textBox4.Text = null;
            }
        private int Repeticion(string placa) // retorna 1 si se encuentra en la lista
        {
            int resultado = 0;
            for (int i = 0; i < vehiculos.Count; i++)
            {
                if (vehiculos[i].Placa.Contains(placa))
                    resultado = 1;
            }
            return resultado;
        }

        private void button1_Click(object sender, EventArgs e)
            {
                Form1 vclientes = new Form1();
                vclientes.Show();
                this.SetVisibleCore(false);
            }



            private void button2_Click(object sender, EventArgs e)
            {

            }
        }
    }
