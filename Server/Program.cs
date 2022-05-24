using System;
using System.Net.Sockets;
using System.Text;
using System.IO;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener listener = new TcpListener(System.Net.IPAddress.Any, 1302);
            listener.Start();
            while (true)
            {
                Console.WriteLine("Waiting for a connection.");
                TcpClient client = listener.AcceptTcpClient();
                Console.WriteLine("Client accepted.");
                NetworkStream stream = client.GetStream();
                StreamReader sr = new StreamReader(client.GetStream()); // ver isso
                StreamWriter sw = new StreamWriter(client.GetStream());
                try
                {
                    byte[] buffer = new byte[1024];
                    stream.Read(buffer, 0, buffer.Length);
                    int recv = 0;
                    foreach (byte b in buffer)
                    {
                        if (b != 0)
                        {
                            recv++;
                        }
                    }
                    string request = Encoding.UTF8.GetString(buffer, 0, recv);
                    Console.WriteLine("request received: " + request);
                    sw.WriteLine("foi!");
                    //sw.Flush(); eu acho q esse flush é so p enviar info devolta p client
                    // fechar conexoes
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something went wrong.");
                    sw.WriteLine(e.ToString());
                }
            }
        }
    }
}