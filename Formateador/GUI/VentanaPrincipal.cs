using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Formateador
{
    public partial class Principal : Form
    {
        Word.Application ObjWord;
        Word.Document ObjDoc;
        object ObjMiss = System.Reflection.Missing.Value;

        public Principal()
        {
            string ruta = Application.StartupPath + @"\PIPC CAMPECHE.docx";
            ObjWord = new Word.Application();
            ObjDoc = ObjWord.Documents.Open(ruta, ObjMiss);
            InitializeComponent();
        }

        private bool Verifica()
        {
            if (string.IsNullOrEmpty(razonsocial.Text))
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
