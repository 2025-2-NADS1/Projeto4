using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace PicMyestery__WinForms_
{
    public partial class TELA_CADASTRO : Form
    {
        public TELA_CADASTRO()
        {
            InitializeComponent();
        }

        // Confirma o cadastro e salva os dados no banco de dados
        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            string nome = textBoxUser.Text;
            string email = textBoxEmail.Text;
            string dataNasc = textBoxDataNasc.Text;
            string senha = textBoxSenha.Text;

            // Validar os campos
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(dataNasc) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Inserir os dados no banco
            if (CadastrarUsuario(nome, email, dataNasc, senha))
            {
                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                TELA_LOGIN telaLogin = new TELA_LOGIN();
                telaLogin.Show();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar o usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para cadastrar o usuário no banco de dados
        private bool CadastrarUsuario(string nome, string email, string dataNasc, string senha)
        {
            try
            {
                string conexaoBanco = @"Data Source=C:\Users\user\Desktop\AULALA4 - DESKTOP\BANCO DE DADOS\picmystery.db"; // Caminho do banco de dados
                using (var conexao = new SQLiteConnection(conexaoBanco))
                {
                    conexao.Open();
                    string sql = "INSERT INTO Usuario (nome, email, data_nasc, senha, nivel) VALUES (@nome, @email, @data_nasc, @senha, 'Iniciante')";
                    using (var cmd = new SQLiteCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@data_nasc", dataNasc);
                        cmd.Parameters.AddWithValue("@senha", senha);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void TELA_CADASTRO_Load(object sender, EventArgs e)
        {

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            // Fecha a TELA_CADASTRO
            this.Close();

            // Cria uma instância da TELA_LOGIN e exibe
            TELA_LOGIN telaLogin = new TELA_LOGIN();
            telaLogin.Show();
        }

    }
}
