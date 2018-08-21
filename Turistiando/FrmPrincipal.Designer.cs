namespace Turistiando
{
    partial class FrmPrincipal
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
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.tbxTiempo = new System.Windows.Forms.TextBox();
            this.btnRecomendar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbTiempo = new System.Windows.Forms.ComboBox();
            this.btnEscogerUbicacion = new System.Windows.Forms.Button();
            this.btnMiUbicacion = new System.Windows.Forms.Button();
            this.pbCheck = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbTipos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbxCerrar = new System.Windows.Forms.PictureBox();
            this.pbxBanner = new System.Windows.Forms.PictureBox();
            this.gpbTiempo = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBanner)).BeginInit();
            this.gpbTiempo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxTiempo
            // 
            this.tbxTiempo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTiempo.Location = new System.Drawing.Point(6, 65);
            this.tbxTiempo.Multiline = true;
            this.tbxTiempo.Name = "tbxTiempo";
            this.tbxTiempo.Size = new System.Drawing.Size(237, 29);
            this.tbxTiempo.TabIndex = 53;
            // 
            // btnRecomendar
            // 
            this.btnRecomendar.BackColor = System.Drawing.Color.Teal;
            this.btnRecomendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecomendar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecomendar.ForeColor = System.Drawing.Color.White;
            this.btnRecomendar.Location = new System.Drawing.Point(331, 338);
            this.btnRecomendar.Name = "btnRecomendar";
            this.btnRecomendar.Size = new System.Drawing.Size(150, 50);
            this.btnRecomendar.TabIndex = 55;
            this.btnRecomendar.Text = "Recomiéndame";
            this.btnRecomendar.UseVisualStyleBackColor = false;
            this.btnRecomendar.Click += new System.EventHandler(this.btnRecomendar_Click);
            // 
            // cbTiempo
            // 
            this.cbTiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTiempo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTiempo.FormattingEnabled = true;
            this.cbTiempo.Items.AddRange(new object[] {
            "Horas",
            "Días"});
            this.cbTiempo.Location = new System.Drawing.Point(6, 100);
            this.cbTiempo.Name = "cbTiempo";
            this.cbTiempo.Size = new System.Drawing.Size(237, 29);
            this.cbTiempo.TabIndex = 56;
            // 
            // btnEscogerUbicacion
            // 
            this.btnEscogerUbicacion.BackColor = System.Drawing.Color.SlateGray;
            this.btnEscogerUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscogerUbicacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscogerUbicacion.ForeColor = System.Drawing.Color.White;
            this.btnEscogerUbicacion.Location = new System.Drawing.Point(6, 22);
            this.btnEscogerUbicacion.Name = "btnEscogerUbicacion";
            this.btnEscogerUbicacion.Size = new System.Drawing.Size(233, 50);
            this.btnEscogerUbicacion.TabIndex = 57;
            this.btnEscogerUbicacion.Text = "Seleccionar ubicación";
            this.btnEscogerUbicacion.UseVisualStyleBackColor = false;
            this.btnEscogerUbicacion.Click += new System.EventHandler(this.btnEscogerUbicacion_Click);
            // 
            // btnMiUbicacion
            // 
            this.btnMiUbicacion.BackColor = System.Drawing.Color.SlateGray;
            this.btnMiUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiUbicacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiUbicacion.ForeColor = System.Drawing.Color.White;
            this.btnMiUbicacion.Location = new System.Drawing.Point(6, 78);
            this.btnMiUbicacion.Name = "btnMiUbicacion";
            this.btnMiUbicacion.Size = new System.Drawing.Size(177, 50);
            this.btnMiUbicacion.TabIndex = 58;
            this.btnMiUbicacion.Text = "Mi ubicación";
            this.btnMiUbicacion.UseVisualStyleBackColor = false;
            this.btnMiUbicacion.Click += new System.EventHandler(this.btnMiUbicacion_Click);
            // 
            // pbCheck
            // 
            this.pbCheck.Image = global::Turistiando.Properties.Resources.success;
            this.pbCheck.Location = new System.Drawing.Point(189, 78);
            this.pbCheck.Name = "pbCheck";
            this.pbCheck.Size = new System.Drawing.Size(50, 50);
            this.pbCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheck.TabIndex = 59;
            this.pbCheck.TabStop = false;
            this.pbCheck.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(220, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(220, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // cbTipos
            // 
            this.cbTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipos.FormattingEnabled = true;
            this.cbTipos.Items.AddRange(new object[] {
            "Parques",
            "Museos",
            "Zoologicos",
            "Galerias de arte",
            "Terrenos para acampar",
            "Centros comerciales"});
            this.cbTipos.Location = new System.Drawing.Point(8, 65);
            this.cbTipos.Name = "cbTipos";
            this.cbTipos.Size = new System.Drawing.Size(231, 29);
            this.cbTipos.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 19);
            this.label2.TabIndex = 61;
            this.label2.Text = "Lugares que desea visitar:";
            // 
            // pbxCerrar
            // 
            this.pbxCerrar.BackColor = System.Drawing.Color.MintCream;
            this.pbxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxCerrar.Image = global::Turistiando.Properties.Resources.cancel;
            this.pbxCerrar.Location = new System.Drawing.Point(762, 2);
            this.pbxCerrar.Name = "pbxCerrar";
            this.pbxCerrar.Size = new System.Drawing.Size(35, 35);
            this.pbxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCerrar.TabIndex = 15;
            this.pbxCerrar.TabStop = false;
            this.pbxCerrar.Click += new System.EventHandler(this.pbxCerrar_Click);
            // 
            // pbxBanner
            // 
            this.pbxBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbxBanner.Image")));
            this.pbxBanner.Location = new System.Drawing.Point(163, 12);
            this.pbxBanner.Name = "pbxBanner";
            this.pbxBanner.Size = new System.Drawing.Size(492, 171);
            this.pbxBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxBanner.TabIndex = 62;
            this.pbxBanner.TabStop = false;
            // 
            // gpbTiempo
            // 
            this.gpbTiempo.Controls.Add(this.label1);
            this.gpbTiempo.Controls.Add(this.tbxTiempo);
            this.gpbTiempo.Controls.Add(this.cbTiempo);
            this.gpbTiempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbTiempo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTiempo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gpbTiempo.Location = new System.Drawing.Point(12, 197);
            this.gpbTiempo.Name = "gpbTiempo";
            this.gpbTiempo.Size = new System.Drawing.Size(249, 135);
            this.gpbTiempo.TabIndex = 63;
            this.gpbTiempo.TabStop = false;
            this.gpbTiempo.Text = "Tiempo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTipos);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox2.Location = new System.Drawing.Point(280, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 135);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lugares";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEscogerUbicacion);
            this.groupBox3.Controls.Add(this.btnMiUbicacion);
            this.groupBox3.Controls.Add(this.pbCheck);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox3.Location = new System.Drawing.Point(543, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 135);
            this.groupBox3.TabIndex = 64;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ubicación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 19);
            this.label1.TabIndex = 62;
            this.label1.Text = "Ingrese tiempo de visita:";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gpbTiempo);
            this.Controls.Add(this.pbxBanner);
            this.Controls.Add(this.pbxCerrar);
            this.Controls.Add(this.btnRecomendar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBanner)).EndInit();
            this.gpbTiempo.ResumeLayout(false);
            this.gpbTiempo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbxTiempo;
        private System.Windows.Forms.Button btnRecomendar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbTiempo;
        private System.Windows.Forms.Button btnEscogerUbicacion;
        private System.Windows.Forms.Button btnMiUbicacion;
        private System.Windows.Forms.PictureBox pbCheck;
        private System.Windows.Forms.ComboBox cbTipos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxCerrar;
        private System.Windows.Forms.PictureBox pbxBanner;
        private System.Windows.Forms.GroupBox gpbTiempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

