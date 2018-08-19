namespace Turistiando
{
    partial class FrmResultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResultados));
            this.label1 = new System.Windows.Forms.Label();
            this.pbxCerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gmcMapa = new GMap.NET.WindowsForms.GMapControl();
            this.pbRating = new System.Windows.Forms.PictureBox();
            this.pbUbicacion = new System.Windows.Forms.PictureBox();
            this.pbTiempo = new System.Windows.Forms.PictureBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblNombreLugar = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.plButtons = new System.Windows.Forms.Panel();
            this.vsBar = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUbicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.plButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(217, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 50);
            this.label1.TabIndex = 17;
            this.label1.Text = "RECOMENDACIONES";
            // 
            // pbxCerrar
            // 
            this.pbxCerrar.BackColor = System.Drawing.Color.Teal;
            this.pbxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbxCerrar.Image")));
            this.pbxCerrar.Location = new System.Drawing.Point(756, 10);
            this.pbxCerrar.Name = "pbxCerrar";
            this.pbxCerrar.Size = new System.Drawing.Size(32, 32);
            this.pbxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxCerrar.TabIndex = 15;
            this.pbxCerrar.TabStop = false;
            this.pbxCerrar.Click += new System.EventHandler(this.pbxCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbxCerrar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 65);
            this.panel1.TabIndex = 50;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Teal;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(718, 10);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.gmcMapa);
            this.panel2.Controls.Add(this.pbRating);
            this.panel2.Controls.Add(this.pbUbicacion);
            this.panel2.Controls.Add(this.pbTiempo);
            this.panel2.Controls.Add(this.lblRating);
            this.panel2.Controls.Add(this.lblTiempo);
            this.panel2.Controls.Add(this.lblNombreLugar);
            this.panel2.Controls.Add(this.pbImagen);
            this.panel2.Location = new System.Drawing.Point(121, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(658, 304);
            this.panel2.TabIndex = 51;
            // 
            // gmcMapa
            // 
            this.gmcMapa.Bearing = 0F;
            this.gmcMapa.CanDragMap = true;
            this.gmcMapa.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmcMapa.GrayScaleMode = false;
            this.gmcMapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmcMapa.LevelsKeepInMemmory = 5;
            this.gmcMapa.Location = new System.Drawing.Point(352, 58);
            this.gmcMapa.MarkersEnabled = true;
            this.gmcMapa.MaxZoom = 18;
            this.gmcMapa.MinZoom = 13;
            this.gmcMapa.MouseWheelZoomEnabled = true;
            this.gmcMapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmcMapa.Name = "gmcMapa";
            this.gmcMapa.NegativeMode = false;
            this.gmcMapa.PolygonsEnabled = true;
            this.gmcMapa.RetryLoadTile = 0;
            this.gmcMapa.RoutesEnabled = true;
            this.gmcMapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmcMapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmcMapa.ShowTileGridLines = false;
            this.gmcMapa.Size = new System.Drawing.Size(277, 175);
            this.gmcMapa.TabIndex = 9;
            this.gmcMapa.Zoom = 14D;
            // 
            // pbRating
            // 
            this.pbRating.Image = ((System.Drawing.Image)(resources.GetObject("pbRating.Image")));
            this.pbRating.Location = new System.Drawing.Point(325, 262);
            this.pbRating.Name = "pbRating";
            this.pbRating.Size = new System.Drawing.Size(20, 20);
            this.pbRating.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRating.TabIndex = 8;
            this.pbRating.TabStop = false;
            // 
            // pbUbicacion
            // 
            this.pbUbicacion.Image = ((System.Drawing.Image)(resources.GetObject("pbUbicacion.Image")));
            this.pbUbicacion.Location = new System.Drawing.Point(325, 58);
            this.pbUbicacion.Name = "pbUbicacion";
            this.pbUbicacion.Size = new System.Drawing.Size(20, 20);
            this.pbUbicacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUbicacion.TabIndex = 7;
            this.pbUbicacion.TabStop = false;
            // 
            // pbTiempo
            // 
            this.pbTiempo.Image = ((System.Drawing.Image)(resources.GetObject("pbTiempo.Image")));
            this.pbTiempo.Location = new System.Drawing.Point(325, 239);
            this.pbTiempo.Name = "pbTiempo";
            this.pbTiempo.Size = new System.Drawing.Size(20, 20);
            this.pbTiempo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTiempo.TabIndex = 6;
            this.pbTiempo.TabStop = false;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(357, 269);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(50, 17);
            this.lblRating.TabIndex = 5;
            this.lblRating.Text = "Rating";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(357, 246);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(137, 17);
            this.lblTiempo.TabIndex = 4;
            this.lblTiempo.Text = "Tiempo de traslado.";
            // 
            // lblNombreLugar
            // 
            this.lblNombreLugar.AutoSize = true;
            this.lblNombreLugar.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLugar.ForeColor = System.Drawing.Color.Teal;
            this.lblNombreLugar.Location = new System.Drawing.Point(319, 23);
            this.lblNombreLugar.Name = "lblNombreLugar";
            this.lblNombreLugar.Size = new System.Drawing.Size(251, 32);
            this.lblNombreLugar.TabIndex = 1;
            this.lblNombreLugar.Text = "Nombre del Lugar";
            // 
            // pbImagen
            // 
            this.pbImagen.Image = ((System.Drawing.Image)(resources.GetObject("pbImagen.Image")));
            this.pbImagen.Location = new System.Drawing.Point(19, 23);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(270, 259);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            // 
            // plButtons
            // 
            this.plButtons.BackColor = System.Drawing.Color.Silver;
            this.plButtons.Controls.Add(this.vsBar);
            this.plButtons.Location = new System.Drawing.Point(22, 84);
            this.plButtons.Name = "plButtons";
            this.plButtons.Size = new System.Drawing.Size(73, 304);
            this.plButtons.TabIndex = 52;
            // 
            // vsBar
            // 
            this.vsBar.LargeChange = 30;
            this.vsBar.Location = new System.Drawing.Point(56, 0);
            this.vsBar.Name = "vsBar";
            this.vsBar.Size = new System.Drawing.Size(17, 304);
            this.vsBar.TabIndex = 9;
            this.vsBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsBar_Scroll);
            // 
            // FrmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.plButtons);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmResultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUbicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.plButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbRating;
        private System.Windows.Forms.PictureBox pbUbicacion;
        private System.Windows.Forms.PictureBox pbTiempo;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblNombreLugar;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Panel plButtons;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.VScrollBar vsBar;
        private GMap.NET.WindowsForms.GMapControl gmcMapa;
    }
}