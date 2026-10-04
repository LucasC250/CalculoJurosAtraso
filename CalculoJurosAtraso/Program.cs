using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor da conta: ");
        decimal valor = decimal.Parse(Console.ReadLine()!);

        Console.Write("Digite a data de vencimento (dd/MM/yyyy): ");
        DateTime vencimento = DateTime.ParseExact(
            Console.ReadLine()!,
            "dd/MM/yyyy",
            null
        );

        DateTime hoje = DateTime.Today;

        if (vencimento >= hoje)
        {
            Console.WriteLine("A conta não está atrasada.");
            Console.WriteLine($"Valor: R$ {valor:F2}");
        }
        else
        {
            int diasAtraso = (hoje - vencimento).Days;

            decimal juros = valor * 0.025m * diasAtraso;
            decimal valorTotal = valor + juros;

            Console.WriteLine($"\nDias de atraso: {diasAtraso}");
            Console.WriteLine($"Valor dos juros: R$ {juros:F2}");
            Console.WriteLine($"Valor total: R$ {valorTotal:F2}");
        }
    }
}