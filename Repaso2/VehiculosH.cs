using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso2
{
    class VehiculosH: Vehiculos
    {
        string placa, marca, modelo, color;
        float precioK;

        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // VehiculosH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(579, 397);
            this.Name = "VehiculosH";
            this.ResumeLayout(false);

        }

        public string Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public float PrecioK { get => precioK; set => precioK = value; }
    }
}
