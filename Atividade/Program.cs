using System;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;

            Console.WriteLine("Informar Nome");
            string var_nome = Console.ReadLine();

            Console.WriteLine("Informar Endereço");
            string var_endereco = Console.ReadLine();

            Console.WriteLine("Pessoa Física (f) ou Jurídica (j) ?");
            string var_tipo = Console.ReadLine();

            if (var_tipo == "f")
            {
                // --- Pessoa Física ----
                Pessoa_Fisica pf = new Pessoa_Fisica
                {
                    Nome = var_nome,
                    Endereco = var_endereco
                };

                Console.WriteLine("Informar CPF:");
                pf.Cpf = Console.ReadLine();

                Console.WriteLine("Informar RG:");
                pf.Rg = Console.ReadLine();

                Console.WriteLine("Informar Valor de Compra:");
                val_pag = float.Parse(Console.ReadLine());

                pf.PagarImposto(val_pag);

                Console.WriteLine("-------- Pessoa Física ---------");
                Console.WriteLine("Nome ..........: " + pf.Nome);
                Console.WriteLine("Endereço ......: " + pf.Endereco);
                Console.WriteLine("CPF ...........: " + pf.Cpf);
                Console.WriteLine("RG ............: " + pf.Rg);
                Console.WriteLine("Valor de Compra: " + pf.Valor.ToString("C"));
                Console.WriteLine("Imposto .......: " + pf.ValorImposto.ToString("C"));
                Console.WriteLine("Total a Pagar : " + pf.Total.ToString("C"));
            }
            else if (var_tipo == "j")
            {
                // Pessoa Jurídica
                Pessoa_Juridica pj = new Pessoa_Juridica
                {
                    Nome = var_nome,
                    Endereco = var_endereco
                };

                Console.WriteLine("Informar CNPJ:");
                pj.Cnpj = Console.ReadLine();

                Console.WriteLine("Informar IE:");
                pj.Ie = Console.ReadLine();

                Console.WriteLine("Informar Valor de Compra:");
                val_pag = float.Parse(Console.ReadLine());

                pj.PagarImposto(val_pag);

                Console.WriteLine("-------- Pessoa Jurídica ---------");
                Console.WriteLine("Nome ..........: " + pj.Nome);
                Console.WriteLine("Endereço ......: " + pj.Endereco);
                Console.WriteLine("CNPJ ..........: " + pj.Cnpj);
                Console.WriteLine("IE ............: " + pj.Ie);
                Console.WriteLine("Valor de Compra: " + pj.Valor.ToString("C"));
                Console.WriteLine("Imposto .......: " + pj.ValorImposto.ToString("C"));
                Console.WriteLine("Total a Pagar : " + pj.Total.ToString("C"));
            }
        }
    }
}
