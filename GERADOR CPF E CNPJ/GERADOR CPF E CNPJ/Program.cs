using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace VALIDAR_CPF
    {
        internal class Program
        {



            static void Main(string[] args)
            {
                ExibirLogo();
                ExibirMenu();
                string opção = Console.ReadLine();
                while (true)
                {
                    switch (opção)
                    {
                        
                        case "1":
                            
                            Console.WriteLine("Opção 1 selecionada, o cpf sera gerado!");
                            GerarCpf();
                            break;



                        case "2":
                            GerarCnpj();
                            Console.WriteLine("Opção 2 selecionada , o cpnj sera gerado!");
                            break;



                        case "3":
                            Console.WriteLine("Fim da execução do programa!");
                            break;



                        default:
                            Console.WriteLine("Opção nao disponivel");
                            break;
                    }
                
                Console.WriteLine("Deseja tentar novamente? (S/N)");
                string tentarNovamente = Console.ReadLine();
                if (tentarNovamente.ToUpper() != "S")
                    break;
            }
            }




            



















            static void ExibirLogo()
            {
                Console.WriteLine(@"

            ░██████╗░███████╗██████╗░░█████╗░██████╗░░█████╗░██████╗░  ██████╗░███████╗  ░█████╗░██████╗░███████╗
            ██╔════╝░██╔════╝██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗  ██╔══██╗██╔════╝  ██╔══██╗██╔══██╗██╔════╝
            ██║░░██╗░█████╗░░██████╔╝███████║██║░░██║██║░░██║██████╔╝  ██║░░██║█████╗░░  ██║░░╚═╝██████╔╝█████╗░░
            ██║░░╚██╗██╔══╝░░██╔══██╗██╔══██║██║░░██║██║░░██║██╔══██╗  ██║░░██║██╔══╝░░  ██║░░██╗██╔═══╝░██╔══╝░░
            ╚██████╔╝███████╗██║░░██║██║░░██║██████╔╝╚█████╔╝██║░░██║  ██████╔╝███████╗  ╚█████╔╝██║░░░░░██║░░░░░
            ░╚═════╝░╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝  ╚═════╝░╚══════╝  ░╚════╝░╚═╝░░░░░╚═╝░░░░░

 

            ███████╗  ░█████╗░██████╗░███╗░░██╗░░░░░██╗
            ██╔════╝  ██╔══██╗██╔══██╗████╗░██║░░░░░██║
            █████╗░░  ██║░░╚═╝██████╔╝██╔██╗██║░░░░░██║
            ██╔══╝░░  ██║░░██╗██╔═══╝░██║╚████║██╗░░██║
            ███████╗  ╚█████╔╝██║░░░░░██║░╚███║╚█████╔╝
            ╚══════╝  ░╚════╝░╚═╝░░░░░╚═╝░░╚══╝░╚════╝░   
                ");
            }
            static void ExibirMenu()
            {
                Console.WriteLine("1- Para gerar CPF");
                Console.WriteLine("2- Para gerar CNPJ");
                Console.WriteLine("3- Sair");
            }
            static void GerarCpf()
            {
                Random cpf = new Random();



                int n1 = cpf.Next(0, 10);
                int n2 = cpf.Next(0, 10);
                int n3 = cpf.Next(0, 10);
                int n4 = cpf.Next(0, 10);
                int n5 = cpf.Next(0, 10);
                int n6 = cpf.Next(0, 10);
                int n7 = cpf.Next(0, 10);
                int n8 = cpf.Next(0, 10);
                int n9 = cpf.Next(0, 10);
                int soma, soma1;
                int dig1, dig2;




                soma = n1 * 10 + n2 * 9 + n3 * 8 + n4 * 7 + n5 * 6 + n6 * 5 + n7 * 4 + n8 * 3 + n9 * 2;



                dig1 = soma % 11;



                if (dig1 < 2)
                {
                    dig1 = 0;
                }
                else
                {
                    dig1 = 11 - dig1;
                }



                soma1 = n1 * 11 + n2 * 10 + n3 * 9 + n4 * 8 + n5 * 7 + n6 * 6 + n7 * 5 + n8 * 4 + n9 * 3 + dig1 * 2;



                dig2 = soma1 % 11;



                if (dig2 < 2)
                {
                    dig2 = 0;
                }
                else
                {
                    dig2 = 11 - dig2;
                }



                Console.WriteLine(n1.ToString() + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + dig1 + dig2);
            }
            static void GerarCnpj()
            {
                Random cnpj = new Random();
                int n1 = cnpj.Next(0, 12);
                int n2 = cnpj.Next(0, 12);
                int n3 = cnpj.Next(0, 12);
                int n4 = cnpj.Next(0, 12);
                int n5 = cnpj.Next(0, 12);
                int n6 = cnpj.Next(0, 12);
                int n7 = cnpj.Next(0, 12);
                int n8 = cnpj.Next(0, 12);
                int n9 = 0;
                int n10 = 0;
                int n11 = 0;
                int n12 = 1;
                int soma, soma1;
                int dig1, dig2;



                soma = n1 * 5 + n2 * 4 + n3 * 3 + n4 * 2 + n5 * 9 + n6 * 8 + n7 * 7 + n8 * 6 + n9 * 5 + n10 * 4 + n11 * 3 + n12 * 2;



                dig1 = soma % 11;
                if (dig1 < 2)
                {
                    dig1 = 0;



                }
                else
                {
                    dig1 = 11 - dig1;
                }
                soma1 = n1 * 6 + n2 * 5 + n3 * 4 + n4 * 3 + n5 * 2 + n6 * 9 + n7 * 8 + n8 * 7 + n9 * 6 + n10 * 5 + n11 * 4 + n12 * 3 + dig1 * 2;



                dig2 = soma1 % 11;
                if (dig2 < 2)
                {
                    dig2 = 0;
                }
                else
                {
                    dig2 = 11 - dig2;
                }
                Console.WriteLine(n1.ToString() + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10 + n11 + n12 + dig1 + dig2);
            }
        }

    }

    

