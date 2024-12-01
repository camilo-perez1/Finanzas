using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Finanzas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        /*
        public Form2(string EyEq, string CxC, string inv,
            string oac, string resdep, string oanoc)
        {
            InitializeComponent();

            // Asignar el valor recibido al TextBox en Form2
            textBox1.Text = EyEq + CxC + inv + oac + resdep + oanoc;

        }
        */



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public static class GlobalData
        {
            public static double TotalActivoCirculante { get; set; }
            public static double TotalPasivoCirculante { get; set; }
            public static double Inv { get; set; }
            public static double CxC { get; set; }
            public static double ActivosFijios { get; set; }
            public static double ActivosTotales { get; set; } //4
            public static double PasivosTotales { get; set; }//2
            public static double pasivolP { get; set; }
            public static double GR { get; set; }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double EyE, CxC, Inv, OAC,ResDep, OaNOC, TotalActivoCirculante, ActivosFijos, ActivosTotales, GR;
            EyE = double.Parse(EfectivosyEquivalentes2011.Text);
            CxC = double.Parse(CuentasPorCobrar2011.Text);
            Inv = double.Parse(Inventarios2011.Text);
            OAC = double.Parse(OACorrientes2011.Text);
            ResDep = double.Parse(RestaDepreciacion2011.Text);
            OaNOC = double.Parse(OaNOCorrientes2011.Text);
            ActivosTotales = double.Parse(TotalActivos2011.Text);
            GR = double.Parse(GananciasRetenidas2011.Text);
            GlobalData.ActivosTotales = ActivosTotales;
            GlobalData.CxC = CxC;
            GlobalData.Inv = Inv;
            GlobalData.GR = GR;
            ActivosFijos = OaNOC + ResDep;
            TotalActivoCirculante = EyE + CxC + Inv + OAC;
            ActivosTotales = ActivosFijos + TotalActivoCirculante;

            GlobalData.ActivosFijios = ActivosFijos;
            GlobalData.TotalActivoCirculante = TotalActivoCirculante;

            double CxP, DPCP, OPC , TotalPasivoCirculante, DPLP, IRDifer, OpNOC, PasivosTotales, pasivoLP;
            CxP = double.Parse(CuentasPorPagar2011.Text);
            DPCP = double.Parse(DeudaPagarCortoPlazo2011.Text);
            OPC = double.Parse(OPCorrientes2011.Text);
            DPLP = double.Parse(DeudaPagarLargoPlazo2011.Text);
            IRDifer = double.Parse(ImpuestoSobreRentaDiferidos2011.Text);
            OpNOC = double.Parse(OpNOCorrientes2011.Text);
            
            TotalPasivoCirculante = CxP+ DPCP + OPC;
            GlobalData.TotalPasivoCirculante = TotalPasivoCirculante;
            pasivoLP = DPLP + IRDifer + OpNOC;
            GlobalData.pasivolP = pasivoLP;

            PasivosTotales = TotalPasivoCirculante + DPLP + IRDifer + OpNOC;
            GlobalData.PasivosTotales = PasivosTotales;
            GlobalData.ActivosTotales = ActivosTotales;
        }
    }
}
