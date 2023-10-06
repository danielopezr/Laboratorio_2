using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_2
{
    public partial class Inicio : Form
    {
        //La línea de código crea una nueva instancia de la clase “Lineas” y la asigna a la variable “opLineas”.
        Lineas opLineas = new Lineas();

        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
        }

        private void linea1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtLinea1, "");
        }
        private void linea2_TextChanged(object sender, EventArgs e)
        {
            errorProvider2.SetError(txtLinea2, "");
        }

        //El método verifica si las cadenas de entrada representan ecuaciones de línea válidas.
        //Si las cadenas no representan ecuaciones de línea, se muestra un mensaje de error en los cuadros de texto correspondientes.
        //Si ambas cadenas representan ecuaciones de línea válidas, se crea una nueva instancia del formulario "Respuesta".
        //Luego, el método calcula la pendiente y el intercepto para ambas líneas utilizando los métodos "pendiente" e "intercepto" definidos en la clase "opLineas".
        //A continuación, el método verifica si las dos líneas son paralelas, perpendiculares o ninguna mostrando el mensaje correspondiente en el cuadro de texto del formulario "Respuesta".
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            String linea1 = txtLinea1.Text;
            String linea2 = txtLinea2.Text;
            bool val1 = opLineas.esLinea(linea1);
            bool val2 = opLineas.esLinea(linea2);

            if (!val1 && !val2)
            {
                errorProvider1.SetError(txtLinea1, "No es la ecuacion de una linea");
                errorProvider2.SetError(txtLinea2, "No es la ecuacion de una linea");
            }
            else
            {
                if (!val1)
                {
                    errorProvider1.SetError(txtLinea1, "No es la ecuacion de una linea");
                }
                else
                {
                    if (!val2)
                    {
                        errorProvider2.SetError(txtLinea2, "No es la ecuacion de una linea");
                    }
                    else
                    {
                        Respuesta respuesta = new Respuesta();
                        AddOwnedForm(respuesta);

                        float pendiente1 = opLineas.pendiente(linea1);
                        float intercepto1 = opLineas.intercepto(linea1);

                        float pendiente2 = opLineas.pendiente(linea2);
                        float intercepto2 = opLineas.intercepto(linea2);

                        if (pendiente1 - pendiente2 == 0)
                        {
                            respuesta.txtRespuesta.Text = ("Las dos líneas son paralelas y no se cruzan en ningún punto");
                            respuesta.ShowDialog();
                        }
                        else
                        {
                            float x = (intercepto2 - intercepto1) / (pendiente1 - pendiente2);
                            float y = pendiente1 * x + intercepto1;

                            String valX = x.ToString();
                            String valY = y.ToString();

                            respuesta.txtRespuesta.Text = ("(" + x + ", " + y + ")");

                            if (pendiente1 * pendiente2 == -1) 
                            {
                                respuesta.txtRespuesta.Text = ("Las dos líneas son perpendiculares y se cruzan en (" + x + ", " + y + ")");
                                respuesta.ShowDialog();
                            }
                            else
                            {
                                respuesta.txtRespuesta.Text = ("Las dos líneas se cruzan en (" + x + ", " + y + ")");
                                respuesta.ShowDialog();
                            }
                        }
                    }
                }
            }
        }

        //El método cierra el formulario "Inicio".
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
