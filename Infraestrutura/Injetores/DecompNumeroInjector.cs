using Dominio.Interfaces;
using Infraestrutura.Servicos;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
