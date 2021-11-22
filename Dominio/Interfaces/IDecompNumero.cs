using Aplicacao.Modelos;
using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IDecompNumero
    {
        AplicacaoDecompNumero ObterDecomposicao(int numero);
        AplicacaoDecompNumero ObterPrimos(List<int> numeros);
    }
}
