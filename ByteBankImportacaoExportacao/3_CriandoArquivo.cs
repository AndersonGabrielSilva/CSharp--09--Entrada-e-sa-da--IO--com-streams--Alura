using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//IO = Input e Output
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void CriarArquivo()
        {
                        
            var caminhoNovoArquivo = "contasExportadas.csv";
            var stringQueDesejoGravarNoArquivo = "428,56987,2500.78,Anderson Gabriel";
            using (var fluxoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                //Estou criando o codificador/Decodificador
                var enconding = Encoding.UTF8;
                var bytes = enconding.GetBytes(stringQueDesejoGravarNoArquivo);
                
                //O metodo "Write", espera receber 
                fluxoArquivo.Write(bytes,0,bytes.Length);
            }
        }



        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";


            using (var fluxoArquivo = new FileStream(caminhoNovoArquivo,FileMode.Create))
            using (var escritor = new StreamWriter(fluxoArquivo,Encoding.UTF8))
            {
                escritor.Write("362,55478,1500.25,Anderson Silva");
            }
        }

        static void CriarArquivoJson(string json)
        {
            var caminhoNovoArquivo = "ArquivoJson.json";

            /*Para Criar um arquivo "Json" não muda muita coisa, Criamos um fluxo de arquivo com a classe
             * "FileStream" chamamos o "FileMode.Create" para criar um arquivo novo. E depois escrevemos a string
             em um arquivo texto com a classe "StreamWriter"*/
            using (var fluxoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoArquivo))
            {
                escritor.Write(json);
            }

        }

    }
}