using PPAI_CU17.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_CU17
{
    public partial class InterfazOperador : Form
    {
        public InterfazOperador()
        {
            InitializeComponent();
        }

        private void InterfazOperador_Load(object sender, EventArgs e)
        {
            cargarDatos();
            panel1.Visible = false;
        }
        private void cargarDatos()
        {
            //datos cliente
            //Cliente cliente = new Cliente(txtDni.Text, txtCliente.Text);
            txtCliente.Text = "Samir";
            txtDni.Text = "43602304";
            //datos llamada
            txtCategoria.Text = "uno (1)";
            txtOpcion.Text = "tres (3)";
            txtSubOpcion.Text = "cinco (5)";

            
            
        }



        private void btnVerificarDatos_Click_1(object sender, EventArgs e)
        {
            String fechaNac = txtfdn.Text;
            String cantHijos = txtcdh.Text;
            String codigoP = txtcp.Text;

            String fechaNacimiento = "30/08/2001";
            String cantidadHijos = "2";
            String codigoPostal ="5000";


            if (fechaNac.Equals(fechaNacimiento) && cantHijos.Equals(cantidadHijos) && codigoP.Equals(codigoPostal))
            {
                MessageBox.Show("Los datos ingresados son correctos, el estado de la llamada se actualiza a 'FINALIZADA', a continuacion agregar una observacion de la llamada: ", " D A T O S  C O R R E C T O S ", MessageBoxButtons.OK);
                panel1.Visible = true;
                labelestado.Text = "LLAMADA: FINALIZADA";
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos, vuelva a ingresarlos", " * E R R O R * ", MessageBoxButtons.OK);
            }



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cancelar la respuesta del operador?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea guardar la observacion?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }


    }
    //public partial class InterfazOperador : Form
    //{

    //    // declarar atributo gestor
    //    private gestorOperador gestor;
    //    // atributo llamadas que es una lista de llamadas
    //    private List<Llamada> llamadasSeleccionadas;
    //    private Llamada llamadaSeleccionada;

}      

        //private void button2_Click(object sender, EventArgs e)
        //{

        //}
        //public InterfazOperador()
        //{
        //    InitializeComponent();
        //    gestor = new gestorOperador(this);
        //    llamadasSeleccionadas = new List<Llamada>();


        //}

        //private void InterfazOperador_Load(object sender, EventArgs e)
        //{
        //    //buscar estado en curso
        //    int esEnCurso = gestor.esEnCurso();
        //    //esEnCurso tiene el numero identificador del estado "En Curso"

        //    gestor.seleccionarLlamadaIniciada();




        //  // crear nuevo cambio de estado con ese estado


        //}




        //public void mostrarDatos(String nombreCompleto, String dni, String categoria, String opcion, String subopcion)
        //{
        //    txtNombre.Text = nombreCompleto;
        //    lblDNI.Text = dni;
        //    lblCategoria.Text = categoria;
        //    lblOpcion.Text = opcion;
        //    lblSubOpcion.Text = subopcion;
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    string v1 = txtValidacion1.ToString();
        //    string v2 = txtValidacion2.ToString();
        //    string v3 = txtValidacion3.ToString();

        //    gestor.tomarOpcionValidacion( v1,  v2, v3);
        //}
    
//}