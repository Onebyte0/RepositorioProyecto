using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneByte.capaLogica
{
    internal class cliente
    {
        private int idCliente;
        private string tipoDoc;
        private string numDoc;
        private string primerNom;
        private string segundoNom;
        private string primerApe;
        private string segundoApe;
        private string Direccion;
        private int numCalle;
        private string Departamento;
        private DateTime? Fecha;
        private string estPago;
        private string Deporte;
        private string Contraseña;

        public cliente(int idCliente, string tipoDoc, string numDoc, string primerNom, string segundoNom, string primerApe, string segundoApe, string Direccion, int numCalle, string Departamento, DateTime? Fecha, string estPago, string Deporte, string Contraseña)
        {
            this.idCliente = idCliente;
            this.tipoDoc = tipoDoc;
            this.numDoc = numDoc;
            this.primerNom = primerNom;
            this.segundoNom = segundoNom;
            this.primerApe = primerApe;
            this.segundoApe = segundoApe;
            this.direccion = Direccion;
            this.numCalle = numCalle;
            this.Departamento = Departamento;
            this.Fecha = Fecha;
            this.estPago = estPago;
            this.Deporte = Deporte;
            this.Contraseña = Contraseña;
        }
        // metodos get y set
        public int id_cliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        public string tipo_doc
        {
            get { return tipoDoc; }
            set { tipoDoc = value; }
        }
        public string num_doc
        {
            get { return numDoc; }
            set { numDoc = value; }
        }
        public string primer_nom
        {
            get { return primerNom; }
            set { primerNom = value; }
        }
        public string segundo_nom
        {
            get { return segundoNom; }
            set { segundoNom = value; }
        }
        public string primer_ape
        {
            get { return primerApe; }
            set { primerApe = value; }
        }
        public string segundo_ape
        {
            get { return segundoApe; }
            set { segundoApe = value; }
        }
        public string direccion
        {
            get { return Direccion; }
            set { Direccion = value; }
        }
        public int calle
        {
            get { return numCalle; }
            set { numCalle = value; }
        }
        public string departamento
        {
            get { return Departamento; }
            set { Departamento = value; }
        }
        public DateTime? fecha
        {
            get { return Fecha; }
            set { Fecha = value; }
        }
        public string est_pago
        {
            get { return estPago; }
            set { estPago = value; }
        }
        public string deporte
        {
            get { return Deporte; }
            set { Deporte = value; }
        }
        public string contraseña
        {
            get { return Contraseña; }
            set { Contraseña = value; }
        }

        public object[] toObject()
        {
            object[] c = new object[14]; // cant de atributos deL cliente
            c[0] = this.idCliente;
            c[1] = this.tipoDoc;
            c[2] = this.numDoc;
            c[3] = this.primerNom;
            c[4] = this.segundoNom;
            c[5] = this.primerApe;
            c[6] = this.segundoApe;
            c[7]= this.direccion;
            c[8] = this.numCalle;
            c[9] = this.Departamento;
            c[10] = this.Fecha;
            c[11] = this.estPago;
            c[12] = this.Deporte;
            c[13] = this.Contraseña;

            return c;
        }
    }
}

