﻿namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int INDICE = 12, SOMA = 0, K = 1;

            while (K < INDICE)
            {

                K = K + 1;
                SOMA = SOMA + K;
            }
            Console.WriteLine(SOMA);
        }

    }
}

