﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using versami_desktop.Controllers;
using versami_desktop.Entities;
using versami_desktop.Util;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace versami_desktop.Views
{
    public partial class FrmPosts : Form
    {
        private DenunciaController dc = new DenunciaController();
        private Post publicacao;
        private Denuncia denuncia;
        private Usuario usuarioDenunciado;
        private Usuario usuarioDenunciante;
        private bool postVisualizado = false;

        public FrmPosts()
        {
            InitializeComponent();
        }

        private void FrmPosts_Load(object sender, EventArgs e)
        {
            panelDenuncia.Visible = false;
            gridDenuncias.DataSource = dc.listarDenunciasPendentes();
            comboSituacao.Items.Clear();
            formatarGrid();
            comboSituacao.DataSource = dc.listarStatusDenuncia();
            comboSituacao.ValueMember = "idStatusDenuncia";
            comboSituacao.DisplayMember = "descStatus";
            comboSituacao.SelectedIndex = 0;
        }

        private void formatarGrid()
        {
            gridDenuncias.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            gridDenuncias.AllowUserToAddRows = false; //ESCONDE A NOVA LINHA DO GRID
            gridDenuncias.AllowUserToDeleteRows = false;
            gridDenuncias.RowHeadersVisible = false; //ESCONDE O PONTEIRO DO GRID
            gridDenuncias.ReadOnly = true;
            //permite personalizar o grid
            gridDenuncias.AutoGenerateColumns = false;
            gridDenuncias.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            gridDenuncias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            //altera a cor das linhas alternadas no grid
            gridDenuncias.RowsDefaultCellStyle.BackColor = Color.FromArgb(26, 42, 65);
            gridDenuncias.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(56, 77, 108);
            gridDenuncias.ForeColor = Color.White;
            //altera o cabecalho
            gridDenuncias.EnableHeadersVisualStyles = false;
            gridDenuncias.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(56, 77, 108);
            gridDenuncias.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //altera o nome das colunas
            gridDenuncias.Columns[0].HeaderText = "ID DENUNCIA";
            gridDenuncias.Columns[1].HeaderText = "DATA DA DENUNCIA";
            gridDenuncias.Columns[2].HeaderText = "STATUS";
            //altera o tamanho das colunas
            gridDenuncias.Columns[0].Width = 70;
            gridDenuncias.Columns[1].Width = 250;
            gridDenuncias.Columns[2].Width = 530;
            //não permite seleção de multiplas linhas    
            gridDenuncias.MultiSelect = false;
            //ao clicar, seleciona a linha inteira
            gridDenuncias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Expande a célula automáticamente
            gridDenuncias.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void gridDenuncias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                string idDenuncia = gridDenuncias.Rows[e.RowIndex].Cells[0].Value.ToString(); 
                if (string.IsNullOrEmpty(idDenuncia) || idDenuncia.Equals("0")) return;

                this.denuncia = dc.obterDenuncia(idDenuncia);

                if (denuncia == null) return;

                this.publicacao = this.denuncia.GetPost();
                this.usuarioDenunciante = this.denuncia.getUser();
                this.usuarioDenunciado = this.publicacao.getUsuario();

                txtID.Text = this.publicacao.getIdPublicacao().ToString();
                panelDenuncia.Visible = true;
                panelDenuncia.Enabled = true;
               
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if(this.publicacao == null)
            {
                MessageBox.Show("Selecione uma denúncia antes de visualizar publicação", "Selecione a denuncia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            CompartilhaDados.setPublicacao(this.publicacao);
            FrmVisualizarPost vp = new FrmVisualizarPost();
            this.postVisualizado = vp.ShowDialog() == DialogResult.OK;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string justificativa = txtJustificativa.Text;
            int statusSelecionado = Convert.ToInt32(comboSituacao.SelectedValue);

            if (this.postVisualizado == false)
            {
                MessageBox.Show("É preciso visualizar a publicação antes de seguir com a ação", "Publicação não visualizada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(statusSelecionado == Denuncia.STATUS_PENDENTE)
            {
                MessageBox.Show("Não é possível tratar um denúncia com status pendente", "Status Pendente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (string.IsNullOrEmpty(justificativa))
            {
                MessageBox.Show("Insira uma justificativa antes de salvar", "Justificativa em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(MessageBox.Show("Deseja finalizar essa denúncia? ", "Finalizar Denúncia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Admin adm = new Admin();
                this.denuncia.setAdmin(adm);
                this.denuncia.setObservacao(justificativa);
                this.denuncia.setStatusDenuncia(statusSelecionado);

                if (!dc.tratarDenuncia(this.denuncia))
                {
                    MessageBox.Show("Não foi possível finalizar essa denúncia. Tente mais tarde", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(statusSelecionado == Denuncia.STATUS_DEFERIDO)
                {
                    this.dc.excluirPost(this.publicacao.getIdPublicacao());
                }

                notificarUsuarios(statusSelecionado);
                gridDenuncias.DataSource = dc.listarDenunciasPendentes();
                panelDenuncia.Visible = false;
                this.denuncia = null;
            }
        }

        private void notificarUsuarios(int statusDenuncia)
        {
            int feedbackDenuncia = 5;
            int postDeletado = 6;

            this.dc.notificarTratamentoDenuncia(feedbackDenuncia, statusDenuncia, this.usuarioDenunciante);

            if (statusDenuncia == Denuncia.STATUS_DEFERIDO)
            {
                this.dc.notificarTratamentoDenuncia(postDeletado, statusDenuncia, this.usuarioDenunciado);
            }
        }
    }

}
