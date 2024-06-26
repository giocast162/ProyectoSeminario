﻿ using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto
{
    public partial class ListadoSeminarios : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public ListadoSeminarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La inscripción de seminarios se realiza de forma virtual pero el pago debes acercarte al punto de pago mas cercano y mostrar el comprobante para poder completar el proceso de inscripción.");
        }

        private void ListadoSeminarios_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void ListadoSeminarios_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void ListadoSeminarios_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void ListadoSeminarios_Load(object sender, EventArgs e)
        {

        }
    }
}
