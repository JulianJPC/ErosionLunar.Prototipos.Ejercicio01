using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErosionLunar.Prototipos.Ejercicio01.DatosDeUnaPersona
{
    public partial class DatosDeUnaPersonaForm : Form
    {
        private DatosDeUnaPersonaModel modelo = new();
        public DatosDeUnaPersonaForm()
        {
            InitializeComponent();
        }



        private void DatosDeUnaPersonaForm_Load(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            var persona = new Persona();

            if(!int.TryParse(DNIText.Text, out int dni))
            {
                MessageBox.Show("Ingrese un DNI Valido");
                return;
            }

            persona.DNI = dni;
            persona.Apellido = ApellidoText.Text;
            persona.Nombre = NombreText.Text;

            if(!DateTime.TryParse(FechaNacText.Text, out DateTime fN))
            {
                MessageBox.Show("Ingrese Fecha Nacimiento");
                return;
            }

            persona.FechaNacimiento = fN;
            var error = modelo.PersonaIngresada(persona);

            if (error != null) 
            {
                MessageBox.Show(error);
            }
            else
            {
                MessageBox.Show("Los Datos se han ingresado correctamente.");
                //Preparar datos de formulario
                DNIText.Text = string.Empty;
                ApellidoText.Text = string.Empty;
                NombreText.Text = string.Empty;
                FechaNacText.Text = string.Empty;
            }

        }
    }
}
