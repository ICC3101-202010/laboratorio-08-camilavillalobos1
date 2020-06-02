namespace CentroComercial
{
    partial class UserControl2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl2));
            this.label1 = new System.Windows.Forms.Label();
            this.botonTienda = new System.Windows.Forms.Button();
            this.botonRestaurant = new System.Windows.Forms.Button();
            this.botonRecreac = new System.Windows.Forms.Button();
            this.botonCines = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Locales Existentes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // botonTienda
            // 
            this.botonTienda.Location = new System.Drawing.Point(53, 169);
            this.botonTienda.Name = "botonTienda";
            this.botonTienda.Size = new System.Drawing.Size(78, 76);
            this.botonTienda.TabIndex = 1;
            this.botonTienda.Text = "Tiendas";
            this.botonTienda.UseVisualStyleBackColor = true;
            this.botonTienda.Click += new System.EventHandler(this.botonTienda_Click);
            // 
            // botonRestaurant
            // 
            this.botonRestaurant.Location = new System.Drawing.Point(189, 169);
            this.botonRestaurant.Name = "botonRestaurant";
            this.botonRestaurant.Size = new System.Drawing.Size(78, 76);
            this.botonRestaurant.TabIndex = 2;
            this.botonRestaurant.Text = "Restaurantes";
            this.botonRestaurant.UseVisualStyleBackColor = true;
            this.botonRestaurant.Click += new System.EventHandler(this.botonRestaurant_Click);
            // 
            // botonRecreac
            // 
            this.botonRecreac.Location = new System.Drawing.Point(451, 169);
            this.botonRecreac.Name = "botonRecreac";
            this.botonRecreac.Size = new System.Drawing.Size(114, 76);
            this.botonRecreac.TabIndex = 4;
            this.botonRecreac.Text = "Recreacionales";
            this.botonRecreac.UseVisualStyleBackColor = true;
            this.botonRecreac.Click += new System.EventHandler(this.button3_Click);
            // 
            // botonCines
            // 
            this.botonCines.Location = new System.Drawing.Point(321, 169);
            this.botonCines.Name = "botonCines";
            this.botonCines.Size = new System.Drawing.Size(80, 76);
            this.botonCines.TabIndex = 3;
            this.botonCines.Text = "Cines";
            this.botonCines.UseVisualStyleBackColor = true;
            this.botonCines.Click += new System.EventHandler(this.botonCines_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 371);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Nombre: Zara   Categoria: Ropa   Horario de Atencion: 10am - 9pm",
            "Nombre: Foster  Categoria: Ropa   Horario de Atencion: 10am - 9pm",
            "Nombre: Umbrale  Categoria: Ropa  Horario de Atencion: 10am - 9pm",
            "Nombre: Roxy  Categoria: Ropa  Horario de Atencion: 10am - 9pm",
            "Nombre: Americanino  Categoria: Ropa   Horario de Atencion: 10am - 9pm",
            "Nombre: Levis  Categoria: Ropa   Horario de Atencion: 10am - 9pm",
            "Nombre: Zara Home  Categoria: Hogar  Horario de Atencion: 10am - 9pm"});
            this.listBox1.Location = new System.Drawing.Point(15, 147);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(562, 212);
            this.listBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiendas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 368);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Restaurantes";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Nombre: Tanta   Categoria: Comida Peruana   Horario de Atencion: 12pm - 10pm",
            "Nombre: Chilli\'s  Categoria: Comida Mexicana   Horario de Atencion: 11am - 10pm",
            "Nombre: Danes  Categoria: Comida Rapida  Horario de Atencion: 11am - 10pm",
            "Nombre: Tavelli  Categoria: Cafeteria  Horario de Atencion: 10am - 9pm",
            "Nombre: Strada  Categoria: Comida Italiana   Horario de Atencion: 12pm - 10pm",
            "Nombre: Streat Burger  Categoria: Hamburguesas   Horario de Atencion: 11am - 12am" +
                "",
            "Nombre: Vapiano  Categoria: Comida Italiana  Horario de Atencion: 13pm - 11pm"});
            this.listBox2.Location = new System.Drawing.Point(38, 144);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(524, 212);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(38, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "volver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.listBox3);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(605, 365);
            this.panel3.TabIndex = 3;
            this.panel3.Visible = false;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint_1);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Items.AddRange(new object[] {
            "Nombre: Cine Hoyts  Horario de Atencion: 10am - 12 am",
            "Nombre: Cinemark  Horario de Atencion: 10am - 10pm"});
            this.listBox3.Location = new System.Drawing.Point(34, 150);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(554, 199);
            this.listBox3.TabIndex = 0;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cines";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(36, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "volver";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.listBox4);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(602, 362);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint_1);
            // 
            // listBox4
            // 
            this.listBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Items.AddRange(new object[] {
            "Nombre: Genial Horario de Atencion: 10am - 10pm"});
            this.listBox4.Location = new System.Drawing.Point(27, 150);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(561, 199);
            this.listBox4.TabIndex = 0;
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Recreacionales";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(30, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "volver";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.botonRecreac);
            this.Controls.Add(this.botonCines);
            this.Controls.Add(this.botonRestaurant);
            this.Controls.Add(this.botonTienda);
            this.Controls.Add(this.label1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(615, 371);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonTienda;
        private System.Windows.Forms.Button botonRestaurant;
        private System.Windows.Forms.Button botonRecreac;
        private System.Windows.Forms.Button botonCines;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox4;
    }
}
