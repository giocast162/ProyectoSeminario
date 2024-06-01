
using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class DocenteRegistro : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private string connectionString = "Data Source=LAPTOP-ERSQ3P4V\\SQLEXPRESS;Initial Catalog=Universidad4;Integrated Security=True";

        public DocenteRegistro()
        {
            InitializeComponent();
            dataGridViewResultados.BorderStyle = BorderStyle.None;
            // Suscribir los eventos de mouse en el constructor
            this.MouseDown += DocenteRegistro_MouseDown;
            this.MouseMove += DocenteRegistro_MouseMove;
            this.MouseUp += DocenteRegistro_MouseUp;
        }

        private void DocenteRegistro_Load(object sender, EventArgs e)
        {
           
            CargarMaterias();
        }

        private void CargarMaterias()
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT NombreMateria FROM InscripcionSeminarios";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        
                        Smateria.Items.Clear();

                        
                        while (reader.Read())
                        {
                            string materia = reader["NombreMateria"].ToString();
                            Smateria.Items.Add(materia);
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar las materias: " + ex.Message);
                    }
                }
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void DocenteRegistro_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void DocenteRegistro_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void DocenteRegistro_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string materiaSeleccionada = Smateria.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(materiaSeleccionada))
            {
                MessageBox.Show("Seleccione una materia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT NombreEstudiante, CorreoEstudiante, NombreSeminario, FacultadNombre " +
                               "FROM InscripcionSeminarios " +
                               "WHERE NombreMateria = @Materia";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@Materia", materiaSeleccionada);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        
                        dataGridViewResultados.Rows.Clear();
                        dataGridViewResultados.Columns.Clear();

                        
                        dataGridViewResultados.Columns.Add("NombreEstudiante", "Nombre Estudiante");
                        dataGridViewResultados.Columns.Add("CorreoEstudiante", "Correo Estudiante");
                        dataGridViewResultados.Columns.Add("NombreSeminario", "Nombre Seminario");
                        dataGridViewResultados.Columns.Add("FacultadNombre", "Facultad");

                        
                        while (reader.Read())
                        {
                            string nombreEstudiante = reader["NombreEstudiante"].ToString();
                            string correoEstudiante = reader["CorreoEstudiante"].ToString();
                            string nombreSeminario = reader["NombreSeminario"].ToString();
                            string facultad = reader["FacultadNombre"].ToString();

                            
                            dataGridViewResultados.Rows.Add(nombreEstudiante, correoEstudiante, nombreSeminario, facultad);
                        }

                        reader.Close();

                       
                        dataGridViewResultados.AutoResizeColumns();
                        dataGridViewResultados.AutoResizeRows();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
                    }
                }
            }
        }

        private void Smateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            button1_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear un nuevo archivo Excel
                using (var workbook = new XLWorkbook())
                {
                    // Agregar una nueva hoja de trabajo al libro de trabajo
                    var worksheet = workbook.Worksheets.Add("Datos");

                    // Agregar los encabezados de las columnas
                    for (int i = 1; i <= dataGridViewResultados.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i).Value = dataGridViewResultados.Columns[i - 1].HeaderText;
                        worksheet.Column(i).Width = dataGridViewResultados.Columns[i - 1].Width / 8; // Ajustar el ancho de la columna
                    }

                    // Agregar los datos de las filas
                    for (int i = 0; i < dataGridViewResultados.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridViewResultados.Columns.Count; j++)
                        {
                            worksheet.Cell(i + 2, j + 1).Value = dataGridViewResultados.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                    // Guardar el libro de trabajo en un archivo Excel
                    using (var saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx|Todos los archivos (*.*)|*.*";
                        saveFileDialog.FileName = "Datos";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            workbook.SaveAs(saveFileDialog.FileName);
                            MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


