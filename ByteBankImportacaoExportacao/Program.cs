using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//IO = Input e Output
using System.Text.RegularExpressions;
using Newtonsoft.Json;
namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // TestandoStreamReader(); 
            // PopulandoContaCorrente();
            // CriarArquivo();
            //CriarArquivoComWriter();
            //PopulandoContaCorrenteECriandoArquivoJason();

            var caminhoArquivo = "ArquivoJson.json";
            string leituraJson;
            using (var fluxoArquivo = new FileStream(caminhoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoArquivo))
            {
                leituraJson = leitor.ReadToEnd();
            }

            var jsonDeserializer = JsonConvert.DeserializeObject<List<ContaCorrente>>(leituraJson);

            Console.WriteLine("FIMMM");
            Console.ReadLine();
        }

        /*Atraves deste metédo conseguimos pegar um arquivo json e converter para Classes e objetos. Assim o Compilador
         já cria para nós as classes e objetos de acordo com o que está no arquivo Json.*/
        static void DeserializandoJson()
        {            
            var caminhoArquivo = "ArquivoJson.json";
            string leituraJson;
            /*Primeiro irei abrir o Fluxo do arquivo normalmente. Depois criar um fluxo de leitura com o "Streamreader"
             desta forma conseguiremos ler o arquivo. Depois deste processo passamos todo o conteudo do arquivo para uma string.
             */
            using (var fluxoArquivo = new FileStream(caminhoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoArquivo))
            {
                leituraJson = leitor.ReadToEnd();
            }

            /*Desta forma, atraves do "JsonConvert" que esta na biblioteca "Newtonsoft.Json" COnseguimos Deserializar nosso arquivo Json
             convertendo seus dados para classes e objetos.
             Passamos como parametro u tipo de retorno que queremos, neste caso uma lista do tipo conta Corrente, e dentro dos () passando a string
             aonde contem o conteudo Json.
             Desta forma a saida é uma Lista de objetos.(ContaCorrente)*/
            var jsonDeserializer = JsonConvert.DeserializeObject<List<ContaCorrente>>(leituraJson);
        }


     
    }
}
