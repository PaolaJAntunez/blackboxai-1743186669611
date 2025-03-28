using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Actividad_8
{
    public partial class Form4 : Form
    {
        private OleDbConnection conn;
        private string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\EMPRESA.mdb";

        public Form4()
        {
            InitializeComponent();
            conn = new OleDbConnection(connectionString);
            ConfigurarControles();
            PersonalizarDiseno();
        }

        private void PersonalizarDiseno()
        {
            // Configurar el formulario
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.Font = new Font("Segoe UI", 9F);

            // Configurar los botones
            ConfigurarBoton(btnNuevo, Color.FromArgb(92, 184, 92), "➕ Nuevo");
            ConfigurarBoton(btnGuardar, Color.FromArgb(91, 192, 222), "💾 Guardar");
            ConfigurarBoton(btnCancelar, Color.FromArgb(217, 83, 79), "❌ Cancelar");
            ConfigurarBoton(btnAbrir, Color.FromArgb(92, 184, 92), "📂 Abrir");
            ConfigurarBoton(btnSalir, Color.FromArgb(217, 83, 79), "🚪 Salir");

            // Configurar los NumericUpDown
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)ctrl;
                    nud.BorderStyle = BorderStyle.FixedSingle;
                    nud.Font = new Font("Segoe UI", 10F);
                }
                else if (ctrl is TextBox)
                {
                    TextBox txt = (TextBox)ctrl;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.Font = new Font("Segoe UI", 10F);
                }
                else if (ctrl is Label)
                {
                    Label lbl = (Label)ctrl;
                    lbl.Font = new Font("Segoe UI", 9F);
                    lbl.ForeColor = Color.FromArgb(64, 64, 64);
                }
            }

            // Configurar DateTimePicker
            dtpFecha.Font = new Font("Segoe UI", 10F);
        }

        private void ConfigurarBoton(Button btn, Color color, string texto)
        {
            btn.BackColor = color;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Size = new Size(100, 40);
            btn.Text = texto;
            btn.Font = new Font("Segoe UI", 9F);
            btn.TextAlign = ContentAlignment.MiddleCenter;

            // Agregar efecto hover
            btn.MouseEnter += (s, e) => {
                btn.BackColor = ControlPaint.Light(color);
            };
            btn.MouseLeave += (s, e) => {
                btn.BackColor = color;
            };
        }

        private void ConfigurarControles()
        {
            // Configurar el DateTimePicker
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "dddd dd 'de' MMMM 'de' yyyy";
            dtpFecha.Value = DateTime.Now;

            // Configurar los NumericUpDown
            ConfigurarNumericUpDown(nudSueldo, 100000);
            ConfigurarNumericUpDown(nudExtra, 50000);
            ConfigurarNumericUpDown(nudBonificacion, 50000);
            ConfigurarNumericUpDown(nudIHSS, 10000);
            ConfigurarNumericUpDown(nudDeducciones, 50000);
        }

        private void ConfigurarNumericUpDown(NumericUpDown nud, decimal maxValue)
        {
            nud.Minimum = 0;
            nud.Maximum = maxValue;
            nud.DecimalPlaces = 2;
            nud.ThousandsSeparator = true;
            nud.Value = 0;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNumPlanilla.Text) || string.IsNullOrEmpty(txtCodigoEmpleado.Text))
                {
                    MessageBox.Show("Por favor complete los campos requeridos.");
                    return;
                }

                using (OleDbCommand cmd = new OleDbCommand(
                    "INSERT INTO PLANILLA (NUMP, FECP, COD, SUE, EXT, BON, IHSS, DED) VALUES (?, ?, ?, ?, ?, ?, ?, ?)", conn))
                {
                    cmd.Parameters.AddWithValue("?", txtNumPlanilla.Text);
                    cmd.Parameters.AddWithValue("?", dtpFecha.Value);
                    cmd.Parameters.AddWithValue("?", txtCodigoEmpleado.Text);
                    cmd.Parameters.AddWithValue("?", nudSueldo.Value);
                    cmd.Parameters.AddWithValue("?", nudExtra.Value);
                    cmd.Parameters.AddWithValue("?", nudBonificacion.Value);
                    cmd.Parameters.AddWithValue("?", nudIHSS.Value);
                    cmd.Parameters.AddWithValue("?", nudDeducciones.Value);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Planilla guardada exitosamente!");
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la planilla: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM PLANILLA WHERE NUMP = ?", conn))
                {
                    cmd.Parameters.AddWithValue("?", txtNumPlanilla.Text);
                    conn.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        dtpFecha.Value = Convert.ToDateTime(reader["FECP"]);
                        txtCodigoEmpleado.Text = reader["COD"].ToString();
                        nudSueldo.Value = Convert.ToDecimal(reader["SUE"]);
                        nudExtra.Value = Convert.ToDecimal(reader["EXT"]);
                        nudBonificacion.Value = Convert.ToDecimal(reader["BON"]);
                        nudIHSS.Value = Convert.ToDecimal(reader["IHSS"]);
                        nudDeducciones.Value = Convert.ToDecimal(reader["DED"]);
                    }
                    else
                    {
                        MessageBox.Show("Planilla no encontrada.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la planilla: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            txtNumPlanilla.Clear();
            dtpFecha.Value = DateTime.Now;
            txtCodigoEmpleado.Clear();
            nudSueldo.Value = 0;
            nudExtra.Value = 0;
            nudBonificacion.Value = 0;
            nudIHSS.Value = 0;
            nudDeducciones.Value = 0;
        }

        private void txtCodigoEmpleado_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoEmpleado.Text))
            {
                try
                {
                    using (OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM EMPLEADO WHERE COD = ?", conn))
                    {
                        cmd.Parameters.AddWithValue("?", txtCodigoEmpleado.Text);
                        conn.Open();
                        int count = (int)cmd.ExecuteScalar();
                        if (count == 0)
                        {
                            MessageBox.Show("El código de empleado no existe.");
                            txtCodigoEmpleado.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar empleado: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}