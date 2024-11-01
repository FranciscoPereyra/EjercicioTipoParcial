using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2022
{
    internal class Cliente:Ticket
    {
        private long dni;
        static int numero;

        public Cliente (long dni)
        {
            this.dni = dni;
        }

    }
}
