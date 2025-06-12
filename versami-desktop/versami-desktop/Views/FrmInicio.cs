using iTextSharp.text.pdf;
using iTextSharp.text;
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
using System.Data.SqlClient;
using System.IO;

namespace versami_desktop.Views
{
    public partial class FrmInicio: Form
    {
        DashboardController dc;
        string caminho;

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

        private static void AddCellToHeader(PdfPTable tableLayout, string cellText)
        {
            tableLayout.AddCell(new PdfPCell(new Phrase(cellText, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8)))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                Padding = 10,
                BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 255)
            });
        }

        protected PdfPTable corpo_documento(PdfPTable tableLayout)
        {
            float[] headers = { 10, 40, 30, 20 }; //largura de cada campo
            tableLayout.SetWidths(headers); //Set the pdf headers 
            tableLayout.WidthPercentage = 100; //Set the PDF File witdh percentage 
            tableLayout.HeaderRows = 1;
            //Add header 
            AddCellToHeader(tableLayout, "POSIÇÃO");
            AddCellToHeader(tableLayout, "NOME");
            AddCellToHeader(tableLayout, "LOGIN DE USUARIO");
            AddCellToHeader(tableLayout, "TOTAL PUBLICAÇÕES");

            //Add body
            DashboardController dc = new DashboardController();
            DataTable dt = dc.obterTopUsers();
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                AddCellToBody(tableLayout, (i+1).ToString(), i);
                AddCellToBody(tableLayout, dt.Rows[i]["nome"].ToString(), i);
                AddCellToBody(tableLayout, dt.Rows[i]["arroba_usuario"].ToString(), i);
                AddCellToBody(tableLayout, dt.Rows[i]["total_publicacoes"].ToString(), i);
            }
            return tableLayout;
        }

        private static void AddCellToBody(PdfPTable tableLayout, string cellText, int count) //Efeito fundo: cinza e claro
        {
            if (count % 2 == 0)
            {
                tableLayout.AddCell(new PdfPCell(new Phrase(cellText, FontFactory.GetFont(FontFactory.HELVETICA, 8, 1, iTextSharp.text.BaseColor.BLACK)))
                {
                    HorizontalAlignment = Element.ALIGN_LEFT,
                    Padding = 8,
                    BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 255)
                });
            }
            else
            {
                tableLayout.AddCell(new PdfPCell(new Phrase(cellText, FontFactory.GetFont(FontFactory.HELVETICA, 8, 1, iTextSharp.text.BaseColor.BLACK)))
                {
                    HorizontalAlignment = Element.ALIGN_LEFT,
                    Padding = 8,
                    BackgroundColor = new iTextSharp.text.BaseColor(230, 230, 230)
                });
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Salvar PDF como";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            caminho = saveFileDialog1.FileName;
            MessageBox.Show("Salvo em: " + caminho);
            Document doc = null;
            try
            {
                //criando o arquivo pdf
                doc = new Document(PageSize.A4);//tipo da folha usada
                doc.SetMargins(10, 10, 10, 10);//estibulando o espaçamento das margens que queremos
                doc.AddCreationDate();//adicionando as configuracoes
                
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));
                doc.Open();

                PdfPTable tableLayout = new PdfPTable(4); //qtde de colunas do relatório
                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font fontInvoice = new iTextSharp.text.Font(bf, 20, iTextSharp.text.Font.NORMAL);
                Paragraph paragraph = new Paragraph("TOP 10 USUÁRIOS COM MAIS PUBLICAÇÕES", fontInvoice);
                paragraph.Alignment = Element.ALIGN_CENTER;
                doc.Add(paragraph);
                Paragraph p3 = new Paragraph();
                p3.SpacingAfter = 6;
                doc.Add(p3);
                doc.Add(corpo_documento(tableLayout));
                doc.Close();
            }
            catch (Exception erro)
            {
                if (doc != null)
                    doc.Close();
                MessageBox.Show("Erro Arquivo PDF --> " + erro);
            }
        }
    }
}
