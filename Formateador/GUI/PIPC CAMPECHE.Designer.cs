namespace Formateador
{
    partial class PipcCampeche
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
            this.label6 = new System.Windows.Forms.Label();
            this.razoncomercial = new System.Windows.Forms.TextBox();
            this.municipio = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // razonsocial
            // 
            this.razonsocial.Location = new System.Drawing.Point(284, 120);
            this.razonsocial.Name = "razonsocial";
            this.razonsocial.Size = new System.Drawing.Size(261, 20);
            this.razonsocial.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "RAZÓN SOCIAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ACTIVIDAD DE LA EMPRESA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "DOMICILIO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "ACEPTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "TELÉFONO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "REPRESENTANTE LEGAL";
            // 
            // actividadempresa
            // 
            this.actividadempresa.Location = new System.Drawing.Point(284, 153);
            this.actividadempresa.Name = "actividadempresa";
            this.actividadempresa.Size = new System.Drawing.Size(261, 20);
            this.actividadempresa.TabIndex = 2;
            // 
            // domicilio
            // 
            this.domicilio.Location = new System.Drawing.Point(284, 187);
            this.domicilio.Name = "domicilio";
            this.domicilio.Size = new System.Drawing.Size(261, 20);
            this.domicilio.TabIndex = 3;
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(284, 215);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(261, 20);
            this.telefono.TabIndex = 4;
            // 
            // representante
            // 
            this.representante.Location = new System.Drawing.Point(284, 245);
            this.representante.Name = "representante";
            this.representante.Size = new System.Drawing.Size(261, 20);
            this.representante.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "RAZÓN COMERCIAL";
            // 
            // razoncomercial
            // 
            this.razoncomercial.Location = new System.Drawing.Point(284, 88);
            this.razoncomercial.Name = "razoncomercial";
            this.razoncomercial.Size = new System.Drawing.Size(261, 20);
            this.razoncomercial.TabIndex = 0;
            // 
            // municipio
            // 
            this.municipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.municipio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.municipio.FormattingEnabled = true;
            this.municipio.Items.AddRange(new object[] {
            "CALAKMUL",
            "CALKINÍ",
            "CAMPECHE",
            "CANDELARIA",
            "CARMEN",
            "CHAMPOTÓN",
            "ESCÁRCEGA",
            "HECHELCHACKÁN",
            "HOPELCHÉN",
            "PALIZADA",
            "TENABO"});
            this.municipio.Location = new System.Drawing.Point(284, 46);
            this.municipio.Name = "municipio";
            this.municipio.Size = new System.Drawing.Size(121, 21);
            this.municipio.TabIndex = 12;
            // 
            // PipcCampeche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 348);
            this.Controls.Add(this.municipio);
            this.Controls.Add(this.razoncomercial);
            this.Controls.Add(this.label6);
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
            this.Name = "PipcCampeche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PIPC CAMPECHE";
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox razoncomercial;
        private System.Windows.Forms.ComboBox municipio;
    }
}

