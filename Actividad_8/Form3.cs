using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Actividad_8
{
    public partial class Form3 : Form
    {
        private OleDbConnection conn;
        private string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\EMPRESA.mdb";

        public Form3()
        {
            InitializeComponent();
            conn = new OleDbConnection(connectionString);
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                using (OleDbCommand cmd = new OleDbCommand(
                    "SELECT COD, NOM, DIR, NAC, ESC, GEB FROM EMPLEADO", conn))
                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    // Configurar las columnas del DataGridView
                    dataGridView1.Columns["COD"].HeaderText = "Código";
                    dataGridView1.Columns["NOM"].HeaderText = "Nombre completo";
                    dataGridView1.Columns["DIR"].HeaderText = "Dirección";
                    dataGridView1.Columns["NAC"].HeaderText = "Nacionalidad";
                    dataGridView1.Columns["ESC"].HeaderText = "Estado Civil";
                    dataGridView1.Columns["GEB"].HeaderText = "Género";

                    // Ajustar el ancho de las columnas
                    dataGridView1.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Configuración inicial del DataGridView
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;

                // Copiar los encabezados
                for (int i = 1; i <= dataGridView1.Columns.Count; i++)
                {
                    sheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                // Copiar los datos
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        sheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // Ajustar columnas
                sheet.Columns.AutoFit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar a Excel: " + ex.Message);
            }
        }
    }
}