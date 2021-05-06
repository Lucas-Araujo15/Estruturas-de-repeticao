using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario;
            string senha;
            string confirmacao;
            bool tentativa = false;
            bool repeticao = true;

            do
            {
                Console.Write("Digite seu nome de usuário: ");
                usuario = Console.ReadLine();

                Console.Write("Digite sua senha: ");
                senha = Console.ReadLine();

                if (usuario == senha)
                {
                    Console.WriteLine("Sua senha é semelhante ao seu nome de usuário.");
                    Console.Write("Gostaria de tentar novamente? (s/n) ");
                    confirmacao = Console.ReadLine();

                    if (confirmacao == "s")
                    {
                        tentativa = true;
                    }
                    else
                    {
                        Console.WriteLine("Agradecemos sua consulta!");
                        tentativa = false;
                    }
                }
                else if (senha.Length > 10)
                {
                    do
                    {
                        Console.WriteLine("Sua senha extrapola o limite suportado.");
                        Console.Write("Gostaria de tentar novamente? (s/n) ");
                        confirmacao = Console.ReadLine();

                        if (confirmacao == "s")
                        {
                            Console.Write("Digite sua senha: ");
                            senha = Console.ReadLine();

                            if (senha.Length <= 10)
                            {
                                repeticao = false;
                                tentativa = false;
                                Console.WriteLine("Agradecemos sua consulta. Aguarde por mais informações!");
                            }
                            else
                            {
                                repeticao = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Agradecemos sua consulta!");
                            tentativa = false;
                            repeticao = false;
                        }
                    } while (repeticao == true);
                }
                else
                {
                    Console.WriteLine("Agradecemos seu cadastro. Aguarde por mais informações!");
                    tentativa = false;
                }
            } while (tentativa == true);

        }
    }
}
