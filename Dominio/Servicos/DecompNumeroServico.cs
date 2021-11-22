using Aplicacao.Modelos;
using Dominio.Interfaces;
using Dominio.Modelos;

namespace Infraestrutura.Servicos
{
    public class DecompNumeroServico : IDecompNumero
    {
        public AplicacaoDecompNumero ObterDecomposicao(int decompNumero)
        {
            AplicacaoDecompNumero appDecomNro = new();
            try
            {
                if (!int.TryParse(decompNumero.ToString(), out int number) || number <= 0)
                {
                    throw new ArithmeticException("O número digitado é inválido.");
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
            catch (Exception)
            {
                return appDecomNro;
            }
        }
        public AplicacaoDecompNumero ObterPrimos(List<int> numeros)
        {
            AplicacaoDecompNumero appDecomNro = new();
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
            catch (Exception)
            {
                return appDecomNro;
            }
        }
    }
}
