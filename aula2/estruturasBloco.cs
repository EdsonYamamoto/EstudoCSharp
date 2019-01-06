using System;
using System.Collections.Generic;
using System.Text;

namespace AulasCSharp.aula2
{
    class estruturasBloco
    {
        //bloco de if
        public void BlocoIf()
        {
            if (1==1){
                System.Console.WriteLine("Verdade");
                System.Console.WriteLine(true);
                System.Console.WriteLine(1==1);
            }
        }

        //bloco de if else
        public void BlocoIfElse()
        {
            int inteiro = 1;
            int inteiro2 = 2;
            if (inteiro == inteiro2 ){
                System.Console.WriteLine("Verdade");
            }
            else{
                System.Console.WriteLine("É mentira");
            }
        }

        //bloco de if 
        public void BlocoIfComEeOu()
        {
            int inteiro = 1;
            int inteiro2 = 2;
            // && - e
            // || - ou
            if (inteiro == inteiro2 && true==false || "oi"=="ola")
            {
                System.Console.WriteLine("sei la faz algo");
            }
        }

        //bloco de for
        public void BlocoFor()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        //bloco de for
        public void BlocoWhile()
        {
            int i = 0;
            while (i < 10)
            {
                System.Console.WriteLine(i);
                i++;
            }
        }
        //bloco de for
        public void BlocoDoWhile()
        {
            string s;
            do{
                s = Console.ReadLine();
                Console.WriteLine(s);
            } while (!string.IsNullOrEmpty(s));
        }

        //para cada item dentro do vetor dentro do bloco 
        //crie um objeto com o valor da posição em sequencia
        public void BlocoForeach()
        {
            string[] args = new string[5];
            args[0] = "seila";
            args[1] = "indice 1";
            args[2] = "Scatalove";
            args[3] = "Dalhia";
            args[4] = "Eu te amo andressa";
            foreach (string s in args)
            {
                Console.WriteLine(s);
            }
        }

        //bloco condicional
        public void BlocoSwitch()
        {
            int n = 1;
            switch (n)
            {
                case 0:
                    Console.WriteLine("No arguments");
                    break;
                case 1:
                    Console.WriteLine("One argument");
                    break;
                //default acontece se não houver nenhum dos outros casos
                default:
                    Console.WriteLine($"{n} arguments");
                    break;
            }
        }
    }
}
