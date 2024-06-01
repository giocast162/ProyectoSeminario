using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Registro : Form
    {
        private string connectionString = "Data Source=LAPTOP-ERSQ3P4V\\SQLEXPRESS;Initial Catalog=Universidad4;Integrated Security=True";

        public Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuardarRegistro();
        }

        private void GuardarRegistro()
        {
            if (!string.IsNullOrWhiteSpace(ReNombre.Text) &&
                !string.IsNullOrWhiteSpace(ReCorreo.Text) &&
                !string.IsNullOrWhiteSpace(ReUsuario.Text) &&
                !string.IsNullOrWhiteSpace(ReContra.Text) &&
                RegistroFacultad.SelectedIndex != -1) 
            {
                string correo = ReCorreo.Text.Trim();
                if (!correo.EndsWith("@mail.utec.edu.sv"))
                {
                    correo += "@mail.utec.edu.sv";
                }

                if (EsNombreValido(ReNombre.Text) && EsContrasenaValida(ReContra.Text))
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "INSERT INTO Estudiantes (Nombre, Usuario, Contraseña, Correo, FacultadNombre) VALUES (@Nombre, @Usuario, @Contraseña, @Correo, @FacultadNombre)";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@Nombre", ReNombre.Text);
                                command.Parameters.AddWithValue("@Usuario", ReUsuario.Text);
                                command.Parameters.AddWithValue("@Contraseña", ReContra.Text);
                                command.Parameters.AddWithValue("@Correo", correo);
                                string facultadSeleccionada = RegistroFacultad.SelectedItem.ToString();
                                command.Parameters.AddWithValue("@FacultadNombre", facultadSeleccionada); 
                                command.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Registro guardado exitosamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar el registro: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa valores válidos en los campos de texto. La contraseña debe contener al menos un símbolo y un número.");
                }

            }
            else
            {
                MessageBox.Show("Por favor, completa todos los campos y selecciona una facultad.");
            }

        }

        public bool EsNombreValido(string nombre)
        {
            foreach (char c in nombre)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }

        public bool EsContrasenaValida(string contrasena)
        {
            bool tieneSimbolo = false;
            bool tieneNumero = false;
            foreach (char c in contrasena)
            {
                if (char.IsSymbol(c) || char.IsPunctuation(c))
                {
                    tieneSimbolo = true;
                }
                if (char.IsDigit(c))
                {
                    tieneNumero = true;
                }
            }
            return tieneSimbolo && tieneNumero;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                ReContra.PasswordChar = '\0';
            }
            else
            {
                ReContra.PasswordChar = '*';
            }
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            CargarFacultades();
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
                            RegistroFacultad.Items.Add(reader["NombreFacultad"].ToString());
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
    }
}
