namespace Proyecto
{
    partial class DocenteRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocenteRegistro));
            panel1 = new Panel();
            label3 = new Label();
            Cerrar = new Button();
            Smateria = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            dataGridViewResultados = new DataGridView();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Cerrar);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1120, 52);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(435, 7);
            label3.Name = "label3";
            label3.Size = new Size(332, 45);
            label3.TabIndex = 1;
            label3.Text = "Seminarios disponibles";
            // 
            // Cerrar
            // 
            Cerrar.Location = new Point(970, 12);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(75, 23);
            Cerrar.TabIndex = 0;
            Cerrar.Text = "Cerrar";
            Cerrar.UseVisualStyleBackColor = true;
            Cerrar.Click += Cerrar_Click_1;
            // 
            // Smateria
            // 
            Smateria.FormattingEnabled = true;
            Smateria.Location = new Point(556, 104);
            Smateria.Name = "Smateria";
            Smateria.Size = new Size(221, 23);
            Smateria.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(434, 104);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 4;
            label2.Text = "Materia";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(790, 170);
            button1.Name = "button1";
            button1.Size = new Size(94, 42);
            button1.TabIndex = 6;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridViewResultados
            // 
            dataGridViewResultados.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResultados.GridColor = SystemColors.ButtonHighlight;
            dataGridViewResultados.Location = new Point(12, 259);
            dataGridViewResultados.Name = "dataGridViewResultados";
            dataGridViewResultados.Size = new Size(1047, 293);
            dataGridViewResultados.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(171, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 184);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Location = new Point(456, 170);
            button2.Name = "button2";
            button2.Size = new Size(101, 42);
            button2.TabIndex = 9;
            button2.Text = "Exportar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // DocenteRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1071, 564);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridViewResultados);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(Smateria);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DocenteRegistro";
            Text = "DocenteRegistro";
            Load += DocenteRegistro_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultados).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Button Cerrar;
        private ComboBox Smateria;
        private Label label2;
        private Button button1;
        private DataGridView dataGridViewResultados;
        private PictureBox pictureBox1;
        private Button button2;
    }
}