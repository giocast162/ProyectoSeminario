namespace Proyecto
{
    partial class Registro_de_seminario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            SDRegistrar = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SDalumno = new TextBox();
            SDcorreo = new TextBox();
            SDconsulta = new Button();
            SDFacultad = new ComboBox();
            SDSeminarios = new ComboBox();
            SDMateria = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-2, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(611, 44);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(518, 15);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(119, 0);
            label3.Name = "label3";
            label3.Size = new Size(332, 45);
            label3.TabIndex = 0;
            label3.Text = "Seminarios disponibles";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 70);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 1;
            label1.Text = "Facultad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 208);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 2;
            label2.Text = "Seminarios";
            // 
            // SDRegistrar
            // 
            SDRegistrar.BackColor = SystemColors.ActiveBorder;
            SDRegistrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SDRegistrar.Location = new Point(418, 338);
            SDRegistrar.Name = "SDRegistrar";
            SDRegistrar.Size = new Size(145, 38);
            SDRegistrar.TabIndex = 6;
            SDRegistrar.Text = "Registrarme";
            SDRegistrar.UseVisualStyleBackColor = false;
            SDRegistrar.Click += SDRegistrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(48, 251);
            label4.Name = "label4";
            label4.Size = new Size(67, 21);
            label4.TabIndex = 9;
            label4.Text = "Materia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(37, 117);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 10;
            label5.Text = "Alumno";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(37, 162);
            label6.Name = "label6";
            label6.Size = new Size(121, 17);
            label6.TabIndex = 14;
            label6.Text = "Correo electronico";
            // 
            // SDalumno
            // 
            SDalumno.Location = new Point(241, 117);
            SDalumno.Name = "SDalumno";
            SDalumno.Size = new Size(187, 23);
            SDalumno.TabIndex = 18;
            // 
            // SDcorreo
            // 
            SDcorreo.Location = new Point(241, 161);
            SDcorreo.Name = "SDcorreo";
            SDcorreo.Size = new Size(187, 23);
            SDcorreo.TabIndex = 19;
            // 
            // SDconsulta
            // 
            SDconsulta.BackColor = SystemColors.ActiveBorder;
            SDconsulta.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SDconsulta.ForeColor = SystemColors.ActiveCaptionText;
            SDconsulta.Location = new Point(12, 338);
            SDconsulta.Name = "SDconsulta";
            SDconsulta.Size = new Size(194, 38);
            SDconsulta.TabIndex = 23;
            SDconsulta.Text = "Consultar seminarios";
            SDconsulta.UseVisualStyleBackColor = false;
            SDconsulta.Click += SDconsulta_Click;
            // 
            // SDFacultad
            // 
            SDFacultad.FormattingEnabled = true;
            SDFacultad.Location = new Point(216, 72);
            SDFacultad.Name = "SDFacultad";
            SDFacultad.Size = new Size(245, 23);
            SDFacultad.TabIndex = 24;
            // 
            // SDSeminarios
            // 
            SDSeminarios.FormattingEnabled = true;
            SDSeminarios.Location = new Point(167, 206);
            SDSeminarios.Name = "SDSeminarios";
            SDSeminarios.Size = new Size(375, 23);
            SDSeminarios.TabIndex = 25;
            // 
            // SDMateria
            // 
            SDMateria.FormattingEnabled = true;
            SDMateria.Location = new Point(241, 251);
            SDMateria.Name = "SDMateria";
            SDMateria.Size = new Size(187, 23);
            SDMateria.TabIndex = 26;
            // 
            // Registro_de_seminario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(603, 417);
            Controls.Add(SDMateria);
            Controls.Add(SDSeminarios);
            Controls.Add(SDFacultad);
            Controls.Add(SDconsulta);
            Controls.Add(SDcorreo);
            Controls.Add(SDalumno);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(SDRegistrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registro_de_seminario";
            StartPosition = FormStartPosition.Manual;
            Text = "Registro_de_seminario";
            Load += Registro_de_seminario_Load;
            MouseDown += Registro_de_seminario_MouseDown;
            MouseMove += Registro_de_seminario_MouseMove;
            MouseUp += Registro_de_seminario_MouseUp;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button SDRegistrar;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
        private Label label6;
        private TextBox SDalumno;
        private TextBox SDcorreo;
        private Button SDconsulta;
        private ComboBox SDFacultad;
        private ComboBox SDSeminarios;
        private ComboBox SDMateria;
    }
}