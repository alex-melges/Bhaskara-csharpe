using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Fórmula de Bhaskara para o cálculo de raízes de polinômios de 2º grau ===\n");
        Console.WriteLine("A equação do segundo grau tem a forma: ax² + bx + c = 0");
        Console.WriteLine("Informe os coeficientes abaixo:\n");

        // Coletar os coeficientes da equação
        double a, b, c;

        // A entrada de 'a' deve ser verificada para garantir que não seja zero
        Console.Write("Digite o coeficiente a (não pode ser nulo): ");
        while (!double.TryParse(Console.ReadLine(), out a) || a == 0)
        {
            Console.WriteLine("Coeficiente 'a' precisa ser um número real e não-nulo.");
            Console.Write("Digite o coeficiente a (não pode ser nulo): ");
        }

        // Para os coeficientes 'b' e 'c', garantimos que são números válidos
        Console.Write("Digite o coeficiente b: ");
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Coeficiente 'b' precisa ser um número real.");
            Console.Write("Digite o coeficiente b: ");
        }

        Console.Write("Digite o coeficiente c: ");
        while (!double.TryParse(Console.ReadLine(), out c))
        {
            Console.WriteLine("Coeficiente 'c' precisa ser um número real.");
            Console.Write("Digite o coeficiente c: ");
        }

        // Calculando o discriminante (delta)
        double delta = Math.Pow(b, 2) - 4 * a * c;
        Console.WriteLine($"Discriminante (Δ) = {delta}");

        // Calculando as raízes
        if (delta > 0)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"As raízes reais são:");
            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"A raiz real é:");
            Console.WriteLine($"x1 = x2 = {x}");
        }
        else
        {
            double realPart = -b / (2 * a);
            double imaginaryPart = Math.Sqrt(-delta) / (2 * a);
            Console.WriteLine($"As raízes complexas são:");
            Console.WriteLine($"x1 = {realPart} + {imaginaryPart}i");
            Console.WriteLine($"x2 = {realPart} - {imaginaryPart}i");
        }
    }
}
