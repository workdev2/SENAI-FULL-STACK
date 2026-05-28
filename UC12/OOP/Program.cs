using System;
// Namespace System.IO - Contém tipos que permitem a leitura e escrita em arquivos 
// e dados de fluxo, e tipos que fornecem suporte para a manipulação de arquivos e 
//diretórios.
using System.IO;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Caminho do arquivo a ser criado
            string path = "C:\\Workspace\\Senai-FullStack\\UC12\\OOP\\arquivo.txt";

            // Escrevendo no arquivo
            var stream = new StreamWriter(path);
            stream.Write("Olá, este é um arquivo de exemplo.");
            
            //fecha o arquivo para garantir que os dados sejam gravados corretamente
            stream.Close();
            // o uso do using é recomendado para garantir que os recursos sejam liberados corretamente, mesmo em caso de exceções
             using (var reader = new StreamReader(path))
            {
                // lê a linha e retorna a string
                Console.WriteLine(reader.ReadLine());
            }
           
        }
    }
}
