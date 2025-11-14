using System;
using System.Net.Sockets;
using System.Text;

namespace EXEMPLO_02_CLIENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("COMANDOS VÁLIDOS:");
            Console.WriteLine("ME PERGUNTE");
            Console.WriteLine("RESPOSTA - id_pergunta - A/B/C/D");  // Comando de resposta alterado

            while (true)
            {
                // Lê comando do usuário
                Console.Write("Digite seu comando: ");
                string comando = Console.ReadLine();

                // Conectar ao servidor
                string IPServer = "127.0.0.1";
                int PORT = 30000;
                try
                {
                    using (TcpClient client = new TcpClient(IPServer, PORT))
                    {
                        NetworkStream stream = client.GetStream();
                        byte[] data = Encoding.UTF8.GetBytes(comando);

                        // Enviar comando para o servidor
                        stream.Write(data, 0, data.Length);

                        // Receber resposta do servidor
                        byte[] buffer = new byte[4096];
                        int bytes = stream.Read(buffer, 0, buffer.Length);
                        string resposta = Encoding.UTF8.GetString(buffer, 0, bytes);
                        Console.WriteLine("[Servidor] " + resposta);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
            }
        }
    }
}
