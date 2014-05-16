namespace WFA_InterfazProyectoFinal
{
    partial class AnalisisdeBusqueda
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBusqueda = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBuscarporMatricula = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.btnInsertarMatriculas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBuscarporMateria = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEligeunaMateria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnBuscarporProfesor = new System.Windows.Forms.Button();
            this.txtNominaProfesor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreProfesor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnBuscarporHorario = new System.Windows.Forms.Button();
            this.txtHoraFin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHoraInicio = new System.Windows.Forms.TextBox();
            this.De = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabAsistencias = new System.Windows.Forms.TabPage();
            this.tabECOAS = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabBusqueda.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBusqueda);
            this.tabControl1.Controls.Add(this.tabAsistencias);
            this.tabControl1.Controls.Add(this.tabECOAS);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(543, 351);
            this.tabControl1.TabIndex = 0;
            // 
            // tabBusqueda
            // 
            this.tabBusqueda.Controls.Add(this.tabControl2);
            this.tabBusqueda.Location = new System.Drawing.Point(4, 22);
            this.tabBusqueda.Name = "tabBusqueda";
            this.tabBusqueda.Padding = new System.Windows.Forms.Padding(3);
            this.tabBusqueda.Size = new System.Drawing.Size(535, 325);
            this.tabBusqueda.TabIndex = 0;
            this.tabBusqueda.Text = "Búsqueda";
            this.tabBusqueda.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(-3, 1);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(539, 329);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.btnBuscarporMatricula);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.txtMatricula);
            this.tabPage1.Controls.Add(this.btnInsertarMatriculas);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(531, 303);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Matrícula";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(123, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "(Ej. A00123456)";
            // 
            // btnBuscarporMatricula
            // 
            this.btnBuscarporMatricula.Enabled = false;
            this.btnBuscarporMatricula.Location = new System.Drawing.Point(205, 239);
            this.btnBuscarporMatricula.Name = "btnBuscarporMatricula";
            this.btnBuscarporMatricula.Size = new System.Drawing.Size(83, 41);
            this.btnBuscarporMatricula.TabIndex = 5;
            this.btnBuscarporMatricula.Text = "Buscar";
            this.btnBuscarporMatricula.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(321, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 147);
            this.listBox1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.listBox1, "Para eliminar un elemento de la lista, seleccionelo y oprima suprimir");
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(106, 118);
            this.txtMatricula.MaxLength = 9;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 3;
            this.txtMatricula.TextChanged += new System.EventHandler(this.txtMatricula_TextChanged);
            this.txtMatricula.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatricula_KeyDown);
            this.txtMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatricula_KeyPress);
            // 
            // btnInsertarMatriculas
            // 
            this.btnInsertarMatriculas.Location = new System.Drawing.Point(117, 188);
            this.btnInsertarMatriculas.Name = "btnInsertarMatriculas";
            this.btnInsertarMatriculas.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarMatriculas.TabIndex = 2;
            this.btnInsertarMatriculas.Text = "Insertar";
            this.btnInsertarMatriculas.UseVisualStyleBackColor = true;
            this.btnInsertarMatriculas.Click += new System.EventHandler(this.btnInsertarMatriculas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inserte las matrículas de las cuales quiera buscar\r\nhorarios disponibles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBuscarporMateria);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cmbEligeunaMateria);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(531, 303);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Materia";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBuscarporMateria
            // 
            this.btnBuscarporMateria.Enabled = false;
            this.btnBuscarporMateria.Location = new System.Drawing.Point(209, 219);
            this.btnBuscarporMateria.Name = "btnBuscarporMateria";
            this.btnBuscarporMateria.Size = new System.Drawing.Size(83, 41);
            this.btnBuscarporMateria.TabIndex = 6;
            this.btnBuscarporMateria.Text = "Buscar";
            this.btnBuscarporMateria.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Elige una materia";
            // 
            // cmbEligeunaMateria
            // 
            this.cmbEligeunaMateria.FormattingEnabled = true;
            this.cmbEligeunaMateria.Items.AddRange(new object[] {
            "Administración de procesos de negocios",
            "Administración de servicios de tecnologías de información",
            "Administración de servidores",
            "Arquitecturas empresariales de tecnologías de información",
            "Bases de datos",
            "Circuitos eléctricos",
            "Desarrollo de aplicaciones web",
            "Electrónica",
            "Estructura de datos",
            "Evaluación y administración de proyectos",
            "Fundamentos de diseño interactivo",
            "Fundamentos de ingeniería de software",
            "Fundamentos de programación",
            "Fundamentos de redes",
            "Interconexión de redes",
            "Introducción a la ingeniería en tecnologías de información y comunicaciones",
            "Introducción a la vida profesional",
            "Laboratorio de desarrollo de aplicaciones Web",
            "Matemáticas computacionales",
            "Matemáticas discretas",
            "Métodos cuantitativos y simulación",
            "Métodos númericos en ingeniería",
            "Microcontroladores",
            "Organización computacional",
            "Programación orientada a objetos",
            "Proyecto de automatización y domótica",
            "Proyecto de desarrollo de videojuegos",
            "Proyecto integrador de arquitectura de tecnologías de información",
            "Redes avanzadas",
            "Seguridad informática",
            "Seguridad informática avanzada",
            "Sistemas de información empresarial",
            "Sistemas digitales",
            "Sistemas operativos"});
            this.cmbEligeunaMateria.Location = new System.Drawing.Point(173, 122);
            this.cmbEligeunaMateria.Name = "cmbEligeunaMateria";
            this.cmbEligeunaMateria.Size = new System.Drawing.Size(257, 21);
            this.cmbEligeunaMateria.TabIndex = 1;
            this.cmbEligeunaMateria.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbEligeunaMateria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEligeunaMateria_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(410, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Selecciona la materia para buscar los horarios disponibles en común para los alum" +
                "nos\r\nque pertenezcan a dicha materia";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnBuscarporProfesor);
            this.tabPage3.Controls.Add(this.txtNominaProfesor);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txtNombreProfesor);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(531, 303);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Profesor";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnBuscarporProfesor
            // 
            this.btnBuscarporProfesor.Enabled = false;
            this.btnBuscarporProfesor.Location = new System.Drawing.Point(195, 204);
            this.btnBuscarporProfesor.Name = "btnBuscarporProfesor";
            this.btnBuscarporProfesor.Size = new System.Drawing.Size(83, 41);
            this.btnBuscarporProfesor.TabIndex = 8;
            this.btnBuscarporProfesor.Text = "Buscar";
            this.btnBuscarporProfesor.UseVisualStyleBackColor = true;
            this.btnBuscarporProfesor.Click += new System.EventHandler(this.btnBuscarporProfesor_Click);
            // 
            // txtNominaProfesor
            // 
            this.txtNominaProfesor.Location = new System.Drawing.Point(220, 152);
            this.txtNominaProfesor.MaxLength = 9;
            this.txtNominaProfesor.Name = "txtNominaProfesor";
            this.txtNominaProfesor.Size = new System.Drawing.Size(100, 20);
            this.txtNominaProfesor.TabIndex = 7;
            this.txtNominaProfesor.TextChanged += new System.EventHandler(this.txtNominaProfesor_TextChanged);
            this.txtNominaProfesor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNominaProfesor_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nómina";
            // 
            // txtNombreProfesor
            // 
            this.txtNombreProfesor.Location = new System.Drawing.Point(220, 116);
            this.txtNombreProfesor.Name = "txtNombreProfesor";
            this.txtNombreProfesor.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProfesor.TabIndex = 5;
            this.txtNombreProfesor.TextChanged += new System.EventHandler(this.txtNombreProfesor_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(378, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Introduce el Nombre o la Nómina del profesor para buscar su horario disponible";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnBuscarporHorario);
            this.tabPage4.Controls.Add(this.txtHoraFin);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.txtHoraInicio);
            this.tabPage4.Controls.Add(this.De);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.txtDia);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(531, 303);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Horario";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // btnBuscarporHorario
            // 
            this.btnBuscarporHorario.Enabled = false;
            this.btnBuscarporHorario.Location = new System.Drawing.Point(215, 224);
            this.btnBuscarporHorario.Name = "btnBuscarporHorario";
            this.btnBuscarporHorario.Size = new System.Drawing.Size(83, 41);
            this.btnBuscarporHorario.TabIndex = 13;
            this.btnBuscarporHorario.Text = "Buscar";
            this.btnBuscarporHorario.UseVisualStyleBackColor = true;
            // 
            // txtHoraFin
            // 
            this.txtHoraFin.Location = new System.Drawing.Point(323, 126);
            this.txtHoraFin.MaxLength = 5;
            this.txtHoraFin.Name = "txtHoraFin";
            this.txtHoraFin.Size = new System.Drawing.Size(56, 20);
            this.txtHoraFin.TabIndex = 12;
            this.txtHoraFin.TextChanged += new System.EventHandler(this.txtHoraFin_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(260, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Hora fin";
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Location = new System.Drawing.Point(187, 126);
            this.txtHoraInicio.MaxLength = 5;
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(56, 20);
            this.txtHoraInicio.TabIndex = 10;
            this.txtHoraInicio.TextChanged += new System.EventHandler(this.txtHoraInicio_TextChanged);
            // 
            // De
            // 
            this.De.AutoSize = true;
            this.De.Location = new System.Drawing.Point(124, 129);
            this.De.Name = "De";
            this.De.Size = new System.Drawing.Size(57, 13);
            this.De.TabIndex = 9;
            this.De.Text = "Hora inicio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(212, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 26);
            this.label10.TabIndex = 8;
            this.label10.Text = "(Solo introduzca la primera letra del día,\r\nen el caso de miércoles introduzca MI" +
                ")";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(150, 168);
            this.txtDia.MaxLength = 2;
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(56, 20);
            this.txtDia.TabIndex = 7;
            this.txtDia.TextChanged += new System.EventHandler(this.txtDia_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(119, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Día";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 61);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(404, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "Introduce la hora de inicio, hora de fin y el día en el que quieras realizar la b" +
                "úsqueda\r\nde horarios disponibles";
            // 
            // tabAsistencias
            // 
            this.tabAsistencias.Location = new System.Drawing.Point(4, 22);
            this.tabAsistencias.Name = "tabAsistencias";
            this.tabAsistencias.Padding = new System.Windows.Forms.Padding(3);
            this.tabAsistencias.Size = new System.Drawing.Size(535, 325);
            this.tabAsistencias.TabIndex = 1;
            this.tabAsistencias.Text = "Asistencias";
            this.tabAsistencias.UseVisualStyleBackColor = true;
            // 
            // tabECOAS
            // 
            this.tabECOAS.Location = new System.Drawing.Point(4, 22);
            this.tabECOAS.Name = "tabECOAS";
            this.tabECOAS.Padding = new System.Windows.Forms.Padding(3);
            this.tabECOAS.Size = new System.Drawing.Size(535, 325);
            this.tabECOAS.TabIndex = 2;
            this.tabECOAS.Text = "ECOAS";
            this.tabECOAS.UseVisualStyleBackColor = true;
            // 
            // AnalisisdeBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(567, 375);
            this.Controls.Add(this.tabControl1);
            this.Name = "AnalisisdeBusqueda";
            this.Text = "Análisis de Búsqueda";
            this.tabControl1.ResumeLayout(false);
            this.tabBusqueda.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBusqueda;
        private System.Windows.Forms.TabPage tabAsistencias;
        private System.Windows.Forms.TabPage tabECOAS;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnBuscarporMatricula;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Button btnInsertarMatriculas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnBuscarporMateria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEligeunaMateria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNominaProfesor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreProfesor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarporProfesor;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHoraInicio;
        private System.Windows.Forms.Label De;
        private System.Windows.Forms.TextBox txtHoraFin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBuscarporHorario;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}