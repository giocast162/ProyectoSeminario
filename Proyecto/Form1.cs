using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        private bool mouseDown;
        private Point lastLocation;
     
        private string connectionString = "Data Source=LAPTOP-ERSQ3P4V\\SQLEXPRESS;Initial Catalog=Universidad4;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                connection.Open();

                
                string queryDocente = "SELECT COUNT(*) FROM Docente WHERE Usuario = @Usuario";

                using (SqlCommand commandDocente = new SqlCommand(queryDocente, connection))
                {
                    commandDocente.Parameters.AddWithValue("@Usuario", usuario);

                    int countDocente = (int)commandDocente.ExecuteScalar();

                    if (countDocente > 0)
                    {
                        
                        string queryContraseñaDocente = "SELECT COUNT(*) FROM Docente WHERE Usuario = @Usuario AND Contraseña = @Contraseña";

                        using (SqlCommand commandContraseñaDocente = new SqlCommand(queryContraseñaDocente, connection))
                        {
                            commandContraseñaDocente.Parameters.AddWithValue("@Usuario", usuario);
                            commandContraseñaDocente.Parameters.AddWithValue("@Contraseña", contraseña);

                            int countContraseñaDocente = (int)commandContraseñaDocente.ExecuteScalar();

                            if (countContraseñaDocente > 0)
                            {
                                
                                DocenteRegistro docenteRegistroForm = new DocenteRegistro();
                                docenteRegistroForm.Show();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }

                
                string queryEstudiante = "SELECT COUNT(*) FROM Estudiantes WHERE Usuario = @Usuario";

                using (SqlCommand commandEstudiante = new SqlCommand(queryEstudiante, connection))
                {
                    commandEstudiante.Parameters.AddWithValue("@Usuario", usuario);

                    int countEstudiante = (int)commandEstudiante.ExecuteScalar();

                    if (countEstudiante > 0)
                    {
                        
                        string queryContraseñaEstudiante = "SELECT COUNT(*) FROM Estudiantes WHERE Usuario = @Usuario AND Contraseña = @Contraseña";

                        using (SqlCommand commandContraseñaEstudiante = new SqlCommand(queryContraseñaEstudiante, connection))
                        {
                            commandContraseñaEstudiante.Parameters.AddWithValue("@Usuario", usuario);
                            commandContraseñaEstudiante.Parameters.AddWithValue("@Contraseña", contraseña);

                            int countContraseñaEstudiante = (int)commandContraseñaEstudiante.ExecuteScalar();

                            if (countContraseñaEstudiante > 0)
                            {
                                
                                Registro_de_seminario registroSeminarioForm = new Registro_de_seminario();
                                registroSeminarioForm.Show();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }

                
                MessageBox.Show("Usuario no registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Registro registroForm = new Registro();
            registroForm.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0'; 
            }
            else
            {
                textBox2.PasswordChar = '*'; 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}


