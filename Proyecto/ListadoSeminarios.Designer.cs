namespace Proyecto
{
    partial class ListadoSeminarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoSeminarios));
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1026, 47);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(309, 0);
            label1.Name = "label1";
            label1.Size = new Size(387, 47);
            label1.TabIndex = 1;
            label1.Text = "Seminarios Disponibles";
            // 
            // button1
            // 
            button1.Location = new Point(940, 13);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 161);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1026, 286);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(869, 395);
            button2.Name = "button2";
            button2.Size = new Size(132, 30);
            button2.TabIndex = 2;
            button2.Text = "Mas información";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ListadoSeminarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 447);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListadoSeminarios";
            StartPosition = FormStartPosition.Manual;
            Text = "ListadoSeminarios";
            Load += ListadoSeminarios_Load;
            MouseDown += ListadoSeminarios_MouseDown;
            MouseMove += ListadoSeminarios_MouseMove;
            MouseUp += ListadoSeminarios_MouseUp;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button2;
    }
}