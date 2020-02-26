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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Inicia el proceso de formateado
        private void button1_Click(object sender, EventArgs e)
        {
            object ObjMiss = System.Reflection.Missing.Value;
            string ruta = Application.StartupPath + @"\..\word\PIPC CAMPECHE.docx";
            Word.Application ObjWord = new Word.Application();
            Word.Document ObjDoc = ObjWord.Documents.Open(ruta, ObjMiss);

            //Reemplaza la razon social en el texto
            Operaciones.RazonSocial(ObjWord, ObjDoc, razonsocial.Text);
            Operaciones.Domicilio();
        }
    }
}
