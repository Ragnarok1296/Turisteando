namespace Turistiando
{
    partial class FrmUbicacion
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
            this.gmcMapa = new GMap.NET.WindowsForms.GMapControl();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gmcMapa
            // 
            this.gmcMapa.AutoScroll = true;
            this.gmcMapa.Bearing = 0F;
            this.gmcMapa.CanDragMap = true;
            this.gmcMapa.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmcMapa.GrayScaleMode = false;
            this.gmcMapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmcMapa.LevelsKeepInMemmory = 5;
            this.gmcMapa.Location = new System.Drawing.Point(12, 12);
            this.gmcMapa.MarkersEnabled = true;
            this.gmcMapa.MaxZoom = 18;
            this.gmcMapa.MinZoom = 4;
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
            this.gmcMapa.Size = new System.Drawing.Size(776, 383);
            this.gmcMapa.TabIndex = 0;
            this.gmcMapa.Zoom = 13D;
            this.gmcMapa.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gmcMapa_MouseDoubleClick);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(361, 415);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FrmUbicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gmcMapa);
            this.Name = "FrmUbicacion";
            this.Text = "FrmUbicacion";
            this.Load += new System.EventHandler(this.FrmUbicacion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmcMapa;
        private System.Windows.Forms.Button btnAceptar;
    }
}