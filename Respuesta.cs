using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_2
{
    public partial class Respuesta : Form
    {
        public Respuesta()
        {
            InitializeComponent();
        }

        //El método verifica si el resultado del cuadro de diálogo es "OK".
        //Si es así, crea una nueva instancia del formulario "Inicio" y lo muestra.
        private void Respuesta_Load(object sender, EventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                Inicio inicio = new Inicio();
                inicio.Show();
            }
        }

        //El método establece el resultado del cuadro de diálogo en "OK".
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
