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
            //ObjWord.Quit();
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PipcCampeche));
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rfc = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.picturelogo = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.razoncomercial = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.domicilio = new System.Windows.Forms.TextBox();
            this.municipio = new System.Windows.Forms.ComboBox();
            this.btnregresar = new System.Windows.Forms.Button();
            this.actividadempresa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.razonsocial = new System.Windows.Forms.TextBox();
            this.representante = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnlogo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textrfc = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturelogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(431, 558);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 13;
            this.btnguardar.Text = "ACEPTAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(590, 12);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(12, 12);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btncerrar.TabIndex = 14;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(560, 12);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(12, 12);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnminimizar.TabIndex = 15;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rfc
            // 
            this.rfc.AutoSize = true;
            this.rfc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfc.Location = new System.Drawing.Point(30, 470);
            this.rfc.Name = "rfc";
            this.rfc.Size = new System.Drawing.Size(33, 17);
            this.rfc.TabIndex = 16;
            this.rfc.Text = "RFC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(320, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Población Fija";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(455, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Población Flotante";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(320, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Superficie Total del Terreno";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(320, 414);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(253, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Responsable Operativo del programa";
            // 
            // picturelogo
            // 
            this.picturelogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picturelogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturelogo.Location = new System.Drawing.Point(320, 105);
            this.picturelogo.Name = "picturelogo";
            this.picturelogo.Size = new System.Drawing.Size(260, 140);
            this.picturelogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturelogo.TabIndex = 22;
            this.picturelogo.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Razón Comercial";
            // 
            // razoncomercial
            // 
            this.razoncomercial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.razoncomercial.ForeColor = System.Drawing.Color.Black;
            this.razoncomercial.Location = new System.Drawing.Point(30, 160);
            this.razoncomercial.Name = "razoncomercial";
            this.razoncomercial.Size = new System.Drawing.Size(260, 20);
            this.razoncomercial.TabIndex = 1;
            // 
            // telefono
            // 
            this.telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.telefono.ForeColor = System.Drawing.Color.Black;
            this.telefono.Location = new System.Drawing.Point(30, 380);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(260, 20);
            this.telefono.TabIndex = 5;
            // 
            // domicilio
            // 
            this.domicilio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.domicilio.ForeColor = System.Drawing.Color.Black;
            this.domicilio.Location = new System.Drawing.Point(30, 325);
            this.domicilio.Name = "domicilio";
            this.domicilio.Size = new System.Drawing.Size(260, 20);
            this.domicilio.TabIndex = 4;
            // 
            // municipio
            // 
            this.municipio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            this.municipio.Location = new System.Drawing.Point(30, 105);
            this.municipio.Name = "municipio";
            this.municipio.Size = new System.Drawing.Size(260, 21);
            this.municipio.TabIndex = 0;
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(28, 558);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(75, 23);
            this.btnregresar.TabIndex = 14;
            this.btnregresar.Text = "REGRESAR";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // actividadempresa
            // 
            this.actividadempresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.actividadempresa.ForeColor = System.Drawing.Color.Black;
            this.actividadempresa.Location = new System.Drawing.Point(30, 270);
            this.actividadempresa.Name = "actividadempresa";
            this.actividadempresa.Size = new System.Drawing.Size(260, 20);
            this.actividadempresa.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "REPRESENTANTE LEGAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "TELÉFONO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "DOMICILIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ACTIVIDAD DE LA EMPRESA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Razón Social";
            // 
            // razonsocial
            // 
            this.razonsocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.razonsocial.ForeColor = System.Drawing.Color.Black;
            this.razonsocial.Location = new System.Drawing.Point(30, 215);
            this.razonsocial.Name = "razonsocial";
            this.razonsocial.Size = new System.Drawing.Size(260, 20);
            this.razonsocial.TabIndex = 2;
            // 
            // representante
            // 
            this.representante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.representante.ForeColor = System.Drawing.Color.Black;
            this.representante.Location = new System.Drawing.Point(30, 435);
            this.representante.Name = "representante";
            this.representante.Size = new System.Drawing.Size(260, 20);
            this.representante.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Municipio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(320, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "Logo";
            // 
            // btnlogo
            // 
            this.btnlogo.Location = new System.Drawing.Point(320, 266);
            this.btnlogo.Name = "btnlogo";
            this.btnlogo.Size = new System.Drawing.Size(260, 23);
            this.btnlogo.TabIndex = 8;
            this.btnlogo.Text = "Subir Logo";
            this.btnlogo.UseVisualStyleBackColor = true;
            this.btnlogo.Click += new System.EventHandler(this.btnlogo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // textrfc
            // 
            this.textrfc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textrfc.ForeColor = System.Drawing.Color.Black;
            this.textrfc.Location = new System.Drawing.Point(30, 490);
            this.textrfc.Name = "textrfc";
            this.textrfc.Size = new System.Drawing.Size(260, 20);
            this.textrfc.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(320, 434);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(260, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(320, 379);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(260, 20);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(320, 324);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(455, 324);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(125, 20);
            this.textBox5.TabIndex = 10;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(602, 593);
            this.shapeContainer1.TabIndex = 32;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 20;
            this.lineShape1.X2 = 590;
            this.lineShape1.Y1 = 40;
            this.lineShape1.Y2 = 40;
            // 
            // PipcCampeche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(580, 610);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textrfc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnlogo);
            this.Controls.Add(this.representante);
            this.Controls.Add(this.razonsocial);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picturelogo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.actividadempresa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.rfc);
            this.Controls.Add(this.municipio);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.domicilio);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.razoncomercial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PipcCampeche";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PIPC CAMPECHE";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PipcCampeche_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturelogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label rfc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox picturelogo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox razoncomercial;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox domicilio;
        private System.Windows.Forms.ComboBox municipio;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.TextBox actividadempresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox razonsocial;
        private System.Windows.Forms.TextBox representante;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnlogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textrfc;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}

