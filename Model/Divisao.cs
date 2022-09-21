using System;
namespace Calculator.Model
{
    internal class Divisao
    {
        Menu menu = new Menu();
        public void divisao()
        {
            float v1, v2;
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float.TryParse(Console.ReadLine(), out v1);
            Console.WriteLine("Digite o segundo valor: ");
            float.TryParse(Console.ReadLine(), out v2);

            float divisao = v1 / v2;

            Console.WriteLine($"Você digitou {v1} e {v2}. O resultado da divisão é: {divisao}\n");
            Console.WriteLine("Pressione qualque tecla para continuar");
            Console.ReadKey();

            menu.menu();

        }
    }
}