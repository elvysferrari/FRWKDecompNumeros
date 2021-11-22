using Aplicacao.DTOS;
using Dominio.Interfaces;

namespace Dominio.Servicos
{
    public class DecompNumeroServico : IDecompNumero
    {
        public DecompNumeroDTO ObterDecomposicao(int decompNumero)
        {
            DecompNumeroDTO appDecomNro = new();
            try
            {
                if (!int.TryParse(decompNumero.ToString(), out int numSaida) || numSaida <= 0)
                {
                    Exception erro = new Exception($"O número {numSaida} é inválido pra esta operação.");
                    appDecomNro.erro = erro;
                    return appDecomNro;
                }

                for (int x = 1; x <= Math.Sqrt(decompNumero); x++)
                {
                    if (decompNumero % x == 0)
                    {
                        appDecomNro.numerosDivisores.Add(x);

                        if (x != decompNumero / x)
                        {
                            appDecomNro.numerosDivisores.Add(decompNumero / x);
                        }
                    }
                }

                appDecomNro.numerosDivisores.Sort();

                return appDecomNro;
            }
            catch (Exception e)
            {
                appDecomNro.erro = e;
                return appDecomNro;
            }
        }
        public DecompNumeroDTO ObterPrimos(List<int> numeros)
        {
            DecompNumeroDTO appDecomNro = new();
            try
            {
                bool isPrime = true;

                for (int x = 0; x < numeros.Count; x++)
                {
                    if (numeros[x] == 2)
                    {
                        appDecomNro.numerosPrimos.Add(numeros[x]);
                    }

                    if (numeros[x] <= 1)
                    {
                        continue;
                    }

                    if (numeros[x] < 2 || (numeros[x] % 2 == 0))
                    {
                        continue;
                    }

                    for (int y = 3; y * y <= numeros[x]; y += 2)
                    {
                        if (numeros[x] % y == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        appDecomNro.numerosPrimos.Add(numeros[x]);
                    }
                }

                return appDecomNro;
            }
            catch (Exception e)
            {
                appDecomNro.erro = e;
                return appDecomNro;
            }
        }
    }
}
