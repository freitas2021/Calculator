using System;
namespace Calculator.Model
{
    internal class Soma
    {
        Menu menu = new Menu();
        public void soma()
        {
            float v1, v2;
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float.TryParse(Console.ReadLine(), out v1);
            Console.WriteLine("Digite o segundo valor: ");
            float.TryParse(Console.ReadLine(), out v2);

            float soma = v1 + v2;

            Console.WriteLine($"Você digitou {v1} e {v2}. A soma dos valores é: {soma}\n");
            Console.WriteLine("Pressione qualque tecla para continuar");
            Console.ReadKey();

            menu.menu();

        }
    }
}