namespace CentroComercial
{
    partial class UserControl1
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.NombreLocal = new System.Windows.Forms.TextBox();
            this.NombreDueño = new System.Windows.Forms.TextBox();
            this.HorarioLocal = new System.Windows.Forms.TextBox();
            this.IDlocal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.botonAgregarLocal = new System.Windows.Forms.Button();
            this.CategoriaLocal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TipoLocal = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NombreLocal
            // 
            this.NombreLocal.Location = new System.Drawing.Point(171, 93);
            this.NombreLocal.Name = "NombreLocal";
            this.NombreLocal.Size = new System.Drawing.Size(311, 20);
            this.NombreLocal.TabIndex = 0;
            this.NombreLocal.TextChanged += new System.EventHandler(this.NombreLocal_TextChanged);
            // 
            // NombreDueño
            // 
            this.NombreDueño.Location = new System.Drawing.Point(171, 135);
            this.NombreDueño.Name = "NombreDueño";
            this.NombreDueño.Size = new System.Drawing.Size(311, 20);
            this.NombreDueño.TabIndex = 1;
            this.NombreDueño.TextChanged += new System.EventHandler(this.NombreDueño_TextChanged);
            // 
            // HorarioLocal
            // 
            this.HorarioLocal.Location = new System.Drawing.Point(171, 221);
            this.HorarioLocal.Name = "HorarioLocal";
            this.HorarioLocal.Size = new System.Drawing.Size(311, 20);
            this.HorarioLocal.TabIndex = 3;
            this.HorarioLocal.TextChanged += new System.EventHandler(this.HorarioLocal_TextChanged);
            // 
            // IDlocal
            // 
            this.IDlocal.Location = new System.Drawing.Point(171, 180);
            this.IDlocal.Name = "IDlocal";
            this.IDlocal.Size = new System.Drawing.Size(311, 20);
            this.IDlocal.TabIndex = 2;
            this.IDlocal.TextChanged += new System.EventHandler(this.IDlocal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(55, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre Local:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(55, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre Dueño:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(55, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID Local:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(55, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Horario Local:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(332, 38);
            this.label5.TabIndex = 8;
            this.label5.Text = "Datos del local";
            // 
            // botonAgregarLocal
            // 
            this.botonAgregarLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregarLocal.Location = new System.Drawing.Point(519, 330);
            this.botonAgregarLocal.Name = "botonAgregarLocal";
            this.botonAgregarLocal.Size = new System.Drawing.Size(103, 37);
            this.botonAgregarLocal.TabIndex = 9;
            this.botonAgregarLocal.Text = "Agregar";
            this.botonAgregarLocal.UseVisualStyleBackColor = true;
            this.botonAgregarLocal.Click += new System.EventHandler(this.button1_Click);
            // 
            // CategoriaLocal
            // 
            this.CategoriaLocal.Location = new System.Drawing.Point(171, 300);
            this.CategoriaLocal.Name = "CategoriaLocal";
            this.CategoriaLocal.Size = new System.Drawing.Size(311, 20);
            this.CategoriaLocal.TabIndex = 10;
            this.CategoriaLocal.TextChanged += new System.EventHandler(this.CategoriaLocal_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(55, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Categoria:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(55, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tipo Local:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // TipoLocal
            // 
            this.TipoLocal.Location = new System.Drawing.Point(171, 259);
            this.TipoLocal.Name = "TipoLocal";
            this.TipoLocal.Size = new System.Drawing.Size(311, 20);
            this.TipoLocal.TabIndex = 12;
            this.TipoLocal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TipoLocal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CategoriaLocal);
            this.Controls.Add(this.botonAgregarLocal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HorarioLocal);
            this.Controls.Add(this.IDlocal);
            this.Controls.Add(this.NombreDueño);
            this.Controls.Add(this.NombreLocal);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(652, 380);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreLocal;
        private System.Windows.Forms.TextBox NombreDueño;
        private System.Windows.Forms.TextBox HorarioLocal;
        private System.Windows.Forms.TextBox IDlocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button botonAgregarLocal;
        private System.Windows.Forms.TextBox CategoriaLocal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TipoLocal;
        private System.Windows.Forms.Button button2;
    }
}
