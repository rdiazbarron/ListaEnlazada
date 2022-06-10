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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BotonInsertar = new System.Windows.Forms.Button();
            this.BotonEliminar = new System.Windows.Forms.Button();
            this.BotonPrimero = new System.Windows.Forms.Button();
            this.BotonAnterior = new System.Windows.Forms.Button();
            this.BotonSiguiente = new System.Windows.Forms.Button();
            this.BotonUltimo = new System.Windows.Forms.Button();
            this.TextMascota = new System.Windows.Forms.TextBox();
            this.TextEdad = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextRaza = new System.Windows.Forms.TextBox();
            this.AgregarDespuesDe = new System.Windows.Forms.Button();
            this.TextMascotaAux = new System.Windows.Forms.TextBox();
            this.BotonAgregarInicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mascota :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "LISTA DE NUESTRAS MASCOTAS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BotonInsertar
            // 
            this.BotonInsertar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BotonInsertar.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonInsertar.Location = new System.Drawing.Point(518, 205);
            this.BotonInsertar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BotonInsertar.Name = "BotonInsertar";
            this.BotonInsertar.Size = new System.Drawing.Size(93, 105);
            this.BotonInsertar.TabIndex = 3;
            this.BotonInsertar.Text = "Agregar al final";
            this.BotonInsertar.UseVisualStyleBackColor = false;
            this.BotonInsertar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BotonEliminar.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEliminar.Location = new System.Drawing.Point(647, 433);
            this.BotonEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(93, 105);
            this.BotonEliminar.TabIndex = 4;
            this.BotonEliminar.Text = "Eliminar";
            this.BotonEliminar.UseVisualStyleBackColor = false;
            this.BotonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // BotonPrimero
            // 
            this.BotonPrimero.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BotonPrimero.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonPrimero.Location = new System.Drawing.Point(398, 433);
            this.BotonPrimero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BotonPrimero.Name = "BotonPrimero";
            this.BotonPrimero.Size = new System.Drawing.Size(93, 105);
            this.BotonPrimero.TabIndex = 5;
            this.BotonPrimero.Text = "Primero";
            this.BotonPrimero.UseVisualStyleBackColor = false;
            this.BotonPrimero.Click += new System.EventHandler(this.BotonPrimero_Click);
            // 
            // BotonAnterior
            // 
            this.BotonAnterior.BackColor = System.Drawing.Color.LightSalmon;
            this.BotonAnterior.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAnterior.Location = new System.Drawing.Point(398, 320);
            this.BotonAnterior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BotonAnterior.Name = "BotonAnterior";
            this.BotonAnterior.Size = new System.Drawing.Size(93, 105);
            this.BotonAnterior.TabIndex = 6;
            this.BotonAnterior.Text = "Anterior";
            this.BotonAnterior.UseVisualStyleBackColor = false;
            this.BotonAnterior.Click += new System.EventHandler(this.BotonAnterior_Click);
            // 
            // BotonSiguiente
            // 
            this.BotonSiguiente.BackColor = System.Drawing.Color.LightSalmon;
            this.BotonSiguiente.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonSiguiente.Location = new System.Drawing.Point(518, 320);
            this.BotonSiguiente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BotonSiguiente.Name = "BotonSiguiente";
            this.BotonSiguiente.Size = new System.Drawing.Size(93, 105);
            this.BotonSiguiente.TabIndex = 7;
            this.BotonSiguiente.Text = "Siguiente";
            this.BotonSiguiente.UseVisualStyleBackColor = false;
            this.BotonSiguiente.Click += new System.EventHandler(this.BotonSiguiente_Click);
            // 
            // BotonUltimo
            // 
            this.BotonUltimo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BotonUltimo.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonUltimo.Location = new System.Drawing.Point(518, 433);
            this.BotonUltimo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BotonUltimo.Name = "BotonUltimo";
            this.BotonUltimo.Size = new System.Drawing.Size(93, 105);
            this.BotonUltimo.TabIndex = 8;
            this.BotonUltimo.Text = "Ultimo";
            this.BotonUltimo.UseVisualStyleBackColor = false;
            this.BotonUltimo.Click += new System.EventHandler(this.BotonUltimo_Click);
            // 
            // TextMascota
            // 
            this.TextMascota.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMascota.Location = new System.Drawing.Point(335, 75);
            this.TextMascota.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextMascota.Name = "TextMascota";
            this.TextMascota.Size = new System.Drawing.Size(185, 30);
            this.TextMascota.TabIndex = 9;
            // 
            // TextEdad
            // 
            this.TextEdad.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextEdad.Location = new System.Drawing.Point(335, 152);
            this.TextEdad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextEdad.Name = "TextEdad";
            this.TextEdad.Size = new System.Drawing.Size(93, 30);
            this.TextEdad.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(12, 263);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(289, 280);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Buscar
            // 
            this.Buscar.BackColor = System.Drawing.Color.Khaki;
            this.Buscar.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Location = new System.Drawing.Point(635, 205);
            this.Buscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(92, 105);
            this.Buscar.TabIndex = 13;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = false;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(166, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 43);
            this.label4.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(284, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 49);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mi Veterinaria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(236, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Raza :";
            // 
            // TextRaza
            // 
            this.TextRaza.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextRaza.Location = new System.Drawing.Point(335, 115);
            this.TextRaza.Name = "TextRaza";
            this.TextRaza.Size = new System.Drawing.Size(185, 30);
            this.TextRaza.TabIndex = 17;
            this.TextRaza.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AgregarDespuesDe
            // 
            this.AgregarDespuesDe.Location = new System.Drawing.Point(647, 23);
            this.AgregarDespuesDe.Name = "AgregarDespuesDe";
            this.AgregarDespuesDe.Size = new System.Drawing.Size(93, 105);
            this.AgregarDespuesDe.TabIndex = 18;
            this.AgregarDespuesDe.Text = "Agregar despues de";
            this.AgregarDespuesDe.UseVisualStyleBackColor = true;
            this.AgregarDespuesDe.Click += new System.EventHandler(this.AgregarDespuesDe_Click);
            // 
            // TextMascotaAux
            // 
            this.TextMascotaAux.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMascotaAux.Location = new System.Drawing.Point(603, 135);
            this.TextMascotaAux.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextMascotaAux.Name = "TextMascotaAux";
            this.TextMascotaAux.Size = new System.Drawing.Size(185, 30);
            this.TextMascotaAux.TabIndex = 19;
            // 
            // BotonAgregarInicio
            // 
            this.BotonAgregarInicio.Location = new System.Drawing.Point(398, 205);
            this.BotonAgregarInicio.Name = "BotonAgregarInicio";
            this.BotonAgregarInicio.Size = new System.Drawing.Size(93, 105);
            this.BotonAgregarInicio.TabIndex = 20;
            this.BotonAgregarInicio.Text = "Agregar al inicio";
            this.BotonAgregarInicio.UseVisualStyleBackColor = true;
            this.BotonAgregarInicio.Click += new System.EventHandler(this.BotonAgregarInicio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.BotonAgregarInicio);
            this.Controls.Add(this.TextMascotaAux);
            this.Controls.Add(this.AgregarDespuesDe);
            this.Controls.Add(this.TextRaza);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.TextEdad);
            this.Controls.Add(this.TextMascota);
            this.Controls.Add(this.BotonUltimo);
            this.Controls.Add(this.BotonSiguiente);
            this.Controls.Add(this.BotonAnterior);
            this.Controls.Add(this.BotonPrimero);
            this.Controls.Add(this.BotonEliminar);
            this.Controls.Add(this.BotonInsertar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.TextBox TextMascota;
        private System.Windows.Forms.TextBox TextEdad;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextRaza;
        private System.Windows.Forms.Button AgregarDespuesDe;
        private System.Windows.Forms.TextBox TextMascotaAux;
        private System.Windows.Forms.Button BotonAgregarInicio;
    }
}

