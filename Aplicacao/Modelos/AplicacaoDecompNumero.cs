using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Modelos
{
    public class AplicacaoDecompNumero
    {
        public List<int> numerosPrimos { get; set; }
        public List<int> numerosDivisores { get; set; }
        public AplicacaoDecompNumero()
        {
            numerosPrimos = new();
            numerosDivisores = new();
        }
    }
}
