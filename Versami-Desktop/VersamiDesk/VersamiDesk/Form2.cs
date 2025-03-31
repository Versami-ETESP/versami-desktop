using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VersamiDesk;

namespace VersamiDesk
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(26, 42, 65);
        }
        private void CountUsers()
        {
            try
            {
                using (var context = new ApplicationDbContext()) 
                {
                    int userCount = context.Usuarios.Count();
                    lblContarUsu.Text = userCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao contar usuários: " + ex.Message);
            }

        }
        private void CountPublications()
        {
            try
            {
                // Verifica se o contexto está acessando corretamente o banco
                using (var context = new ApplicationDbContext())
                {
                    // Conta o número de publicações
                    int count = context.Publicacao.Count();

                    // Exibe um MessageBox para verificar o valor de count (para depuração)
                    MessageBox.Show($"Número de publicações: {count}");

                    // Atualiza a label com o valor de count
                    lblTotalPosts.Text = count.ToString();  // Isso deve exibir 0 se não houver publicações

                    // Verifica se a label não é nula e exibe a contagem
                    if (lblTotalPosts != null)
                    {
                        lblTotalPosts.Text = count.ToString();  // A label sempre será atualizada com o número de publicações, inclusive 0
                    }
                    else
                    {
                        MessageBox.Show("Label 'lblTotalPosts' não encontrada.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Exibe qualquer erro que ocorrer
                MessageBox.Show("Erro ao contar publicações: " + ex.Message);
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {

            //Design e afins

            PintarTodosOsPaineis();
            CountUsers();
            DefinirPropriedadesDaLabel(lblContarUsu);
            DefinirPropriedadesTitulos(lblUsuRegis);
            DefinirPropriedadesDaLabel(lblTotalPosts);
            DefinirPropriedadesTitulos(lblPosts);
            DefinirPropriedadesDaLabel(lblTotalComen);
            DefinirPropriedadesTitulos(lblComentarios);
            DefinirPropriedadesDaLabel(lblPostsMaisCurtidos);
            DefinirPropriedadesTitulos(lblCurtidos);


        }











        //Design e afins

        private void DefinirPropriedadesDaLabel(Label label)
        {
            label.Width = 1000;  
            label.Height = 856; 
            label.Font = new Font("Arial", 16, FontStyle.Bold); 
            label.ForeColor = Color.White; 
        }
        private void DefinirPropriedadesTitulos(Label label)
        {
            label.Width = 1000;
            label.Height = 856;
            label.Font = new Font("Arial", 16, FontStyle.Bold);
            label.ForeColor = Color.White;
        }
        private void PintarTodosOsPaineis()
        {
            Color corDeFundo = Color.FromArgb(50, 70, 100);
            foreach (Control controle in this.Controls)
            {
                if (controle is Panel)
                {
                    controle.BackColor = corDeFundo;
                }
            }
        }
    }
}
