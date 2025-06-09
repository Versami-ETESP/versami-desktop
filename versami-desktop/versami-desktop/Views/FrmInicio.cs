using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using versami_desktop.Controllers;
using versami_desktop.Entities;
using versami_desktop.Util;

namespace versami_desktop.Views
{
    public partial class FrmInicio: Form
    {
        List<int> totalPublicacao = new List<int>();
        List<String> mesPublicacao = new List<string>();
        
        public FrmInicio()
        {
            InitializeComponent();
        }


        private void FrmInicio_Load(object sender, EventArgs e)
        {
            preencherEstatisticas();
        }

        private void preencherEstatisticas()
        {
            DashboardController dc = new DashboardController();
            DataTable dt = dc.obterEstatisticasPublicacoes();

            if (dt == null || dt.Rows.Count <= 0) return;
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.totalPublicacao.Add(Convert.ToInt32(dt.Rows[i]["TOTAL"].ToString()));
                int numMes = Convert.ToInt32(dt.Rows[i]["MES"].ToString());
                string mes = new CultureInfo("pt-BR").DateTimeFormat.GetMonthName(numMes);
                this.mesPublicacao.Add(mes);
            }

            graficoPublicacoes.Series.Clear();
            graficoPublicacoes.Palette = ChartColorPalette.None;
            graficoPublicacoes.BackColor = Color.FromArgb(56, 77, 108);
            
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                Series series = graficoPublicacoes.Series.Add(mesPublicacao.ElementAt(i));
                series.Points.Add(totalPublicacao.ElementAt(i));
            }
        }
    }
}
