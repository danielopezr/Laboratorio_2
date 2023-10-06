using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    internal class Lineas
    {

        //Este método se llama "esLinea" y toma un String llamado "linea" como entrada y devuelve un booleano.
        //El método elimina todos los espacios en blanco de la cadena de texto utilizando el método Replace y lo almacena en una nueva variable llamada "ecuacion".
        //Luego, el método utiliza dos expresiones regulares para verificar si la cadena de texto cumple con ciertos patrones:
        //y=mx+b, donde m y b son números enteros y y-y1=m(x-x1), donde m, x1, y y1 son números.
        public bool esLinea(String linea)
        {
            String ecuacion = linea.Replace(" ", "");
            bool ec1 = Regex.IsMatch(ecuacion, @"^y=\d*x\+\d+$");
            bool ec2 = Regex.IsMatch(ecuacion, @"^y-\d+=\d*\(\w-\d+\)$");
            if (!ec1 && !ec2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Este método se llama "pendiente" y toma un String llamado "linea" como entrada y devuelve un float que representa la pendiente.
        //El método elimina todos los espacios en blanco de la cadena de texto utilizando el método Replace y lo almacena en una nueva variable llamada "ecuacion".
        //Luego, el método utiliza dos expresiones regulares para determinar si la ecuación es del tipo "y = mx + b" o "y - y1 = m(x - x1)".
        //Si la ecuación es del tipo “y = mx + b”, el método extrae los dígitos que representan la pendiente (m) y los convierte en un número.
        //Si la ecuación es del tipo “y - y1 = m(x - x1)”, el método extrae los dígitos que representan la pendiente (m) y los convierte en un número.
        public float pendiente(String linea)
        {
            String ecuacion = linea.Replace(" ", "");
            bool ec1 = Regex.IsMatch(ecuacion, @"^y=\d*x\+\d+$");
            bool ec2 = Regex.IsMatch(ecuacion, @"^y-\d+=\d*\(\w-\d+\)$");
            if (ec1)
            {
                int indice1 = ecuacion.IndexOf("=") + 1;
                int indice2 = ecuacion.IndexOf("x");
                string digitos = ecuacion.Substring(indice1, indice2 - indice1);
                float m = float.Parse(digitos);
                return m;
            }
            else
            {
                int indice1 = ecuacion.IndexOf("=") + 1;
                int indice2 = ecuacion.IndexOf("(");
                string digitos = ecuacion.Substring(indice1, indice2 - indice1);
                float m = float.Parse(digitos);
                return m;
            }
        }

        //Este método se llama "intercepto" y toma un String llamado "linea" como entrada y devuelve un float que representa el intercepto.
        //El método elimina todos los espacios en blanco de la cadena de texto utilizando el método Replace y lo almacena en una nueva variable llamada "ecuacion".
        //Luego, el método utiliza dos expresiones regulares para determinar si la ecuación es del tipo "y = mx + b" o "y - y1 = m(x - x1)".
        //Si la ecuación es del tipo “y = mx + b”, el método extrae los dígitos que representan el intercepto (b) y los convierte en un número.
        //Si la ecuación es del tipo “y - y1 = m(x - x1)”, el método extrae los dígitos que representan la pendiente (m), el valor de (y1) y (x1), y los convierte en números para luego operar con ellos y encontrar el intercepto (b).
        public float intercepto(String linea)
        {
            String ecuacion = linea.Replace(" ", "");
            bool ec1 = Regex.IsMatch(ecuacion, @"^y=\d*x\+\d+$");
            bool ec2 = Regex.IsMatch(ecuacion, @"^y-\d+=\d*\(\w-\d+\)$");
            if (ec1)
            {
                int indice1 = ecuacion.IndexOf("+") + 1;
                string digitos = ecuacion.Substring(indice1);
                float b = float.Parse(digitos);
                return b;
            }
            else
            {
                int indice1 = ecuacion.IndexOf("-") + 1;
                int indice2 = ecuacion.IndexOf("=");
                string digitosY1 = ecuacion.Substring(indice1, indice2 - indice1);

                int indice3 = ecuacion.IndexOf("=") + 1;
                int indice4 = ecuacion.IndexOf("(");
                string digitosM = ecuacion.Substring(indice3, indice4 - indice3);

                int indice5 = ecuacion.IndexOf("x") + 2;
                int indice6 = ecuacion.IndexOf(")");
                string digitosX1 = ecuacion.Substring(indice5, indice6 - indice5);

                float y1 = float.Parse(digitosY1);
                float m = float.Parse(digitosM);
                float x1 = float.Parse(digitosX1);

                float b = (y1 - m * x1);

                return b;
            }
        }
    }
}
