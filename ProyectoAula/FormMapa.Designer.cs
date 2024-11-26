namespace ProyectoAula
{
    partial class FormMapa
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
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PNLsEPARACION = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreApp = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.cbxTipoAlerta = new System.Windows.Forms.ComboBox();
            this.lblLongitud = new System.Windows.Forms.Label();
            this.lblLatitud = new System.Windows.Forms.Label();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.txtLatitud = new System.Windows.Forms.TextBox();
            this.btnCrearAlerta = new System.Windows.Forms.Button();
            this.pnlBarraSuperior = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pnlBarraInferior = new System.Windows.Forms.Panel();
            this.pnlOpciones.SuspendLayout();
            this.pnlBarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.BackColor = System.Drawing.Color.Transparent;
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(-3, 27);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(689, 458);
            this.gMapControl1.TabIndex = 9;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDoubleClick);
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Controls.Add(this.panel1);
            this.pnlOpciones.Controls.Add(this.PNLsEPARACION);
            this.pnlOpciones.Controls.Add(this.label1);
            this.pnlOpciones.Controls.Add(this.lblNombreApp);
            this.pnlOpciones.Controls.Add(this.lblW);
            this.pnlOpciones.Controls.Add(this.cbxTipoAlerta);
            this.pnlOpciones.Controls.Add(this.lblLongitud);
            this.pnlOpciones.Controls.Add(this.lblLatitud);
            this.pnlOpciones.Controls.Add(this.txtLongitud);
            this.pnlOpciones.Controls.Add(this.txtLatitud);
            this.pnlOpciones.Controls.Add(this.btnCrearAlerta);
            this.pnlOpciones.Location = new System.Drawing.Point(683, 28);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(246, 457);
            this.pnlOpciones.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(17, 523);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 1);
            this.panel1.TabIndex = 11;
            // 
            // PNLsEPARACION
            // 
            this.PNLsEPARACION.BackColor = System.Drawing.Color.White;
            this.PNLsEPARACION.ForeColor = System.Drawing.Color.White;
            this.PNLsEPARACION.Location = new System.Drawing.Point(17, 144);
            this.PNLsEPARACION.Name = "PNLsEPARACION";
            this.PNLsEPARACION.Size = new System.Drawing.Size(209, 1);
            this.PNLsEPARACION.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(142, 121);
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
            this.lblNombreApp.Location = new System.Drawing.Point(9, 88);
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
            this.lblW.Font = new System.Drawing.Font("Script MT Bold", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblW.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblW.Location = new System.Drawing.Point(59, 21);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(130, 77);
            this.lblW.TabIndex = 8;
            this.lblW.Text = "Wx";
            // 
            // cbxTipoAlerta
            // 
            this.cbxTipoAlerta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoAlerta.ForeColor = System.Drawing.Color.Black;
            this.cbxTipoAlerta.FormattingEnabled = true;
            this.cbxTipoAlerta.Location = new System.Drawing.Point(13, 305);
            this.cbxTipoAlerta.Name = "cbxTipoAlerta";
            this.cbxTipoAlerta.Size = new System.Drawing.Size(213, 28);
            this.cbxTipoAlerta.TabIndex = 6;
            this.cbxTipoAlerta.Text = "Tipo Alerta...";
            // 
            // lblLongitud
            // 
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.BackColor = System.Drawing.Color.Transparent;
            this.lblLongitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLongitud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitud.ForeColor = System.Drawing.Color.White;
            this.lblLongitud.Location = new System.Drawing.Point(12, 238);
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
            this.lblLatitud.Location = new System.Drawing.Point(13, 176);
            this.lblLatitud.Name = "lblLatitud";
            this.lblLatitud.Size = new System.Drawing.Size(72, 20);
            this.lblLatitud.TabIndex = 4;
            this.lblLatitud.Text = "LATITUD";
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(12, 258);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(213, 20);
            this.txtLongitud.TabIndex = 2;
            // 
            // txtLatitud
            // 
            this.txtLatitud.Location = new System.Drawing.Point(13, 196);
            this.txtLatitud.Name = "txtLatitud";
            this.txtLatitud.Size = new System.Drawing.Size(213, 20);
            this.txtLatitud.TabIndex = 1;
            // 
            // btnCrearAlerta
            // 
            this.btnCrearAlerta.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCrearAlerta.FlatAppearance.BorderSize = 0;
            this.btnCrearAlerta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCrearAlerta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearAlerta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearAlerta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrearAlerta.Location = new System.Drawing.Point(0, 379);
            this.btnCrearAlerta.Name = "btnCrearAlerta";
            this.btnCrearAlerta.Size = new System.Drawing.Size(243, 45);
            this.btnCrearAlerta.TabIndex = 0;
            this.btnCrearAlerta.Text = "CREAR ALERTA";
            this.btnCrearAlerta.UseVisualStyleBackColor = false;
            this.btnCrearAlerta.Click += new System.EventHandler(this.btnCrearAlerta_Click);
            // 
            // pnlBarraSuperior
            // 
            this.pnlBarraSuperior.BackColor = System.Drawing.Color.Black;
            this.pnlBarraSuperior.Controls.Add(this.btnSalir);
            this.pnlBarraSuperior.Controls.Add(this.btnHistorial);
            this.pnlBarraSuperior.Controls.Add(this.btnInicio);
            this.pnlBarraSuperior.Location = new System.Drawing.Point(-9, 0);
            this.pnlBarraSuperior.Name = "pnlBarraSuperior";
            this.pnlBarraSuperior.Size = new System.Drawing.Size(938, 30);
            this.pnlBarraSuperior.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(902, -2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 30);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.Black;
            this.btnHistorial.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHistorial.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHistorial.Location = new System.Drawing.Point(125, 0);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(124, 30);
            this.btnHistorial.TabIndex = 6;
            this.btnHistorial.Text = "HISTORIAL";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.btnInicio.Size = new System.Drawing.Size(125, 30);
            this.btnInicio.TabIndex = 5;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.UseVisualStyleBackColor = false;
            // 
            // pnlBarraInferior
            // 
            this.pnlBarraInferior.BackColor = System.Drawing.Color.Black;
            this.pnlBarraInferior.Location = new System.Drawing.Point(-3, 482);
            this.pnlBarraInferior.Name = "pnlBarraInferior";
            this.pnlBarraInferior.Size = new System.Drawing.Size(932, 33);
            this.pnlBarraInferior.TabIndex = 4;
            // 
            // FormMapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoAula.Properties.Resources.FondoPrincipal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 512);
            this.Controls.Add(this.pnlBarraInferior);
            this.Controls.Add(this.pnlBarraSuperior);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.pnlOpciones);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "FormMapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMapa_Load);
            this.pnlOpciones.ResumeLayout(false);
            this.pnlOpciones.PerformLayout();
            this.pnlBarraSuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Panel pnlBarraSuperior;
        private System.Windows.Forms.Panel pnlBarraInferior;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCrearAlerta;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.TextBox txtLatitud;
        private System.Windows.Forms.Label lblLongitud;
        private System.Windows.Forms.Label lblLatitud;
        private System.Windows.Forms.ComboBox cbxTipoAlerta;
        private System.Windows.Forms.Label lblNombreApp;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PNLsEPARACION;
    }
}