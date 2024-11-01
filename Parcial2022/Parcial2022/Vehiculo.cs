using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2022
{
    internal class Vehiculo
    {
        private string nroPatente;
        private Cliente dueño;

        public Vehiculo(string patente, Cliente dueño)
        {
            nroPatente = patente;
            this.dueño = dueño;
        }

        public Cliente VerDueño()
        {
            return dueño;
        }
        public string VerPatente()
        {
            return nroPatente; ;
        }
    }
}
