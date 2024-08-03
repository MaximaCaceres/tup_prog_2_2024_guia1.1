using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ej1ConcesionariaMotos.Models;

namespace Ej1ConcesionariaMotos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {

            string marca = tbxMarca.Text;
            int modelo = Convert.ToInt32(dupdModelo.Value);
            int anioACalcular = Convert.ToInt32(dupdAñoCalcu.Value);
            double valorFabrica = Convert.ToDouble(tbxValFabri.Text);
            int VidaUtil = Convert.ToInt32(tbxVida.Text);
            double tasaDepreciacion = Convert.ToDouble(tbxTasa.Text);

            Moto miMoto = new Moto(marca, modelo, valorFabrica);


            Resultado result = new Resultado();
            result.lbxResult.Items.Add(miMoto.VerDescripcion());

            double valorAnual = miMoto.CalcularDepreciacionAnual(anioACalcular, tasaDepreciacion);
            result.lbxResult.Items.Add($"Depreciación anual: ${valorAnual,10:f2}");

            double valorLineal = miMoto.CalcularDepreciacionLineal(anioACalcular, VidaUtil);
            result.lbxResult.Items.Add($"Depreciación lineal: ${valorLineal,10:f2}");
           
            result.ShowDialog();
        }

    }
}
