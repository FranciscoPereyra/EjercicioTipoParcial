using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2022
{
    abstract internal class Ticket
    {
        protected int nroOrden;
        private DateTime fechaHora;
        public int VerNro()
        {
            return nroOrden;
        }
        public DateTime VerFechaHora()
                    {
            return fechaHora;
        }
}
