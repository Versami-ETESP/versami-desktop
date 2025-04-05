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
            bool notPermission = !rdoBanir.Checked && !rdoEditLivro.Checked && !rdoMaster.Checked && !rdoModerador.Checked && !rdoModerador.Checked;

            if (notPermission)
            {
                lblMensagem.Text = "Selecione o tipo de permissão";
            }
            else
            {
                if (!ValidaDados.nameIsValid(txtNome.Text)
                || !ValidaDados.emailIsvalid(txtEmail.Text)
                || !ValidaDados.passIsValid(txtSenha.Text)
                || !ValidaDados.confirmIsValid(txtSenha.Text, txtConfirma.Text)
                || !ValidaDados.birthIsValid(dateBirth.Value)
                || !ValidaDados.userExist(txtArroba.Text))
                {
                    lblMensagem.Text = "Por favor, preencha os campos corretamente";
                }
                else
                {
                    int numPermissao = 0;
                    if (rdoMaster.Checked)
                        numPermissao = 1;
                    else if (rdoEditLivro.Checked)
                        numPermissao = 2;
                    else if (rdoModerador.Checked)
                        numPermissao = 3;
                    else if (rdoBanir.Checked)
                        numPermissao = 4;
                    else if (rdoPublicar.Checked)
                        numPermissao = 5;

                    Admin adm = new Admin(txtNome.Text, txtArroba.Text, numPermissao, txtEmail.Text, txtSenha.Text, dateBirth.Value);


                    if (cd.cadastrar(adm))
                    {
                        MessageBox.Show("Administrador cadastrado!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Administrador não cadastrado. Tente novamente mais tarde!");
                    }
                    
                }
            }
        }
    }
}
