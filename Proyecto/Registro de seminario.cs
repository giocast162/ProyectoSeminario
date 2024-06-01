using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Proyecto
{
    public partial class Registro_de_seminario : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        
        string connectionString = "Data Source=LAPTOP-ERSQ3P4V\\SQLEXPRESS;Initial Catalog=Universidad4;Integrated Security=True";

        public Registro_de_seminario()
        {
            InitializeComponent();
        }

        private void SDRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO InscripcionSeminarios (NombreEstudiante, CorreoEstudiante, NombreMateria, NombreSeminario, FacultadNombre) VALUES (@NombreEstudiante, @CorreoEstudiante, @NombreMateria, @NombreSeminario, @FacultadNombre)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NombreEstudiante", SDalumno.Text);
                        command.Parameters.AddWithValue("@CorreoEstudiante", SDcorreo.Text.EndsWith("@mail.utec.edu.sv") ? SDcorreo.Text : SDcorreo.Text + "@mail.utec.edu.sv");
                        command.Parameters.AddWithValue("@NombreMateria", SDMateria.Text);
                        command.Parameters.AddWithValue("@NombreSeminario", SDSeminarios.Text);
                        command.Parameters.AddWithValue("@FacultadNombre", SDFacultad.Text);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("¡Registro exitoso! Su comprobante será enviado al correo en 24 horas.");
                LimpiarCampos();
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(SDalumno.Text) ||
                string.IsNullOrWhiteSpace(SDcorreo.Text) ||
                string.IsNullOrWhiteSpace(SDMateria.Text) ||
                string.IsNullOrWhiteSpace(SDSeminarios.Text) ||
                string.IsNullOrWhiteSpace(SDFacultad.Text))
            {
                MessageBox.Show("Todos los campos son requeridos.");
                return false;
            }

            if (!EsNumero(SDcorreo.Text))
            {
                MessageBox.Show("El correo electrónico solo puede contener números.");
                return false;
            }

            if (SDalumno.Text.Length < 15)
            {
                MessageBox.Show("El nombre del estudiante es demasiado corto.");
                return false;
            }

            return true;
        }

        private bool EsNumero(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void LimpiarCampos()
        {
            SDalumno.Clear();
            SDcorreo.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SDconsulta_Click(object sender, EventArgs e)
        {
            ListadoSeminarios listadoForm = new ListadoSeminarios();
            listadoForm.Show();
        }

        private void Registro_de_seminario_Load(object sender, EventArgs e)
        {
            CargarFacultades();
            CargarSeminarios();
            CargarMaterias();
        }

        private void CargarFacultades()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT NombreFacultad FROM Facultad";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            SDFacultad.Items.Add(reader["NombreFacultad"].ToString());
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las facultades: " + ex.Message);
            }
        }

        private void CargarSeminarios()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Nombre FROM Seminarios";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            SDSeminarios.Items.Add(reader["Nombre"].ToString());
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los seminarios: " + ex.Message);
            }
        }

        private void CargarMaterias()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Nombre FROM Materias";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            SDMateria.Items.Add(reader["Nombre"].ToString());
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las materias: " + ex.Message);
            }
        }

        private void Registro_de_seminario_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Registro_de_seminario_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Registro_de_seminario_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}