using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//IO = Input e Output

namespace ByteBankImportacaoExportacao 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        {
            var enderecoDoArquivo = "contas.txt";

            //Como parametro, esta sendo entregue o endereço do arquivo, eo modo de tratamentro(Leitura, criação, apendicee etc.)
            var fluxoAquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

            //O "buffer" é um array de bytes. Aonde eu informo parao read, quandos bytes eu quero que ele carregue para mim
            //na memoria do computador.
            var buffer = new byte[1024];// 1kb
                                  
            fluxoAquivo.Read(buffer, 0, 1024);
            EscreverNaTela(buffer);
            
            Console.ReadLine();
        }

        static void EscreverNaTela(byte[] bytes)
        {
            foreach (var meubyte in bytes)
            {
                Console.Write(meubyte);
                Console.Write(" ");
            }
        }
    }
} 
 