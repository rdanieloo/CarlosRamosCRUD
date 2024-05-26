namespace CarlosRamosCRUD
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
            this.dataGridViewPersonajes = new System.Windows.Forms.DataGridView();
            this.buttonCargaData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxRaza = new System.Windows.Forms.TextBox();
            this.numericUpDownNivelPoder = new System.Windows.Forms.NumericUpDown();
            this.comboBoxRaza = new System.Windows.Forms.ComboBox();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonTestCon = new System.Windows.Forms.Button();
            this.textBoxHistoria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerfecha_creacion = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.eliminar_personaje = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.botonBuscarPorFecha = new System.Windows.Forms.Button();
            this.fechas_seleccionadas = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNivelPoder)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPersonajes
            // 
            this.dataGridViewPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonajes.Location = new System.Drawing.Point(24, 201);
            this.dataGridViewPersonajes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewPersonajes.Name = "dataGridViewPersonajes";
            this.dataGridViewPersonajes.RowHeadersWidth = 51;
            this.dataGridViewPersonajes.RowTemplate.Height = 24;
            this.dataGridViewPersonajes.Size = new System.Drawing.Size(1007, 253);
            this.dataGridViewPersonajes.TabIndex = 0;
            // 
            // buttonCargaData
            // 
            this.buttonCargaData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCargaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargaData.Location = new System.Drawing.Point(842, 484);
            this.buttonCargaData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCargaData.Name = "buttonCargaData";
            this.buttonCargaData.Size = new System.Drawing.Size(189, 72);
            this.buttonCargaData.TabIndex = 1;
            this.buttonCargaData.Text = "Cargar";
            this.buttonCargaData.UseVisualStyleBackColor = false;
            this.buttonCargaData.Click += new System.EventHandler(this.buttonCargaData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(561, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Raza";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(823, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 38);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nivel de Poder";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(47, 100);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(72, 26);
            this.textBoxID.TabIndex = 6;
            this.textBoxID.Leave += new System.EventHandler(this.textBoxID_Leave);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(269, 97);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(269, 30);
            this.textBoxNombre.TabIndex = 7;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxRaza
            // 
            this.textBoxRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRaza.Location = new System.Drawing.Point(568, 97);
            this.textBoxRaza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxRaza.Name = "textBoxRaza";
            this.textBoxRaza.Size = new System.Drawing.Size(178, 30);
            this.textBoxRaza.TabIndex = 8;
            // 
            // numericUpDownNivelPoder
            // 
            this.numericUpDownNivelPoder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNivelPoder.Location = new System.Drawing.Point(830, 100);
            this.numericUpDownNivelPoder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownNivelPoder.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownNivelPoder.Name = "numericUpDownNivelPoder";
            this.numericUpDownNivelPoder.Size = new System.Drawing.Size(203, 30);
            this.numericUpDownNivelPoder.TabIndex = 9;
            // 
            // comboBoxRaza
            // 
            this.comboBoxRaza.FormattingEnabled = true;
            this.comboBoxRaza.Location = new System.Drawing.Point(568, 140);
            this.comboBoxRaza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxRaza.Name = "comboBoxRaza";
            this.comboBoxRaza.Size = new System.Drawing.Size(136, 28);
            this.comboBoxRaza.TabIndex = 10;
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertar.Location = new System.Drawing.Point(1752, 476);
            this.buttonInsertar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(216, 78);
            this.buttonInsertar.TabIndex = 11;
            this.buttonInsertar.Text = "Insertar";
            this.buttonInsertar.UseVisualStyleBackColor = false;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(145, 100);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(84, 29);
            this.buttonBuscar.TabIndex = 12;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonTestCon
            // 
            this.buttonTestCon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTestCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTestCon.Location = new System.Drawing.Point(24, 482);
            this.buttonTestCon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonTestCon.Name = "buttonTestCon";
            this.buttonTestCon.Size = new System.Drawing.Size(234, 74);
            this.buttonTestCon.TabIndex = 13;
            this.buttonTestCon.Text = "Prueba Conexion";
            this.buttonTestCon.UseVisualStyleBackColor = false;
            this.buttonTestCon.Click += new System.EventHandler(this.buttonTestCon_Click);
            // 
            // textBoxHistoria
            // 
            this.textBoxHistoria.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxHistoria.Location = new System.Drawing.Point(1482, 92);
            this.textBoxHistoria.Multiline = true;
            this.textBoxHistoria.Name = "textBoxHistoria";
            this.textBoxHistoria.Size = new System.Drawing.Size(486, 362);
            this.textBoxHistoria.TabIndex = 14;
            this.textBoxHistoria.TextChanged += new System.EventHandler(this.textBoxHistoria_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1475, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 38);
            this.label5.TabIndex = 15;
            this.label5.Text = "Historia";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dateTimePickerfecha_creacion
            // 
            this.dateTimePickerfecha_creacion.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerfecha_creacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerfecha_creacion.Location = new System.Drawing.Point(1085, 97);
            this.dateTimePickerfecha_creacion.Name = "dateTimePickerfecha_creacion";
            this.dateTimePickerfecha_creacion.Size = new System.Drawing.Size(347, 26);
            this.dateTimePickerfecha_creacion.TabIndex = 16;
            this.dateTimePickerfecha_creacion.ValueChanged += new System.EventHandler(this.dateTimePickerfecha_creacion_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1078, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 38);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fecha de Creacion";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // eliminar_personaje
            // 
            this.eliminar_personaje.Location = new System.Drawing.Point(47, 148);
            this.eliminar_personaje.Name = "eliminar_personaje";
            this.eliminar_personaje.Size = new System.Drawing.Size(182, 30);
            this.eliminar_personaje.TabIndex = 18;
            this.eliminar_personaje.Text = "Eliminar Personaje";
            this.eliminar_personaje.UseVisualStyleBackColor = true;
            this.eliminar_personaje.Click += new System.EventHandler(this.buttonEliminarPersonaje_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1078, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(254, 38);
            this.label8.TabIndex = 20;
            this.label8.Text = "Buscar por Fechas:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // botonBuscarPorFecha
            // 
            this.botonBuscarPorFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBuscarPorFecha.Location = new System.Drawing.Point(1243, 476);
            this.botonBuscarPorFecha.Name = "botonBuscarPorFecha";
            this.botonBuscarPorFecha.Size = new System.Drawing.Size(189, 54);
            this.botonBuscarPorFecha.TabIndex = 22;
            this.botonBuscarPorFecha.Text = "Buscar Personajes";
            this.botonBuscarPorFecha.UseVisualStyleBackColor = true;
            this.botonBuscarPorFecha.Click += new System.EventHandler(this.botonBuscarPorFecha_Click);
            // 
            // fechas_seleccionadas
            // 
            this.fechas_seleccionadas.Location = new System.Drawing.Point(1085, 201);
            this.fechas_seleccionadas.MaxSelectionCount = 30;
            this.fechas_seleccionadas.Name = "fechas_seleccionadas";
            this.fechas_seleccionadas.TabIndex = 23;
            this.fechas_seleccionadas.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.fechas_seleccionadas_DateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2008, 662);
            this.Controls.Add(this.fechas_seleccionadas);
            this.Controls.Add(this.botonBuscarPorFecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.eliminar_personaje);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerfecha_creacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxHistoria);
            this.Controls.Add(this.buttonTestCon);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonInsertar);
            this.Controls.Add(this.comboBoxRaza);
            this.Controls.Add(this.numericUpDownNivelPoder);
            this.Controls.Add(this.textBoxRaza);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCargaData);
            this.Controls.Add(this.dataGridViewPersonajes);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNivelPoder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPersonajes;
        private System.Windows.Forms.Button buttonCargaData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxRaza;
        private System.Windows.Forms.NumericUpDown numericUpDownNivelPoder;
        private System.Windows.Forms.ComboBox comboBoxRaza;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonTestCon;
        private System.Windows.Forms.TextBox textBoxHistoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerfecha_creacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button eliminar_personaje;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button botonBuscarPorFecha;
        private System.Windows.Forms.MonthCalendar fechas_seleccionadas;
    }
}

