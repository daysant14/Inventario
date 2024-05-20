namespace capapresentacion
{
    partial class borrarinventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(borrarinventario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.disminuir2 = new System.Windows.Forms.PictureBox();
            this.aumentar2 = new System.Windows.Forms.PictureBox();
            this.btnborrar = new System.Windows.Forms.PictureBox();
            this.btnocultar = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.borrarcliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disminuir2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aumentar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnborrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnocultar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.disminuir2);
            this.panel1.Controls.Add(this.aumentar2);
            this.panel1.Controls.Add(this.btnborrar);
            this.panel1.Controls.Add(this.btnocultar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 34);
            this.panel1.TabIndex = 34;
            // 
            // disminuir2
            // 
            this.disminuir2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.disminuir2.Image = ((System.Drawing.Image)(resources.GetObject("disminuir2.Image")));
            this.disminuir2.Location = new System.Drawing.Point(385, 3);
            this.disminuir2.Name = "disminuir2";
            this.disminuir2.Size = new System.Drawing.Size(25, 25);
            this.disminuir2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.disminuir2.TabIndex = 7;
            this.disminuir2.TabStop = false;
            this.disminuir2.Click += new System.EventHandler(this.disminuir1_Click);
            // 
            // aumentar2
            // 
            this.aumentar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aumentar2.Image = ((System.Drawing.Image)(resources.GetObject("aumentar2.Image")));
            this.aumentar2.Location = new System.Drawing.Point(385, 3);
            this.aumentar2.Name = "aumentar2";
            this.aumentar2.Size = new System.Drawing.Size(25, 25);
            this.aumentar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aumentar2.TabIndex = 6;
            this.aumentar2.TabStop = false;
            this.aumentar2.Click += new System.EventHandler(this.aumentar2_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnborrar.Image = ((System.Drawing.Image)(resources.GetObject("btnborrar.Image")));
            this.btnborrar.Location = new System.Drawing.Point(416, 3);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(25, 25);
            this.btnborrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnborrar.TabIndex = 5;
            this.btnborrar.TabStop = false;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnocultar
            // 
            this.btnocultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnocultar.Image = ((System.Drawing.Image)(resources.GetObject("btnocultar.Image")));
            this.btnocultar.Location = new System.Drawing.Point(354, 3);
            this.btnocultar.Name = "btnocultar";
            this.btnocultar.Size = new System.Drawing.Size(25, 25);
            this.btnocultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnocultar.TabIndex = 4;
            this.btnocultar.TabStop = false;
            this.btnocultar.Click += new System.EventHandler(this.btnocultar_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(323, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 27);
            this.button1.TabIndex = 35;
            this.button1.Text = "Borrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // borrarcliente
            // 
            this.borrarcliente.Location = new System.Drawing.Point(73, 133);
            this.borrarcliente.Name = "borrarcliente";
            this.borrarcliente.Size = new System.Drawing.Size(306, 22);
            this.borrarcliente.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Ingrese el id del clinte que desea borrar";
            // 
            // borrarinventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(443, 270);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.borrarcliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "borrarinventario";
            this.Text = "borrarinventario";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.disminuir2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aumentar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnborrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnocultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox disminuir2;
        private System.Windows.Forms.PictureBox aumentar2;
        private System.Windows.Forms.PictureBox btnborrar;
        private System.Windows.Forms.PictureBox btnocultar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox borrarcliente;
        private System.Windows.Forms.Label label1;
    }
}