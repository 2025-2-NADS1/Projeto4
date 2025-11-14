using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace PicMyestery__WinForms_
{
    public partial class TELA_JOGO : Form
    {
        private int idPergunta;                      // ID da pergunta atual
        private string dificuldadeEscolhida;         // Dificuldade escolhida (recebida do form anterior)

        // Game state
        private int pontos = 0;                      // Pontos do jogador
        private int tempoRestante = 20;              // Tempo total da partida (em segundos)
        private System.Windows.Forms.Timer cronometro = new System.Windows.Forms.Timer(); // Timer WinForms

        // Construtor que recebe a dificuldade (pode receber null se você chamar sem argumento)
        public TELA_JOGO(string dificuldade)
        {
            InitializeComponent();
            dificuldadeEscolhida = dificuldade ?? string.Empty;

            // Inicializa a UI do tempo/pontos
            labelTimer.Text = $"? Tempo: {tempoRestante}s | ?? Pontos: {pontos}";

            // Configura o cronometro para "tick" a cada 1 segundo
            cronometro.Interval = 1000;
            cronometro.Tick += Cronometro_Tick;
            cronometro.Start();
        }

        // Se você também tiver um construtor sem parâmetros e for usar, mantenha este (opcional)
        public TELA_JOGO() : this(string.Empty) { }

        private void Form1_Load(object sender, EventArgs e)
        {
            // nada adicional por enquanto
        }

        // Botão "Me Pergunte!" - pede pergunta ao servidor
        private void btnPerguntar_Click(object sender, EventArgs e)
        {
            try
            {
                // Comando que será enviado para o servidor com base na dificuldade escolhida
                // Se não houver dificuldade, envia "ME PERGUNTE" simples
                string comando = string.IsNullOrWhiteSpace(dificuldadeEscolhida) ? "ME PERGUNTE" : $"ME PERGUNTE {dificuldadeEscolhida}";

                string resposta = EnviarComandoParaServidor(comando);
                txtPergunta.Text = resposta ?? "Nenhuma pergunta recebida.";

                // Espera o formato "id_pergunta|enunciado..."
                string[] partesResposta = (resposta ?? string.Empty).Split('|');
                if (partesResposta.Length > 1 && int.TryParse(partesResposta[0].Trim(), out int parsedId))
                {
                    idPergunta = parsedId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar o comando: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botão "Verificar" - envia resposta para o servidor e atualiza pontos
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                string resposta = txtResposta.Text.ToUpper().Trim();

                if (string.IsNullOrEmpty(resposta))
                {
                    MessageBox.Show("Por favor, insira sua resposta.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Monta e envia o comando de verificação
                string comando = $"RESPOSTA - {idPergunta} - {resposta}";
                string resultado = EnviarComandoParaServidor(comando);

                // Mostra o resultado ao usuário
                MessageBox.Show(resultado, "Resultado");

                // Atualiza pontos com base no retorno do servidor.
                // O servidor retorna "? Resposta correta!" ou "? Errado! ...", então verificamos os símbolos.
                if (!string.IsNullOrEmpty(resultado))
                {
                    if (resultado.Contains("?"))    // acerto (emoji verde)
                    {
                        pontos += 10;
                    }
                    else if (resultado.Contains("?")) // erro (emoji vermelho)
                    {
                        pontos -= 5;
                    }
                    else
                    {
                        // fallback: procura palavras
                        if (resultado.IndexOf("correta", StringComparison.OrdinalIgnoreCase) >= 0)
                            pontos += 10;
                        else if (resultado.IndexOf("errado", StringComparison.OrdinalIgnoreCase) >= 0)
                            pontos -= 5;
                    }
                }

                // Atualiza exibição de tempo e pontos
                labelTimer.Text = $"? Tempo: {tempoRestante}s | ?? Pontos: {pontos}";

                // Limpa campo de resposta para próxima pergunta (opcional)
                txtResposta.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar a resposta: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Envia comando TCP para o servidor e recebe resposta (reaproveita seu código)
        private string EnviarComandoParaServidor(string comando)
        {
            try
            {
                string IPServer = "127.0.0.1";
                int PORT = 30000;

                using (TcpClient client = new TcpClient(IPServer, PORT))
                {
                    NetworkStream stream = client.GetStream();
                    byte[] data = Encoding.UTF8.GetBytes(comando);
                    stream.Write(data, 0, data.Length);

                    byte[] buffer = new byte[4096];
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    string resposta = Encoding.UTF8.GetString(buffer, 0, bytes);
                    return resposta;
                }
            }
            catch (Exception ex)
            {
                return "Erro ao conectar com o servidor: " + ex.Message;
            }
        }

        // Botão "Finalizar"
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            cronometro.Stop();
            MessageBox.Show($"Partida finalizada. Você fez {pontos} pontos.", "Fim de Jogo");
            this.Close();
            // opcional: voltar ao menu:
            TELA_MENU menu = new TELA_MENU();
            menu.Show();
        }

        // Botão "Voltar" (TELA_JOGO -> TELA_MENU)
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            cronometro.Stop();
            this.Close();
            TELA_MENU telaMenu = new TELA_MENU();
            telaMenu.Show();
        }

        // === Timer tick: contagem regressiva segundo a segundo ===
        private void Cronometro_Tick(object sender, EventArgs e)
        {
            tempoRestante--;
            if (tempoRestante < 0) tempoRestante = 0;

            // Mostra tempo e pontos no label que já existe no Designer (labelTimer)
            labelTimer.Text = $"? Tempo: {tempoRestante}s | ?? Pontos: {pontos}";

            if (tempoRestante <= 0)
            {
                cronometro.Stop();
                MessageBox.Show($"? Tempo esgotado! Você fez {pontos} pontos.", "Fim do Jogo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Fecha o jogo e volta ao menu
                this.Close();
                TELA_MENU menu = new TELA_MENU();
                menu.Show();
            }
        }
    }
}
