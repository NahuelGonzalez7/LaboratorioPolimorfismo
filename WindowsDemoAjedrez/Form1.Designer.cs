
namespace WindowsDemoAjedrez
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
            this.btnCrearInstancias = new System.Windows.Forms.Button();
            this.btnInstanciasTransporte = new System.Windows.Forms.Button();
            this.btnCrearAnimales = new System.Windows.Forms.Button();
            this.btnCrearInstanciaCuenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearInstancias
            // 
            this.btnCrearInstancias.Location = new System.Drawing.Point(12, 12);
            this.btnCrearInstancias.Name = "btnCrearInstancias";
            this.btnCrearInstancias.Size = new System.Drawing.Size(160, 23);
            this.btnCrearInstancias.TabIndex = 0;
            this.btnCrearInstancias.Text = "Crear Instancias";
            this.btnCrearInstancias.UseVisualStyleBackColor = true;
            this.btnCrearInstancias.Click += new System.EventHandler(this.btnCrearInstancias_Click);
            // 
            // btnInstanciasTransporte
            // 
            this.btnInstanciasTransporte.Location = new System.Drawing.Point(178, 12);
            this.btnInstanciasTransporte.Name = "btnInstanciasTransporte";
            this.btnInstanciasTransporte.Size = new System.Drawing.Size(159, 23);
            this.btnInstanciasTransporte.TabIndex = 1;
            this.btnInstanciasTransporte.Text = "Crear Instancias Transporte";
            this.btnInstanciasTransporte.UseVisualStyleBackColor = true;
            this.btnInstanciasTransporte.Click += new System.EventHandler(this.btnInstanciasTransporte_Click);
            // 
            // btnCrearAnimales
            // 
            this.btnCrearAnimales.Location = new System.Drawing.Point(12, 41);
            this.btnCrearAnimales.Name = "btnCrearAnimales";
            this.btnCrearAnimales.Size = new System.Drawing.Size(159, 23);
            this.btnCrearAnimales.TabIndex = 2;
            this.btnCrearAnimales.Text = "Crear Instancias Animales";
            this.btnCrearAnimales.UseVisualStyleBackColor = true;
            this.btnCrearAnimales.Click += new System.EventHandler(this.btnCrearAnimales_Click);
            // 
            // btnCrearInstanciaCuenta
            // 
            this.btnCrearInstanciaCuenta.Location = new System.Drawing.Point(178, 41);
            this.btnCrearInstanciaCuenta.Name = "btnCrearInstanciaCuenta";
            this.btnCrearInstanciaCuenta.Size = new System.Drawing.Size(159, 23);
            this.btnCrearInstanciaCuenta.TabIndex = 3;
            this.btnCrearInstanciaCuenta.Text = "Crear Instancia Cuenta";
            this.btnCrearInstanciaCuenta.UseVisualStyleBackColor = true;
            this.btnCrearInstanciaCuenta.Click += new System.EventHandler(this.btnCrearInstanciaCuenta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 309);
            this.Controls.Add(this.btnCrearInstanciaCuenta);
            this.Controls.Add(this.btnCrearAnimales);
            this.Controls.Add(this.btnInstanciasTransporte);
            this.Controls.Add(this.btnCrearInstancias);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearInstancias;
        private System.Windows.Forms.Button btnInstanciasTransporte;
        private System.Windows.Forms.Button btnCrearAnimales;
        private System.Windows.Forms.Button btnCrearInstanciaCuenta;
    }
}

