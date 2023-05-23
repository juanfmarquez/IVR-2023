using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Entidades
{
    public class OpcionLlamada
    {
        private string nombre;
        private string mensajesOpciones;
        private int nroOrden;
        private string audioMensajeSubOpciones;
        public List<SubOpcionLlamada> subopcionesSeleccionadas;



        public OpcionLlamada(string nombre, string mensajesOpciones, int nroOrden, string audioMensajeSubOpciones, List<SubOpcionLlamada> subopcionesSeleccionadas)
        {
            this.nombre = nombre;
            this.mensajesOpciones = mensajesOpciones;
            this.nroOrden = nroOrden;
            this.audioMensajeSubOpciones = audioMensajeSubOpciones;
            this.subopcionesSeleccionadas = subopcionesSeleccionadas;
        }
        public string _nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string _mensajeSubOpciones
        {
            get => mensajesOpciones;
            set => mensajesOpciones = value;
        }

        public int _nroOrden
        {
            get => nroOrden;
            set => nroOrden = value;
        }
        public string _audioMensajeSubOpciones
        {
            get => audioMensajeSubOpciones;
            set => audioMensajeSubOpciones = value;
        }

        public List<SubOpcionLlamada> _subopcionesSeleccionadas
        {
            get => subopcionesSeleccionadas;
            set => subopcionesSeleccionadas = value;
        }


    }
}

