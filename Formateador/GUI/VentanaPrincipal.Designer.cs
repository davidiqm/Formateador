namespace Formateador
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            ObjWord.Quit();
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.razonsocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.actividadempresa = new System.Windows.Forms.TextBox();
            this.domicilio = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.representante = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // razonsocial
            // 
            this.razonsocial.Location = new System.Drawing.Point(275, 44);
            this.razonsocial.Name = "razonsocial";
            this.razonsocial.Size = new System.Drawing.Size(261, 20);
            this.razonsocial.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "RAZÓN SOCIAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ACTIVIDAD DE LA EMPRESA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "DOMICILIO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "ACEPTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "TELÉFONO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "REPRESENTANTE LEGAL";
            // 
            // actividadempresa
            // 
            this.actividadempresa.Location = new System.Drawing.Point(275, 74);
            this.actividadempresa.Name = "actividadempresa";
            this.actividadempresa.Size = new System.Drawing.Size(261, 20);
            this.actividadempresa.TabIndex = 7;
            // 
            // domicilio
            // 
            this.domicilio.Location = new System.Drawing.Point(275, 108);
            this.domicilio.Name = "domicilio";
            this.domicilio.Size = new System.Drawing.Size(261, 20);
            this.domicilio.TabIndex = 8;
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(275, 136);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(261, 20);
            this.telefono.TabIndex = 9;
            // 
            // representante
            // 
            this.representante.Location = new System.Drawing.Point(275, 166);
            this.representante.Name = "representante";
            this.representante.Size = new System.Drawing.Size(261, 20);
            this.representante.TabIndex = 10;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 278);
            this.Controls.Add(this.representante);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.domicilio);
            this.Controls.Add(this.actividadempresa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.razonsocial);
            this.Name = "Principal";
            this.Text = "Protección Civil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox razonsocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox actividadempresa;
        private System.Windows.Forms.TextBox domicilio;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox representante;
    }
}

