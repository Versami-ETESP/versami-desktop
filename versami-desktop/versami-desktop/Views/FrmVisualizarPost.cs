using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using versami_desktop.Controllers;
using versami_desktop.Entities;
using versami_desktop.Util;

namespace versami_desktop.Views
{
    public partial class FrmVisualizarPost: Form
    {
        private Post publicacao;
        public FrmVisualizarPost()
        {
            InitializeComponent();
        }

        private void FrmVisualizarPost_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void FrmVisualizarPost_Load(object sender, EventArgs e)
        {
            if(CompartilhaDados.getPublicacao() == null || CompartilhaDados.getPublicacao().getIdPublicacao() == 0)
            {
                this.Close();
                return;
            }

            DenunciaController dc = new DenunciaController();
            this.publicacao = dc.obterPublicacao(CompartilhaDados.getPublicacao().getIdPublicacao());

            if(this.publicacao == null)
            {
                Debug.WriteLine("Objeto veio vazio da consulta");
                MessageBox.Show("Erro ao obter publicação");
                this.Close();
                return;
            }

            Usuario user = this.publicacao.getUsuario();
            lblNomeUser.Text = user.getUserName();
            lblArrobaUser.Text = user.getUserLogin();
            if(user.getUserImage() != null)
            {
                Image fotoPerfil = UtilitarioImagens.ConverteByteParaImagem(user.getUserImage());
                imgPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
                imgPerfil.Image = fotoPerfil;
            }

            txtConteuPublic.Text = this.publicacao.getConteudo();
            lblData.Text = this.publicacao.getDataPublic().ToString();

            Livro livro = this.publicacao.getLivro();

            if(livro != null)
            {
                lblTituloLivro.Text = livro.getTitle();

                if(livro.getCover() != null)
                {
                    Image capa = UtilitarioImagens.ConverteByteParaImagem(livro.getCover());
                    imgCapaLivro.SizeMode = PictureBoxSizeMode.StretchImage;
                    imgCapaLivro.Image = capa;
                }

                panelLivro.Visible = true;
            }
        }
    }
}
