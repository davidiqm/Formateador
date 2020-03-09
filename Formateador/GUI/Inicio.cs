using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Formateador
{
    public partial class Inicio : Form
    {
        public Inicio()
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

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Inicio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btncampeche_Click(object sender, EventArgs e)
        {
            this.Hide();
            PipcCampeche campeche = new PipcCampeche();
            campeche.Show();
        }

        private void btnquintanaroo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No disponible por el momento");
        }

        private void btnyucatan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No disponible por el momento");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 100.0)
            {
                this.Opacity += 0.2;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            Form confirm = new GUI.Confirmar("¿Desea salir del programa?");
            resultado = confirm.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
