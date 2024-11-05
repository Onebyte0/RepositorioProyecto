using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneByte.capaLogica
{
    internal class Ejercicio
    {
        private string idEjercicio;
        private string descripcion;
        private string nombreEjercicio;
        private string grupoMuscular;

        public Ejercicio(string idEjercicio, string descripcion, string nombreEjercicio, string grupoMuscular)
        {
            this.idEjercicio = idEjercicio;
            this.descripcion = descripcion;
            this.nombreEjercicio = nombreEjercicio;
            this.grupoMuscular = grupoMuscular;
        }
        public string id_ejercicio
        {
            get { return idEjercicio; }
            set { idEjercicio = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public string NombreEjercicio
        {
            get { return nombreEjercicio; }
            set { nombreEjercicio = value; }
        }
        public string grupo_muscular
        {
            get { return grupoMuscular; }
            set { grupoMuscular = value; }
        }
        public Object[] toObject()
        {
            object[] ejer = new object[4];
            ejer[0] = idEjercicio;
            ejer[1] = descripcion;
            ejer[2] = nombreEjercicio;
            ejer[3] = grupoMuscular;
            return ejer;
        }
    }
}
