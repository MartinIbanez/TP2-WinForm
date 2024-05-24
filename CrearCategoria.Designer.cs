namespace TP_2_Programacion3
{
    partial class CrearCategoria
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
            this.lblBuscarArt = new System.Windows.Forms.Label();
            this.lbDescripcionCategoria = new System.Windows.Forms.Label();
            this.txtNuevaCategoria = new System.Windows.Forms.TextBox();
            this.btnAceptarCategoría = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBuscarArt
            // 
            this.lblBuscarArt.AutoSize = true;
            this.lblBuscarArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarArt.Location = new System.Drawing.Point(64, 24);
            this.lblBuscarArt.Name = "lblBuscarArt";
            this.lblBuscarArt.Size = new System.Drawing.Size(409, 32);
            this.lblBuscarArt.TabIndex = 1;
            this.lblBuscarArt.Text = "CREAR NUEVA CATEGORIA";
            // 
            // lbDescripcionCategoria
            // 
            this.lbDescripcionCategoria.AutoSize = true;
            this.lbDescripcionCategoria.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcionCategoria.Location = new System.Drawing.Point(40, 109);
            this.lbDescripcionCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescripcionCategoria.Name = "lbDescripcionCategoria";
            this.lbDescripcionCategoria.Size = new System.Drawing.Size(125, 24);
            this.lbDescripcionCategoria.TabIndex = 2;
            this.lbDescripcionCategoria.Text = "Descripción: ";
            // 
            // txtNuevaCategoria
            // 
            this.txtNuevaCategoria.Location = new System.Drawing.Point(216, 113);
            this.txtNuevaCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtNuevaCategoria.Name = "txtNuevaCategoria";
            this.txtNuevaCategoria.Size = new System.Drawing.Size(228, 22);
            this.txtNuevaCategoria.TabIndex = 3;
            // 
            // btnAceptarCategoría
            // 
            this.btnAceptarCategoría.Location = new System.Drawing.Point(94, 224);
            this.btnAceptarCategoría.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptarCategoría.Name = "btnAceptarCategoría";
            this.btnAceptarCategoría.Size = new System.Drawing.Size(100, 28);
            this.btnAceptarCategoría.TabIndex = 5;
            this.btnAceptarCategoría.Text = "ACEPTAR";
            this.btnAceptarCategoría.UseVisualStyleBackColor = true;
            this.btnAceptarCategoría.Click += new System.EventHandler(this.btnAceptarCategoría_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(344, 224);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // CrearCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 318);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptarCategoría);
            this.Controls.Add(this.txtNuevaCategoria);
            this.Controls.Add(this.lbDescripcionCategoria);
            this.Controls.Add(this.lblBuscarArt);
            this.Name = "CrearCategoria";
            this.Text = "CrearCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarArt;
        private System.Windows.Forms.Label lbDescripcionCategoria;
        private System.Windows.Forms.TextBox txtNuevaCategoria;
        private System.Windows.Forms.Button btnAceptarCategoría;
        private System.Windows.Forms.Button btnSalir;
    }
}