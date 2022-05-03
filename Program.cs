using System;

namespace Calculator
{
    class Program
    {
        static float v1, v2;

        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("-----------");
            Console.WriteLine("Selecione uma opção: ");

            short op = 0;

            try{
            op = short.Parse(Console.ReadLine());
            }catch(FormatException){
                Console.WriteLine("Comando inválido");
                Console.ReadKey();
                Menu();
            }
            
            switch(op){
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Sair(); break;

                default:
                Console.WriteLine("Opção inválida");
                Console.ReadKey();
                Menu();
                break;
            }

        }

        static void PegaValores()
        {
            Console.Clear();
            
            Console.WriteLine("Primeiro valor: ");
            v1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Segundo valor: ");
            v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
        }

        static void Soma()
        {
            PegaValores();
            float resultado = v1+v2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();
            Menu();
        }
   
        static void Subtracao()
        {
            PegaValores();
            float resultado = v1-v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            PegaValores();
            float resultado = v1/v2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            PegaValores();
            float resultado = v1*v2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Deseja realmente sair?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            Console.WriteLine("-----------");
            Console.WriteLine("Selecione uma opção: ");

            short op=0;

            try{
            op = short.Parse(Console.ReadLine());
            }catch(FormatException){
                Console.WriteLine("Comando inválido");
                Console.ReadKey();
                Sair();
            }

            switch(op)
            {
                case 1: Console.Clear(); System.Environment.Exit(0); break;
                case 2: Menu(); break;
                default: Console.WriteLine("Opção inválida");
                Console.ReadKey();
                Sair(); break;
            }
        }
    }
}
