﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ejercicios09Punto03.BL;
using Ejercicios09Punto03.DL;
using Microsoft.VisualBasic;

namespace Ejercicios09Punto03.Windows
{
    public partial class FrmRectangulos : Form
    {
        public FrmRectangulos()
        {
            InitializeComponent();
        }
        private RepositorioDeRectangulos repositorio;
        private List<Rectangulo> lista;    
        private void FrmRectangulos_Load(object sender, EventArgs e)
        {
            repositorio=new RepositorioDeRectangulos();
            
            var cantidad = repositorio.GetCantidad();
            if (cantidad==0)
            {
                MessageBox.Show("No se agregaron rectángulos todavía",
                    "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            CantidadTextBox.Enabled = false;
            CantidadTextBox.Text = cantidad.ToString();
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            lista = repositorio.GetLista();
            MostrarListaEnGrilla();
        }

        private void MostrarListaEnGrilla()
        {
            DatosDataGridView.Rows.Clear();
            foreach (var rectangulo in lista)
            {
                DataGridViewRow r = ConstruirFila();//Creo la fila en blanco
                SetearFila(r, rectangulo);//le pongo los datos
                AgregarFila(r);//lo agrego a la grilla
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Rectangulo rectangulo)
        {
            r.Cells[cmnLadoMayor.Index].Value = rectangulo.LadoMayor;
            r.Cells[cmnLadoMenor.Index].Value = rectangulo.LadoMenor;
            r.Cells[cmnPerimeto.Index].Value = rectangulo.GetPerimetro();
            r.Cells[cmnSuperficie.Index].Value = rectangulo.GetSuperficie();
            r.Tag = rectangulo;

        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r=new DataGridViewRow();
            r.CreateCells(DatosDataGridView);
            return r;
        }

        private void SalirToolStripButton_Click(object sender, EventArgs e)
        {
            //DialogResult dr = MessageBox.Show("¿Desea guardar los datos en el archivo?", "Confirmar",
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //if (dr==DialogResult.Yes)
            //{
                repositorio.GuardarDatosEnArchivo();
            //}
            Application.Exit();
        }

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            FrmRectangulosAE frm=new FrmRectangulosAE(){Text = "Agregar Rectángulo"};
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            Rectangulo rectangulo = frm.GetRectangulo();
            DataGridViewRow r = ConstruirFila();
            SetearFila(r,rectangulo);
            AgregarFila(r);
            repositorio.Agregar(rectangulo);
            ActualizarCantidadDeRegistros();
            MessageBox.Show($"Rectángulo agregado Existen {repositorio.GetCantidad()} rectángulos", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ActualizarCantidadDeRegistros()
        {
            CantidadTextBox.Text = repositorio.GetCantidad().ToString();
        }

        private void BorrarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count==0)
            {
                return;
            }

            DataGridViewRow r = DatosDataGridView.SelectedRows[0];
            Rectangulo rectangulo =r.Tag as Rectangulo;
            DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr==DialogResult.Yes)
            {
                DatosDataGridView.Rows.Remove(r);
                repositorio.Borrar(rectangulo);
                ActualizarCantidadDeRegistros();
                MessageBox.Show($"Rectángulo borrado Existen {repositorio.GetCantidad()} rectángulos", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void EditarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow r = DatosDataGridView.SelectedRows[0];
            Rectangulo rectangulo = r.Tag as Rectangulo;
            FrmRectangulosAE frm = new FrmRectangulosAE() {Text = "Editar Rectángulo"};
            frm.SetRectangulo(rectangulo);
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.OK)
            {
                rectangulo = frm.GetRectangulo();
                SetearFila(r,rectangulo);
                repositorio.EstaModificado = true;
                MessageBox.Show($"Rectángulo Editado Existen {repositorio.GetCantidad()} rectángulos", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void AscXladomayorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.OrdenarAscPorLadoMayor();
            MostrarListaEnGrilla();
        }

        private void DescXLadomayorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.OrdenarDescPorLadoMayor();
            MostrarListaEnGrilla();

        }

        private void ActualizarToolStripButton_Click(object sender, EventArgs e)
        {
           ActualizarGrilla();
        }

        private void FiltrarToolStripButton_Click(object sender, EventArgs e)
        {
            int valorFiltro = 15;
            lista = repositorio.Filtrar(valorFiltro);
            MostrarListaEnGrilla();

        }
    }
}
