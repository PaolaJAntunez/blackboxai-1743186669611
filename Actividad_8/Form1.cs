using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Actividad_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void controlDeEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 formEmpleados = new Form2();
            formEmpleados.MdiParent = this;
            formEmpleados.Show();
        }

        private void vistaGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 formVista = new Form3();
            formVista.MdiParent = this;
            formVista.Show();
        }

        private void pagosEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 formPagos = new Form4();
            formPagos.MdiParent = this;
            formPagos.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("calc.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la calculadora: " + ex.Message);
            }
        }

        private void blocNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("notepad.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el bloc de notas: " + ex.Message);
            }
        }

        private void paginaWebUSAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://www.usap.edu/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la página web: " + ex.Message);
            }
        }

        private void creditosDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "UNIVERSIDAD DE SAN PEDRO SULA - USAP\n" +
                "PROGRAMACION 1 / DMV (1P-2025)\n" +
                "ELABORADO POR PAOLA JACKELINE ANTUNEZ DUARTE (1220723)",
                "Créditos del sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Confirmar", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}