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
        static void PopulandoContaCorrente()
        {

            var enderecoDoArquivo = "contas.txt";
            var listaConta = new List<ContaCorrente>();

            using (var fluxoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                     var conta = QuebrandoStringEPopulandoContaCorrente(linha);                    
                     listaConta.Add(conta);
                    Console.WriteLine($"Numero: {conta.Numero}  Agencia: {conta.Agencia}  Saldo: {conta.Saldo}  Nome: {conta.Titular.Nome}.");
                }
                
            }
        }

        static void PopulandoContaCorrenteECriandoArquivoJason()
        {

            var enderecoDoArquivo = "contas.txt";
            var listaConta = new List<ContaCorrente>();
            ContaCorrente conta;

            using (var fluxoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    conta = QuebrandoStringEPopulandoContaCorrente(linha);
                    listaConta.Add(conta);
                    Console.WriteLine($"Numero: {conta.Numero}  Agencia: {conta.Agencia}  Saldo: {conta.Saldo}  Nome: {conta.Titular.Nome}.");
                }

            }

            //Gerar Arquivo Json ↓
            var json_serializer = JsonConvert.SerializeObject(listaConta);
            CriarArquivoJson(json_serializer);

            /*O metodo "SerializeObjecr" transforma a lista de objetos em uma string com o formato "json". Depois de transformar
             toda a lista em uma string, Passamos esta string como parametro no metodo "Criar arquivo Json"*/
        }
        //-  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  

        static ContaCorrente QuebrandoStringEPopulandoContaCorrente(string linha)
        {
            /*Atraves do metodo "Split" eu quebro a string a cada caractere que eu passar como parametro neste caso ' '. Estou
             passando o espaço, a cada espaço ele irá quebrar a string e ira retornar um "string[]" (array), aonde as posicoes
             é justamente os pedaços da string.*/
            string[] campos = linha.Split(',');

            /*Depois de quebrar a linha o que eu quero dela? Par acessar os pedaços, é muito simples é somente acessar os indices
            dela. Porem podemos observar que lá no "arquivo.txt" o saldo está sendo representado com "."(Ponto) e por isto ao realizar
            a conversao para double ele é ignorado e o saldo fica muito alem do que realmente é.
            Para concertar isto é nescessario trocar o ponto pela ","(virgula), e como fazemos isto? Já aprendemos como trocar caracteres
            com o metodo replace().
            Que troca um caractere por outro, por este motivo utilizamos ele no campo saldo. desta maneira o compilador entendera que 
            depois da "," se trata dos centavos.
            */
            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.', ',');

            var nome = campos[3];

            //Convert.ToInt32(): Converte a string para um numero inteiro, ou double.
            //int.Parse() e doouble.Parse(): realiza a mesma função do Convert.To convertendo string
            var agenciaInt = Convert.ToInt32(agencia);
            var numeroInt = Convert.ToInt32(numero);
            var saldoDouble = Convert.ToDouble(saldo);


            var contaQueIreiPopular = new ContaCorrente(agenciaInt, numeroInt);
            contaQueIreiPopular.Depositar(saldoDouble);
            contaQueIreiPopular.Titular.Nome = nome;

            return contaQueIreiPopular;
        }
 //----------------------------------------------------------------------------------------------------------------------------------------------------

        static void TestandoStreamReader()
        {

            // TestaFileStream();           
            // ExercicioTeste();
            // TestandoEncoding();
            //ExerciciosRegex();
            //TestandoUsing();

            var enderecoDoArquivo = "contas.txt";


            /*Quando Possuimos dois using, um dentro do outro. Podemos retirar os {} do using mais externo e colocar o using interno logo abaixo 
             dele, assim nosso codigo fica mais limpo e elegante.*/
            using (var fluxoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoArquivo))
            {
                //var linha = leitor.ReadLine();
                //Console.WriteLine(linha);

                //var lerTudo = leitor.ReadToEnd();
                //Console.WriteLine(lerTudo);


                /*Para ler até o final sem utilizar o metodo "ReadToEnd", podemos criar um laço de repetição que irá ler
                 linha por linha, enquanto o arquivo não chegar no final.
                 O responsavel para verificar isto é o "EndOfStream", que é uma propriedade da classe stream, ele retorn um valor bool
                 verificando se o arquivo chegou ou não no final. Desta forma usamos menos recursos (Ram)*/
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    Console.WriteLine(linha);
                }
            }
        }
    }
}