using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    class Trabalhando_com_buffer
    {

        /*TRABALHANDO COM BUFFER
          Exemplo a baixo:↓
/-----------------------------------------------------------------------------------------------------------------------------------------------
           Fluxo de dados e Buffer:

                                 1º ---→ var buffer = new byte[1024];
                                        var numeroDeBytesLidos = -1;

                                        while (numeroDeBytesLidos != 0)
                                        {
                                 2º ------→ numeroDeBytesLidos = fluxoAquivo.Read(buffer,0,1024);
                                            
                                            EscreverNaTelaTexto(buffer);|>--.
                                                                            |
                                        }                                   |
                                                                            |
                                                                            |
/---------------------------------------------------------------------------|-------------------------------------------------------------------
            Metodo Escrever na tela texto:                                  |
                                                                            ↓
                                         static void EscreverNaTelaTexto(byte[] bytes, int bytesLidos)
                                         {
                                             Formas de realizar a transformação
                                            
                                             O "Defaut" é o formato padrao do meu Sistema Operacional
                                             var utf8 = Encoding.Default;

                                             Console.Write(utf8.GetString(bytes));

                                         }

       1º →  No exemplo a cima, eu estou criando um buffer (bytes[]), para depois poder ultilizar no metodo ".Read" no item 2º.
       2º →  No metodo ".Read", eu estou passando este buffer como parametro e dizendo. "Eu quero que voce leia apartir do indice 0
       e quero que voce leia ate a posição 1024". E o que o metodo "Read" faz? ele garante para a gente que ele ira ler ate 1024. 

       Porêm não será sempre que sera nescessario ler 1024. por exemplo: Ao final do arquivo (Do fluxo), pode ser que não tenha bytes
       necessarios para completar o array. E assim desta forma no ultimo ciclo pode ser que ele repita os dados do ciclo anterior 
       "Lixo no buffer". 
       Para resolver este problema é nescessario informar ao metodo ".Read" até que indice ele poderá ler, no parametro "count".
       E como fazer isto? Como saber ate aonde eu posso ler?. Simples 

       No metodo "Escrever Na Tela Texto" , sempre será escrito na tela o tamanho completo do bytes[], e isto é um problema pois
       mesmo se na linha de cima, antes do metodo "Escrever na tela" o metodo ".Read" não tenha lido e preenchido todos os dados 
       do buffer, ainda sim contem lixo do ciclo anterior.

       O metodo ".Read" retorna um numero inteiro que é a quantidade de indices (bytes) que ele leu, podemos informar como parametro no count 
       este numero. Desta forma se a leitura dos indices forem menor que o tamanho o array, isto não importa, pois ele irá ler apenas
       ate o indice "count" que iremos passar como parametro. Ou seja a devolução do metodo ".Read"

       Para resolver este problema, podemos informar a posição do indice que gostariamos de realizar a decodificação, no metodo "Getstring" 
       que é o metodo que decodifica os bytes em texto e pertence a classe "Enconding". O "Getstring" possui uma sobrecarga que recebe os mesmos 
       parametros do ".Read" que é possivel informar o indice inicial e o final que gostariamos de realizar a decodificação. Ou seja
       podemos pegar o devolução do ".Read" e informar como parametro a posição dos indices como parametro "count", pois estamos informando 
       que lemos até aquela posição ou seja decodifica até ela.


                                           ...

                                               Console.Write(utf8.GetString(bytes,0,bytesLidos));
                                                                                        ^
                                           ...                                        .´    
                                                       Devolução do metodo ".Read" -´   

        .GetString: decodifique até esta posição. pois alem dela contem lixo.
          
         
         METODO GETSTRING:
         
         .GetString: 
         
         
         */

    }
}
