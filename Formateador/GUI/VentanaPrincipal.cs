using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Formateador
{
    public partial class Principal : Form
    {
        //Atributos Word para modificar los valores
        Word.Application ObjWord;
        Word.Document ObjDoc;
        //ObjectMiss para enviar valores cualquiera
        object ObjMiss = System.Reflection.Missing.Value;

        public Principal()
        {
            ObjWord = new Word.Application();
            string archivo = Application.StartupPath + @"\PIPC CAMPECHE.docx";
            ObjDoc = ObjWord.Documents.Open(archivo, ObjMiss);
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
                Operaciones.RazonComercial(ObjWord, ObjDoc, razoncomercial.Text);
                Operaciones.RazonSocial(ObjWord, ObjDoc, razonsocial.Text);
                Operaciones.ActividadEmpresa(ObjWord, ObjDoc, actividadempresa.Text);
                Operaciones.Domicilio(ObjWord, ObjDoc, domicilio.Text);
                Operaciones.Telefono(ObjWord, ObjDoc, telefono.Text);
                Operaciones.Representante(ObjWord, ObjDoc, representante.Text);
                return true;
            }
        }

        //Inicia el proceso de formateado
        private void button1_Click(object sender, EventArgs e)
        {
            if (Verifica())
            {
                ObjWord.Visible = true; 
            }
        }
    }
}
