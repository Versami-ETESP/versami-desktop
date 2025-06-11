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
        DashboardController dc;

        public FrmInicio()
        {
            InitializeComponent();
        }


        private void FrmInicio_Load(object sender, EventArgs e)
        {
            preencherGraficoPublicacoes();
            preencherGraficoComentarios();
            preencherGraficoUsers();
        }

        private void preencherGraficoPublicacoes()
        {
            dc = new DashboardController();
            DataTable dt = dc.obterEstatisticasPublicacoes();
            List<int> totalPublicacao = new List<int>();
            List<String> mesPublicacao = new List<string>();

            if (dt == null || dt.Rows.Count <= 0) return;
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                totalPublicacao.Add(Convert.ToInt32(dt.Rows[i]["TOTAL"].ToString()));
                int numMes = Convert.ToInt32(dt.Rows[i]["MES"].ToString());
                string mes = new CultureInfo("pt-BR").DateTimeFormat.GetMonthName(numMes);
                mesPublicacao.Add(mes);
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

        private void preencherGraficoComentarios()
        {
            dc = new DashboardController();
            DataTable dt = dc.obterEstatisticasComentarios();
            List<int> totalComent = new List<int>();
            List<String> mesPublicacao = new List<string>();

            if (dt == null || dt.Rows.Count <= 0) return;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                totalComent.Add(Convert.ToInt32(dt.Rows[i]["TOTAL"].ToString()));
                int numMes = Convert.ToInt32(dt.Rows[i]["MES"].ToString());
                string mes = new CultureInfo("pt-BR").DateTimeFormat.GetMonthName(numMes);
                mesPublicacao.Add(mes);
            }

            graficoComentarios.Series.Clear();
            graficoComentarios.Palette = ChartColorPalette.None;
            graficoComentarios.BackColor = Color.FromArgb(56, 77, 108);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Series series = graficoComentarios.Series.Add(mesPublicacao.ElementAt(i));
                series.Points.Add(totalComent.ElementAt(i));
            }
        }

        private void preencherGraficoUsers()
        {
            dc = new DashboardController();
            DataTable dt = dc.obterEstatisticasUsers();
            List<int> totalUser = new List<int>();
            List<String> faixaEtaria = new List<string>();

            if (dt == null || dt.Rows.Count <= 0) return;
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                totalUser.Add(Convert.ToInt32(dt.Rows[i]["Quantidade"].ToString()));
                faixaEtaria.Add(dt.Rows[i]["FaixaEtaria"].ToString() + " anos");
            }

            graficoUsuarios.Series.Clear();
            graficoUsuarios.Palette = ChartColorPalette.None;
            graficoUsuarios.BackColor = Color.FromArgb(56, 77, 108);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Series series = graficoUsuarios.Series.Add(faixaEtaria.ElementAt(i));
                series.Points.Add(totalUser.ElementAt(i));
            }
        }
    }
}
