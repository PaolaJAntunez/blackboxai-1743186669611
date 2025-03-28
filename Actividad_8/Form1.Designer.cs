namespace Actividad_8
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistaGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blocNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paginaWebUSAPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditosDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlDeEmpleadoToolStripMenuItem,
            this.vistaGeneralToolStripMenuItem,
            this.pagosEmpleadoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // controlDeEmpleadoToolStripMenuItem
            // 
            this.controlDeEmpleadoToolStripMenuItem.Name = "controlDeEmpleadoToolStripMenuItem";
            this.controlDeEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.controlDeEmpleadoToolStripMenuItem.Text = "Control de empleados";
            this.controlDeEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.controlDeEmpleadoToolStripMenuItem_Click);
            // 
            // vistaGeneralToolStripMenuItem
            // 
            this.vistaGeneralToolStripMenuItem.Name = "vistaGeneralToolStripMenuItem";
            this.vistaGeneralToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vistaGeneralToolStripMenuItem.Text = "Vista general de empleado";
            this.vistaGeneralToolStripMenuItem.Click += new System.EventHandler(this.vistaGeneralToolStripMenuItem_Click);
            // 
            // pagosEmpleadoToolStripMenuItem
            // 
            this.pagosEmpleadoToolStripMenuItem.Name = "pagosEmpleadoToolStripMenuItem";
            this.pagosEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pagosEmpleadoToolStripMenuItem.Text = "Pagos por empleados";
            this.pagosEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.pagosEmpleadoToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem,
            this.blocNotasToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // blocNotasToolStripMenuItem
            // 
            this.blocNotasToolStripMenuItem.Name = "blocNotasToolStripMenuItem";
            this.blocNotasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blocNotasToolStripMenuItem.Text = "Bloc de notas";
            this.blocNotasToolStripMenuItem.Click += new System.EventHandler(this.blocNotasToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paginaWebUSAPToolStripMenuItem,
            this.creditosDelSistemaToolStripMenuItem,
            this.salirDelSistemaToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // paginaWebUSAPToolStripMenuItem
            // 
            this.paginaWebUSAPToolStripMenuItem.Name = "paginaWebUSAPToolStripMenuItem";
            this.paginaWebUSAPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paginaWebUSAPToolStripMenuItem.Text = "Página web USAP";
            this.paginaWebUSAPToolStripMenuItem.Click += new System.EventHandler(this.paginaWebUSAPToolStripMenuItem_Click);
            // 
            // creditosDelSistemaToolStripMenuItem
            // 
            this.creditosDelSistemaToolStripMenuItem.Name = "creditosDelSistemaToolStripMenuItem";
            this.creditosDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.creditosDelSistemaToolStripMenuItem.Text = "Créditos del Sistema";
            this.creditosDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.creditosDelSistemaToolStripMenuItem_Click);
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            this.salirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirDelSistemaToolStripMenuItem.Text = "Salir del Sistema";
            this.salirDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tarea - Menú";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vistaGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blocNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paginaWebUSAPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditosDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
    }
}