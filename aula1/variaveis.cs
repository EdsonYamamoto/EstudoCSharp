using System;
using System.Collections.Generic;
using System.Text;

namespace AulasCSharp.aula1
{
    class variaveis
    {
        //essas barras são comentario de linha
        /*
            isso daqui é um comentario de bloco
        */

        //vamos la, as variaveis da linguagem
        //cada varivel instanciada é um objeto do sistema

        //true e false
        bool tipoBooleana;
        //inteiros
        int tipoInteiro;
        //inteiros maiores
        long tipoLong;
        //floats
        float tipoFloat;
        //floats maiores
        double tipoDouble;
        //numeros ate com 28 casas decimais
        decimal tipoDecimal;
        //tipo char
        char tipoChar;
        //vetor de chars
        string tipoString;

        //demais tipos
        ulong tipoUlong;
        uint tipoUinteiro2;
        byte tipoByte;
        sbyte tipoSByte;
        short tipoShort;
        ushort tipoUshort;

        //tipo vetor de inteiros
        int[] vetorInteiro;

        //tipo lista, ele é parecido com o vetor porem tem outros atributos
        //a tributo vai dentro das "<" e ">"
        List<int> listaInteiros;

        void metodoQualquer()
        {
            //A VARIAVEL MAIS GENERICA que aceita ser qualquer coisa
            var variavelGenerica = new List<int> {1, 2, 7, 9 };
        }
    }
}
