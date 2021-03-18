using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Consulta
{
    class Program
    {
        static void Main(string[] args)
        {volta:
            Console.WriteLine("Informaçãoes sobre usuarios cadastrados\n");
            Console.WriteLine("0)ANTONIO CLAUDIO\n1)MARCOS ADABERTO DE SOLZA\n2)ELIANE MARIA CONCEICAO");
            int capture = int.Parse(Console.ReadLine());
            if(capture>2)
            {
                Console.WriteLine("******************* USUARIO NÃO EXISTE!************");
                goto volta;
            }
            Console.Clear();
            string[] link = new string[] { @"C:\Users\Julia3000\Desktop\c#programing\Consulta\Consulta\c1.txt", @"C:\Users\Julia3000\Desktop\c#programing\Consulta\Consulta\c2.txt",
            @"C:\Users\Julia3000\Desktop\c#programing\Consulta\Consulta\c3.txt"};
            using(StreamReader reader = new StreamReader(link[capture]))
            {
                while(!reader.EndOfStream)
                {
                    
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                  
                }
            }


            




            Console.ReadKey();
        }
    }
}
