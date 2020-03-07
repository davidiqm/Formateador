using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Formateador
{
    public partial class PipcCampeche : Form
    {
        //Atributos Word para modificar los valores
        Word.Application ObjWord;
        Word.Document ObjDoc;
        //ObjectMiss para enviar valores cualquiera
        object ObjMiss = System.Reflection.Missing.Value;

        public PipcCampeche()
        {
            InitializeComponent();
        }

        //Verfica que los campos estén completos
        private bool Verifica()
        {

            if (string.IsNullOrEmpty(razoncomercial.Text))
            {
                MessageBox.Show("Ingrese valor en RAZÓN COMERCIAL");
                return false;
            }
            else if (string.IsNullOrEmpty(razonsocial.Text))
            {
                MessageBox.Show("Ingrese un valor en RAZON SOCIAL ");
                return false;
            }
            else if (string.IsNullOrEmpty(actividadempresa.Text))
            {
                MessageBox.Show("Ingrese valor en ACTIVIDAD DE LA EMPRESA");
                return false;
            }
            else if (string.IsNullOrEmpty(domicilio.Text))
            {
                MessageBox.Show("Ingrese valor en DOMICILIO");
                return false;
            }
            else if (string.IsNullOrEmpty(telefono.Text))
            {
                MessageBox.Show("Ingrese valor en TELEFONO");
                return false;
            }
            else if (string.IsNullOrEmpty(representante.Text))
            {
                MessageBox.Show("Ingrese valor en REPRESENTANTE LEGAL");
                return false;
            }
            else
            {
                return true;
            }
        }

        //Copia el archivo base en una ruta nueva escogido por el usuario
        private void btnguardar_Click(object sender, EventArgs e)
        {
            //Si verifica es true, el cual checa las casillas, se ejecuta el copiado
            if (Verifica())
            {
                //Instancia de SaveFileDialog
                SaveFileDialog sfd = new SaveFileDialog();

                //Advertencia de sobreescritura
                sfd.OverwritePrompt = true;

                //Nombre del archivo por defecto
                sfd.FileName = "PIPC " + razonsocial.Text;
                //Filtros de archivo
                sfd.Filter = "Archivos Word (*.docx)|*.docx|Todos los archivos (*.*)|*.*";
                sfd.Title = "Guardar";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    sfd.Dispose();
                    Word(sfd.FileName);
                }
            }
        }

        //Regresa a la ventana principal
        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio principal = new Inicio();
            principal.Show();
        }

        //Realiza el proceso de sustitución de valores
        private void Word(string rutafinal)
        {
            string archivo = Application.StartupPath + @"\PIPC CAMPECHE.docx";

            System.IO.File.Copy(archivo, rutafinal);

            //ObjWord = new Word.Application();
            //ObjDoc = ObjWord.Documents.Open(rutafinal, ObjMiss);

            //Operaciones.RazonComercial(ObjWord, ObjDoc, razoncomercial.Text);
            //Operaciones.RazonSocial(ObjWord, ObjDoc, razonsocial.Text);
            //Operaciones.ActividadEmpresa(ObjWord, ObjDoc, actividadempresa.Text);
            //Operaciones.Domicilio(ObjWord, ObjDoc, domicilio.Text);
            //Operaciones.Telefono(ObjWord, ObjDoc, telefono.Text);
            //Operaciones.Representante(ObjWord, ObjDoc, representante.Text);
            //ObjWord.Visible = true;
        }
    }
}
