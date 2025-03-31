using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VersamiDesk
{
    public partial class Form1: Form
    {
        private string connectionString = "Server=DESKTOP-J57J04U\\SQLEXPRESS;Database=versami;Integrated Security=True;";


        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(23, 32, 41);
            pnlNav.BackColor = Color.FromArgb(26, 42, 65);
            pnlFormLoader.BackColor = Color.FromArgb(26, 42, 65);

            lblAdmin.ForeColor = Color.White;
            lblArrobaAdmin.ForeColor = Color.White;

        }
        private void CountUsers()
        {
            string query = "SELECT COUNT(*) FROM tblUsuario";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    int count = (int)command.ExecuteScalar();

                    MessageBox.Show($"Número de usuários cadastrados: {count}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao contar registros: {ex.Message}");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetButtonStyles(this.Controls);
            SetButtonStyles(pnlNav.Controls);
            SetButtonStyles(pnlFormLoader.Controls);

            btnInicio.Image = Image.FromFile("C:\\Users\\Vera\\Desktop\\Versami-Desktop\\VersamiDesk\\imgInicio.png");
            btnUsuarios.Image = Image.FromFile("C:\\Users\\Vera\\Desktop\\Versami-Desktop\\VersamiDesk\\imgUsuarios.png");
            btnLivros.Image = Image.FromFile("C:\\Users\\Vera\\Desktop\\Versami-Desktop\\VersamiDesk\\imgLivros.png");
            btnPosts.Image = Image.FromFile("C:\\Users\\Vera\\Desktop\\Versami-Desktop\\VersamiDesk\\imgPosts.png");

            Admin admin = GetAdminById(1);  // Exemplo para buscar o administrador com id 1

            if (admin != null)
            {
                lblArrobaAdmin.Text = admin.ArrobaUsuario;  // Exibe o arroba_usuario na Label
            }
            else
            {
                lblArrobaAdmin.Text = "Admin não encontrado";
            }

        }
        private Admin GetAdminById(int idAdmin)
        {
            Admin admin = null;

            string query = "SELECT idAdmin, nome, data_nasc, email, senha, arroba_usuario, permissao_admin FROM tblAdmin WHERE idAdmin = @idAdmin";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idAdmin", idAdmin);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        admin = new Admin
                        {
                            IdAdmin = (int)reader["idAdmin"],
                            Nome = reader["nome"].ToString(),
                            DataNasc = (DateTime)reader["data_nasc"],
                            Email = reader["email"].ToString(),
                            Senha = reader["senha"].ToString(),
                            ArrobaUsuario = reader["arroba_usuario"].ToString(),
                            PermissaoAdmin = (bool)reader["permissao_admin"]
                        };
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message);
                }
            }

            return admin;
        }

        private void SetButtonStyles(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is Button button)
                {
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.BackColor = Color.FromArgb(26, 42, 65);
                    button.ForeColor = Color.White;
                    button.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 70, 100);
                    button.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 20, 30);
                }
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            Form2 FormDashboard_vrb = new Form2()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            this.pnlFormLoader.Controls.Add(FormDashboard_vrb);

            FormDashboard_vrb.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            Form3 FormDashboard_vrb = new Form3()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            this.pnlFormLoader.Controls.Add(FormDashboard_vrb);

            FormDashboard_vrb.Show();
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            Form3 FormDashboard_vrb = new Form3()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };

            this.pnlFormLoader.Controls.Add(FormDashboard_vrb);

            FormDashboard_vrb.Show();
        }

        private void btnPosts_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            Form4 FormDashboard_vrb = new Form4()
            {
                Dock = DockStyle.Fill,  // Faz o formulário preencher todo o painel
                TopLevel = false,  // Necessário para ser exibido dentro do painel
                TopMost = true,  // Faz o formulário ficar sempre por cima
                FormBorderStyle = FormBorderStyle.None  // Remove a borda do formulário
            };

            // Adiciona o formulário ao painel
            this.pnlFormLoader.Controls.Add(FormDashboard_vrb);

            // Exibe o formulário
            FormDashboard_vrb.Show();
        }

    }
}
