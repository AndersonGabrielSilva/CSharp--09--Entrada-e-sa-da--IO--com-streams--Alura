using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    class FileStreamExplicacao
    {
        /*FILE STREAM
                 FileStream: "Fluxo de Arquivos".
         Arquivos.^  |  ^.Fluxo.

        Sintaxe:                                                                            
                                                                                              .Abrindo Arquivo
                                                                                            ▼´
                            var fluxoAquivo = new FileStream(enderecoDoArquivo, FileMode.Open);
                      Variavel que.^             Endereço do Arquivo.^             ^.Informo o que eu quero fazer com o arquivo,
                                                                                     eu quero ler, escrever, criar?
                                                                                     
/----------------------------------------------------------------------------------------------------------------------------------------------
       
        Criando o Fluxo de Arquivos:
        Para criar um fluxo de arquivos, é nescessario chamar o metodo ".Read" que espera receber
        1º → um array de "bytes[]", que podemos chamar tambem de "buffer", que nao é nada mais do que o tamanho do pedaço
        que sera carregado por vez para a memoria Ram.
        É aonde ele irá armazenar os bytes que ele leu no arquivo.
        
        "READ": Metódo de leitura. É o que preenche o Buffer de bytes. 
        2º → Atravez do ".read" definimos qual serao fluxo que iremos ler. E como ele funciona? o que espera receber, como parametro?
                1º) O metodo "read" espera receber uma sequencia de array de "bytes[]", ou seja um buffer.
                2º) Depois como segundo argumento ele espera o "offset" que deve receber a posição em que ele deve começar a leitura do array[]
                3º) E por fim o "count" que quer diser. ->Quantos bytes eu quero que voce leia e coloque no meu array[]
                                                             
                             
                                public override int Read(byte[] array, int offset, int count);

        Observe que o metodo "Read", retorna um int. A cada operação. Explicação ↓
        Devoluções:
        → O numero total de bytes lidos do buffer. Ele pode ser menor que o numero de bytes solicitados ou seja o "count"
        e se este numero de bytes não tiver disponivel no momento, ou seja está no final do arquivo e não há bytes sufucientes
        para preenchero array, ou "Zero" se o final do fluxo  for atingido.
               
//- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

                                                         "offset": Qual posição eu devo começar a ler?
                                                         neste caso eu quero que ele começe a gravar no começo do buffer
                                                             ↓                                   
                                   fluxoArquivo.Read(buffer, 0, 1024);
                                       .^              ^.         ▲_/"Count", e quero que grave ate o final do meu array[]
                   Local aonde esta -´                   `-Bytes[]: Array aonde será gravado os bytes
                   localizado a fonte 
                   dos bytes.         
       
         
         
         */
    }
}
