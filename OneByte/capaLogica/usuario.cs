using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneByte.capaLogica
{
    internal class usuario
    {
        private string nroDocumento;
        private string Rol;
        private string Contraseña;

        public usuario(string nroDocumento, string rol, string contraseña)
        {
            this.nroDocumento = nroDocumento;
            this.Rol = rol;
            this.Contraseña = contraseña;
        }

        public string nro_documento
        {
            get { return nroDocumento; }
            set { nroDocumento = value; }
        }
        public string rol
        {
            get { return Rol; }
            set { Rol = value; }
        }
        public string contraseña
        {
            get { return Contraseña; }
            set { Contraseña = value; }
        }
        public object[] toObject()
        {
            object[] u = new object[2];
            u[0] = nroDocumento;
            u[1] = rol; 
            u[2] = contraseña ;
            return u;
        }

    }
}
