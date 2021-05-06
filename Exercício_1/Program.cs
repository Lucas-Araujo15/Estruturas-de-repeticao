using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool notas;
            int resposta;
            string confirmacao;

            do
            {
                Console.Write("Digite sua nota entre 0 a 10: ");
                resposta = int.Parse(Console.ReadLine());

                if (resposta > 10 || resposta < 0)
                {
                    Console.WriteLine("O valor indicado é inválido.");
                    Console.WriteLine("Gostaria de continuar? (s/n) ");
                    confirmacao = Console.ReadLine();

                    if (confirmacao == "s")
                    {
                        notas = true;
                    }else{
                        Console.WriteLine("Agradecemos sua consulta.");
                        notas = false;
                    }
                }else{
                    Console.WriteLine("Sua nota é válida. Logo mais será avaliada pela instituição escolar.");
                    notas = false;
                }
            } while (notas == true);
        }
    }
}
