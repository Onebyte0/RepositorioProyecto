using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneByte.capaLogica
{
    internal class cliente
    {
       
            public int idCliente { get; set; }
            public string tipoDoc { get; set; }
            public string numDoc { get; set; }
            public string primerNom { get; set; }
            public string segundoNom { get; set; }
            public string primerApe { get; set; }
            public string segundoApe { get; set; }
            public string direccion { get; set; }
            public int numCalle { get; set; }
            public string departamento { get; set; }
            public DateTime fecha { get; set; }
            public bool estPago { get; set; }
            public bool contraseña { get; set; }
    }
    }

