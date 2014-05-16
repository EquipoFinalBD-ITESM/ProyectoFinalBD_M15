namespace WFA_InterfazProyectoFinal
{
    partial class CargarArchivos
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
            this.txtArchivo1 = new System.Windows.Forms.TextBox();
            this.btnExaminarArchivo1 = new System.Windows.Forms.Button();
            this.btnExaminarArchivo2 = new System.Windows.Forms.Button();
            this.txtArchivo2 = new System.Windows.Forms.TextBox();
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnBuscarHorarios1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtArchivo1
            // 
            this.txtArchivo1.Location = new System.Drawing.Point(44, 113);
            this.txtArchivo1.Name = "txtArchivo1";
            this.txtArchivo1.ReadOnly = true;
            this.txtArchivo1.Size = new System.Drawing.Size(111, 20);
            this.txtArchivo1.TabIndex = 0;
            this.txtArchivo1.TextChanged += new System.EventHandler(this.txtArchivo1_TextChanged);
            // 
            // btnExaminarArchivo1
            // 
            this.btnExaminarArchivo1.Location = new System.Drawing.Point(172, 112);
            this.btnExaminarArchivo1.Name = "btnExaminarArchivo1";
            this.btnExaminarArchivo1.Size = new System.Drawing.Size(75, 23);
            this.btnExaminarArchivo1.TabIndex = 1;
            this.btnExaminarArchivo1.Text = "Examinar";
            this.btnExaminarArchivo1.UseVisualStyleBackColor = true;
            this.btnExaminarArchivo1.Click += new System.EventHandler(this.btnExaminarArchivo1_Click);
            // 
            // btnExaminarArchivo2
            // 
            this.btnExaminarArchivo2.Location = new System.Drawing.Point(406, 113);
            this.btnExaminarArchivo2.Name = "btnExaminarArchivo2";
            this.btnExaminarArchivo2.Size = new System.Drawing.Size(75, 23);
            this.btnExaminarArchivo2.TabIndex = 3;
            this.btnExaminarArchivo2.Text = "Examinar";
            this.btnExaminarArchivo2.UseVisualStyleBackColor = true;
            // 
            // txtArchivo2
            // 
            this.txtArchivo2.Location = new System.Drawing.Point(278, 114);
            this.txtArchivo2.Name = "txtArchivo2";
            this.txtArchivo2.ReadOnly = true;
            this.txtArchivo2.ShortcutsEnabled = false;
            this.txtArchivo2.Size = new System.Drawing.Size(111, 20);
            this.txtArchivo2.TabIndex = 2;
            this.txtArchivo2.TextChanged += new System.EventHandler(this.txtArchivo2_TextChanged);
            // 
            // btnSubir
            // 
            this.btnSubir.Enabled = false;
            this.btnSubir.Location = new System.Drawing.Point(223, 196);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(86, 38);
            this.btnSubir.TabIndex = 4;
            this.btnSubir.Text = "Subir";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // btnBuscarHorarios1
            // 
            this.btnBuscarHorarios1.Enabled = false;
            this.btnBuscarHorarios1.Location = new System.Drawing.Point(200, 253);
            this.btnBuscarHorarios1.Name = "btnBuscarHorarios1";
            this.btnBuscarHorarios1.Size = new System.Drawing.Size(126, 38);
            this.btnBuscarHorarios1.TabIndex = 5;
            this.btnBuscarHorarios1.Text = "Buscar Horarios";
            this.btnBuscarHorarios1.UseVisualStyleBackColor = true;
            this.btnBuscarHorarios1.Click += new System.EventHandler(this.btnBuscarHorarios1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Espacio para subir archivo donde se \r\nencuentre la relación de los horarios \r\n   " +
                "                de los alumnos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Espacio para subir archivo donde se \r\nencuentre la relación de los profesores";
            // 
            // CargarArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(543, 374);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarHorarios1);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.btnExaminarArchivo2);
            this.Controls.Add(this.txtArchivo2);
            this.Controls.Add(this.btnExaminarArchivo1);
            this.Controls.Add(this.txtArchivo1);
            this.Name = "CargarArchivos";
            this.Text = "CargarArchivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArchivo1;
        private System.Windows.Forms.Button btnExaminarArchivo1;
        private System.Windows.Forms.Button btnExaminarArchivo2;
        private System.Windows.Forms.TextBox txtArchivo2;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Button btnBuscarHorarios1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}