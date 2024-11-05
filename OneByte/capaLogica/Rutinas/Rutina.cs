using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneByte.capaLogica
{
    internal class Rutina
    {
        private string tipoRutina;
        private string Nombre;

        public Rutina(string tipoRutina, string Nombre)
        {
            this.tipoRutina = tipoRutina;
            this.Nombre = nombre;
        }
        public string tiporutina
        {
            get { return tipoRutina; }
            set { tipoRutina = value; }
        }
        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public Object[] toObject()
        {
            return new Object[] { tipoRutina, Nombre };
        }
        
    }
}