using System;

class exercicio {

    public static void um () {
        Console.WriteLine("Olá Mundo!");
    }

    public static void dois () {
        Console.Write("Informe um número: ");
        string num = Console.ReadLine();
        Console.WriteLine("O numero informado foi " + num);
    }

    public static void tres () {
        Console.Write("Informe o primeiro número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Informe o segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("A soma de {0} + {1} é = {2}", num1, num2, num1+num2);
    }

    public static void quatro () {
        Console.Write("Informe a primeira nota: ");
        float nota1 = float.Parse(Console.ReadLine());
        Console.Write("Informe a segunda nota: ");
        float nota2 = float.Parse(Console.ReadLine());
        Console.Write("Informe a terceira nota: ");
        float nota3 = float.Parse(Console.ReadLine());
        Console.Write("Informe a quarta nota: ");
        float nota4 = float.Parse(Console.ReadLine());

        float media = (nota1 + nota2 + nota3 + nota4) / 4;

        Console.WriteLine("A média é " + media);
    }
}