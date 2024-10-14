namespace DataTable_Filtrada
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.semestreInput = new System.Windows.Forms.ComboBox();
            this.nombreInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.asignaturaInput = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.filtrarBtn = new System.Windows.Forms.Button();
            this.semestreFiltro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.asignaturaFiltro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreFiltro = new System.Windows.Forms.TextBox();
            this.tablaForm = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.semestreFiltroLabel = new System.Windows.Forms.Label();
            this.asignaturaFiltroLabel = new System.Windows.Forms.Label();
            this.nombreFiltroLabel = new System.Windows.Forms.Label();
            this.eliminarFiltro = new System.Windows.Forms.Button();
            this.borrarBtn = new System.Windows.Forms.Button();
            this.editarBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.alumnosCuentaLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.promedioInput = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.mayorSeleccion = new System.Windows.Forms.RadioButton();
            this.menorSeleccion = new System.Windows.Forms.RadioButton();
            this.igualSeleccion = new System.Windows.Forms.RadioButton();
            this.promedioFiltro = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.promedioGeneralLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promedioInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promedioFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.promedioGeneralLabel);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.promedioInput);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.alumnosCuentaLabel);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.editarBtn);
            this.groupBox1.Controls.Add(this.borrarBtn);
            this.groupBox1.Controls.Add(this.agregarBtn);
            this.groupBox1.Controls.Add(this.semestreInput);
            this.groupBox1.Controls.Add(this.nombreInput);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.asignaturaInput);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 654);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar";
            // 
            // agregarBtn
            // 
            this.agregarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarBtn.Location = new System.Drawing.Point(294, 232);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(105, 33);
            this.agregarBtn.TabIndex = 14;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = true;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // semestreInput
            // 
            this.semestreInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semestreInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semestreInput.FormattingEnabled = true;
            this.semestreInput.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.semestreInput.Location = new System.Drawing.Point(179, 142);
            this.semestreInput.Name = "semestreInput";
            this.semestreInput.Size = new System.Drawing.Size(220, 28);
            this.semestreInput.TabIndex = 13;
            // 
            // nombreInput
            // 
            this.nombreInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombreInput.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreInput.ForeColor = System.Drawing.Color.Black;
            this.nombreInput.Location = new System.Drawing.Point(179, 55);
            this.nombreInput.Name = "nombreInput";
            this.nombreInput.Size = new System.Drawing.Size(220, 32);
            this.nombreInput.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Semestre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nombre";
            // 
            // asignaturaInput
            // 
            this.asignaturaInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.asignaturaInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asignaturaInput.FormattingEnabled = true;
            this.asignaturaInput.IntegralHeight = false;
            this.asignaturaInput.Items.AddRange(new object[] {
            "Desarrollo y Diseño de Software",
            "Programación II",
            "Inglés Técnico"});
            this.asignaturaInput.Location = new System.Drawing.Point(179, 100);
            this.asignaturaInput.Name = "asignaturaInput";
            this.asignaturaInput.Size = new System.Drawing.Size(220, 28);
            this.asignaturaInput.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Asignatura";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.promedioFiltro);
            this.groupBox2.Controls.Add(this.igualSeleccion);
            this.groupBox2.Controls.Add(this.menorSeleccion);
            this.groupBox2.Controls.Add(this.mayorSeleccion);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.eliminarFiltro);
            this.groupBox2.Controls.Add(this.semestreFiltroLabel);
            this.groupBox2.Controls.Add(this.asignaturaFiltroLabel);
            this.groupBox2.Controls.Add(this.nombreFiltroLabel);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.filtrarBtn);
            this.groupBox2.Controls.Add(this.semestreFiltro);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.asignaturaFiltro);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nombreFiltro);
            this.groupBox2.Controls.Add(this.tablaForm);
            this.groupBox2.Location = new System.Drawing.Point(447, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(847, 654);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar";
            // 
            // filtrarBtn
            // 
            this.filtrarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrarBtn.Location = new System.Drawing.Point(345, 248);
            this.filtrarBtn.Name = "filtrarBtn";
            this.filtrarBtn.Size = new System.Drawing.Size(105, 33);
            this.filtrarBtn.TabIndex = 15;
            this.filtrarBtn.Text = "Filtrar";
            this.filtrarBtn.UseVisualStyleBackColor = true;
            this.filtrarBtn.Click += new System.EventHandler(this.filtrarBtn_Click);
            // 
            // semestreFiltro
            // 
            this.semestreFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semestreFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semestreFiltro.FormattingEnabled = true;
            this.semestreFiltro.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4"});
            this.semestreFiltro.Location = new System.Drawing.Point(230, 141);
            this.semestreFiltro.Name = "semestreFiltro";
            this.semestreFiltro.Size = new System.Drawing.Size(220, 28);
            this.semestreFiltro.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Semestre";
            // 
            // asignaturaFiltro
            // 
            this.asignaturaFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.asignaturaFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asignaturaFiltro.FormattingEnabled = true;
            this.asignaturaFiltro.IntegralHeight = false;
            this.asignaturaFiltro.Items.AddRange(new object[] {
            "",
            "Desarrollo y Diseño de Software",
            "Programación II",
            "Inglés Técnico"});
            this.asignaturaFiltro.Location = new System.Drawing.Point(230, 99);
            this.asignaturaFiltro.Name = "asignaturaFiltro";
            this.asignaturaFiltro.Size = new System.Drawing.Size(220, 28);
            this.asignaturaFiltro.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Asignatura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // nombreFiltro
            // 
            this.nombreFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombreFiltro.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreFiltro.ForeColor = System.Drawing.Color.Black;
            this.nombreFiltro.Location = new System.Drawing.Point(230, 54);
            this.nombreFiltro.Name = "nombreFiltro";
            this.nombreFiltro.Size = new System.Drawing.Size(220, 32);
            this.nombreFiltro.TabIndex = 1;
            // 
            // tablaForm
            // 
            this.tablaForm.AllowUserToAddRows = false;
            this.tablaForm.AllowUserToDeleteRows = false;
            this.tablaForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaForm.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tablaForm.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tablaForm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaForm.ColumnHeadersHeight = 29;
            this.tablaForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaForm.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tablaForm.Location = new System.Drawing.Point(6, 299);
            this.tablaForm.Name = "tablaForm";
            this.tablaForm.ReadOnly = true;
            this.tablaForm.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaForm.RowHeadersWidth = 51;
            this.tablaForm.RowTemplate.Height = 24;
            this.tablaForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaForm.Size = new System.Drawing.Size(835, 349);
            this.tablaForm.TabIndex = 0;
            this.tablaForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaForm_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(478, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Filtro: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(478, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Filtro: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(478, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Filtro: ";
            // 
            // semestreFiltroLabel
            // 
            this.semestreFiltroLabel.AutoSize = true;
            this.semestreFiltroLabel.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semestreFiltroLabel.Location = new System.Drawing.Point(578, 143);
            this.semestreFiltroLabel.Name = "semestreFiltroLabel";
            this.semestreFiltroLabel.Size = new System.Drawing.Size(22, 24);
            this.semestreFiltroLabel.TabIndex = 21;
            this.semestreFiltroLabel.Text = "-";
            // 
            // asignaturaFiltroLabel
            // 
            this.asignaturaFiltroLabel.AutoSize = true;
            this.asignaturaFiltroLabel.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asignaturaFiltroLabel.Location = new System.Drawing.Point(578, 99);
            this.asignaturaFiltroLabel.Name = "asignaturaFiltroLabel";
            this.asignaturaFiltroLabel.Size = new System.Drawing.Size(22, 24);
            this.asignaturaFiltroLabel.TabIndex = 20;
            this.asignaturaFiltroLabel.Text = "-";
            // 
            // nombreFiltroLabel
            // 
            this.nombreFiltroLabel.AutoSize = true;
            this.nombreFiltroLabel.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreFiltroLabel.Location = new System.Drawing.Point(578, 58);
            this.nombreFiltroLabel.Name = "nombreFiltroLabel";
            this.nombreFiltroLabel.Size = new System.Drawing.Size(22, 24);
            this.nombreFiltroLabel.TabIndex = 19;
            this.nombreFiltroLabel.Text = "-";
            // 
            // eliminarFiltro
            // 
            this.eliminarFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarFiltro.Location = new System.Drawing.Point(482, 248);
            this.eliminarFiltro.Name = "eliminarFiltro";
            this.eliminarFiltro.Size = new System.Drawing.Size(144, 33);
            this.eliminarFiltro.TabIndex = 22;
            this.eliminarFiltro.Text = "Eliminar filtro";
            this.eliminarFiltro.UseVisualStyleBackColor = true;
            this.eliminarFiltro.Click += new System.EventHandler(this.eliminarFiltro_Click);
            // 
            // borrarBtn
            // 
            this.borrarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarBtn.Location = new System.Drawing.Point(183, 232);
            this.borrarBtn.Name = "borrarBtn";
            this.borrarBtn.Size = new System.Drawing.Size(105, 33);
            this.borrarBtn.TabIndex = 15;
            this.borrarBtn.Text = "Borrar";
            this.borrarBtn.UseVisualStyleBackColor = true;
            this.borrarBtn.Click += new System.EventHandler(this.borrarBtn_Click);
            // 
            // editarBtn
            // 
            this.editarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarBtn.Location = new System.Drawing.Point(72, 232);
            this.editarBtn.Name = "editarBtn";
            this.editarBtn.Size = new System.Drawing.Size(105, 33);
            this.editarBtn.TabIndex = 16;
            this.editarBtn.Text = "Editar";
            this.editarBtn.UseVisualStyleBackColor = true;
            this.editarBtn.Click += new System.EventHandler(this.editarBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Fira Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "Alumnos:";
            // 
            // alumnosCuentaLabel
            // 
            this.alumnosCuentaLabel.AutoSize = true;
            this.alumnosCuentaLabel.Font = new System.Drawing.Font("Fira Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alumnosCuentaLabel.Location = new System.Drawing.Point(154, 299);
            this.alumnosCuentaLabel.Name = "alumnosCuentaLabel";
            this.alumnosCuentaLabel.Size = new System.Drawing.Size(20, 21);
            this.alumnosCuentaLabel.TabIndex = 18;
            this.alumnosCuentaLabel.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 24);
            this.label11.TabIndex = 19;
            this.label11.Text = "Promedio";
            // 
            // promedioInput
            // 
            this.promedioInput.Font = new System.Drawing.Font("Fira Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promedioInput.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.promedioInput.Location = new System.Drawing.Point(179, 188);
            this.promedioInput.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.promedioInput.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.promedioInput.Name = "promedioInput";
            this.promedioInput.Size = new System.Drawing.Size(120, 28);
            this.promedioInput.TabIndex = 20;
            this.promedioInput.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(82, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 24);
            this.label12.TabIndex = 23;
            this.label12.Text = "Promedio";
            // 
            // mayorSeleccion
            // 
            this.mayorSeleccion.AutoSize = true;
            this.mayorSeleccion.Font = new System.Drawing.Font("Fira Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mayorSeleccion.Location = new System.Drawing.Point(233, 188);
            this.mayorSeleccion.Name = "mayorSeleccion";
            this.mayorSeleccion.Size = new System.Drawing.Size(101, 25);
            this.mayorSeleccion.TabIndex = 24;
            this.mayorSeleccion.TabStop = true;
            this.mayorSeleccion.Text = "Mayor a";
            this.mayorSeleccion.UseVisualStyleBackColor = true;
            // 
            // menorSeleccion
            // 
            this.menorSeleccion.AutoSize = true;
            this.menorSeleccion.Font = new System.Drawing.Font("Fira Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menorSeleccion.Location = new System.Drawing.Point(349, 188);
            this.menorSeleccion.Name = "menorSeleccion";
            this.menorSeleccion.Size = new System.Drawing.Size(101, 25);
            this.menorSeleccion.TabIndex = 25;
            this.menorSeleccion.TabStop = true;
            this.menorSeleccion.Text = "Menor a";
            this.menorSeleccion.UseVisualStyleBackColor = true;
            // 
            // igualSeleccion
            // 
            this.igualSeleccion.AutoSize = true;
            this.igualSeleccion.Font = new System.Drawing.Font("Fira Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igualSeleccion.Location = new System.Drawing.Point(475, 188);
            this.igualSeleccion.Name = "igualSeleccion";
            this.igualSeleccion.Size = new System.Drawing.Size(101, 25);
            this.igualSeleccion.TabIndex = 26;
            this.igualSeleccion.TabStop = true;
            this.igualSeleccion.Text = "Igual a";
            this.igualSeleccion.UseVisualStyleBackColor = true;
            // 
            // promedioFiltro
            // 
            this.promedioFiltro.Font = new System.Drawing.Font("Fira Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promedioFiltro.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.promedioFiltro.Location = new System.Drawing.Point(611, 188);
            this.promedioFiltro.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.promedioFiltro.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.promedioFiltro.Name = "promedioFiltro";
            this.promedioFiltro.Size = new System.Drawing.Size(120, 28);
            this.promedioFiltro.TabIndex = 21;
            this.promedioFiltro.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Fira Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(31, 346);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(180, 21);
            this.label13.TabIndex = 21;
            this.label13.Text = "Promedio general:";
            // 
            // promedioGeneralLabel
            // 
            this.promedioGeneralLabel.AutoSize = true;
            this.promedioGeneralLabel.Font = new System.Drawing.Font("Fira Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promedioGeneralLabel.Location = new System.Drawing.Point(247, 346);
            this.promedioGeneralLabel.Name = "promedioGeneralLabel";
            this.promedioGeneralLabel.Size = new System.Drawing.Size(20, 21);
            this.promedioGeneralLabel.TabIndex = 22;
            this.promedioGeneralLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 678);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Administración";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promedioInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promedioFiltro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox semestreFiltro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox asignaturaFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreFiltro;
        private System.Windows.Forms.DataGridView tablaEstudiantes;
        private System.Windows.Forms.ComboBox semestreInput;
        private System.Windows.Forms.TextBox nombreInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox asignaturaInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.Button filtrarBtn;
        private System.Windows.Forms.DataGridView tablaForm;
        private System.Windows.Forms.Button eliminarFiltro;
        private System.Windows.Forms.Label semestreFiltroLabel;
        private System.Windows.Forms.Label asignaturaFiltroLabel;
        private System.Windows.Forms.Label nombreFiltroLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button editarBtn;
        private System.Windows.Forms.Button borrarBtn;
        private System.Windows.Forms.Label alumnosCuentaLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown promedioInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown promedioFiltro;
        private System.Windows.Forms.RadioButton igualSeleccion;
        private System.Windows.Forms.RadioButton menorSeleccion;
        private System.Windows.Forms.RadioButton mayorSeleccion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label promedioGeneralLabel;
    }
}

