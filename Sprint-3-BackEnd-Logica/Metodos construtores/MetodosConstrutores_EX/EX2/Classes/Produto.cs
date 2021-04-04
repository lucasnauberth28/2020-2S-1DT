using System;
namespace EX2.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        
        public string Nome { get; set; }

        public string Descricao { get; set; }
        
        public int Estoque { get; set; }

        public Produto()
        { }
        public Produto(int codigo){
            if(codigo >= 1){
                Console.WriteLine("Código verificado");
            }else{
                Console.WriteLine("Código inválido.");
            }
        }

        public Produto(int codigo, string nome, string descricao, int estoque){
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            Estoque = estoque;

            Console.WriteLine($"Produto cadastrado!\nCódigo: {codigo}\nNome: {nome}\nDescrição: {descricao}\nEstoque: {estoque}");
        }
    }

}