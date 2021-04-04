using System;
using POO_Heranca.classes;

namespace POO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            pf.cpf = "000.000-00";

            pf.nome = "Paulo";

            Console.WriteLine(pf.DarBoasVindas(pf.nome));
            Console.WriteLine(pf.ValidarCPF(pf.cpf));

            
        }
    }
}
