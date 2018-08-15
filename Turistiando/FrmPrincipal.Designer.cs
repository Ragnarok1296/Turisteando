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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbxCerrar = new System.Windows.Forms.PictureBox();
            this.tbxTiempo = new System.Windows.Forms.TextBox();
            this.btnRecomendar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbTiempo = new System.Windows.Forms.ComboBox();
            this.btnEscogerUbicacion = new System.Windows.Forms.Button();
            this.btnMiUbicacion = new System.Windows.Forms.Button();
            this.pbCheck = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 50);
            this.label1.TabIndex = 17;
            this.label1.Text = "TURISTEANDO - ANDO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbxCerrar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 65);
            this.panel1.TabIndex = 49;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Teal;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(27, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pbxCerrar
            // 
            this.pbxCerrar.BackColor = System.Drawing.Color.Teal;
            this.pbxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbxCerrar.Image")));
            this.pbxCerrar.Location = new System.Drawing.Point(756, 12);
            this.pbxCerrar.Name = "pbxCerrar";
            this.pbxCerrar.Size = new System.Drawing.Size(32, 32);
            this.pbxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxCerrar.TabIndex = 15;
            this.pbxCerrar.TabStop = false;
            this.pbxCerrar.Click += new System.EventHandler(this.pbxCerrar_Click);
            // 
            // tbxTiempo
            // 
            this.tbxTiempo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTiempo.Location = new System.Drawing.Point(259, 129);
            this.tbxTiempo.Multiline = true;
            this.tbxTiempo.Name = "tbxTiempo";
            this.tbxTiempo.Size = new System.Drawing.Size(213, 29);
            this.tbxTiempo.TabIndex = 53;
            // 
            // btnRecomendar
            // 
            this.btnRecomendar.BackColor = System.Drawing.Color.Teal;
            this.btnRecomendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecomendar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecomendar.ForeColor = System.Drawing.Color.White;
            this.btnRecomendar.Location = new System.Drawing.Point(339, 315);
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
            this.cbTiempo.Location = new System.Drawing.Point(488, 129);
            this.cbTiempo.Name = "cbTiempo";
            this.cbTiempo.Size = new System.Drawing.Size(121, 29);
            this.cbTiempo.TabIndex = 56;
            // 
            // btnEscogerUbicacion
            // 
            this.btnEscogerUbicacion.BackColor = System.Drawing.Color.SlateGray;
            this.btnEscogerUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscogerUbicacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscogerUbicacion.ForeColor = System.Drawing.Color.White;
            this.btnEscogerUbicacion.Location = new System.Drawing.Point(259, 209);
            this.btnEscogerUbicacion.Name = "btnEscogerUbicacion";
            this.btnEscogerUbicacion.Size = new System.Drawing.Size(150, 50);
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
            this.btnMiUbicacion.Location = new System.Drawing.Point(415, 209);
            this.btnMiUbicacion.Name = "btnMiUbicacion";
            this.btnMiUbicacion.Size = new System.Drawing.Size(150, 50);
            this.btnMiUbicacion.TabIndex = 58;
            this.btnMiUbicacion.Text = "Mi ubicación";
            this.btnMiUbicacion.UseVisualStyleBackColor = false;
            this.btnMiUbicacion.Click += new System.EventHandler(this.btnMiUbicacion_Click);
            // 
            // pbCheck
            // 
            this.pbCheck.Image = global::Turistiando.Properties.Resources.success;
            this.pbCheck.Location = new System.Drawing.Point(571, 209);
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
            this.pictureBox1.Location = new System.Drawing.Point(178, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(178, 209);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.pbCheck);
            this.Controls.Add(this.btnMiUbicacion);
            this.Controls.Add(this.btnEscogerUbicacion);
            this.Controls.Add(this.cbTiempo);
            this.Controls.Add(this.btnRecomendar);
            this.Controls.Add(this.tbxTiempo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbxTiempo;
        private System.Windows.Forms.Button btnRecomendar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cbTiempo;
        private System.Windows.Forms.Button btnEscogerUbicacion;
        private System.Windows.Forms.Button btnMiUbicacion;
        private System.Windows.Forms.PictureBox pbCheck;
    }
}

