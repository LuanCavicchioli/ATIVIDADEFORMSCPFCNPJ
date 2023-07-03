using System;
using System.Text;

namespace ValidarCPNJ
{
    internal class ValidarCNPJ
    {
        static void Main(string[] args)
        {
            bool validaCnpj = false;
            // Sistema de repetição para que ele fique voltando, se for digitado mais de 14 números ou alguma letra;
            while (!validaCnpj)
            {
                Console.Write("Digite o CNPJ: ");
                string cnpj = Console.ReadLine();

                if (cnpj.Length != 14)
                {
                    Console.WriteLine("O CNPJ DEVE CONTER 14 DIGITOS!");
                }
                else if (!ValidateInput(cnpj))
                {
                    Console.WriteLine("//////////////////////////////");
                    Console.WriteLine("Apenas números são permitidos!");
                    Console.WriteLine("//////////////////////////////");
                }
                else
                {
                    // Se a escrita der certo, ele vai cair aqui onde será realizado a conta do 1º e 2º dígito verificador
                    validaCnpj = true;

                    int[] mult = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                    int[] mult2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                    int dig1 = 0;
                    int dig2 = 0;
                    int[] x = new int[14];
                    int soma = 0, soma1 = 0;

                    for (int i = 0; i < 14; i++)
                    {
                        x[i] = int.Parse(cnpj[i].ToString());
                    }

                    // Cálculo primeiro dígito verificador;
                    for (int i = 0; i < 12; i++)
                    {
                        soma += x[i] * mult[i];
                    }
                    dig1 = (soma % 11 < 2) ? 0 : 11 - (soma % 11);

                    // Cálculo segundo dígito verificador;
                    for (int i = 0; i < 13; i++)
                    {
                        soma1 += x[i] * mult2[i];
                    }
                    dig2 = (soma1 % 11 < 2) ? 0 : 11 - (soma1 % 11);

                    Console.Clear();
                    if (dig1 != x[12] || dig2 != x[13])
                    {
                        Console.WriteLine("/////////////////");
                        Console.WriteLine("  CNPJ INVÁLIDO! ");
                        Console.WriteLine("/////////////////");
                    }
                    else
                    {
                        Console.WriteLine("/////////////////");
                        Console.WriteLine("   CNPJ VÁLIDO!  ");
                        Console.WriteLine("/////////////////");
                    }

                    // Adicionando a máscara ao imprimir o CNPJ, nos 2 primeiros dígitos adiciona '.', nos 6 primeiros '.', nos 9 adiciona '/', nos 12 dígitos adiciona '-', nos 14 dígitos adiciona '\n'
                    StringBuilder cnpjFormatado = new StringBuilder();
                    cnpjFormatado.Append(cnpj.Substring(0, 2)); cnpjFormatado.Append(".");
                    cnpjFormatado.Append(cnpj.Substring(2, 3)); cnpjFormatado.Append(".");
                    cnpjFormatado.Append(cnpj.Substring(5, 3)); cnpjFormatado.Append("/");
                    cnpjFormatado.Append(cnpj.Substring(8, 4)); cnpjFormatado.Append("-");
                    cnpjFormatado.Append(cnpj.Substring(12, 2)); cnpjFormatado.Append("\n");

                    Console.WriteLine("\nO CNPJ DIGITADO FOI:\n" + cnpjFormatado.ToString());
                }
            }
        }

        static bool ValidateInput(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
