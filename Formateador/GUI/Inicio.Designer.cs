namespace Formateador
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btncampeche = new System.Windows.Forms.Button();
            this.btnyucatan = new System.Windows.Forms.Button();
            this.btnquintanaroo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // btncerrar
            // 
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(503, 12);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(15, 15);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btncerrar.TabIndex = 2;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(482, 12);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(15, 15);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnminimizar.TabIndex = 3;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btncampeche
            // 
            this.btncampeche.BackColor = System.Drawing.Color.Gray;
            this.btncampeche.FlatAppearance.BorderSize = 0;
            this.btncampeche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncampeche.Location = new System.Drawing.Point(311, 75);
            this.btncampeche.Name = "btncampeche";
            this.btncampeche.Size = new System.Drawing.Size(166, 23);
            this.btncampeche.TabIndex = 4;
            this.btncampeche.Text = "PIPC CAMPECHE";
            this.btncampeche.UseVisualStyleBackColor = false;
            this.btncampeche.Click += new System.EventHandler(this.btncampeche_Click);
            // 
            // btnyucatan
            // 
            this.btnyucatan.BackColor = System.Drawing.Color.Gray;
            this.btnyucatan.FlatAppearance.BorderSize = 0;
            this.btnyucatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyucatan.Location = new System.Drawing.Point(311, 176);
            this.btnyucatan.Name = "btnyucatan";
            this.btnyucatan.Size = new System.Drawing.Size(166, 23);
            this.btnyucatan.TabIndex = 6;
            this.btnyucatan.Text = "PIPC YUCATÁN";
            this.btnyucatan.UseVisualStyleBackColor = false;
            this.btnyucatan.Click += new System.EventHandler(this.btnyucatan_Click);
            // 
            // btnquintanaroo
            // 
            this.btnquintanaroo.BackColor = System.Drawing.Color.Gray;
            this.btnquintanaroo.FlatAppearance.BorderSize = 0;
            this.btnquintanaroo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquintanaroo.Location = new System.Drawing.Point(311, 128);
            this.btnquintanaroo.Name = "btnquintanaroo";
            this.btnquintanaroo.Size = new System.Drawing.Size(166, 23);
            this.btnquintanaroo.TabIndex = 7;
            this.btnquintanaroo.Text = "PIPC QUINTANA ROO";
            this.btnquintanaroo.UseVisualStyleBackColor = false;
            this.btnquintanaroo.Click += new System.EventHandler(this.btnquintanaroo_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(530, 343);
            this.Controls.Add(this.btnquintanaroo);
            this.Controls.Add(this.btnyucatan);
            this.Controls.Add(this.btncampeche);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.btncerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PIPC";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Inicio_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.Button btncampeche;
        private System.Windows.Forms.Button btnyucatan;
        private System.Windows.Forms.Button btnquintanaroo;
    }
}