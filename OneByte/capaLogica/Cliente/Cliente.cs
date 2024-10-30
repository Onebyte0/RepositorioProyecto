using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneByte.capaLogica
{
    internal class cliente
    {
       
            public int IdCliente { get; set; }
            public string TipoDoc { get; set; }
            public string numDoc { get; set; }
            public string PrimerNom { get; set; }
            public string SegundoNom { get; set; }
            public string PrimerApe { get; set; }
            public string SegundoApe { get; set; }
            public string Direccion { get; set; }
            public int NumCalle { get; set; }
            public string Departamento { get; set; }
            public DateTime Fecha { get; set; }
            public bool EstPago { get; set; }
            public bool contraseña { get; set; }
    }
    }

