using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimeraAplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Conexion objconexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        string accion = "nuevo";
        int posicion = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            obtenerDatos();
        }
        private void obtenerDatos()
        {
            ds.Clear();
            ds = objconexion.obtenerDatos();
            dt = ds.Tables["alumnos"];
            dt.PrimaryKey = new DataColumn[] { dt.Columns["idAlumno"] };
        }

        private void mostrarDatos()
        {
            
            if(dt.Rows.Count > 0){
                txtcodigo.Text = dt.Rows[posicion]["codigo"].ToString();
                txtnombre.Text = dt.Rows[posicion]["nombre"].ToString();
                txtdireccion.Text = dt.Rows[posicion]["direccion"].ToString();
                txttelefono.Text = dt.Rows[posicion]["telefono"].ToString();
                txtemail.Text = dt.Rows[posicion]["email"].ToString();

                lblregistro.Text = (posicion + 1) + " de " + dt.Rows.Count;
            }
        }
        private void activarDesactivarCtrls(Boolean estado)
        {
            grbdatos.Enabled = estado;
            grpnavegacion.Enabled = !estado;
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (btnagregar.Text == "Agregar"){
                btnagregar.Text = "Guardar";
                btnmodificar.Text = "Cancelar";
                activarDesactivarCtrls(true);
        }else{//Guardar

                activarDesactivarCtrls(false);
                btnagregar.Text = "Agregar";
                btnmodificar.Text = "Modificar";

            
        }
    }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
                if (btnmodificar.Text == "Modificar"){
                    btnagregar.Text = "Guardar";
                    btnmodificar.Text = "Cancelar";
                    activarDesactivarCtrls(true);
                }else{//Guardar

                    activarDesactivarCtrls(false);
                    btnagregar.Text = "Agregar";
                    btnmodificar.Text = "Modificar";
            }
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            posicion++;
            mostrarDatos();
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            posicion--;
            mostrarDatos();
        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            posicion = dt.Rows.Count - 1;
            mostrarDatos();
        }

        private void btnprimero_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }
    }
}