using System;
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

        //Verfica que los campos estén completos para retroceder a la pantalla principal
        private bool Verifica2()
        {
            return !string.IsNullOrEmpty(razoncomercial.Text) || !string.IsNullOrEmpty(razonsocial.Text) || !string.IsNullOrEmpty(actividadempresa.Text) || !string.IsNullOrEmpty(domicilio.Text) || !string.IsNullOrEmpty(telefono.Text) || !string.IsNullOrEmpty(representante.Text);
        }

        //Verifica que los campos estén llenos para formatear el documento
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
                sfd.FileName = "PIPC " + razoncomercial.Text;
                //Filtros de archivo
                sfd.Filter = "Archivos Word (*.docx)|*.docx";
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
            if (Verifica2() == false)
            {
                this.Hide();
                Inicio principal = new Inicio();
                principal.Show();
            }
            else
            {
                DialogResult resultado = new DialogResult();
                Form confirm = new GUI.Confirmar("¿Desea regresar al menú de inicio?");
                resultado = confirm.ShowDialog();
                if(resultado == DialogResult.OK)
                {
                    this.Hide();
                    Inicio inicio = new Inicio();
                    inicio.Show();
                }
            }

        }

        //Realiza el proceso de sustitución de valores
        private void Word(string rutafinal)
        {
            string ruta = Application.StartupPath + @"\Nuevo.docx";
            //byte[] word = Recursos.PIPC_CAMPECHE;
            //System.IO.File.WriteAllBytes(rutafinal, word);

            ObjWord = new Word.Application();
            ObjDoc = ObjWord.Documents.Open(ruta, ObjMiss);

            //Operaciones.RazonComercial(ObjWord, ObjDoc, razoncomercial.Text);
            //Operaciones.RazonSocial(ObjWord, ObjDoc, razonsocial.Text);
            //Operaciones.ActividadEmpresa(ObjWord, ObjDoc, actividadempresa.Text);
            //Operaciones.Domicilio(ObjWord, ObjDoc, domicilio.Text);
            //Operaciones.Telefono(ObjWord, ObjDoc, telefono.Text);
            //Operaciones.Representante(ObjWord, ObjDoc, representante.Text);
            Operaciones.Tabla(ObjWord, ObjDoc, representante.Text);
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

        private void btnlogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog abririmg = new OpenFileDialog();
            abririmg.Filter = "Subir Logo (*.jpg, *.jepg)|*.jpg;*.jepg|PNG (*.png)|*.png";

            if (abririmg.ShowDialog() == DialogResult.OK)
            {
                picturelogo.ImageLocation = abririmg.FileName;
            }
        }
    }
}
