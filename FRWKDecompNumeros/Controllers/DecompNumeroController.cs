using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FRWKDecompNumerosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DecompNumeroController : ControllerBase
    {
        private readonly IDecompNumero _decompNumeroServico;

        public DecompNumeroController(IDecompNumero decompNumeroServico)
        {
            _decompNumeroServico = decompNumeroServico;
        }

        [HttpGet("{numero}")]
        public ActionResult Get(int numero)
        {
            try
            {
                var appNumerosDecomp = _decompNumeroServico.ObterDecomposicao(numero);
                appNumerosDecomp.numerosPrimos = _decompNumeroServico.ObterPrimos(appNumerosDecomp.numerosDivisores).numerosPrimos;

                if(appNumerosDecomp.erro != null)
                    return this.StatusCode(StatusCodes.Status400BadRequest, appNumerosDecomp.erro.Message);
                else
                    return Ok(appNumerosDecomp);

            }catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, e.Message);             
            }
            
        }

    }
}
