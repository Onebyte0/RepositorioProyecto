using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneByte.capaLogica.Rutinas
{
    internal class Deporte
    {
        private string idDeporte;
        private string nombre;

        public Deporte(string idDeporte, string nombre)
        {
            this.idDeporte = idDeporte;
            this.nombre = nombre;
        }

        public string IdDeporte
        {
            get { return idDeporte; }
            set { idDeporte = value; }
        }

        public string nom
        {
            get { return nombre;  }
            set {  nombre = value; }
        }

        public Object[] toObject()
        {
            object[] dep = new Object[2];
            dep[0] = this.idDeporte;
            dep[1] = this.nombre;
            return dep;
        }
    }
}
