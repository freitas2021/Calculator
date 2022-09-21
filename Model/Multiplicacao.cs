using System;
namespace Calculator.Model
{
    internal class Multiplicacao
    {
        Menu menu = new Menu();
        public void multiplicacao()
        {
            float v1, v2;
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float.TryParse(Console.ReadLine(), out v1);
            Console.WriteLine("Digite o segundo valor: ");
            float.TryParse(Console.ReadLine(), out v2);

            float multiplicacao = v1 * v2;

            Console.WriteLine($"Você digitou {v1} e {v2}. O resultado da multiplicação dos valores é:   {multiplicacao}\n");
            Console.WriteLine("Pressione qualque tecla para continuar");
            Console.ReadKey();

            menu.menu();

        }
    }
}