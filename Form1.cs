using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarlosRamosCRUD.Data.DataAccess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarlosRamosCRUD
{
    public partial class Form1 : Form
    {

        // Lista de razas
        private string[] razasDragonBall = {
            "Android",
            "Bio-Android",
            "Humana",
            "Humano",
            "Majin",
            "Namekuseijin",
            "Saiyajin",
            "Saiyajin/Humano",
            "Saiyajin/Saiyajin"
        };
        private PersonajeDB personaje;
      

        public Form1()
        {
            InitializeComponent();
            personaje = new PersonajeDB("localhost","root","Ram0s.24CC19");
        }


        

        private void buttonCargaData_Click(object sender, EventArgs e)
        {
            dataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxRaza.Items.AddRange(razasDragonBall);
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            //string raza = comboBoxRaza.Text;
            string raza = textBoxRaza.Text;
            int nivelPoder = (int)numericUpDownNivelPoder.Value;
            DateTime fecha_creacion = dateTimePickerfecha_creacion.Value; 
            string historia = textBoxHistoria.Text; 



            int respuesta = personaje.CrearPersonaje(nombre, raza, nivelPoder,fecha_creacion, historia);
            if (respuesta > 0)
            {
                MessageBox.Show("Personaje creado correctamente");
                dataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
            }
            else
            {
                MessageBox.Show("Error al crear el personaje");
            }
        }


        private void buscarPorId()
        {
            int idPersonajeABuscar = int.Parse(textBoxID.Text);

            DataTable personajeEncontrado = personaje.BuscarPersonajePorId(idPersonajeABuscar);

            if (personajeEncontrado.Rows.Count > 0)
            {
                // El personaje fue encontrado
                string nombre = personajeEncontrado.Rows[0]["nombre"].ToString();
                string raza = personajeEncontrado.Rows[0]["raza"].ToString();
                int nivelPoder = int.Parse(personajeEncontrado.Rows[0]["nivel_poder"].ToString());
                string historia = personajeEncontrado.Rows[0]["historia"].ToString();
                textBoxNombre.Text = nombre;
                textBoxRaza.Text = raza;
                comboBoxRaza.Text = raza;
                numericUpDownNivelPoder.Value = nivelPoder;
                DateTime fecha_creacion = dateTimePickerfecha_creacion.Value;
                textBoxHistoria.Text = historia;
            }
            else
            {
                // El personaje no fue encontrado
                Console.WriteLine("No se encontró el personaje con ID: " + idPersonajeABuscar);
            }
        }


        private void buttonBuscar_Click(object sender, EventArgs e)
        {
           buscarPorId();
        }

        private void textBoxID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxID.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor en el campo de texto.");
                textBoxID.Focus(); // Devolver el foco al TextBox
            } else
            {
                buscarPorId();
            }
        }

        private void buttonTestCon_Click(object sender, EventArgs e)
        {
            if (personaje.ProbarConexion())
            {
                MessageBox.Show("Conexión exitosa");
            }
            else
            {
                MessageBox.Show("Error en la conexión");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxHistoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerfecha_creacion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonEliminarPersonaje_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxID.Text))
            {
                MessageBox.Show("Por favor, ingresa el ID del personaje a eliminar.");
                return;
            }

            int idPersonajeAEliminar;
            if (!int.TryParse(textBoxID.Text, out idPersonajeAEliminar))
            {
                MessageBox.Show("Por favor, ingresa un ID válido.");
                return;
            }

            int respuesta = personaje.EliminarPersonaje(idPersonajeAEliminar);
            if (respuesta > 0)
            {
                MessageBox.Show("Personaje eliminado correctamente");
                dataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
            }
            else
            {
                MessageBox.Show("Error al eliminar el personaje o el personaje no existe.");
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fechas_seleccionadas_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }



        private void botonBuscarPorFecha_Click(object sender, EventArgs e)
        {
            // Aca obtenemos las fechas seleccionadas del MonthCalendar o los DateTimePicker

            DateTime fechaInicio = fechas_seleccionadas.SelectionStart;
            DateTime fechaFin = fechas_seleccionadas.SelectionEnd;

            // Crear una instancia de PersonajeDB con los argumentos adecuados

            PersonajeDB personajeDB = new PersonajeDB("localhost", "root", "Ram0s.24CC19");

            // Aca llamamos al metodo BuscarPorRangoDeFecha de nuestra clase PersonajeDB

            DataTable resultadoBusqueda = personajeDB.BuscarPorRangoDeFecha(fechaInicio, fechaFin);

            // Mostramos el resultado de la búsqueda en el DataGridView

            dataGridViewPersonajes.DataSource = resultadoBusqueda;
        }

    }

}
