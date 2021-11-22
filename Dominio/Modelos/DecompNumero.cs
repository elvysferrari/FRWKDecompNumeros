using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos
{
    public class DecompNumero
    {
        public int numero { get; set; }
        public List<int>? numerosPrimos { get; set; }
        public List<int>? numerosDivisores { get; set; }
    }
}
