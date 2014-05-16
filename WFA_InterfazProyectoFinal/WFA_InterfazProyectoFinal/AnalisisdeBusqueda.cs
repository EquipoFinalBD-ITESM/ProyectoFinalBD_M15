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
    public partial class AnalisisdeBusqueda : Form
    {
        public AnalisisdeBusqueda()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Activar boton de buscar solo si existen datos en la listBox
            if (listBox1 != null)
                btnBuscarporMatricula.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEligeunaMateria != null)
                btnBuscarporMateria.Enabled = true;
        }

        private void cmbEligeunaMateria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;//Bloquear el combox
        }

        private void txtNombreProfesor_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreProfesor != null)
                btnBuscarporProfesor.Enabled = true;
            if (txtNominaProfesor != null)
                btnBuscarporProfesor.Enabled = true;
        }

        private void txtHoraInicio_TextChanged(object sender, EventArgs e)
        {
            if ((txtDia != null) && (txtHoraFin != null) && (txtHoraInicio != null))
                btnBuscarporHorario.Enabled = true;
            //txtHoraInicio.Text = Datatime.tostring();
                
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarporProfesor_Click(object sender, EventArgs e)
        {

        }

        private void txtHoraFin_TextChanged(object sender, EventArgs e)
        {
            if ((txtDia != null) && (txtHoraFin != null) && (txtHoraInicio != null))
                btnBuscarporHorario.Enabled = true;
        }

        private void txtDia_TextChanged(object sender, EventArgs e)
        {
            txtDia.Text = txtDia.Text.ToUpper();
            if ((txtDia != null) && (txtHoraFin != null) && (txtHoraInicio != null))
                btnBuscarporHorario.Enabled = true;
        }

        private void btnInsertarMatriculas_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtMatricula.Text);
            txtMatricula.Text = "";
            txtMatricula.Focus();
            //Activar boton de buscar solo si existen datos en la listBox
            if (listBox1 != null)
                btnBuscarporMatricula.Enabled = true;
            
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //Eliminar elementos de la lista
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    break;
            }
        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMatricula_KeyDown(object sender, KeyEventArgs e)
        {
            //Sonido :/
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    {
                        txtMatricula.Text = txtMatricula.Text.ToUpper();
                        listBox1.Items.Add(txtMatricula.Text);
                        txtMatricula.Text = "";
                        txtMatricula.Select();
                        break;
                    }
            }
            //Activar boton de buscar solo si existen datos en la listBox
            if (listBox1 != null)
                btnBuscarporMatricula.Enabled = true;
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo permite 'A' y números
            if (  (   (e.KeyChar) < 48 && e.KeyChar != 8 )    || ( (e.KeyChar) > 57   && e.KeyChar != 65  && e.KeyChar != 97))
                e.Handled = true;

        }

        private void txtNominaProfesor_TextChanged(object sender, EventArgs e)
        {     

        }

        private void txtNominaProfesor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo permite 'L' y números
            if (((e.KeyChar) < 48 && e.KeyChar != 8) || ((e.KeyChar) > 57 && e.KeyChar != 76))
                e.Handled = true;
        }
    }
}
