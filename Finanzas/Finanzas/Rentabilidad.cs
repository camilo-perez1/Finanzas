using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finanzas
{
    public partial class Rentabilidad : Form
    {
        public Rentabilidad()
        {
            InitializeComponent();
        }

        private void btnRealizarOperacion_Click(object sender, EventArgs e)
        {
            lblVentas.Text = Estado_de_Resultado.GlobalData2.VNCredito.ToString();
            lblCostoVentas.Text = Estado_de_Resultado.GlobalData2.CBVendidos.ToString();
            lblVent1.Text = Estado_de_Resultado.GlobalData2.VNCredito.ToString();
            lblUO.Text = Estado_de_Resultado.GlobalData2.UO.ToString();
            lblVentas2.Text = Estado_de_Resultado.GlobalData2.VNCredito.ToString();
            lblUNDI.Text = Estado_de_Resultado.GlobalData2.UNDI.ToString();
            lblVEntas3.Text = Estado_de_Resultado.GlobalData2.VNCredito.ToString();

            double MUB = Math.Round((Estado_de_Resultado.GlobalData2.VNCredito - 
                Estado_de_Resultado.GlobalData2.CBVendidos)  / Estado_de_Resultado.GlobalData2.VNCredito, 2);
            double MOP = Math.Round(Estado_de_Resultado.GlobalData2.UO  / 
                Estado_de_Resultado.GlobalData2.VNCredito, 2);
            double MUN = Math.Round(  Estado_de_Resultado.GlobalData2.UNDI /
                Estado_de_Resultado.GlobalData2.VNCredito   , 2);

            lblMArgenUB.Text = Convert.ToString(MUB);
            lblMArgenUO.Text = Convert.ToString(MOP);
            lblMArgenUN.Text = Convert.ToString(MUN);

        }
    }
}
