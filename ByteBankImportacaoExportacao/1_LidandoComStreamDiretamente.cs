﻿using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//IO = Input e Output
using System.Text.RegularExpressions;

namespace ByteBankImportacaoExportacao
{
//----------------------------------------------------------------------------------------------------------------------------------------------------
    /*Atraves da palavra reservada "partial" informamos ao compilador que não a classe "program" não está duplicada e sim na realizade é uma so
     * classe dividida em dois arquivos separados. Desta forma, podemos ter "duas" classes com o mesmo nome, porem não são duas classes e sim 
     * apenas uma, dividida em dois arquivos.
     * Desta forma podemos ter apenas uma classe, com seus metodos separados em varios arquivos.*/
    partial class Program
    {     

        static void ExerciciosRegex()
        {
            /*Ainda não esta funcionando como deve ser. Dar uma olhadmais tarde!!!*/
            var enderecoDoArquivo = "RegexExercicio.txt";

            using (var fluxoAquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                var buffer = new byte[1024];
                var numeroDeBytesLidos = -1;
                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoAquivo.Read(buffer, 0, 1024);

                    RegexTeste(buffer, numeroDeBytesLidos);
                      
                }
            }
        }
//-  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  

        static void RegexTeste(byte[] bytes, int bytesLidos)
        {
            var utf8 = Encoding.UTF8;
            //Retorna uma cadeia de caracteres.

            //375 4644 -> Padrão do texto
            string padrao = "[0-9]{3} [0-9]{4}";
            string texto = utf8.GetString(bytes, 0, bytesLidos);

            var MatchesEncontrado = Regex.Matches(texto, padrao);

            foreach (Match match in MatchesEncontrado)
            {
                Console.WriteLine("Agencia e Numero: {0}", match.Value);
            }
        }
//----------------------------------------------------------------------------------------------------------------------------------------------------

        static void ExercicioTeste()
        {
            /*Gabriela começou a testar a leitura de arquivos com C# e criou o arquivo teste.txt abaixo:

                 O que esta escrito no arquivo → Arquivo: "para ser lido com código C#."
                 Para ler e exibir o documento na tela, criou o código abaixo:

             Contudo, a saída não foi o que ela esperava. Marque as alternativas corretas: (Faça o teste em sua máquina!)    
             RESPOSTA:

            ->A saída foi Arquivo para ser lido com c?digo C#..
            -Correta! O caractere ó não possui representação no encoding ASCII, 
            -por isto o resultado da chamada encoding.GetString foi este.
             
             */

            var fs = new FileStream("teste.txt", FileMode.Open);

            var buffer = new byte[1024];
            var encoding = Encoding.ASCII;

            var bytesLidos = fs.Read(buffer, 0, 1024);
            var conteudoArquivo = encoding.GetString(buffer, 0, bytesLidos);

            Console.Write(conteudoArquivo);
        }
//----------------------------------------------------------------------------------------------------------------------------------------------------

        static void TestandoUsing()
        {
            var enderecoDoArquivo = "contas.txt";
            /*O "using" somente pode ser implementado se a classe que ele recebe como aergumento implementa a interface
             "IDisposable". 
             Sintaxe:
                →Primeiro se ultiliza a palavra reservada using e dentro dos () coloca o recurso que queremos ultilizar, que 
                ao final da execução dele eu desejo liberar. 
                →No nosso caso estamos ultilizando o FileStream e logo apos sua execução queremos liberar este recurso. (Fechar arquivo).
                →Quando ultilizamos o "using" porbaixo dos panos ele esta impementando o "Try"e o "finally".  Aonde "finally" fica implementado na 
                interface IDisposable(No metodo).
                →Neste caso, nós não presisamos criar este metodo, pois o dotNet já tem isto implementado para nós. Internamente
                o metodo "Disposable" chama para nos o metodo close().
                →Desta maneira ultilizando o Using ele será fechado logo apos a execução das instrucoes.*/
            using (var fluxoAquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                var buffer = new byte[1024];
                var numeroDeBytesLidos = -1;
                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoAquivo.Read(buffer, 0, 1024);
                    EscreverNaTelaTexto(buffer, numeroDeBytesLidos);

                }
            }


        }
 //----------------------------------------------------------------------------------------------------------------------------------------------------

        static void TestandoEncoding()
        {
            var enderecoDoArquivo = "contas.txt";

            var fluxoAquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

            var buffer = new byte[1024];


            var numeroDeBytesLidos = -1;

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoAquivo.Read(buffer, 0, 1024);
                EscreverNaTelaTexto(buffer, numeroDeBytesLidos);

            }
            //O arquivo esta sendo fechado e liberando acesso para o sistema
            fluxoAquivo.Close();
        }
//-  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  
        static void EscreverNaTelaTexto(byte[] bytes, int bytesLidos)
        {
            //Formas de realizar a transformação
            //var utf8 = new UTF8Encoding();
            //var utf8 = Encoding.UTF8;

            //O "Defaut" é o formato padrao do meu Sistema Operacional
            var utf8 = Encoding.Default;

            Console.Write(utf8.GetString(bytes, 0, bytesLidos));

        }
//----------------------------------------------------------------------------------------------------------------------------------------------------

        static void TestaFileStream()
        {
            var enderecoDoArquivo = "contas.txt";


            //Como parametro, esta sendo entregue o endereço do arquivo, eo modo de tratamentro(Leitura, criação, apendicee etc.)
            var fluxoAquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

            //O "buffer" é um array de bytes. Aonde eu informo parao read, quandos bytes eu quero que ele carregue para mim
            //na memoria do computador.
            var buffer = new byte[1024];// 1kb

            /*Irá receber o numero de bytes lidos. Pasamoso valor de "-1" por que é um valor que ele nunca irá retornar.*/
            var numeroDeBytesLidos = -1;

            //Desta forma, com este while ultilizamos apenas "1kb" para processar um arquivo de 25kb.
            //Ele verifica se o "Numero De Bytes Lidos" édiferente e zero e realiza o ciclo ate terminaro arquivo
            //e retornar zero.
            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoAquivo.Read(buffer, 0, 1024);
                EscreverNaTelaBytes(buffer);
            }
        }
//-  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  

        static void EscreverNaTelaBytes(byte[] bytes)
        {
            // Lendo Apenas 1024 bytes = 1 Array[]
            foreach (var meubyte in bytes)
            {
                Console.Write(meubyte);
                Console.Write(" ");
            }
        }
//----------------------------------------------------------------------------------------------------------------------------------------------------

    }

}