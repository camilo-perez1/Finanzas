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
    public partial class Endeudamiento : Form
    {
        public Endeudamiento()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnRealizarOperacion_Click(object sender, EventArgs e)
        {
            lblpastotales.Text = Form2.GlobalData.PasivosTotales.ToString();
            lblacttotales.Text = Form2.GlobalData.ActivosTotales.ToString();
            lblPasivosLP.Text = Form2.GlobalData.pasivolP.ToString();
            lblUtilidadAntesintereses.Text = Estado_de_Resultado.GlobalData2.uai.ToString();
            lblCargosPorIntereses.Text = Convert.ToString(Estado_de_Resultado.GlobalData2.gi );
            lblCapitalSocial.Text = Form2.GlobalData.GR.ToString();

            double RPC = Math.Round( Form2.GlobalData.pasivolP / Form2.GlobalData.GR   , 2);
            double RDT = Math.Round(Form2.GlobalData.PasivosTotales / Form2.GlobalData.ActivosTotales , 2);
            double RIU = Math.Round(Estado_de_Resultado.GlobalData2.uai / 
                Estado_de_Resultado.GlobalData2.gi , 2);
            lblRotacionInteresesutilidad.Text = Convert.ToString(RIU /100);
            lblRazonPaivoCaptal.Text = Convert.ToString(RPC);
            lblrazondeudatotal.Text = Convert.ToString(RDT);
        }
    }
}
