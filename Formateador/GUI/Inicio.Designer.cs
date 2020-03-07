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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btncampeche = new System.Windows.Forms.Button();
            this.btnyucatan = new System.Windows.Forms.Button();
            this.btnquintanaroo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncerrar
            // 
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(697, 12);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(12, 12);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btncerrar.TabIndex = 2;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(679, 12);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(12, 12);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnminimizar.TabIndex = 3;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btncampeche
            // 
            this.btncampeche.BackColor = System.Drawing.Color.DarkOrange;
            this.btncampeche.FlatAppearance.BorderSize = 0;
            this.btncampeche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncampeche.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncampeche.ForeColor = System.Drawing.SystemColors.Control;
            this.btncampeche.Location = new System.Drawing.Point(0, 30);
            this.btncampeche.Name = "btncampeche";
            this.btncampeche.Size = new System.Drawing.Size(200, 40);
            this.btncampeche.TabIndex = 4;
            this.btncampeche.Text = "PIPC CAMPECHE";
            this.btncampeche.UseVisualStyleBackColor = false;
            this.btncampeche.Click += new System.EventHandler(this.btncampeche_Click);
            // 
            // btnyucatan
            // 
            this.btnyucatan.BackColor = System.Drawing.Color.DarkOrange;
            this.btnyucatan.FlatAppearance.BorderSize = 0;
            this.btnyucatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyucatan.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyucatan.ForeColor = System.Drawing.SystemColors.Control;
            this.btnyucatan.Location = new System.Drawing.Point(0, 146);
            this.btnyucatan.Name = "btnyucatan";
            this.btnyucatan.Size = new System.Drawing.Size(200, 40);
            this.btnyucatan.TabIndex = 6;
            this.btnyucatan.Text = "PIPC YUCATÁN";
            this.btnyucatan.UseVisualStyleBackColor = false;
            this.btnyucatan.Click += new System.EventHandler(this.btnyucatan_Click);
            // 
            // btnquintanaroo
            // 
            this.btnquintanaroo.BackColor = System.Drawing.Color.DarkOrange;
            this.btnquintanaroo.FlatAppearance.BorderSize = 0;
            this.btnquintanaroo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquintanaroo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquintanaroo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnquintanaroo.Location = new System.Drawing.Point(0, 88);
            this.btnquintanaroo.Name = "btnquintanaroo";
            this.btnquintanaroo.Size = new System.Drawing.Size(200, 40);
            this.btnquintanaroo.TabIndex = 7;
            this.btnquintanaroo.Text = "PIPC QUINTANA ROO";
            this.btnquintanaroo.UseVisualStyleBackColor = false;
            this.btnquintanaroo.Click += new System.EventHandler(this.btnquintanaroo_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(206, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.btncampeche);
            this.panel1.Controls.Add(this.btnquintanaroo);
            this.panel1.Controls.Add(this.btnyucatan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 343);
            this.panel1.TabIndex = 9;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.DarkOrange;
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnsalir.Location = new System.Drawing.Point(0, 279);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(200, 40);
            this.btnsalir.TabIndex = 8;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(286, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 60);
            this.label1.TabIndex = 10;
            this.label1.Text = "Programa Interino de \r\nProtección Civil";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(721, 343);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.btncerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PIPC";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Inicio_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.Button btncampeche;
        private System.Windows.Forms.Button btnyucatan;
        private System.Windows.Forms.Button btnquintanaroo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label1;
    }
}