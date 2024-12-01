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

namespace Finanzas;

public partial class razones_Liquidez : Form
{
    public razones_Liquidez()
    {
        InitializeComponent();
    }
    private void btnAtras_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {

    }

    private void lblActivoCirculante_Click(object sender, EventArgs e)
    {

    }

    private void label7_Click(object sender, EventArgs e)
    {

    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    private void label11_Click(object sender, EventArgs e)
    {

    }

    private void lblTotalRcirculante_Click(object sender, EventArgs e)
    {

    }

    private void btnRealizarOperacion_Click(object sender, EventArgs e)
    {
        lblActivoCirculante.Text = GlobalData.TotalActivoCirculante.ToString();
        lblActCirculante.Text = GlobalData.TotalActivoCirculante.ToString();
        lblActivCir.Text = GlobalData.TotalActivoCirculante.ToString();
        lblPasCirculante.Text = GlobalData.TotalPasivoCirculante.ToString();
        lblPasiCiculante.Text = GlobalData.TotalPasivoCirculante.ToString();
        lblPasivoCirculante.Text = GlobalData.TotalPasivoCirculante.ToString();
        lblInventario.Text = GlobalData.Inv.ToString();

        double RCircu = Math.Round(GlobalData.TotalActivoCirculante / 
            GlobalData.TotalPasivoCirculante  ,2);
        double PAcido = Math.Round((GlobalData.TotalActivoCirculante - GlobalData.Inv
            ) / GlobalData.TotalPasivoCirculante  ,2);
        double CapTrab = Math.Round(GlobalData.TotalActivoCirculante -
            GlobalData.TotalPasivoCirculante,2 );
        lblTptalCapTrabajo.Text = Convert.ToString(CapTrab);
        label16.Text = Convert.ToString(PAcido);
        lblTotalRcirculante.Text = Convert.ToString(RCircu);
    }

    private void razones_Liquidez_Load(object sender, EventArgs e)
    {

    }
}