using System.Net.Sockets;
using System.Text;

namespace PicMyestery__WinForms_
{
    public partial class TELA_JOGO : Form
    {
        private int idPergunta;  // Variável global para armazenar o ID da pergunta
        private string dificuldadeEscolhida;  // Variável para armazenar a dificuldade escolhida

        // Construtor para receber a dificuldade
        public TELA_JOGO(string dificuldade)
        {
            InitializeComponent();
            dificuldadeEscolhida = dificuldade;  // Armazena a dificuldade no Form1
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Se necessário, adicione mais inicializações aqui
        }

        private void btnPerguntar_Click(object sender, EventArgs e)
        {
            try
            {
                // Comando que será enviado para o servidor com base na dificuldade escolhida
                string comando = $"ME PERGUNTE {dificuldadeEscolhida}";  // Passando a dificuldade

                // Enviar o comando para o servidor e aguardar a resposta
                string resposta = EnviarComandoParaServidor(comando);

                // Exibir a resposta do servidor (a pergunta com alternativas)
                txtPergunta.Text = resposta;

                // Agora, vamos separar o idPergunta da resposta
                string[] partesResposta = resposta.Split('|');
                if (partesResposta.Length > 1)
                {
                    idPergunta = int.Parse(partesResposta[0].Trim()); // ID da pergunta
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar o comando: " + ex.Message);
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Pega a resposta do usuário e verifica se não está vazia
                string resposta = txtResposta.Text.ToUpper().Trim(); // Pega a resposta e formata para maiúsculas

                if (!string.IsNullOrEmpty(resposta))
                {
                    // Enviar o comando de resposta para o servidor (passando o ID da pergunta e a resposta do usuário)
                    string comando = $"RESPOSTA - {idPergunta} - {resposta}"; // O ID da pergunta pode ser recuperado de onde você guarda a pergunta
                    string resultado = EnviarComandoParaServidor(comando); // Envia o comando para o servidor e aguarda a resposta

                    // Exibir a resposta do servidor (informando se a resposta está certa ou errada)
                    MessageBox.Show(resultado); // O servidor vai retornar uma mensagem dizendo se está certo ou errado
                }
                else
                {
                    MessageBox.Show("Por favor, insira sua resposta.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar a resposta: " + ex.Message);
            }
        }

        private string EnviarComandoParaServidor(string comando)
        {
            try
            {
                string IPServer = "127.0.0.1"; // IP do servidor
                int PORT = 30000; // Porta do servidor

                using (TcpClient client = new TcpClient(IPServer, PORT)) // Conecta ao servidor
                {
                    NetworkStream stream = client.GetStream();
                    byte[] data = Encoding.UTF8.GetBytes(comando); // Envia o comando

                    stream.Write(data, 0, data.Length); // Envia os dados para o servidor

                    byte[] buffer = new byte[4096]; // Cria um buffer para a resposta do servidor
                    int bytes = stream.Read(buffer, 0, buffer.Length); // Lê a resposta

                    string resposta = Encoding.UTF8.GetString(buffer, 0, bytes); // Converte a resposta de volta para string
                    return resposta; // Retorna a resposta do servidor (a pergunta com alternativas)
                }
            }
            catch (Exception ex)
            {
                return "Erro ao conectar com o servidor: " + ex.Message; // Caso haja erro, retorna a mensagem de erro
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            // Fecha a TELA_JOGO
            this.Close();

            // Cria uma instância da TELA_MENU e exibe
            TELA_MENU telaMenu = new TELA_MENU();
            telaMenu.Show();
        }
    }
}
