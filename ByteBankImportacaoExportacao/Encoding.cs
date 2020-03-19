using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    class EncodingExplicacao
    {
        /*ENCODING
         
        Como funciona a leitura de caracteres, em um sistema? Se no final são tudo bytes?

        Bem, para cada dado existe uma tabela, que nela contem os codigos (Numeros) de cada caractere para exibir algum valor,
        atraves das tabelas é realizadaa "codificação" e a "decodificação", 
        como por exemplo a tabela ASCII que ultiliza numeros de 0 a 127 para exibir algum caractere. Portanto  ela mesma é 
        muito limitada, não possuindo caracteres como os de acento, caracteres especias e etc.
        →Codificação: Trasforma os caracteres em bytes.
        →Decodificação: Transforma os bytes em caracteres.
                
        UNICODE: 
        É uma organização que define quais serão os codigos de cada caracteres. Lista → <https://en.wikipedia.org/wiki/List_of_Unicode_characters>
        Para suprir esta necessida foi criada a "Unicode" que são tabelas que possuem mais caracteres e com mais numeros
        (codigos) para representar os caracteres.Evale apena resaltar que os primeiros 126 caractres dela respeita os mesmos codigos da
        tabela ASCII.
        Cada codigo de caractere na tabela Unicode é chamado de "code point".
        
        →"Code Point": representa cada caractere na tabela da unicode.

        Para ultilizar os caracteres do unicode, é nescessario gerar um formato de transformação unicode, para ser
        possivel realizar a "codificação" e a "decodificação".

                            Formato de transformacao Unicode -> Em portugues.
                                             ↓
                            Unicode Transformation Unicode   -> Em ingles.
                                             ↓ 
                                            UFT  -----------------> Abreviação.

        UTF: É m protocolo de transformação que eu quero seguir para transformar estes bytes em textos em nossa maquina.
        como por exemplo o UTF-8.

/-------------------------------------------------------------------------------------------------------------------------------
        ENCONDING:  
        É uma classe abstrata presente no dotNet, que realiza a codificação e de codificação, dos bytes(dados). Aonde que por ela
        encontramos o UFT8 que contem os caracteres padrao "Brasil" com o "ç" etc.
        
        "Defaut": ↓
        Entre estes metodos, existe o "Defaut" que ultiliza o protocolo do nosso proprio "Sistema operacional" para realizar acodificação e a 
        decodificação dos dados.
        
        "Unicode": ↓
        No dotNet, é a mesma coisa que o UTF-16.



         */


    }
}
