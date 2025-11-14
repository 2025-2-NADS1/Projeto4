using System;
using System.Data.SQLite;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace EXEMPLO_02_SERVER
{
    class Program
    {
        static TcpListener servidor;
        static bool executando = true;
        static string caminhoBanco = @"./picmystery.db"; // Caminho do banco de dados (ATUALIZAR)

        static void Main(string[] args)
        {
            Console.WriteLine("=== SERVIDOR QUIZ - PICMYSTERY ===");
            Console.WriteLine("Banco de dados em: " + caminhoBanco);
            Console.WriteLine("Iniciando servidor em 127.0.0.1:30000 ...");

            servidor = new TcpListener(IPAddress.Parse("127.0.0.1"), 30000);
            servidor.Start();

            Thread thread = new Thread(() => EscutarClientes());
            thread.Start();

            Console.WriteLine("Servidor em execução. Pressione ENTER para encerrar...");
            Console.ReadLine();
            executando = false;
        }

        static void EscutarClientes()
        {
            while (executando)
            {
                TcpClient cliente = servidor.AcceptTcpClient();
                Thread t = new Thread(() => AtenderCliente(cliente));
                t.Start();
            }
        }

        static void AtenderCliente(TcpClient cliente)
        {
            NetworkStream stream = cliente.GetStream();
            byte[] buffer = new byte[1024];
            int bytesLidos = stream.Read(buffer, 0, buffer.Length);
            string comando = Encoding.UTF8.GetString(buffer, 0, bytesLidos).Trim();

            Console.WriteLine($"Comando recebido: {comando}");

            string resposta = "";

            if (comando.StartsWith("ME PERGUNTE"))
            {
                // Extraímos o nível de dificuldade da string de comando (por exemplo: ME PERGUNTE FACIL)
                string[] partes = comando.Split(' ');
                string dificuldadeEscolhida = partes.Length > 2 ? partes[2] : ""; // Pega a dificuldade passada pelo comando
                resposta = ObterPerguntaAleatoria(dificuldadeEscolhida); // Passa a dificuldade para filtrar as perguntas
            }
            else if (comando.StartsWith("RESPOSTA -"))
            {
                // Exemplo de comando: RESPOSTA - 20 - A
                string[] partes = comando.Split('-');
                if (partes.Length == 3)
                {
                    int idPergunta = int.Parse(partes[1].Trim());
                    string respostaUser = partes[2].Trim();
                    resposta = VerificarResposta(idPergunta, respostaUser);
                }
                else
                {
                    resposta = "Comando de resposta inválido.";
                }
            }
            else
            {
                resposta = "Comando desconhecido.";
            }

            // Envia a resposta de volta
            byte[] dadosResposta = Encoding.UTF8.GetBytes(resposta);
            stream.Write(dadosResposta, 0, dadosResposta.Length);
            cliente.Close();
        }

        // Alteração para aceitar o nível de dificuldade
        static string ObterPerguntaAleatoria(string dificuldade)
        {
            try
            {
                using (var conexao = new SQLiteConnection($"Data Source={caminhoBanco};Version=3;"))
                {
                    conexao.Open();
                    // Alterado para filtrar pela dificuldade
                    string sql = "SELECT id_pergunta, enunciado, alternativa_a, alternativa_b, alternativa_c, alternativa_d FROM Perguntas WHERE nivel_pergunta = @dificuldade ORDER BY RANDOM() LIMIT 1";
                    using (var cmd = new SQLiteCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@dificuldade", dificuldade); // Passa a dificuldade para filtrar as perguntas
                        using (var leitor = cmd.ExecuteReader())
                        {
                            if (leitor.Read())
                            {
                                return $"{leitor["id_pergunta"]}|{leitor["enunciado"]}\nA) {leitor["alternativa_a"]}\nB) {leitor["alternativa_b"]}\nC) {leitor["alternativa_c"]}\nD) {leitor["alternativa_d"]}";
                            }
                        }
                    }
                }
                return "Nenhuma pergunta encontrada.";
            }
            catch (Exception ex)
            {
                return "Erro ao buscar pergunta: " + ex.Message;
            }
        }

        static string VerificarResposta(int idPergunta, string respostaUser)
        {
            try
            {
                using (var conexao = new SQLiteConnection($"Data Source={caminhoBanco};Version=3;"))
                {
                    conexao.Open();
                    string sql = "SELECT resposta_correta FROM Perguntas WHERE id_pergunta = @id";
                    using (var cmd = new SQLiteCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@id", idPergunta);
                        string correta = (string)cmd.ExecuteScalar();
                        if (correta != null && correta.ToUpper() == respostaUser.ToUpper())
                            return "✅ Resposta correta!";
                        else
                            return $"❌ Errado! A resposta certa era: {correta}";
                    }
                }
            }
            catch (Exception ex)
            {
                return "Erro ao verificar resposta: " + ex.Message;
            }
        }
    }
}
