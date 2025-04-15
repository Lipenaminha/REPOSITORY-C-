using System;
using System.IO;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // caminho de origem .
            string sourcePath = @"c:\Ler\Arquivo.txt";

            // caminho de destino .
            string targetPath = @"c:\Ler\Arquivo2.txt";

            //tratamento de exceções 
            try
            {
                File.Copy(sourcePath, targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
