namespace capapresentacion
{
    partial class Loguin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loguin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.barraloguin = new System.Windows.Forms.Panel();
            this.botonrestaurar = new System.Windows.Forms.PictureBox();
            this.btnmaximizar = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.botondeacceso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.barraloguin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(508, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(495, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(627, 401);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(133, 22);
            this.contraseña.TabIndex = 3;
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(627, 371);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(133, 22);
            this.usuario.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(583, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // barraloguin
            // 
            this.barraloguin.BackColor = System.Drawing.Color.Lime;
            this.barraloguin.Controls.Add(this.botonrestaurar);
            this.barraloguin.Controls.Add(this.btnmaximizar);
            this.barraloguin.Controls.Add(this.pictureBox6);
            this.barraloguin.Controls.Add(this.pictureBox7);
            this.barraloguin.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraloguin.Location = new System.Drawing.Point(0, 0);
            this.barraloguin.Name = "barraloguin";
            this.barraloguin.Size = new System.Drawing.Size(1300, 35);
            this.barraloguin.TabIndex = 6;
            this.barraloguin.Paint += new System.Windows.Forms.PaintEventHandler(this.barraloguin_Paint);
            // 
            // botonrestaurar
            // 
            this.botonrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonrestaurar.Image = ((System.Drawing.Image)(resources.GetObject("botonrestaurar.Image")));
            this.botonrestaurar.Location = new System.Drawing.Point(1241, 7);
            this.botonrestaurar.Name = "botonrestaurar";
            this.botonrestaurar.Size = new System.Drawing.Size(25, 25);
            this.botonrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botonrestaurar.TabIndex = 6;
            this.botonrestaurar.TabStop = false;
            this.botonrestaurar.Click += new System.EventHandler(this.botonrestaurar_Click);
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnmaximizar.Image")));
            this.btnmaximizar.Location = new System.Drawing.Point(1241, 7);
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnmaximizar.TabIndex = 5;
            this.btnmaximizar.TabStop = false;
            this.btnmaximizar.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1272, 7);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(1210, 7);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(25, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 3;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // botondeacceso
            // 
            this.botondeacceso.Location = new System.Drawing.Point(679, 429);
            this.botondeacceso.Name = "botondeacceso";
            this.botondeacceso.Size = new System.Drawing.Size(81, 26);
            this.botondeacceso.TabIndex = 7;
            this.botondeacceso.Text = "Loguin";
            this.botondeacceso.UseVisualStyleBackColor = true;
            this.botondeacceso.Click += new System.EventHandler(this.botondeacceso_Click);
            // 
            // Loguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.botondeacceso);
            this.Controls.Add(this.barraloguin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loguin";
            this.Text = ".";
            this.Load += new System.EventHandler(this.p_inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.barraloguin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.botonrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel barraloguin;
        private System.Windows.Forms.Button botondeacceso;
        private System.Windows.Forms.PictureBox btnmaximizar;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox botonrestaurar;
    }
}

