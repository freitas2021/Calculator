using System;
namespace Calculator.Model
{
    internal class Menu
    {
        public void menu()
        {
            Console.Clear();

            Console.WriteLine($"\t   CALCULADORA ");
            Console.WriteLine($"Escolha a operação que deseja fazer: \n ");
            Console.WriteLine("-------------------");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("-------------------");

            short opcao;
            short.TryParse(Console.ReadLine(), out opcao);

            switch (opcao)
            {
                case 1:
                    Soma soma = new Soma();
                    soma.soma();
                    break;
                case 2:
                    Subtracao subtracao = new Subtracao();
                    subtracao.subtracao();
                    break;
                case 3:
                    Multiplicacao multiplicacao = new Multiplicacao();
                    multiplicacao.multiplicacao();
                    break;
                case 4:
                    Divisao divisao = new Divisao();
                    divisao.divisao();
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
                default:
                    Menu menu = new Menu();
                    menu.menu();

                    break;
            }
        }
    }
}
