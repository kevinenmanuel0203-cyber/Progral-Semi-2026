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
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1 = 0, num2 = 0, resultado = 0, indexOpcion = 0;
            num1 = Double.Parse(txtNum1.Text); //txtNum1.Text > cadena= "5" => 5.0
            num2 = Double.Parse(txtNum2.Text);

            indexOpcion = cboOpciones.SelectedIndex;
            switch (indexOpcion)
            {
                case 0: //Suma
                    resultado = num1 + num2;
                    break;
                case 1://Resta
                    resultado = num1 - num2;
                    break;
                case 2://Multiplicacion
                    resultado = num1 * num2;
                    break;
                case 3://Division
                    resultado = num1 / num2;
                    break;
                case 4://Exponente
                    resultado = Math.Pow(num1, num2);
                    break;
                case 5://Raiz
                    resultado = Math.Pow(num1, 1 / num2);
                    break;
                case 6://Factorial
                    resultado = 1;
                    for (int i = 1; i <= num1; i++)
                    {
                        resultado = resultado * i;
                    }
                    break;
            }
            lblRespuesta.Text = "Respuesta: " + Math.Round(resultado, 4).ToString();
        }
    }
}
