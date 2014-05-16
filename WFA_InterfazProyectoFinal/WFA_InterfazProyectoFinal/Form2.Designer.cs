namespace WFA_InterfazProyectoFinal
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnCargarArchivos = new System.Windows.Forms.Button();
            this.btnBuscarHorarios = new System.Windows.Forms.Button();
            this.cmbInicio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCargarArchivos
            // 
            this.btnCargarArchivos.Location = new System.Drawing.Point(189, 224);
            this.btnCargarArchivos.Name = "btnCargarArchivos";
            this.btnCargarArchivos.Size = new System.Drawing.Size(104, 45);
            this.btnCargarArchivos.TabIndex = 2;
            this.btnCargarArchivos.Text = "Cargar un archivo";
            this.btnCargarArchivos.UseVisualStyleBackColor = true;
            this.btnCargarArchivos.Visible = false;
            this.btnCargarArchivos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscarHorarios
            // 
            this.btnBuscarHorarios.Location = new System.Drawing.Point(333, 224);
            this.btnBuscarHorarios.Name = "btnBuscarHorarios";
            this.btnBuscarHorarios.Size = new System.Drawing.Size(104, 45);
            this.btnBuscarHorarios.TabIndex = 3;
            this.btnBuscarHorarios.Text = "Buscar Horarios";
            this.btnBuscarHorarios.UseVisualStyleBackColor = true;
            this.btnBuscarHorarios.Visible = false;
            this.btnBuscarHorarios.Click += new System.EventHandler(this.btnBuscarHorarios_Click);
            // 
            // cmbInicio
            // 
            this.cmbInicio.FormattingEnabled = true;
            this.cmbInicio.Items.AddRange(new object[] {
            "Búsqueda de Horarios",
            "Asistencias",
            "ECOAS"});
            this.cmbInicio.Location = new System.Drawing.Point(311, 155);
            this.cmbInicio.Name = "cmbInicio";
            this.cmbInicio.Size = new System.Drawing.Size(160, 21);
            this.cmbInicio.TabIndex = 4;
            this.cmbInicio.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbInicio_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selecciona la opición que quiera ejecutar";
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(261, 210);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(104, 45);
            this.btnContinuar.TabIndex = 6;
            this.btnContinuar.Text = "Ir";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Visible = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(485, 52);
            this.label2.TabIndex = 7;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(604, 369);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbInicio);
            this.Controls.Add(this.btnBuscarHorarios);
            this.Controls.Add(this.btnCargarArchivos);
            this.Name = "Form2";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargarArchivos;
        private System.Windows.Forms.Button btnBuscarHorarios;
        private System.Windows.Forms.ComboBox cmbInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Label label2;
    }
}