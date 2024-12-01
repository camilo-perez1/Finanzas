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
    public partial class Estado_de_Resultado : Form
    {
        public Estado_de_Resultado()
        {
            InitializeComponent();
        }
        double v, cbv, ub, gva, da, ogf, tgo, uo, oi, gi, unAI, i, unDI = 0; // ventas, costos bienes vendidos, gastos de venta y admon, depr. y amort., otros gastos fiscales, total gastos operativos
                                                                             // util. operativa, otros ingresos, gastos por interes, util. neta AI, impuesto, util. neta DI


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Utilidad Bruta
            if (!string.IsNullOrEmpty(txtVentas.Text) && double.TryParse(txtVentas.Text, out double result1))
            {
                v = result1;
            }
            else
                v = 0;

            if (!string.IsNullOrEmpty(txtCBV.Text) && double.TryParse(txtCBV.Text, out double result2))
            {
                cbv = result2;
            }
            else
                cbv = 0;

            ub = v - cbv;

            if (ub < 0)
            {
                txtUB.Text = $"( {ub * (-1)} )";
                txtUO.Text = $"( {ub * (-1)} )";
            }
            else
            {
                txtUB.Text = $"{ub}";
                txtUO.Text = $"{ub}";
            }


        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGVA.Text) && double.TryParse(txtGVA.Text, out double result1))
            {
                gva = result1;
            }
            else
                gva = 0;

            if (!string.IsNullOrEmpty(txtDA.Text) && double.TryParse(txtDA.Text, out double result2))
            {
                da = result2;
            }
            else
                da = 0;

            if (!string.IsNullOrEmpty(txtOGF.Text) && double.TryParse(txtOGF.Text, out double result3))
            {
                ogf = result3;
            }
            else
                ogf = 0;

            tgo = gva + da + ogf;

            if (tgo < 0)
            {
                txtTGO.Text = $"( {tgo * (-1)} )";
            }
            else
                txtTGO.Text = $"{tgo}";


            //Utilidad Operativa

            uo = ub - tgo;

            if (uo < 0)
            {
                txtUO.Text = $"( {uo * (-1)} )";
            }
            else
                txtUO.Text = $"{uo}";


            //Otros ingresos
            if (!string.IsNullOrEmpty(txtOI.Text) && double.TryParse(txtOI.Text, out double result4))
            {
                oi = result4;
            }
            else
                oi = 0;

            if (!string.IsNullOrEmpty(txtGI.Text) && double.TryParse(txtGI.Text, out double result5))
            {
                gi = result5;
            }
            else
                gi = 0;

            //UN_AI
            unAI = uo + oi - gi;

            if (unAI < 0)
            {
                txtUN_AI.Text = $"( {unAI * (-1)} )";
            }
            else
                txtUN_AI.Text = $"{unAI}";



            //Impuesto
            if (!string.IsNullOrEmpty(txtImp.Text) && double.TryParse(txtImp.Text, out double result6))
            {
                i = result6;
            }
            else
                i = 0;


            //UN_DI
            unDI = unAI - unAI * (i / 100);

            unDI = Math.Round(unDI, 2);

            if (unDI < 0)
            {
                txtUN_DI.Text = $"( {unDI * (-1)} )";
            }
            else
                txtUN_DI.Text = $"{unDI}";






        }



        private void SoloDouble(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal

            if (e.KeyChar == '.' && txtVentas.Text.Contains("."))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtCBV.Text.Contains("."))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtGVA.Text.Contains("."))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtDA.Text.Contains("."))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtOGF.Text.Contains("."))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtOI.Text.Contains("."))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtGI.Text.Contains("."))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtImp.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los TextBox en el formulario
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear(); // Limpia el contenido del TextBox
                }
                else if (control.HasChildren) // Verifica si el control tiene hijos
                {
                    foreach (Control childControl in control.Controls)
                    {
                        if (childControl is TextBox childTextBox)
                        {
                            childTextBox.Clear(); // Limpia el contenido del TextBox hijo
                        }
                    }
                }
            }
            txtVentas.Focus();
        }
        public static class GlobalData2
        {
            public static double CBVendidos { get; set; }
            public static double VNCredito { get; set; }
            public static double uai { get; set; }
            public static double gi { get; set; }
            public static double UO { get; set; }
            public static double UNDI { get; set; }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            double CBVendidos, VNCredito, uai, gi, UO, UNDI;
            uai = double.Parse(txtUN_AI.Text);
            gi = double.Parse(txtGI.Text);
            VNCredito = double.Parse(txtVentas.Text);
            CBVendidos = double.Parse(txtCBV.Text);
            UO = double.Parse(txtUO.Text);
            UNDI = double.Parse(txtUN_DI.Text);

            GlobalData2.UNDI = UNDI;
            GlobalData2.UO = UO;
            GlobalData2.uai = uai;
            GlobalData2.gi = gi;
            GlobalData2.VNCredito = VNCredito;
            GlobalData2.CBVendidos = CBVendidos;
        }
    }
}
