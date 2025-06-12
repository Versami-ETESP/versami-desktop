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
    public partial class FrmCadastro: Form
    {
        AcessoController cd = new AcessoController();
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (!ValidaDados.nameIsValid(txtNome.Text))
                lblMensagem.Text = "O nome do usuário precisa ter 3 ou mais caracteres";
            else
                lblMensagem.Text = "";
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!ValidaDados.emailIsvalid(txtEmail.Text))
                lblMensagem.Text = "Digite um E-mail válido";
            else
                lblMensagem.Text = "";
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (!ValidaDados.passIsValid(txtSenha.Text))
                lblMensagem.Text = "A senha deve ter ao menos 8 caracteres";
            else
                lblMensagem.Text = "";
        }

        private void txtConfirma_Leave(object sender, EventArgs e)
        {
            if (!ValidaDados.confirmIsValid(txtSenha.Text, txtConfirma.Text))
                lblMensagem.Text = "As senhas não coincidem";
            else
                lblMensagem.Text = "";
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            if (!ValidaDados.birthIsValid(dateBirth.Value))
                lblMensagem.Text = "O Administrador deve ser maior de 18 anos";
            else
                lblMensagem.Text = "";
        }

        private void txtArroba_Leave(object sender, EventArgs e)
        {
            if (!ValidaDados.userExist(txtArroba.Text))
                lblMensagem.Text = "Usuário Existente";
            else
                lblMensagem.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidaDados.nameIsValid(txtNome.Text)
                && ValidaDados.emailIsvalid(txtEmail.Text)
                && ValidaDados.passIsValid(txtSenha.Text)
                && ValidaDados.confirmIsValid(txtSenha.Text, txtConfirma.Text)
                && ValidaDados.birthIsValid(dateBirth.Value)
                && ValidaDados.userExist(txtArroba.Text)
                && !string.IsNullOrEmpty(txtResposta.Text))
            {
                int numPermissao = Convert.ToInt32(cbPermissao.SelectedValue), idPergunta = Convert.ToInt32(cbPergunta.SelectedValue);
                string senhaHash = cd.getHash(txtSenha.Text), respostaHash = cd.getHash(txtResposta.Text.ToUpper().Trim());

                Admin adm = new Admin(txtNome.Text, txtArroba.Text, numPermissao, txtEmail.Text, senhaHash, dateBirth.Value);
                adm.setIdPergunta(idPergunta);
                adm.setResposta(respostaHash);

                if (cd.cadastrar(adm))
                {
                    MessageBox.Show("Administrador cadastrado!");
                    limparCampos();
                }
                else
                {
                    MessageBox.Show("Administrador não cadastrado. Tente novamente mais tarde!");
                }
            }
            else
            {
                lblMensagem.Text = "Por favor, preencha os campos corretamente";
            }

        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            // popula o combo box de permissao
            cbPermissao.Items.Clear();
            cbPermissao.DataSource = cd.listaPermissoes();
            cbPermissao.DisplayMember = "descricao";
            cbPermissao.ValueMember = "idPermissao";
            cbPermissao.SelectedIndex = 1;

            // popula o combo box de perguntas secretas

            cbPergunta.Items.Clear();
            cbPergunta.DataSource = cd.listaPerguntas();
            cbPergunta.ValueMember = "idPergunta";
            cbPergunta.DisplayMember = "pergunta";
        }

        private void limparCampos()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtArroba.Text = "";
            txtSenha.Text = "";
            txtConfirma.Text = "";
            txtResposta.Text = "";
            cbPermissao.SelectedIndex = 1;
            cbPergunta.SelectedIndex = 0;
        }

    }
}
