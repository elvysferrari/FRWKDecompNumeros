using Dominio.Interfaces;
using Dominio.Servicos;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestrutura.Injetores
{
    public static class DecompNumeroInjector
    {
        public static void AddInjectors(IServiceCollection services)
        {
            services.AddTransient<IDecompNumero, DecompNumeroServico>();
        }
        
    }
}
