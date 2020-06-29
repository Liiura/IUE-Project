using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio_jrd
{
    class Usuario
    {
      private int cedula;
        private string nombre;
        private string apellido;
        private string correo;
        private int telefono;
        private int estrato;
        private int Cedula_secre;
        public Usuario()
        {

        }
        public Usuario(int cedula, string nombre, string apellido, string correo, int telefono, int estrato, int cedula_secre)
        {
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Correo = correo;
            this.Telefono = telefono;
            this.Estrato = estrato;
            Cedula_secre1 = cedula_secre;
        }

        public int Cedula_secre1 { get => Cedula_secre; set => Cedula_secre = value; }
        public int Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public int Estrato { get => estrato; set => estrato = value; }
    }
}
