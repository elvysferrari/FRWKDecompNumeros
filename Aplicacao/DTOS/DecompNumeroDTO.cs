
namespace Aplicacao.DTOS
{
    public class DecompNumeroDTO
    {
        public List<int> numerosPrimos { get; set; }
        public List<int> numerosDivisores { get; set; }        
        public Exception? erro { get; set; }
        public DecompNumeroDTO()
        {
            numerosPrimos = new();
            numerosDivisores = new();
        }
    }
}
