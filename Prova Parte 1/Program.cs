using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Prova_Parte_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 30;
            int b = 10;
            int soma = a + b;

            int c = -10;
            int d = -30;
            int resultado = c - d;

            int e = 0;
            int s = 0;
            int w = e + s;

            Console.WriteLine("Exercicio 1");

            Console.WriteLine(" ");

            Console.WriteLine("Resuntado=" + soma);

            Console.WriteLine("Resultado=" + resultado);

            Console.WriteLine("Resuntado=" + w);

            Console.WriteLine("----------------");

            Console.WriteLine("Exercico 2");

            Console.WriteLine("");

            double valordePI = 3.14159;

            double multiplicador = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Resultado = valordePI * multiplicador * multiplicador;

            Console.WriteLine("valor=" + Resultado.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("-----------------------");

            Console.WriteLine("Exercicios 3");

            Console.WriteLine(" ");

            int valor1 = 5;

            int valor2 = 6;

            int valor3 = 7;

            int valor4 = 8;

            int valor = valor1 * valor2 - valor3 * valor4;

            Console.WriteLine("Resultado" + valor);

            int valor5 = 5;

            int valor6 = 6;

            int valor7 = -7;

            int valor8 = 8;

            int Valor = valor5 * valor6 - valor7 * valor8;

            Console.WriteLine("Diferença =-" + Valor);

            Console.WriteLine("-------------------");

            Console.WriteLine("Exercicios 4");

            Console.WriteLine(" ");

            int number = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int salario = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Multiplicador = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = salario * Multiplicador;

            Console.WriteLine("Number= " + number);

            Console.WriteLine("Salary= " + total.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(" ");

            Console.WriteLine("exercicio 5");

            string[] valores = Console.ReadLine().Split(' ');

            int Cog1 = int.Parse(valores[0]);

            int quantidade1 = int.Parse(valores[1]);

            double preço1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            string[] valores2 = Console.ReadLine().Split(' ');

            double cog2 = double.Parse(valores2[0]);

            double quatidade2 = double.Parse(valores2[1]);

            double preço2 = double.Parse(valores2[2], CultureInfo.InvariantCulture);

            double Total = preço1 * quantidade1 + preço2 * quatidade2;


            Console.WriteLine("valor a Pagar = R$ " + Total.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("-----------------");

            Console.WriteLine("Exercicios 6 Final");

            Console.WriteLine(" ");

            string[] Valores = Console.ReadLine().Split(' ');

            double pontoA = double.Parse(Valores[0],CultureInfo.InvariantCulture);

            double pontoB = double.Parse(Valores[1], CultureInfo.InvariantCulture);

            double pontoC = double.Parse(Valores[2], CultureInfo.InvariantCulture);

            double triangulo = pontoA * pontoC / 2.0;

            double circulo = 3.14159 * pontoC * pontoC;

            double trapazio = (pontoA + pontoC) / 2.0 * pontoC;

            double quadrado = pontoB * pontoB;

            double retangulo = pontoA * pontoB;

            Console.WriteLine("triangulo = "+triangulo.ToString("F3"),CultureInfo.InvariantCulture);

            Console.WriteLine("circulo = "+circulo.ToString("F3"),CultureInfo.InvariantCulture);

            Console.WriteLine("trapezio = "+trapazio.ToString("F3"),CultureInfo.InvariantCulture);

            Console.WriteLine("quadrado = "+quadrado.ToString("F3"),CultureInfo.InvariantCulture);

            Console.WriteLine("retangulo = "+retangulo.ToString("F3"),CultureInfo.InvariantCulture);













        }
    }
}
