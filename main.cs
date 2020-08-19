using System;

class MainClass {
    public static void Main () {

        int input = 0;

        do {
            Console.WriteLine("Digite o número do exercício ou -1 para sair");
            input = Convert.ToInt32(Console.ReadLine());

            switch (input) {
                case -1:
                    Console.WriteLine("Saindo... Obrigado!");
                    break;
                case 1:
                    exercicio.um();
                    break;
                case 2:
                    exercicio.dois();
                    break;
                case 3:
                    exercicio.tres();
                    break;
                case 4:
                    exercicio.quatro();
                    break;
                default:
                    Console.WriteLine("Exercício não encontrado, tente novamente!");
                    break;
            }
        } while (input != -1);
    }
}