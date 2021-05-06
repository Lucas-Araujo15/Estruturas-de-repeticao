using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            double salario;
            int opcao;
            string[] estado = new string [4] {"Solteiro(a)", "Casado(a)", "Viúvo(a)", "Divorciado(a)"};

            do {
                Console.Write("Insira o seu nome completo: ");
                nome = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(nome))
                {
                    Console.WriteLine("Favor, preencher os locais obrigatórios.");
                }
            } while (string.IsNullOrWhiteSpace(nome));

            do
            {
                Console.Write("Insira sua idade: ");
                idade = int.Parse(Console.ReadLine());

                if (idade < 0 || idade > 150)
                {
                    Console.WriteLine("Favor, inserir a idade corretamente.");
                }
            } while (idade < 0 || idade > 150);

            do
            {
                Console.Write("Insira seu salário: ");
                salario = double.Parse(Console.ReadLine());

                if (salario < 0)
                {
                    Console.WriteLine("Favor, inserir um salário a partir de zero");
                }
            } while (salario < 0);

            do
            {
                Console.WriteLine("Qual seu estado civil?\n (0) Solteiro(a)\t(1) Casado(a)\n(2) Viúvo(a)\t(3) Divorciado(a)\n ");
                opcao = int.Parse(Console.ReadLine());

                if (opcao > 3 || opcao < 0)
                {
                    Console.WriteLine("Favor, escolher uma das opções apresentadas");
                }
            } while (opcao > 3 || opcao < 0);

            Console.WriteLine($@"Registro finalizado! Confira as informações abaixo:
            Nome: {nome} 
            Idade: {idade} 
            Estado civil: {estado[opcao]}  
            Salario: {salario}");
        }
    }
}
