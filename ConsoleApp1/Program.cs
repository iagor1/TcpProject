using System;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] dadossplitados = path.Split(' ');
            //Console.WriteLine(dadossplitados);


            string data;
            //foreach (var sub in dadossplitados)
            //{
            //    Console.WriteLine($"{sub}");
            //}
            //FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read);
            //FileStream fs = new FileStream(@"C:\Users\iagor.luchesi\Desktop\teste.txt", FileMode.Open, FileAccess.Read);
            //using (StreamReader sr = new(fs))
            //{
            //    data = sr.ReadToEnd();
            //}
            //Console.WriteLine(data);
            //fs.Close();
            string data = File.ReadAllText(@"C:\Users\iagor.luchesi\Desktop\access_split.log");
            Console.WriteLine(data);
            


        }
    }
}
