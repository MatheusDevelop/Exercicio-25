namespace ex25
{
    public interface ICarrinho
    {
         void Ler();
         void Adicionar(Produto _produto);
         void Remover(Produto _produto);
         void Alterar(int _codigo, Produto _produtoAlterado);
         void Price();
    }
}