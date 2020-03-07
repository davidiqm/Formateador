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
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.btnregresar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnagrega = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.brigadagrid = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.rfc = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.poblacionflotante = new System.Windows.Forms.TextBox();
            this.poblacionfija = new System.Windows.Forms.TextBox();
            this.Superficie = new System.Windows.Forms.TextBox();
            this.municipio = new System.Windows.Forms.ComboBox();
            this.responsableoperativo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.razoncomercial = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.domicilio = new System.Windows.Forms.TextBox();
            this.textrfc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnlogo = new System.Windows.Forms.Button();
            this.actividadempresa = new System.Windows.Forms.TextBox();
            this.representante = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.razonsocial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.picturelogo = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brigadagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturelogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btncerrar
            // 
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(595, 12);
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
            this.btnminimizar.Location = new System.Drawing.Point(565, 12);
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
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(620, 610);
            this.shapeContainer1.TabIndex = 32;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 20;
            this.lineShape1.X2 = 600;
            this.lineShape1.Y1 = 40;
            this.lineShape1.Y2 = 40;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.rfc);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.poblacionflotante);
            this.panel1.Controls.Add(this.poblacionfija);
            this.panel1.Controls.Add(this.Superficie);
            this.panel1.Controls.Add(this.municipio);
            this.panel1.Controls.Add(this.responsableoperativo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.razoncomercial);
            this.panel1.Controls.Add(this.telefono);
            this.panel1.Controls.Add(this.domicilio);
            this.panel1.Controls.Add(this.textrfc);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnlogo);
            this.panel1.Controls.Add(this.actividadempresa);
            this.panel1.Controls.Add(this.representante);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.razonsocial);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.picturelogo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 542);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtCargo);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.btnguardar);
            this.panel2.Controls.Add(this.txtUbicacion);
            this.panel2.Controls.Add(this.btnregresar);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.btnagrega);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.brigadagrid);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(0, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 309);
            this.panel2.TabIndex = 63;
            // 
            // txtCargo
            // 
            this.txtCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCargo.ForeColor = System.Drawing.Color.Black;
            this.txtCargo.Location = new System.Drawing.Point(210, 57);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(156, 20);
            this.txtCargo.TabIndex = 69;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(372, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 17);
            this.label16.TabIndex = 68;
            this.label16.Text = "Ubicación";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(210, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 17);
            this.label15.TabIndex = 67;
            this.label15.Text = "Cargo en la UIPC";
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Location = new System.Drawing.Point(450, 248);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(130, 40);
            this.btnguardar.TabIndex = 14;
            this.btnguardar.Text = "ACEPTAR";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click_1);
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUbicacion.ForeColor = System.Drawing.Color.Black;
            this.txtUbicacion.Location = new System.Drawing.Point(372, 57);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(130, 20);
            this.txtUbicacion.TabIndex = 66;
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnregresar.FlatAppearance.BorderSize = 0;
            this.btnregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregresar.Location = new System.Drawing.Point(30, 248);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(130, 40);
            this.btnregresar.TabIndex = 0;
            this.btnregresar.Text = "REGRESAR";
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(30, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 17);
            this.label14.TabIndex = 65;
            this.label14.Text = "Nombre";
            // 
            // btnagrega
            // 
            this.btnagrega.Location = new System.Drawing.Point(508, 55);
            this.btnagrega.Name = "btnagrega";
            this.btnagrega.Size = new System.Drawing.Size(75, 23);
            this.btnagrega.TabIndex = 64;
            this.btnagrega.Text = "Agregar";
            this.btnagrega.UseVisualStyleBackColor = true;
            this.btnagrega.Click += new System.EventHandler(this.btnagrega_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(30, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(174, 20);
            this.txtNombre.TabIndex = 64;
            // 
            // brigadagrid
            // 
            this.brigadagrid.AllowUserToAddRows = false;
            this.brigadagrid.AllowUserToDeleteRows = false;
            this.brigadagrid.AllowUserToOrderColumns = true;
            this.brigadagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brigadagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Cargo,
            this.Ubicacion});
            this.brigadagrid.Location = new System.Drawing.Point(30, 82);
            this.brigadagrid.Name = "brigadagrid";
            this.brigadagrid.ReadOnly = true;
            this.brigadagrid.Size = new System.Drawing.Size(550, 160);
            this.brigadagrid.TabIndex = 1;
            this.brigadagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo en la UIPC";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            this.Cargo.Width = 157;
            // 
            // Ubicacion
            // 
            this.Ubicacion.HeaderText = "Ubicación Física del Inmueble";
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.ReadOnly = true;
            this.Ubicacion.Width = 150;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(30, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(230, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Unidad Interna de Protección Civil";
            // 
            // rfc
            // 
            this.rfc.AutoSize = true;
            this.rfc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfc.Location = new System.Drawing.Point(30, 388);
            this.rfc.Name = "rfc";
            this.rfc.Size = new System.Drawing.Size(33, 17);
            this.rfc.TabIndex = 55;
            this.rfc.Text = "RFC";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(320, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 17);
            this.label12.TabIndex = 62;
            this.label12.Text = "Logo";
            // 
            // poblacionflotante
            // 
            this.poblacionflotante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.poblacionflotante.ForeColor = System.Drawing.Color.Black;
            this.poblacionflotante.Location = new System.Drawing.Point(455, 242);
            this.poblacionflotante.Name = "poblacionflotante";
            this.poblacionflotante.Size = new System.Drawing.Size(125, 20);
            this.poblacionflotante.TabIndex = 11;
            // 
            // poblacionfija
            // 
            this.poblacionfija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.poblacionfija.ForeColor = System.Drawing.Color.Black;
            this.poblacionfija.Location = new System.Drawing.Point(320, 242);
            this.poblacionfija.Name = "poblacionfija";
            this.poblacionfija.Size = new System.Drawing.Size(125, 20);
            this.poblacionfija.TabIndex = 10;
            this.poblacionfija.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Superficie
            // 
            this.Superficie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Superficie.ForeColor = System.Drawing.Color.Black;
            this.Superficie.Location = new System.Drawing.Point(320, 297);
            this.Superficie.Name = "Superficie";
            this.Superficie.Size = new System.Drawing.Size(260, 20);
            this.Superficie.TabIndex = 12;
            // 
            // municipio
            // 
            this.municipio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.municipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.municipio.Location = new System.Drawing.Point(30, 23);
            this.municipio.Name = "municipio";
            this.municipio.Size = new System.Drawing.Size(260, 21);
            this.municipio.TabIndex = 1;
            // 
            // responsableoperativo
            // 
            this.responsableoperativo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.responsableoperativo.ForeColor = System.Drawing.Color.Black;
            this.responsableoperativo.Location = new System.Drawing.Point(320, 353);
            this.responsableoperativo.Name = "responsableoperativo";
            this.responsableoperativo.Size = new System.Drawing.Size(260, 20);
            this.responsableoperativo.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "Razón Comercial";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 61;
            this.label11.Text = "Municipio";
            // 
            // razoncomercial
            // 
            this.razoncomercial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.razoncomercial.ForeColor = System.Drawing.Color.Black;
            this.razoncomercial.Location = new System.Drawing.Point(30, 78);
            this.razoncomercial.Name = "razoncomercial";
            this.razoncomercial.Size = new System.Drawing.Size(260, 20);
            this.razoncomercial.TabIndex = 2;
            // 
            // telefono
            // 
            this.telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.telefono.ForeColor = System.Drawing.Color.Black;
            this.telefono.Location = new System.Drawing.Point(30, 298);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(260, 20);
            this.telefono.TabIndex = 6;
            // 
            // domicilio
            // 
            this.domicilio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.domicilio.ForeColor = System.Drawing.Color.Black;
            this.domicilio.Location = new System.Drawing.Point(30, 243);
            this.domicilio.Name = "domicilio";
            this.domicilio.Size = new System.Drawing.Size(260, 20);
            this.domicilio.TabIndex = 5;
            // 
            // textrfc
            // 
            this.textrfc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textrfc.ForeColor = System.Drawing.Color.Black;
            this.textrfc.Location = new System.Drawing.Point(30, 408);
            this.textrfc.Name = "textrfc";
            this.textrfc.Size = new System.Drawing.Size(260, 20);
            this.textrfc.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(320, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 56;
            this.label7.Text = "Población Fija";
            // 
            // btnlogo
            // 
            this.btnlogo.Location = new System.Drawing.Point(320, 184);
            this.btnlogo.Name = "btnlogo";
            this.btnlogo.Size = new System.Drawing.Size(260, 23);
            this.btnlogo.TabIndex = 9;
            this.btnlogo.Text = "Seleccionar Logo";
            this.btnlogo.UseVisualStyleBackColor = true;
            this.btnlogo.Click += new System.EventHandler(this.btnlogo_Click_1);
            // 
            // actividadempresa
            // 
            this.actividadempresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.actividadempresa.ForeColor = System.Drawing.Color.Black;
            this.actividadempresa.Location = new System.Drawing.Point(30, 188);
            this.actividadempresa.Name = "actividadempresa";
            this.actividadempresa.Size = new System.Drawing.Size(260, 20);
            this.actividadempresa.TabIndex = 4;
            // 
            // representante
            // 
            this.representante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.representante.ForeColor = System.Drawing.Color.Black;
            this.representante.Location = new System.Drawing.Point(30, 353);
            this.representante.Name = "representante";
            this.representante.Size = new System.Drawing.Size(260, 20);
            this.representante.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(455, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 17);
            this.label8.TabIndex = 57;
            this.label8.Text = "Población Flotante";
            // 
            // razonsocial
            // 
            this.razonsocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.razonsocial.ForeColor = System.Drawing.Color.Black;
            this.razonsocial.Location = new System.Drawing.Point(30, 133);
            this.razonsocial.Name = "razonsocial";
            this.razonsocial.Size = new System.Drawing.Size(260, 20);
            this.razonsocial.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Representante Legal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Razón Social";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(320, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 17);
            this.label9.TabIndex = 58;
            this.label9.Text = "Superficie Total del Terreno";
            // 
            // picturelogo
            // 
            this.picturelogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picturelogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturelogo.Location = new System.Drawing.Point(320, 23);
            this.picturelogo.Name = "picturelogo";
            this.picturelogo.Size = new System.Drawing.Size(260, 140);
            this.picturelogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturelogo.TabIndex = 60;
            this.picturelogo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Teléfono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Actividad de la Empresa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(320, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(252, 17);
            this.label10.TabIndex = 59;
            this.label10.Text = "Responsable Operativo del Programa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Domicilio";
            // 
            // PipcCampeche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(620, 610);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.panel1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brigadagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturelogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox poblacionflotante;
        private System.Windows.Forms.TextBox poblacionfija;
        private System.Windows.Forms.TextBox Superficie;
        private System.Windows.Forms.ComboBox municipio;
        private System.Windows.Forms.TextBox responsableoperativo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox razoncomercial;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox domicilio;
        private System.Windows.Forms.TextBox textrfc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnlogo;
        private System.Windows.Forms.TextBox actividadempresa;
        private System.Windows.Forms.TextBox representante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox razonsocial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picturelogo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label rfc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView brigadagrid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnagrega;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.TextBox txtCargo;
    }
}

