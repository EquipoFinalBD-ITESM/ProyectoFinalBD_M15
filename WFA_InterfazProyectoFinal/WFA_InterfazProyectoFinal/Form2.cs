using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFA_InterfazProyectoFinal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarArchivos frm = new CargarArchivos();
            frm.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInicio.SelectedIndex == 0) //Búsqueda de Horarios
            {
                btnBuscarHorarios.Visible = true;
                btnCargarArchivos.Visible = true;
                btnContinuar.Visible = false;
            }
            else
            {
                btnCargarArchivos.Visible = false;
                btnBuscarHorarios.Visible = false;
                btnContinuar.Visible = true;
            }
        }

        private void cmbInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;//Bloquear el combox
        }

        private void btnBuscarHorarios_Click(object sender, EventArgs e)
        {
            AnalisisdeBusqueda frm = new AnalisisdeBusqueda();
            frm.Show();
            this.Hide();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            AnalisisdeBusqueda frm = new AnalisisdeBusqueda();
            frm.Show();
            this.Hide();
           
               
        }
    }
}
