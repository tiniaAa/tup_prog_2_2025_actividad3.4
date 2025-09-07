using Ej1.Models;
using System.Collections;

namespace Ej1
{
    public partial class Form1 : Form
    {
        ArrayList figuras = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnActualizarListado_Click(object sender, EventArgs e)
        {
            lbDescribir.Items.Clear();
            for (int n = 0; n < figuras.Count; n++)
            {
                lbDescribir.Items.Add(figuras[n]);
            }
        }

        private void btnCrearFigura_Click(object sender, EventArgs e)
        {
            Figura nueva = null;

            if (rdbCilindro.Checked == true)
            {
                double radio = Convert.ToDouble(tbRadioCIL.Text);
                double alto = Convert.ToDouble(tbAltoCIL.Text);

                nueva = new Cilidro(radio, alto);
            }
            else if (rdbtnOrtoedro.Checked == true)
            {
                double Ancho = Convert.ToDouble(tbAnchoOR.Text);
                double Alto = Convert.ToDouble(tbAltoOR.Text);
                double Largo = Convert.ToDouble(tbLargoOR.Text);

                nueva = new Ortoedro(Ancho, Alto, Largo);
            }

            if (nueva != null)
            {
                figuras.Add(nueva);


            }
            else { MessageBox.Show("Seleccione una figura"); }

            tbAltoCIL.Clear();
            tbAnchoOR.Clear();
            tbAltoOR.Clear();
            tbLargoOR.Clear();
            tbRadioCIL.Clear();
            rdbCilindro.Checked = false;
            rdbtnOrtoedro.Checked = false;




        }

        private void btnMostrarMasDatos_Click(object sender, EventArgs e)
        {
            Figura select = lbDescribir.SelectedItem as Figura;
            if (select != null)
            {
                lbMostrarMas.Text = "";
                lbMostrarMas.Text = select.Describir();

            }
            else { MessageBox.Show("No se a seleccionado una figura "); }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            figuras.Sort();
        }
    }
}
