using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioSP2
{
    public partial class frmPrincipal : Form
    {
        decimal distancia = 0;
        int dias = 0;
        decimal neto = 0, descuento = 0, total = 0;

        private void txtDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            distancia = Convert.ToDecimal(txtDistancia.Text);
            dias = Convert.ToInt32(txtDias.Text);
            if (dias > 30)
            {
                MessageBox.Show("El maximo de dias es 30. Cargue un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
                neto = distancia * 5;
                if (distancia >= 100 && dias >= 7 )
                {
                    descuento = neto / 2;
                }
                total = neto - descuento;
                lblPrecioNeto.Text = "Precio Neto: $" + neto.ToString("N2");
                lblDescuento.Text = "Descuento: $" + descuento.ToString("N2");
                lblTotal.Text = "Total: $" + total.ToString("N2");
                neto = 0; descuento = 0; total = 0;
            }
        }
    }
}
