﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Formateador
{
    public partial class PipcCampeche : Form
    {
        //Atributos Word para modificar los valores
        Word.Application ObjWord;
        Word.Document ObjDoc;
        Word.Document ObjPlanes;
        //ObjectMiss para enviar valores cualquiera
        object ObjMiss = System.Reflection.Missing.Value;

        public PipcCampeche()
        {
            InitializeComponent();
            timer1.Start();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwd, int wmsg, int wparam, int lparam);

        //Verifica que los campos estén llenos para formatear el documento
        private bool Verifica()
        {
            if (string.IsNullOrEmpty(municipio.Text))
            {
                MessageBox.Show("Seleccione Municipio");
                return false;
            }
            else if (string.IsNullOrEmpty(txtCiudad.Text))
            {
                MessageBox.Show("Ingrese valor en Ciudad");
                return false;
            }
            else if (string.IsNullOrEmpty(domicilio.Text))
            {
                MessageBox.Show("Ingrese valor en Domicilio");
                return false;
            }
            else if (string.IsNullOrEmpty(txtColinorte.Text))
            {
                MessageBox.Show("Ingrese valor en Colindancia Norte");
                return false;
            }
            else if (string.IsNullOrEmpty(txtColisur.Text))
            {
                MessageBox.Show("Ingrese valor en Colindancia Sur");
                return false;
            }
            else if (string.IsNullOrEmpty(txtColieste.Text))
            {
                MessageBox.Show("Ingrese valor en Colindancia Este");
                return false;
            }
            else if (string.IsNullOrEmpty(txtColioeste.Text))
            {
                MessageBox.Show("Ingrese valor en Colindancia Oeste");
                return false;
            }
            else if (string.IsNullOrEmpty(razoncomercial.Text))
            {
                MessageBox.Show("Ingrese valor en Razón Comercial");
                return false;
            }
            else if (string.IsNullOrEmpty(razonsocial.Text))
            {
                MessageBox.Show("Ingrese un valor en Razón Social ");
                return false;
            }
            else if (string.IsNullOrEmpty(actividadempresa.Text))
            {
                MessageBox.Show("Ingrese valor en Actividad de la Empresa");
                return false;
            }
            else if (string.IsNullOrEmpty(telefono.Text))
            {
                MessageBox.Show("Ingrese valor en Teléfono");
                return false;
            }
            else if (string.IsNullOrEmpty(representante.Text))
            {
                MessageBox.Show("Ingrese valor en Representante Legal");
                return false;
            }
            else if (string.IsNullOrEmpty(responsableoperativo.Text))
            {
                MessageBox.Show("Ingrese valor en Responsable Operativo del Programa");
                return false;
            }
            else if (string.IsNullOrEmpty(rfc.Text))
            {
                MessageBox.Show("Ingrese valor en RFC");
                return false;
            }
            else if (string.IsNullOrEmpty(txtTrabajadores.Text))
            {
                MessageBox.Show("Ingrese valor en No. de Trabajadores");
                return false;
            }
            else if (string.IsNullOrEmpty(txtHabitual.Text))
            {
                MessageBox.Show("Ingrese valor en Población Habitual");
                return false;
            }
            else if (string.IsNullOrEmpty(poblacionfija.Text))
            {
                MessageBox.Show("Ingrese valor en Población Fija");
                return false;
            }
            else if (string.IsNullOrEmpty(poblacionflotante.Text))
            {
                MessageBox.Show("Ingrese valor en Población Flotante");
                return false;
            }
            else if (string.IsNullOrEmpty(Superficie.Text))
            {
                MessageBox.Show("Ingrese valor en Supercie Total del Terreno");
                return false;
            }
            else if (string.IsNullOrEmpty(txtSuperficieConst.Text))
            {
                MessageBox.Show("Ingrese valor en Supercie Total del Construida");
                return false;
            }
            else if (string.IsNullOrEmpty(txtDiscapacitados.Text))
            {
                MessageBox.Show("Ingrese valor en Personas con Condiciones Especiales");
                return false;
            }
            else if (brigadagrid.Rows.Count == 0)
            {
                MessageBox.Show("Rellene la tabla Unidad Interna de Protección Civil");
                return false;
            }
            else if (recursosHumanos.Rows.Count == 0)
            {
                MessageBox.Show("Rellene la tabla Recursos Humanos");
                return false;
            }
            else
            {
                return true;
            }
        }

        //Copia el archivo base en una ruta nueva escogido por el usuario
        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            //Si verifica es true, el cual checa las casillas, se ejecuta el copiado
            if (Verifica())
            {
                //Instancia de SaveFileDialog
                SaveFileDialog sfdpipc = new SaveFileDialog();

                //Advertencia de sobreescritura
                sfdpipc.OverwritePrompt = true;

                //Nombre del archivo por defecto
                sfdpipc.FileName = "PIPC " + razoncomercial.Text;
                //Filtros de archivo
                sfdpipc.Filter = "Archivos Word (*.docx)|*.docx";
                sfdpipc.Title = "Guardar PIPC";
                if (sfdpipc.ShowDialog() == DialogResult.OK)
                {
                    sfdpipc.Dispose();

                    SaveFileDialog sfdplanes = new SaveFileDialog();
                    sfdplanes.OverwritePrompt = true;
                    sfdplanes.FileName = "PLANES " + razoncomercial.Text;
                    sfdplanes.Filter = "Archivos Word (*.docx)|*.docx";
                    sfdplanes.Title = "Guardar PLANES";

                    if (sfdplanes.ShowDialog() == DialogResult.OK)
                    {
                        sfdplanes.Dispose();
                        Word(sfdpipc.FileName, sfdplanes.FileName);
                        MessageBox.Show("Finalizado");
                    }

                }
            }
        }

        //Regresa a la ventana principal
        private void btnregresar_Click_1(object sender, EventArgs e)
        {
            
            DialogResult resultado = new DialogResult();
            Form confirm = new GUI.Confirmar("¿Desea regresar al menú de inicio?");
            resultado = confirm.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                this.Hide();
                Inicio inicio = new Inicio();
                inicio.Show();
            }

        }

        //Realiza el proceso de sustitución de valores
        private void Word(string rutapipc, string rutaplanes)
        {
            //string ruta = Application.StartupPath + @"\Nuevo.docx";
            byte[] word = Recursos.PIPC_CAMPECHE;
            byte[] wordplanes = Recursos.PLANES;
            System.IO.File.WriteAllBytes(rutapipc, word);
            System.IO.File.WriteAllBytes(rutaplanes, wordplanes);

            ObjWord = new Word.Application();
            ObjDoc = ObjWord.Documents.Open(rutapipc, ObjMiss);
            ObjPlanes = ObjWord.Documents.Open(rutaplanes, ObjMiss);
            //ObjDoc = ObjWord.Documents.Open(ruta, ObjMiss);

            Operaciones.Reglamento(ObjWord, ObjDoc, ObjPlanes, municipio.Text);
            Operaciones.Ciudad(ObjWord, ObjDoc, ObjPlanes, txtCiudad.Text);
            Operaciones.RazonComercial(ObjWord, ObjDoc, ObjPlanes, razoncomercial.Text);
            Operaciones.RazonSocial(ObjWord, ObjDoc, ObjPlanes, razonsocial.Text);
            Operaciones.ActividadEmpresa(ObjWord, ObjDoc, ObjPlanes, actividadempresa.Text);
            Operaciones.Domicilio(ObjWord, ObjDoc, ObjPlanes, domicilio.Text);
            Operaciones.Telefono(ObjWord, ObjDoc, ObjPlanes, telefono.Text);
            Operaciones.Representante(ObjWord, ObjDoc, ObjPlanes, representante.Text);
            Operaciones.RFC(ObjWord, ObjDoc, ObjPlanes, txtrfc.Text);
            Operaciones.PoblacionHabitualyTrabajadores(ObjWord, ObjDoc, txtHabitual.Text, txtTrabajadores.Text, txtDiscapacitados.Text);
            Operaciones.PoblacionFija(ObjWord, ObjDoc, poblacionfija.Text);
            Operaciones.PoblacionFlotante(ObjWord, ObjDoc, poblacionflotante.Text);
            Operaciones.SuperficieTerreno(ObjWord, ObjDoc, Superficie.Text, txtSuperficieConst.Text);
            Operaciones.ResponsableOperativo(ObjWord, ObjPlanes, responsableoperativo.Text);
            Operaciones.Cuerpo(ObjWord, ObjDoc, brigadagrid);
            Operaciones.Colindancias(ObjWord, ObjDoc, txtColinorte.Text, txtColisur.Text, txtColieste.Text, txtColioeste.Text);
            //Operaciones.LogoEncabezado(ObjWord, ObjDoc, picturelogo.ImageLocation);
            Operaciones.RecusosHumanos(ObjWord, ObjDoc, recursosHumanos);
            Operaciones.Tablas(ObjWord, ObjDoc, brigadagrid);
            ObjWord.Visible = true;
        }

        //Ventana de aviso para cerrar el programa
        private void btncerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            Form confirm = new GUI.Confirmar("¿Desea salir del programa?");
            resultado = confirm.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        //Botón minimizar
        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Para poder arrastrar la ventana de windows
        private void PipcCampeche_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //El timer para el efecto fade
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity < 100.0)
            {
                this.Opacity += 0.2;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void btnlogo_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog abririmg = new OpenFileDialog();
            abririmg.Filter = "Subir Logo (*.jpg, *.jepg)|*.jpg;*.jepg|PNG (*.png)|*.png";

            if (abririmg.ShowDialog() == DialogResult.OK)
            {
                picturelogo.ImageLocation = abririmg.FileName;
            }
        }

        private void btnagrega_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtCargo.Text) || string.IsNullOrEmpty(txtUbicacion.Text))
            {
                MessageBox.Show("Rellene los campos faltantes");
            }
            else
            {
                brigadagrid.Rows.Add();
                int numfilas = brigadagrid.Rows.Count - 1;
                brigadagrid[0, numfilas].Value = txtNombre.Text;
                brigadagrid[1, numfilas].Value = txtCargo.Text;
                brigadagrid[2, numfilas].Value = txtUbicacion.Text;
                txtNombre.Text = "";
                txtCargo.Text = "";
                txtUbicacion.Text = "";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            Form confirm = new GUI.Confirmar("¿Desea borrar el elemento?");
            resultado = confirm.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                brigadagrid.Rows.Remove(brigadagrid.CurrentRow);
            }
        }

        private void btnRecursos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreRH.Text) || string.IsNullOrEmpty(txtArea.Text) || string.IsNullOrEmpty(txtPuesto.Text))
            {
                MessageBox.Show("Rellene los campos faltantes");
            }
            else
            {
                recursosHumanos.Rows.Add();
                int numfilas = recursosHumanos.Rows.Count - 1;
                recursosHumanos[0, numfilas].Value = txtNombreRH.Text;
                recursosHumanos[1, numfilas].Value = txtArea.Text;
                recursosHumanos[2, numfilas].Value = txtPuesto.Text;
                txtNombreRH.Text = "";
                txtArea.Text = "";
                txtPuesto.Text = "";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            Form confirm = new GUI.Confirmar("¿Desea borrar el elemento?");
            resultado = confirm.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                recursosHumanos.Rows.Remove(recursosHumanos.CurrentRow);
            }
        }
    }
}
