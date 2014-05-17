using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace WFA_InterfazProyectoFinal
{
    public partial class CargarArchivos : Form
    {
        public CargarArchivos()
        {
            InitializeComponent();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {

        }

        private void txtArchivo1_TextChanged(object sender, EventArgs e)
        {
            //Las cajas de texto no deben estar vacias para poder activar el boton de Subir
            if ((txtArchivo1 != null) && (txtArchivo2 != null))
            {
                btnSubir.Enabled = true;
                btnBuscarHorarios1.Enabled = true;
            }
        }

        private void txtArchivo2_TextChanged(object sender, EventArgs e)
        {
            //Las cajas de texto no deben estar vacias para poder activar el boton de Subir
            if ((txtArchivo1 != null) && (txtArchivo2 != null))
            {
                btnSubir.Enabled = true;
                btnBuscarHorarios1.Enabled = true;
            }
        }

        private void btnBuscarHorarios1_Click(object sender, EventArgs e)
        {

        }

        private void btnExaminarArchivo1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialogAPG = new OpenFileDialog();
            if (openFileDialogAPG.ShowDialog() == DialogResult.OK)
            {
                string filepathAPG = openFileDialogAPG.FileName, aux;
                bool tituloColumnas = false;
                int columClave = 0, columNombreMateria = 0;
                var reader = new StreamReader(File.OpenRead(filepathAPG));
                List<string> listInicial = new List<string>();
                List<string> listClave = new List<string>();
                List<string> listNombreMateria = new List<string>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    if (tituloColumnas == false)
                    {
                        for (int i = 0; i < values.Count(); i++)
                        {
                            if (values[i].Contains("Clave"))
                                columClave = i;
                            else if (values[i].Contains("Materia"))
                            {
                                columNombreMateria = i;
                                tituloColumnas = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        aux = values[columClave] + ";" + values[columNombreMateria];
                        listInicial.Add(aux);  
                    }
                }
                listInicial = listInicial.Distinct().ToList();

                for(int i=0; i<listInicial.Count();i++)
                {
                    var line = listInicial[i];
                    var values = line.Split(';');
                    listClave.Add(values[0]);
                    listNombreMateria.Add(values[1]);
                }




                 MessageBox.Show("Archivo cargado correctamente");

                /*
                string filepathAPG = openFileDialogAPG.FileName;
                bool tituloColumnas = false;
                int columGrupo = 0, columCRN = 0, columClave = 0, columMateria = 0, columLu = 0, columMa = 0, columMi = 0, columJu = 0, columVi = 0, columSa = 0, columInicio = 0, columFin = 0, columNomina = 0, columNombreDelProfesor = 0;
                var reader = new StreamReader(File.OpenRead(filepathAPG));
                List<string> listCRN = new List<string>();
                List<string> listGrupo = new List<string>();
                List<string> listClave = new List<string>();
                List<string> listMateria = new List<string>();
                List<string> listLu = new List<string>();
                List<string> listMa = new List<string>();
                List<string> listMi = new List<string>();
                List<string> listJu = new List<string>();
                List<string> listVi = new List<string>();
                List<string> listSa = new List<string>();
                List<string> listInicio = new List<string>(); // Checar que tipo de datos usar porque son horas
                List<string> listFin = new List<string>(); // Checar que tipo de datos usar porque son horas
                List<string> listNomina = new List<string>();
                List<string> listcolumnNombreDelProfesor = new List<string>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    if (tituloColumnas == false)
                    {
                        for (int i = 0; i < values.Count(); i++)
                        {
                            if (values[i].Contains("CRN"))
                                columCRN = i;
                            else if (values[i].Contains("Grupo"))
                                columGrupo = i;
                            else if (values[i].Contains("Clave"))
                                columClave = i;
                            else if (values[i].Contains("Materia"))
                                columMateria = i;
                            else if (values[i].Contains("Lu"))
                                columLu = i;
                            else if (values[i].Contains("Ma"))
                                columMa = i;
                            else if (values[i].Contains("Mi"))
                                columMi = i;
                            else if (values[i].Contains("Ju"))
                                columJu = i;
                            else if (values[i].Contains("Vi"))
                                columVi = i;
                            else if (values[i].Contains("Sa"))
                                columSa = i;
                            else if (values[i].Contains("Inicio"))
                                columInicio = i;
                            else if (values[i].Contains("Fin"))
                                columFin = i;
                            else if (values[i].Contains("Nomina"))
                                columNomina = i;
                            else if (values[i].Contains("Nombre del profesor"))
                            {
                                columNombreDelProfesor = i;
                                tituloColumnas = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        listCRN.Add(values[columCRN]);
                        listClave.Add(values[columClave]);
                    }
                 }
                MessageBox.Show("Archivo cargado correctamente");
            }*/


            }
        }
    }
}
