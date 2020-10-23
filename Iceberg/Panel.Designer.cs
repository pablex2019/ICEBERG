namespace Iceberg
{
    partial class Panel
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
            this.mnuArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNovedad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCambiarClave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuArticulo
            // 
            this.mnuArticulo.Name = "mnuArticulo";
            this.mnuArticulo.Size = new System.Drawing.Size(61, 20);
            this.mnuArticulo.Text = "Articulo";
            this.mnuArticulo.Click += new System.EventHandler(this.mnuArticulo_Click);
            // 
            // mnuCliente
            // 
            this.mnuCliente.Name = "mnuCliente";
            this.mnuCliente.Size = new System.Drawing.Size(56, 20);
            this.mnuCliente.Text = "Cliente";
            this.mnuCliente.Click += new System.EventHandler(this.mnuCliente_Click);
            // 
            // mnuEmpleado
            // 
            this.mnuEmpleado.Name = "mnuEmpleado";
            this.mnuEmpleado.Size = new System.Drawing.Size(72, 20);
            this.mnuEmpleado.Text = "Empleado";
            this.mnuEmpleado.Click += new System.EventHandler(this.mnuEmpleado_Click);
            // 
            // mnuProveedor
            // 
            this.mnuProveedor.Name = "mnuProveedor";
            this.mnuProveedor.Size = new System.Drawing.Size(73, 20);
            this.mnuProveedor.Text = "Proveedor";
            this.mnuProveedor.Click += new System.EventHandler(this.mnuProveedor_Click);
            // 
            // mnuNovedad
            // 
            this.mnuNovedad.Name = "mnuNovedad";
            this.mnuNovedad.Size = new System.Drawing.Size(67, 20);
            this.mnuNovedad.Text = "Novedad";
            this.mnuNovedad.Click += new System.EventHandler(this.mnuNovedad_Click);
            // 
            // mnuVenta
            // 
            this.mnuVenta.Name = "mnuVenta";
            this.mnuVenta.Size = new System.Drawing.Size(48, 20);
            this.mnuVenta.Text = "Venta";
            this.mnuVenta.Click += new System.EventHandler(this.mnuVenta_Click);
            // 
            // mnuCambiarClave
            // 
            this.mnuCambiarClave.Name = "mnuCambiarClave";
            this.mnuCambiarClave.Size = new System.Drawing.Size(127, 20);
            this.mnuCambiarClave.Text = "Cambiar Contraseña";
            this.mnuCambiarClave.Click += new System.EventHandler(this.mnuCambiarClave_Click);
            // 
            // mnuCerrarSesion
            // 
            this.mnuCerrarSesion.Name = "mnuCerrarSesion";
            this.mnuCerrarSesion.Size = new System.Drawing.Size(88, 20);
            this.mnuCerrarSesion.Text = "Cerrar Sesión";
            this.mnuCerrarSesion.Click += new System.EventHandler(this.mnuCerrarSesion_Click);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(41, 20);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArticulo,
            this.mnuCliente,
            this.mnuEmpleado,
            this.mnuProveedor,
            this.mnuNovedad,
            this.mnuVenta,
            this.mnuCambiarClave,
            this.mnuCerrarSesion,
            this.mnuSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(817, 331);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuArticulo;
        private System.Windows.Forms.ToolStripMenuItem mnuCliente;
        private System.Windows.Forms.ToolStripMenuItem mnuEmpleado;
        private System.Windows.Forms.ToolStripMenuItem mnuProveedor;
        private System.Windows.Forms.ToolStripMenuItem mnuNovedad;
        private System.Windows.Forms.ToolStripMenuItem mnuVenta;
        private System.Windows.Forms.ToolStripMenuItem mnuCambiarClave;
        private System.Windows.Forms.ToolStripMenuItem mnuCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}