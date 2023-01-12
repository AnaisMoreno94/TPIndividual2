namespace TPIWindows
{
    partial class Form1
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
            this.btnMostrarAvionCarga = new System.Windows.Forms.Button();
            this.btnMostrarAvionComercial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrarAvionCarga
            // 
            this.btnMostrarAvionCarga.Location = new System.Drawing.Point(103, 71);
            this.btnMostrarAvionCarga.Name = "btnMostrarAvionCarga";
            this.btnMostrarAvionCarga.Size = new System.Drawing.Size(178, 30);
            this.btnMostrarAvionCarga.TabIndex = 0;
            this.btnMostrarAvionCarga.Text = "Mostrar Avion de Carga";
            this.btnMostrarAvionCarga.UseVisualStyleBackColor = true;
            this.btnMostrarAvionCarga.Click += new System.EventHandler(this.btnMostrarAvionCarga_Click);
            // 
            // btnMostrarAvionComercial
            // 
            this.btnMostrarAvionComercial.Location = new System.Drawing.Point(494, 71);
            this.btnMostrarAvionComercial.Name = "btnMostrarAvionComercial";
            this.btnMostrarAvionComercial.Size = new System.Drawing.Size(178, 23);
            this.btnMostrarAvionComercial.TabIndex = 1;
            this.btnMostrarAvionComercial.Text = "Mostrar Avion Comercial";
            this.btnMostrarAvionComercial.UseVisualStyleBackColor = true;
            this.btnMostrarAvionComercial.Click += new System.EventHandler(this.btnMostrarAvionComercial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarAvionComercial);
            this.Controls.Add(this.btnMostrarAvionCarga);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarAvionCarga;
        private System.Windows.Forms.Button btnMostrarAvionComercial;
    }
}

