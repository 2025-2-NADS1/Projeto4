using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace PicMyestery__WinForms_
{
    public partial class TELA_LOGIN : Form
    {
        public TELA_LOGIN()
        {
            InitializeComponent();
        }

        // Valida o login e senha
        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string senha = textBoxSenha.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, preencha o login e a senha.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Consultar o banco de dados para verificar se o usuário e a senha estão corretos
            if (ValidarLogin(login, senha))
            {
                // Redireciona para a tela do jogo, ou menu, ou a tela que você preferir
                TELA_MENU menu = new TELA_MENU();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para validar o login e senha no banco de dados
        private bool ValidarLogin(string login, string senha)
        {
            try
            {
                string conexaoBanco = @"Data Source=C:\Users\user\Desktop\AULALA4 - DESKTOP\BANCO DE DADOS\picmystery.db"; // Caminho do banco de dados
                using (var conexao = new SQLiteConnection(conexaoBanco))
                {
                    conexao.Open();
                    string sql = "SELECT COUNT(*) FROM Usuario WHERE email = @email AND senha = @senha";
                    using (var cmd = new SQLiteCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@email", login);
                        cmd.Parameters.AddWithValue("@senha", senha);
                        int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                        return resultado > 0;  // Retorna true se o usuário for encontrado
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Redireciona para a tela de cadastro
        private void buttonCadastro_Click(object sender, EventArgs e)
        {
            TELA_CADASTRO telaCadastro = new TELA_CADASTRO();
            telaCadastro.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
