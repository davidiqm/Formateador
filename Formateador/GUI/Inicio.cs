﻿using System;
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
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwd, int wmsg, int wparam, int lparam);

        private void btncerrar_Click(object sender, EventArgs e) => Application.Exit();

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
    }
}
