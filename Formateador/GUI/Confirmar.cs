using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Formateador.GUI
{
    public partial class Confirmar : Form
    {
        public Confirmar(string texto)
        {
            InitializeComponent();
            this.mensaje.Text = texto;
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

        private void Confirmar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btncerrar_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        private void btnminimizar_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnaceptar_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btncancelar_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (this.Opacity < 100.0)
            {
                this.Opacity += 0.1;
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
