using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ejercicios09Punto03.BL;
using Ejercicios09Punto03.DL;

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

        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r=new DataGridViewRow();
            r.CreateCells(DatosDataGridView);
            return r;
        }
    }
}
