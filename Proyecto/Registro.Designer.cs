namespace Proyecto
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            panel1 = new Panel();
            button1 = new Button();
            ReUsuario = new TextBox();
            ReContra = new TextBox();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ReNombre = new TextBox();
            ReCorreo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            label5 = new Label();
            RegistroFacultad = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 38);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(359, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ReUsuario
            // 
            ReUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ReUsuario.Location = new Point(231, 249);
            ReUsuario.Name = "ReUsuario";
            ReUsuario.Size = new Size(153, 23);
            ReUsuario.TabIndex = 1;
            ReUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // ReContra
            // 
            ReContra.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ReContra.Location = new Point(231, 303);
            ReContra.Name = "ReContra";
            ReContra.Size = new Size(153, 23);
            ReContra.TabIndex = 2;
            ReContra.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(129, 442);
            button2.Name = "button2";
            button2.Size = new Size(76, 28);
            button2.TabIndex = 3;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 142);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 184);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // ReNombre
            // 
            ReNombre.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ReNombre.Location = new Point(231, 119);
            ReNombre.Name = "ReNombre";
            ReNombre.Size = new Size(153, 23);
            ReNombre.TabIndex = 6;
            ReNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // ReCorreo
            // 
            ReCorreo.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ReCorreo.Location = new Point(231, 183);
            ReCorreo.Name = "ReCorreo";
            ReCorreo.Size = new Size(153, 25);
            ReCorreo.TabIndex = 7;
            ReCorreo.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(231, 97);
            label1.Name = "label1";
            label1.Size = new Size(102, 19);
            label1.TabIndex = 8;
            label1.Text = "Ingrese su nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(231, 161);
            label2.Name = "label2";
            label2.Size = new Size(95, 19);
            label2.TabIndex = 9;
            label2.Text = "Ingrese su correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(231, 227);
            label3.Name = "label3";
            label3.Size = new Size(100, 19);
            label3.TabIndex = 10;
            label3.Text = "Ingrese su usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(231, 281);
            label4.Name = "label4";
            label4.Size = new Size(119, 19);
            label4.TabIndex = 11;
            label4.Text = "Ingrese su contraseña";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(317, 332);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(67, 19);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Mostrar";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(197, 354);
            label5.Name = "label5";
            label5.Size = new Size(192, 19);
            label5.TabIndex = 14;
            label5.Text = "Ingrese la facultad a la que pertenece";
            // 
            // RegistroFacultad
            // 
            RegistroFacultad.FormattingEnabled = true;
            RegistroFacultad.Location = new Point(205, 389);
            RegistroFacultad.Name = "RegistroFacultad";
            RegistroFacultad.Size = new Size(179, 23);
            RegistroFacultad.TabIndex = 15;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(446, 499);
            Controls.Add(RegistroFacultad);
            Controls.Add(label5);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ReCorreo);
            Controls.Add(ReNombre);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(ReContra);
            Controls.Add(ReUsuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            Load += Registro_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private TextBox ReUsuario;
        private TextBox ReContra;
        private Button button2;
        private PictureBox pictureBox1;
        private TextBox ReNombre;
        private TextBox ReCorreo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
        private Label label5;
        private ComboBox RegistroFacultad;
    }
}