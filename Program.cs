using System;

namespace URI_1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int maiorNumero =0;
            int menorNumero =0;

            if (X > y){
                maiorNumero  = X;
                menorNumero =y;
            }
            else {
                maiorNumero = y;
                menorNumero= X;
            }
            int soma =0;
            for (int i  = menorNumero+1; i < maiorNumero; i ++){
                if (i % 2 !=0){
                    soma = i + soma;
                }                
            }
            Console.WriteLine(soma);
        }
    }
}
