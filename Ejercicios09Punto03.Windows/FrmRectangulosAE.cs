using System;
using System.Windows.Forms;
using Ejercicios09Punto03.BL;

namespace Ejercicios09Punto03.Windows
{
    public partial class FrmRectangulosAE : Form
    {
        public FrmRectangulosAE()
        {
            InitializeComponent();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private Rectangulo rectangulo;
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (rectangulo == null)
                {
                    rectangulo = new Rectangulo();

                }
                rectangulo.LadoMayor = int.Parse(LadoMayorTextBox.Text);
                rectangulo.LadoMenor = int.Parse(LadoMenorTextBox.Text);
                DialogResult = DialogResult.OK;

            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(LadoMayorTextBox.Text, out int lMayor))
            {
                valido = false;
                errorProvider1.SetError(LadoMayorTextBox, "Lado mal ingresado");
            }
            else if (lMayor <= 0)
            {
                valido = false;
                errorProvider1.SetError(LadoMayorTextBox, "Lado no válido");
            }
            if (!int.TryParse(LadoMenorTextBox.Text, out int lMenor))
            {
                valido = false;
                errorProvider1.SetError(LadoMenorTextBox, "Lado mal ingresado");
            }
            else if (lMenor <= 0)
            {
                valido = false;
                errorProvider1.SetError(LadoMenorTextBox, "Lado no válido");
            }
            else if (lMenor >= lMayor)
            {
                valido = false;
                errorProvider1.SetError(LadoMenorTextBox, "Lado menor mayor o igual al lado mayor");

            }


            return valido;
        }

        public Rectangulo GetRectangulo()
        {
            return rectangulo;
        }

        public void SetRectangulo(Rectangulo rectangulo)
        {
            this.rectangulo = rectangulo;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (rectangulo != null)
            {
                LadoMayorTextBox.Text = rectangulo.LadoMayor.ToString();
                LadoMenorTextBox.Text = rectangulo.LadoMenor.ToString();
            }
        }
    }
}
