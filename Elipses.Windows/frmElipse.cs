using System;
using System.Collections.Generic;
using System.ComponentModel;
using Elipses.Datos;
using Elipses.Entidades;

namespace Elipses.Windows
{
    public partial class frmElipse : Form
    {
        private RepositorioElipses? repo;
        private List<Elipse>? listaElipse;
        private int cantidadElipse;
        public frmElipse()
        {
            repo = new RepositorioElipses();
            InitializeComponent();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmElipseAE frm = new frmElipseAE(repo!) { Text = "Nuevo Producto" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            Elipse elipseIngresado = frm.GetElipse();
            if (elipseIngresado is null)
            {
                return;
            }
            repo!.Agregar(elipseIngresado);
            var r = ConstruirFila(dgvDatos);
            SetearFila(r, elipseIngresado);
            AgregarFila(r, dgvDatos);
            cantidadElipse = repo!.GetCantidad();
            MostrarTotales();
            MessageBox.Show("Producto Agregado!!", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MostrarTotales()
        {
            txtCantidad.Text = cantidadElipse.ToString();
        }

        private void AgregarFila(DataGridViewRow r, DataGridView dgv)
        {
            dgv.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Elipse elipse)
        {
            r.Cells[ColLadoMayor.Index].Value = elipse.SemiejeMayor;
            r.Cells[ColLadoMenor.Index].Value = elipse.SemiejeMenor;
            r.Cells[ColColor.Index].Value = elipse.Color;
            r.Cells[ColBorde.Index].Value = elipse.Borde;

        }

        private object ConstruirFila(DataGridView dgv)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgv);
            return r; ;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            repo!.GuardarDatos();
            Application.Exit();
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var rSeleccionada = dgvDatos.SelectedRows[0];
            Elipse productoBorrar = (Elipse)rSeleccionada.Tag!;
            DialogResult dr = MessageBox.Show($"¿Desea borrar al producto {productoBorrar.Color} de la lista?",
                "Comfirmar Borrado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            repo!.Borrar(productoBorrar);
            QuitarFila(rSeleccionada, dgvDatos);
            cantidadElipse = repo!.GetCantidad();
            MostrarTotales();
            MessageBox.Show("Registro Eliminado!!", "Mensaje",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void QuitarFila(DataGridViewRow r, DataGridView dgv)
        {
            dgv.Rows.Remove(r);
        }

        private void frmElipse_Load(object sender, EventArgs e)
        {

        }
    }
}
