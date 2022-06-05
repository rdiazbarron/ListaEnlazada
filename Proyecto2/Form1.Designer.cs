namespace Proyecto2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BotonInsertar = new System.Windows.Forms.Button();
            this.BotonEliminar = new System.Windows.Forms.Button();
            this.BotonPrimero = new System.Windows.Forms.Button();
            this.BotonAnterior = new System.Windows.Forms.Button();
            this.BotonSiguiente = new System.Windows.Forms.Button();
            this.BotonUltimo = new System.Windows.Forms.Button();
            this.TextAsignatura = new System.Windows.Forms.TextBox();
            this.TextHoras = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Asignatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de horas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lista Asignaturas";
            // 
            // BotonInsertar
            // 
            this.BotonInsertar.Location = new System.Drawing.Point(293, 202);
            this.BotonInsertar.Name = "BotonInsertar";
            this.BotonInsertar.Size = new System.Drawing.Size(116, 85);
            this.BotonInsertar.TabIndex = 3;
            this.BotonInsertar.Text = "Insertar";
            this.BotonInsertar.UseVisualStyleBackColor = true;
            this.BotonInsertar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.Location = new System.Drawing.Point(442, 202);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(116, 85);
            this.BotonEliminar.TabIndex = 4;
            this.BotonEliminar.Text = "Eliminar";
            this.BotonEliminar.UseVisualStyleBackColor = true;
            this.BotonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // BotonPrimero
            // 
            this.BotonPrimero.Location = new System.Drawing.Point(149, 312);
            this.BotonPrimero.Name = "BotonPrimero";
            this.BotonPrimero.Size = new System.Drawing.Size(116, 85);
            this.BotonPrimero.TabIndex = 5;
            this.BotonPrimero.Text = "Primero";
            this.BotonPrimero.UseVisualStyleBackColor = true;
            this.BotonPrimero.Click += new System.EventHandler(this.BotonPrimero_Click);
            // 
            // BotonAnterior
            // 
            this.BotonAnterior.Location = new System.Drawing.Point(293, 312);
            this.BotonAnterior.Name = "BotonAnterior";
            this.BotonAnterior.Size = new System.Drawing.Size(116, 85);
            this.BotonAnterior.TabIndex = 6;
            this.BotonAnterior.Text = "Anterior";
            this.BotonAnterior.UseVisualStyleBackColor = true;
            this.BotonAnterior.Click += new System.EventHandler(this.BotonAnterior_Click);
            // 
            // BotonSiguiente
            // 
            this.BotonSiguiente.Location = new System.Drawing.Point(442, 312);
            this.BotonSiguiente.Name = "BotonSiguiente";
            this.BotonSiguiente.Size = new System.Drawing.Size(116, 85);
            this.BotonSiguiente.TabIndex = 7;
            this.BotonSiguiente.Text = "Siguiente";
            this.BotonSiguiente.UseVisualStyleBackColor = true;
            this.BotonSiguiente.Click += new System.EventHandler(this.BotonSiguiente_Click);
            // 
            // BotonUltimo
            // 
            this.BotonUltimo.Location = new System.Drawing.Point(574, 312);
            this.BotonUltimo.Name = "BotonUltimo";
            this.BotonUltimo.Size = new System.Drawing.Size(116, 85);
            this.BotonUltimo.TabIndex = 8;
            this.BotonUltimo.Text = "Ultimo";
            this.BotonUltimo.UseVisualStyleBackColor = true;
            this.BotonUltimo.Click += new System.EventHandler(this.BotonUltimo_Click);
            // 
            // TextAsignatura
            // 
            this.TextAsignatura.Location = new System.Drawing.Point(417, 77);
            this.TextAsignatura.Name = "TextAsignatura";
            this.TextAsignatura.Size = new System.Drawing.Size(238, 22);
            this.TextAsignatura.TabIndex = 9;
            this.TextAsignatura.Text = "te";
            // 
            // TextHoras
            // 
            this.TextHoras.Location = new System.Drawing.Point(417, 137);
            this.TextHoras.Name = "TextHoras";
            this.TextHoras.Size = new System.Drawing.Size(238, 22);
            this.TextHoras.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextHoras);
            this.Controls.Add(this.TextAsignatura);
            this.Controls.Add(this.BotonUltimo);
            this.Controls.Add(this.BotonSiguiente);
            this.Controls.Add(this.BotonAnterior);
            this.Controls.Add(this.BotonPrimero);
            this.Controls.Add(this.BotonEliminar);
            this.Controls.Add(this.BotonInsertar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BotonInsertar;
        private System.Windows.Forms.Button BotonEliminar;
        private System.Windows.Forms.Button BotonPrimero;
        private System.Windows.Forms.Button BotonAnterior;
        private System.Windows.Forms.Button BotonSiguiente;
        private System.Windows.Forms.Button BotonUltimo;
        private System.Windows.Forms.TextBox TextAsignatura;
        private System.Windows.Forms.TextBox TextHoras;
    }
}

