using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    class Stream_FluxoDeDados
    {
        /*STREAM
         
         Stream: Fluxo  
         
         O que é fluxo de dados ?

        Fluxo de dados refere-se à transferência de dados de ou para uma mídia de armazenamento. Pois em muitos casos
        não é possivel carregar todo o arquivo para a memoria ram para depois começar a manipular, ultilizando o
        fluxo de dados estes bytes sao carregados aos poucos para a memoria ram e mesmo que aindaele não tenha sido 
        carregado completamente eu consigo ir trabalhando com eles. E depois de ultilizar estes bytes eu libero o espaço 
        na memoria ram. Desta forma por exemplo eu consigo ler um arquivo de 25 kb, ultilizando apenas 1kb de memoria ram
        fazendo 25 fluxos de 1kb.
        Carrega um pouco do arquivo processae libera memoria, depois carrega mais um pouco, processa e depois libera a memoria.
        
        Beneficios:
        Eu carrega 1kb para a memoria ram, ultilizo e depois eu libero a memoria e depois, mais uma vez carrego mais 1 kb para a
        ram.
        Outro beneficio é, que já não é nescessario carregar todo o arquivo para começara ultiliza-lo, é possivel ir carregando
        aos poucos e ja ir tirando proveito.

        Exemplos concretos:
        1º → Temos os videos da internet aondenãoé nescessario carregar todo o video para nossamaquina para conseguir 
        assistir. O video vem sendo carregado aos poucos e mesmo sem que já tenha sido carregado completamente. Já
        é possivel ir assistindo o video.

        2º → Outro exemplo seria um game instalado em nosso computador. Não énescessario carregar todo ogame para nossa 
        memoria ram. O game é carregado aos poucos para a ram e de acordo com o andar do gameplay já vai liberando memoria ram.
        desta forma conseguimos rodarum jogo de 40 gigaBytes em apenas 2 gigabytes de ram.
        


/-----------------------------------------------------------------------------------------------------------------------


         */

    }
}
