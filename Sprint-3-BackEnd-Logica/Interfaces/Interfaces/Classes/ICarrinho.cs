namespace Interfaces.Classes
{
    public interface ICarrinho
    {
        void Cadastrar(Produto produto);
        void Listar();
        void Alterar(int codigo, Produto novoProduto);
        void Remover(int codigo);
    }
}