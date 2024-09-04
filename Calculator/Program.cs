using System.Diagnostics;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            Menu();
        }

        static void Soma(float num1, float num2)
        {
            float soma = num1 + num2;
            Console.WriteLine($"O resultado da soma é: {soma}");
        }

        static void Subtracao(float num1, float num2)
        {
            float subtracao = num1 - num2;
            Console.WriteLine($"O resultado da subtração é: {subtracao}");
        }

        static void Multiplicacao(float num1, float num2)
        {
            float multiplicacao = num1 * num2;
            Console.WriteLine($"O resultado da multiplicação é: {multiplicacao}");
        }

        static void Divisao(float num1, float num2)
        {
            float divisao = num1 / num2;
            Console.WriteLine($"O resultado da divisao é: {divisao}");
        }

        static float PegaUmFloat()
        {
            Console.Write("Digite um numero: ");
            float num = float.Parse(Console.ReadLine());
            return num;
        }

        static void Menu()
        {
            Console.Clear();

            float v1 = PegaUmFloat();
            float v2 = PegaUmFloat();

            Console.WriteLine("");

            Console.Write("Digite a operação que deseja: [+ - * /]: ");
            string opcao = Console.ReadLine();

            if (opcao.Equals("+"))
            {
                Soma(v1, v2);
            }
            else if (opcao.Equals("-"))
            {
                Subtracao(v1, v2);
            }
            else if (opcao.Equals("*"))
            {
                Multiplicacao(v1, v2);
            }
            else if (opcao.Equals("/"))
            {
                Divisao(v1, v2);
            }
            else
            {
                Console.WriteLine("Opção Inválida!");
            }
        }
    }
}