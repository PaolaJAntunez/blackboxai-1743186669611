using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Actividad_8
{
    public partial class Form2 : Form
    {
        private OleDbConnection conn;
        private string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\EMPRESA.mdb";

        public Form2()
        {
            InitializeComponent();
            conn = new OleDbConnection(connectionString);
            CargarCombos();
        }

        private void CargarCombos()
        {
            // Cargar Género
            cboGenero.Items.AddRange(new string[] { "Masculino", "Femenino" });
            
            // Cargar Nacionalidad
            cboNacionalidad.Items.AddRange(new string[] { "Hondureña", "Extranjera" });
            
            // Cargar Estado Civil
            cboEstadoCivil.Items.AddRange(new string[] { "Soltero", "Casado", "Divorciado", "Viudo" });
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbCommand cmd = new OleDbCommand(
                    "INSERT INTO EMPLEADO (COD, NOM, DIR, NAC, ESC, GEB, OBS) VALUES (?, ?, ?, ?, ?, ?, ?)", conn))
                {
                    cmd.Parameters.AddWithValue("?", txtCodigo.Text);
                    cmd.Parameters.AddWithValue("?", txtNombre.Text + " " + txtApellido.Text);
                    cmd.Parameters.AddWithValue("?", txtDireccion.Text);
                    cmd.Parameters.AddWithValue("?", cboNacionalidad.Text);
                    cmd.Parameters.AddWithValue("?", cboEstadoCivil.Text);
                    cmd.Parameters.AddWithValue("?", cboGenero.Text);
                    cmd.Parameters.AddWithValue("?", txtObservacion.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Empleado guardado exitosamente!");
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM EMPLEADO WHERE COD = ?", conn))
                {
                    cmd.Parameters.AddWithValue("?", txtCodigo.Text);
                    conn.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    
                    if (reader.Read())
                    {
                        string nombreCompleto = reader["NOM"].ToString();
                        string[] nombres = nombreCompleto.Split(new char[] { ' ' }, 2);
                        txtNombre.Text = nombres.Length > 0 ? nombres[0] : "";
                        txtApellido.Text = nombres.Length > 1 ? nombres[1] : "";
                        txtDireccion.Text = reader["DIR"].ToString();
                        cboGenero.Text = reader["GEB"].ToString();
                        cboNacionalidad.Text = reader["NAC"].ToString();
                        cboEstadoCivil.Text = reader["ESC"].ToString();
                        txtObservacion.Text = reader["OBS"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Empleado no encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro de eliminar este empleado?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (OleDbCommand cmd = new OleDbCommand("DELETE FROM EMPLEADO WHERE COD = ?", conn))
                    {
                        cmd.Parameters.AddWithValue("?", txtCodigo.Text);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Empleado eliminado exitosamente!");
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Form3 vistaForm = new Form3();
            vistaForm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            cboGenero.SelectedIndex = -1;
            cboNacionalidad.SelectedIndex = -1;
            cboEstadoCivil.SelectedIndex = -1;
            txtObservacion.Clear();
        }
    }
}