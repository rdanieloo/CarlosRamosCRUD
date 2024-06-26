﻿using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarlosRamosCRUD.Data.DataAccess
{
    internal class PersonajeDB
    {
        // Información de conexión a la base de datos
        private string connectionString = "Server=localhost;Database=db_universidad;Uid=root;Pwd=;";

        //constructor
        public PersonajeDB(string servidor, string usur, string pwd)
        {
            connectionString = "Server=" + servidor + ";Database=db_universidad;Uid=" + usur + ";Pwd=" + pwd + ";";
        }

        //prueba de conexion
        public bool ProbarConexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        // Método para leer todos los personajes
        public DataTable LeerPersonajes()
        {
            DataTable personajes = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM personajes_dragon_ball";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personajes);
                    }
                }
            }

            return personajes;
        }

        // Método para crear un nuevo personaje
        public int CrearPersonaje(string nombre, string raza, int nivelPoder, DateTime fecha_creacion, string historia)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO personajes_dragon_ball (nombre, raza, nivel_poder, fecha_creacion, historia) VALUES (@nombre, @raza, @nivelPoder, @fecha_creacion, @historia)";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@raza", raza);
                    command.Parameters.AddWithValue("@nivelPoder", nivelPoder);
                    command.Parameters.AddWithValue("@fecha_creacion", fecha_creacion); 
                    command.Parameters.AddWithValue("@historia", historia);

                    return command.ExecuteNonQuery();
                }
            }
        }

        //Busca un personaje por su ID
        public DataTable BuscarPersonajePorId(int id)
        {
            DataTable personaje = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM personajes_dragon_ball WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personaje);
                    }
                }
            }

            return personaje;
        }




        // Método para eliminar un personaje
        public int EliminarPersonaje(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "DELETE FROM personajes_dragon_ball WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    return command.ExecuteNonQuery();
                }
            }
        }


        // Método para buscar personajes por rango de fechas
        public DataTable BuscarPorRangoDeFecha(DateTime fechaInicio, DateTime fechaFin)


        {
            DataTable resultados = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM personajes_dragon_ball WHERE fecha_creacion BETWEEN @fechaInicio AND @fechaFin";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@fechaFin", fechaFin);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(resultados);
                    }
                }
            }

            return resultados;
        }
        




    }
}
