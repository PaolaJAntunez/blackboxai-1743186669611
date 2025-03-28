namespace Actividad_8
{
    partial class Form4
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
            this.lblNumPlanilla = new System.Windows.Forms.Label();
            this.txtNumPlanilla = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblPagoEmpleado = new System.Windows.Forms.Label();
            this.lblCodigoEmpleado = new System.Windows.Forms.Label();
            this.txtCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.nudSueldo = new System.Windows.Forms.NumericUpDown();
            this.lblExtra = new System.Windows.Forms.Label();
            this.nudExtra = new System.Windows.Forms.NumericUpDown();
            this.lblBonificacion = new System.Windows.Forms.Label();
            this.nudBonificacion = new System.Windows.Forms.NumericUpDown();
            this.lblIHSS = new System.Windows.Forms.Label();
            this.nudIHSS = new System.Windows.Forms.NumericUpDown();
            this.lblDeducciones = new System.Windows.Forms.Label();
            this.nudDeducciones = new System.Windows.Forms.NumericUpDown();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSueldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBonificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIHSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeducciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumPlanilla
            // 
            this.lblNumPlanilla.AutoSize = true;
            this.lblNumPlanilla.Location = new System.Drawing.Point(12, 15);
            this.lblNumPlanilla.Name = "lblNumPlanilla";
            this.lblNumPlanilla.Size = new System.Drawing.Size(95, 13);
            this.lblNumPlanilla.Text = "Número de planilla";
            // 
            // txtNumPlanilla
            // 
            this.txtNumPlanilla.Location = new System.Drawing.Point(15, 31);
            this.txtNumPlanilla.Name = "txtNumPlanilla";
            this.txtNumPlanilla.Size = new System.Drawing.Size(150, 20);
            this.txtNumPlanilla.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(180, 15);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(89, 13);
            this.lblFecha.Text = "Fecha de planilla";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dddd dd \'de\' MMMM \'de\' yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(183, 31);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(250, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // lblPagoEmpleado
            // 
            this.lblPagoEmpleado.AutoSize = true;
            this.lblPagoEmpleado.Location = new System.Drawing.Point(12, 65);
            this.lblPagoEmpleado.Name = "lblPagoEmpleado";
            this.lblPagoEmpleado.Size = new System.Drawing.Size(97, 13);
            this.lblPagoEmpleado.Text = "Pago de Empleado";
            // 
            // lblCodigoEmpleado
            // 
            this.lblCodigoEmpleado.AutoSize = true;
            this.lblCodigoEmpleado.Location = new System.Drawing.Point(12, 88);
            this.lblCodigoEmpleado.Name = "lblCodigoEmpleado";
            this.lblCodigoEmpleado.Size = new System.Drawing.Size(106, 13);
            this.lblCodigoEmpleado.Text = "Código del empleado";
            // 
            // txtCodigoEmpleado
            // 
            this.txtCodigoEmpleado.Location = new System.Drawing.Point(15, 104);
            this.txtCodigoEmpleado.Name = "txtCodigoEmpleado";
            this.txtCodigoEmpleado.Size = new System.Drawing.Size(150, 20);
            this.txtCodigoEmpleado.TabIndex = 2;
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(180, 88);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(40, 13);
            this.lblSueldo.Text = "Sueldo";
            // 
            // nudSueldo
            // 
            this.nudSueldo.DecimalPlaces = 2;
            this.nudSueldo.Location = new System.Drawing.Point(183, 104);
            this.nudSueldo.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.nudSueldo.Name = "nudSueldo";
            this.nudSueldo.Size = new System.Drawing.Size(120, 20);
            this.nudSueldo.TabIndex = 3;
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(12, 134);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(32, 13);
            this.lblExtra.Text = "Extra";
            // 
            // nudExtra
            // 
            this.nudExtra.DecimalPlaces = 2;
            this.nudExtra.Location = new System.Drawing.Point(15, 150);
            this.nudExtra.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            this.nudExtra.Name = "nudExtra";
            this.nudExtra.Size = new System.Drawing.Size(120, 20);
            this.nudExtra.TabIndex = 4;
            // 
            // lblBonificacion
            // 
            this.lblBonificacion.AutoSize = true;
            this.lblBonificacion.Location = new System.Drawing.Point(180, 134);
            this.lblBonificacion.Name = "lblBonificacion";
            this.lblBonificacion.Size = new System.Drawing.Size(65, 13);
            this.lblBonificacion.Text = "Bonificacion";
            // 
            // nudBonificacion
            // 
            this.nudBonificacion.DecimalPlaces = 2;
            this.nudBonificacion.Location = new System.Drawing.Point(183, 150);
            this.nudBonificacion.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            this.nudBonificacion.Name = "nudBonificacion";
            this.nudBonificacion.Size = new System.Drawing.Size(120, 20);
            this.nudBonificacion.TabIndex = 5;
            // 
            // lblIHSS
            // 
            this.lblIHSS.AutoSize = true;
            this.lblIHSS.Location = new System.Drawing.Point(313, 134);
            this.lblIHSS.Name = "lblIHSS";
            this.lblIHSS.Size = new System.Drawing.Size(31, 13);
            this.lblIHSS.Text = "IHSS";
            // 
            // nudIHSS
            // 
            this.nudIHSS.DecimalPlaces = 2;
            this.nudIHSS.Location = new System.Drawing.Point(316, 150);
            this.nudIHSS.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.nudIHSS.Name = "nudIHSS";
            this.nudIHSS.Size = new System.Drawing.Size(120, 20);
            this.nudIHSS.TabIndex = 6;
            // 
            // lblDeducciones
            // 
            this.lblDeducciones.AutoSize = true;
            this.lblDeducciones.Location = new System.Drawing.Point(12, 180);
            this.lblDeducciones.Name = "lblDeducciones";
            this.lblDeducciones.Size = new System.Drawing.Size(69, 13);
            this.lblDeducciones.Text = "Deducciones";
            // 
            // nudDeducciones
            // 
            this.nudDeducciones.DecimalPlaces = 2;
            this.nudDeducciones.Location = new System.Drawing.Point(15, 196);
            this.nudDeducciones.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            this.nudDeducciones.Name = "nudDeducciones";
            this.nudDeducciones.Size = new System.Drawing.Size(120, 20);
            this.nudDeducciones.TabIndex = 7;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(450, 31);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 50);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(450, 87);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(50, 50);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(450, 143);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnAbrir.FlatAppearance.BorderSize = 0;
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAbrir.ForeColor = System.Drawing.Color.White;
            this.btnAbrir.Location = new System.Drawing.Point(450, 199);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(50, 50);
            this.btnAbrir.TabIndex = 11;
            this.btnAbrir.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(450, 255);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 50);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(514, 321);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.nudDeducciones);
            this.Controls.Add(this.lblDeducciones);
            this.Controls.Add(this.nudIHSS);
            this.Controls.Add(this.lblIHSS);
            this.Controls.Add(this.nudBonificacion);
            this.Controls.Add(this.lblBonificacion);
            this.Controls.Add(this.nudExtra);
            this.Controls.Add(this.lblExtra);
            this.Controls.Add(this.nudSueldo);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.txtCodigoEmpleado);
            this.Controls.Add(this.lblCodigoEmpleado);
            this.Controls.Add(this.lblPagoEmpleado);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtNumPlanilla);
            this.Controls.Add(this.lblNumPlanilla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAREA - Ingreso de planilla";
            ((System.ComponentModel.ISupportInitialize)(this.nudSueldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBonificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIHSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeducciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNumPlanilla;
        private System.Windows.Forms.TextBox txtNumPlanilla;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblPagoEmpleado;
        private System.Windows.Forms.Label lblCodigoEmpleado;
        private System.Windows.Forms.TextBox txtCodigoEmpleado;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.NumericUpDown nudSueldo;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.NumericUpDown nudExtra;
        private System.Windows.Forms.Label lblBonificacion;
        private System.Windows.Forms.NumericUpDown nudBonificacion;
        private System.Windows.Forms.Label lblIHSS;
        private System.Windows.Forms.NumericUpDown nudIHSS;
        private System.Windows.Forms.Label lblDeducciones;
        private System.Windows.Forms.NumericUpDown nudDeducciones;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnSalir;
    }
}