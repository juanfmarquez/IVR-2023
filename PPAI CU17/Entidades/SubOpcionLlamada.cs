using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Entidades
{
    public class SubOpcionLlamada
    {
        public string Nombre { get; set; }
        private int NroOrden { get; set; }

        public SubOpcionLlamada(string nombre, int nroOrden)
        {
            this.Nombre = nombre;
            this.NroOrden = nroOrden;

        }

        public bool esNumero(int i)
        {
            if(i is int)
            {
                return true;
            }
            return false;
            
        }
    }
   
}