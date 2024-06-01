namespace Proyecto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(722, 48);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(636, 12);
            button1.Name = "button1";
            button1.Size = new Size(71, 29);
            button1.TabIndex = 0;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(259, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 171);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(259, 281);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(259, 333);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 23);
            textBox2.TabIndex = 3;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(405, 371);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(67, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Mostrar";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(293, 386);
            button2.Name = "button2";
            button2.Size = new Size(82, 30);
            button2.TabIndex = 5;
            button2.Text = "Entrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(270, 445);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 6;
            label1.Text = "¿No estas registrado?";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(252, 489);
            button3.Name = "button3";
            button3.Size = new Size(171, 32);
            button3.TabIndex = 7;
            button3.Text = "Registrarme";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(225, 65);
            label2.Name = "label2";
            label2.Size = new Size(247, 15);
            label2.TabIndex = 8;
            label2.Text = "PORTAL DE INSCRIPCIONES DE SEMINARIOS ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(149, 286);
            label3.Name = "label3";
            label3.Size = new Size(47, 18);
            label3.TabIndex = 9;
            label3.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(149, 338);
            label4.Name = "label4";
            label4.Size = new Size(65, 18);
            label4.TabIndex = 10;
            label4.Text = "Contraseña";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(719, 550);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private Button button2;
        private Label label1;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
