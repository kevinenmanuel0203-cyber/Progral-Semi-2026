using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;//Esta librería es necesaria para trabajar con bases de datos
using System.Data.SqlClient;//Esta librería permite usar SQL Server

namespace miPrimeraAplicacion
{
    internal class Conexion
    {
        //Definir los mienbros, atributos y metodos de la clase
        public SqlConnection objConexion = new SqlConnection(); //Conectarse a la BD
        public SqlCommand objComando = new SqlCommand(); //Ejecutar consultas (Insert, update, delete, select)
        public SqlDataAdapter objDataAdapter = new SqlDataAdapter(); //un puente entre la BD y la aplicacion.
        DataSet objDs = new DataSet(); //Representa una copia en memoria de la arquitectura de la BD

        public Conexion()         {//Constructor e inicializador de los mienbros de la clase
            string cadenaConextion = "Data Source=DESKTOP-0F7K2A9;Initial Catalog=BD_Alumnos;Integrated Security=True";
            objConexion.ConnectionString = cadenaConextion;
            objConexion.Open();//abrir la BD
    }
        public DataSet obtenerDatos()
        {
            objDs.Clear();//Limpiar el datase.
            objComando.Connection = objConexion;//Establcer la conexion para ejecutar consultas a la BD

            objDataAdapter.SelectCommand = objComando;
            objComando.CommandText = "SELECT * FROM alumnos";
            objDataAdapter.Fill(objDs, "alumnos"); //tomamos los datos de la BD y llenamos el ds

            return objDs;
        }
    }
}   