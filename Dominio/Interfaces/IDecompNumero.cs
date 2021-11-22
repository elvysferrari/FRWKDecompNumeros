using Aplicacao.DTOS;

namespace Dominio.Interfaces
{
    public interface IDecompNumero
    {
        DecompNumeroDTO ObterDecomposicao(int numero);
        DecompNumeroDTO ObterPrimos(List<int> numeros);
    }
}
