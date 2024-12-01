using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Finanzas.Form2;

namespace Finanzas
{
    public partial class Actividad : Form
    {
        public Actividad()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnRealizarOperacion_Click(object sender, EventArgs e)
        {
            lblCBVendidos.Text = Estado_de_Resultado.GlobalData2.CBVendidos.ToString();
            lblInv.Text = GlobalData.Inv.ToString();
            lblVNCredito.Text = Estado_de_Resultado.GlobalData2.VNCredito.ToString();
            lblCxC.Text = GlobalData.CxC.ToString();
            lblCuentasxC.Text = GlobalData.CxC.ToString();
            lblVentasPordia.Text = Convert.ToString(Estado_de_Resultado.GlobalData2.VNCredito /365);
            lblVentas.Text = Estado_de_Resultado.GlobalData2.VNCredito.ToString();
            lblActivosFijos.Text = GlobalData.ActivosFijios.ToString();
            lblvnc.Text = Estado_de_Resultado.GlobalData2.VNCredito.ToString();
            lblactivostotales.Text = GlobalData.ActivosTotales.ToString();


            double RotActT = Math.Round( Estado_de_Resultado.GlobalData2.VNCredito / 
                GlobalData.ActivosTotales  , 2);
            double RotCxC = Math.Round(Estado_de_Resultado.GlobalData2.VNCredito /
                GlobalData.CxC, 2);
            double RotInv = Math.Round(Estado_de_Resultado.GlobalData2.CBVendidos /
                GlobalData.Inv, 2);
            double PPC = Math.Round( GlobalData.CxC / 
                (Estado_de_Resultado.GlobalData2.VNCredito / 365)  , 2);
            double RAF = Math.Round( Estado_de_Resultado.GlobalData2.VNCredito / 
                GlobalData.ActivosFijios  ,2);

            lbltotalRotacttotales.Text = Convert.ToString(RotActT);
            lbltotalRotacionActivoFijo.Text = Convert.ToString(RAF);
            lbltotalPPC.Text = Convert.ToString(PPC);
            lbltotalRotInv.Text = Convert.ToString(RotInv); 
            lblTotalRotCxC.Text = Convert.ToString(RotCxC);
            
        }
    }
}
