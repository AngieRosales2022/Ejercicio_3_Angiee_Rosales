using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_AngieeRosales.Entidades
{
    public  class Usuario
    {


        public String Codigo { get; set; }

        public String Clave { get; set; }

        public Usuario(string codigo, string clave)
        {
            Codigo = codigo;
            Clave = clave;
        }

        public Usuario()
        {
        }
    }



}
