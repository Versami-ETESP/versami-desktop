using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class FrmAlteraSenha: Form
    {
        AcessoController ac = new AcessoController();
        string resposta;
        public FrmAlteraSenha()
        {
            InitializeComponent();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            DataTable dt = ac.buscaUsuario(txtArroba.Text);

            if(dt != null && dt.Rows.Count > 0)
            {
                txtArroba.Enabled = false;
                btnBusca.Enabled = false;
                txtPergunta.Text = dt.Rows[0]["pergunta"].ToString();
                txtResposta.Enabled = true;
                txtSenha.Enabled = true;
                txtConfirma.Enabled = true;
                btnAltera.Enabled = true;
                resposta = dt.Rows[0]["resposta"].ToString();
            }
            else
            {
                lblMensagem.Text = "Usuário Não Encontrado";
            }
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            string respostaForm = ac.getHash(txtResposta.Text.ToUpper().Trim()), senha = txtSenha.Text, confirma = txtConfirma.Text;


            if (resposta.Equals(respostaForm))
            {
                if (ValidaDados.passIsValid(senha) && ValidaDados.confirmIsValid(senha,confirma))
                {
                    Admin adm = new Admin();
                    adm.setSenha(ac.getHash(senha));
                    adm.setArroba(txtArroba.Text);

                    if (ac.alteraSenha(adm))
                    {
                        MessageBox.Show("Senha alterada com sucesso!");
                        this.Close();
                    }
                    else
                    {
                        lblMensagem.Text = "Erro ao alterar senha. Tente mais tarde!";
                    }
                        
                }
                else
                {
                    if (!ValidaDados.confirmIsValid(senha, confirma))
                        lblMensagem.Text = "As senhas não coincidem";

                    if (!ValidaDados.passIsValid(senha))
                        lblMensagem.Text = "A senha deve ter ao menos 8 caracteres";
                }
            }
            else
            {
                lblMensagem.Text = "Resposta Inválida";
            }

        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (!ValidaDados.passIsValid(txtSenha.Text))
                lblMensagem.Text = "A senha deve ter ao menos 8 caracteres";
        }

        private void txtConfirma_Leave(object sender, EventArgs e)
        {
            if (!ValidaDados.confirmIsValid(txtSenha.Text, txtConfirma.Text))
                lblMensagem.Text = "As senhas não coincidem";
        }
    }
}
