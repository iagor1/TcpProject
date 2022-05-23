﻿using System;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace Cliente
{
     class Program
    {
        static void Main(string[] args)
        {
            {
            connection:
                try
                {
                    TcpClient client = new TcpClient("127.0.0.1", 1302);
                    
                    string messageToSend = "teste";
                    int byteCount = Encoding.ASCII.GetByteCount(messageToSend + 1);
                    byte[] sendData = Encoding.ASCII.GetBytes(messageToSend);

                    NetworkStream stream = client.GetStream();
                    stream.Write(sendData, 0, sendData.Length);
                    Console.WriteLine("sending data to server...");

                    StreamReader sr = new StreamReader(stream);
                    string response = sr.ReadLine();
                    Console.WriteLine(response);

                    stream.Close();
                    client.Close();
                    Console.ReadKey();
                }
                catch (Exception e)
                {
                    Console.WriteLine("failed to connect...");
                    goto connection;
                }
            }
        }
    }
}
