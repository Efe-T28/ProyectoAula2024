namespace ProyectoAula
{
    partial class FormHistorial
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pnlBarraSuperior = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlBarraInferior = new System.Windows.Forms.Panel();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.cmbTipoAlerta = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtgAlertas = new System.Windows.Forms.DataGridView();
            this.PNLsEPARACION = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreApp = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.lblLongitud = new System.Windows.Forms.Label();
            this.lblLatitud = new System.Windows.Forms.Label();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.txtLatitud = new System.Windows.Forms.TextBox();
            this.btnUbicacion = new System.Windows.Forms.Button();
            this.gmpMapa = new GMap.NET.WindowsForms.GMapControl();
            this.pnlBarraSuperior.SuspendLayout();
            this.pnlOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlertas)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(125, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "HISTORIAL";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Black;
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInicio.Location = new System.Drawing.Point(0, 0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(125, 32);
            this.btnInicio.TabIndex = 5;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pnlBarraSuperior
            // 
            this.pnlBarraSuperior.BackColor = System.Drawing.Color.Black;
            this.pnlBarraSuperior.Controls.Add(this.btnSalir);
            this.pnlBarraSuperior.Controls.Add(this.button2);
            this.pnlBarraSuperior.Controls.Add(this.btnInicio);
            this.pnlBarraSuperior.Location = new System.Drawing.Point(0, -2);
            this.pnlBarraSuperior.Name = "pnlBarraSuperior";
            this.pnlBarraSuperior.Size = new System.Drawing.Size(928, 32);
            this.pnlBarraSuperior.TabIndex = 5;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(895, -1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 30);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlBarraInferior
            // 
            this.pnlBarraInferior.BackColor = System.Drawing.Color.Black;
            this.pnlBarraInferior.Location = new System.Drawing.Point(0, 483);
            this.pnlBarraInferior.Name = "pnlBarraInferior";
            this.pnlBarraInferior.Size = new System.Drawing.Size(923, 31);
            this.pnlBarraInferior.TabIndex = 6;
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Controls.Add(this.cmbTipoAlerta);
            this.pnlOpciones.Controls.Add(this.btnEliminar);
            this.pnlOpciones.Controls.Add(this.dtgAlertas);
            this.pnlOpciones.Controls.Add(this.PNLsEPARACION);
            this.pnlOpciones.Controls.Add(this.label1);
            this.pnlOpciones.Controls.Add(this.lblNombreApp);
            this.pnlOpciones.Controls.Add(this.lblW);
            this.pnlOpciones.Controls.Add(this.lblLongitud);
            this.pnlOpciones.Controls.Add(this.lblLatitud);
            this.pnlOpciones.Controls.Add(this.txtLongitud);
            this.pnlOpciones.Controls.Add(this.txtLatitud);
            this.pnlOpciones.Location = new System.Drawing.Point(0, 30);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(514, 470);
            this.pnlOpciones.TabIndex = 8;
            // 
            // cmbTipoAlerta
            // 
            this.cmbTipoAlerta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoAlerta.ForeColor = System.Drawing.Color.Black;
            this.cmbTipoAlerta.FormattingEnabled = true;
            this.cmbTipoAlerta.Items.AddRange(new object[] {
            "Accidente",
            "Robo",
            "Actividad Sospechosa"});
            this.cmbTipoAlerta.Location = new System.Drawing.Point(23, 190);
            this.cmbTipoAlerta.Name = "cmbTipoAlerta";
            this.cmbTipoAlerta.Size = new System.Drawing.Size(213, 28);
            this.cmbTipoAlerta.TabIndex = 6;
            this.cmbTipoAlerta.Text = "Tipo Alerta...";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(372, 414);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dtgAlertas
            // 
            this.dtgAlertas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgAlertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlertas.Location = new System.Drawing.Point(50, 233);
            this.dtgAlertas.Name = "dtgAlertas";
            this.dtgAlertas.RowHeadersWidth = 62;
            this.dtgAlertas.Size = new System.Drawing.Size(397, 164);
            this.dtgAlertas.TabIndex = 11;
            this.dtgAlertas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAlertas_CellContentClick);
            // 
            // PNLsEPARACION
            // 
            this.PNLsEPARACION.BackColor = System.Drawing.Color.White;
            this.PNLsEPARACION.ForeColor = System.Drawing.Color.White;
            this.PNLsEPARACION.Location = new System.Drawing.Point(12, 123);
            this.PNLsEPARACION.Name = "PNLsEPARACION";
            this.PNLsEPARACION.Size = new System.Drawing.Size(479, 1);
            this.PNLsEPARACION.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(278, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 7);
            this.label1.TabIndex = 9;
            this.label1.Text = "A L E R T    S Y S T E M";
            // 
            // lblNombreApp
            // 
            this.lblNombreApp.AutoSize = true;
            this.lblNombreApp.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombreApp.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreApp.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNombreApp.Location = new System.Drawing.Point(145, 70);
            this.lblNombreApp.Name = "lblNombreApp";
            this.lblNombreApp.Size = new System.Drawing.Size(222, 40);
            this.lblNombreApp.TabIndex = 7;
            this.lblNombreApp.Text = "Wayfinder X";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.BackColor = System.Drawing.Color.Transparent;
            this.lblW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblW.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblW.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblW.Location = new System.Drawing.Point(195, 3);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(126, 73);
            this.lblW.TabIndex = 8;
            this.lblW.Text = "Wx";
            // 
            // lblLongitud
            // 
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.BackColor = System.Drawing.Color.Transparent;
            this.lblLongitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLongitud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitud.ForeColor = System.Drawing.Color.White;
            this.lblLongitud.Location = new System.Drawing.Point(274, 133);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(87, 20);
            this.lblLongitud.TabIndex = 5;
            this.lblLongitud.Text = "LONGITUD";
            // 
            // lblLatitud
            // 
            this.lblLatitud.AutoSize = true;
            this.lblLatitud.BackColor = System.Drawing.Color.Transparent;
            this.lblLatitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLatitud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatitud.ForeColor = System.Drawing.Color.White;
            this.lblLatitud.Location = new System.Drawing.Point(23, 133);
            this.lblLatitud.Name = "lblLatitud";
            this.lblLatitud.Size = new System.Drawing.Size(72, 20);
            this.lblLatitud.TabIndex = 4;
            this.lblLatitud.Text = "LATITUD";
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(274, 153);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(213, 20);
            this.txtLongitud.TabIndex = 2;
            // 
            // txtLatitud
            // 
            this.txtLatitud.Location = new System.Drawing.Point(23, 153);
            this.txtLatitud.Name = "txtLatitud";
            this.txtLatitud.Size = new System.Drawing.Size(213, 20);
            this.txtLatitud.TabIndex = 1;
            // 
            // btnUbicacion
            // 
            this.btnUbicacion.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnUbicacion.FlatAppearance.BorderSize = 3;
            this.btnUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbicacion.Image = global::ProyectoAula.Properties.Resources.ubicaionMia;
            this.btnUbicacion.Location = new System.Drawing.Point(873, 36);
            this.btnUbicacion.Name = "btnUbicacion";
            this.btnUbicacion.Size = new System.Drawing.Size(39, 37);
            this.btnUbicacion.TabIndex = 10;
            this.btnUbicacion.UseVisualStyleBackColor = true;
            this.btnUbicacion.Click += new System.EventHandler(this.btnUbicacion_Click);
            // 
            // gmpMapa
            // 
            this.gmpMapa.BackColor = System.Drawing.Color.Transparent;
            this.gmpMapa.Bearing = 0F;
            this.gmpMapa.CanDragMap = true;
            this.gmpMapa.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmpMapa.GrayScaleMode = false;
            this.gmpMapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmpMapa.LevelsKeepInMemmory = 5;
            this.gmpMapa.Location = new System.Drawing.Point(511, 30);
            this.gmpMapa.MarkersEnabled = true;
            this.gmpMapa.MaxZoom = 2;
            this.gmpMapa.MinZoom = 2;
            this.gmpMapa.MouseWheelZoomEnabled = true;
            this.gmpMapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmpMapa.Name = "gmpMapa";
            this.gmpMapa.NegativeMode = false;
            this.gmpMapa.PolygonsEnabled = true;
            this.gmpMapa.RetryLoadTile = 0;
            this.gmpMapa.RoutesEnabled = true;
            this.gmpMapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmpMapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmpMapa.ShowTileGridLines = false;
            this.gmpMapa.Size = new System.Drawing.Size(412, 467);
            this.gmpMapa.TabIndex = 9;
            this.gmpMapa.Zoom = 0D;
            // 
            // FormHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoAula.Properties.Resources.FondoPrincipal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 512);
            this.Controls.Add(this.pnlBarraInferior);
            this.Controls.Add(this.btnUbicacion);
            this.Controls.Add(this.pnlBarraSuperior);
            this.Controls.Add(this.gmpMapa);
            this.Controls.Add(this.pnlOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "FormHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOpciones";
            this.Load += new System.EventHandler(this.FormHistorial_Load);
            this.pnlBarraSuperior.ResumeLayout(false);
            this.pnlOpciones.ResumeLayout(false);
            this.pnlOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlertas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel pnlBarraSuperior;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pnlBarraInferior;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Panel PNLsEPARACION;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreApp;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Label lblLongitud;
        private System.Windows.Forms.Label lblLatitud;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.TextBox txtLatitud;
        private System.Windows.Forms.DataGridView dtgAlertas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cmbTipoAlerta;
        private System.Windows.Forms.Button btnUbicacion;
        private GMap.NET.WindowsForms.GMapControl gmpMapa;
    }
}