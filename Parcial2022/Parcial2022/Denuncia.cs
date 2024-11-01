using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2022
{
    internal class Denuncia:Ticket
    {
        private Vehiculo dominio;
        static int numero;

        public Denuncia(Vehiculo asegurado)
        { 
            dominio=asegurado;
        }
    }
}
