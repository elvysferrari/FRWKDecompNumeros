using Aplicacao.DTOS;
using Dominio.Servicos;
using System.Collections.Generic;
using Xunit;

namespace Teste.DecompNumero
{
    public class DecompNumeroTeste
    {
        [Fact(DisplayName = "Teste de Decomposição (número 45)")]
        public void TesteDecomposicaoNumero()
        {
            # region Arrange                       
            //Usaremos o número 45 para testarmos.
            //Criação dos Objects e config dos números.
            int numero = 45;
            List<int> listaDivisores = new List<int> { 1, 3, 5, 9, 15, 45 };

            DecompNumeroServico servicoDecomp = new();
            DecompNumeroDTO decompNumero;
            #endregion

            #region Act
            //Execução do método a ser testado.
            decompNumero = servicoDecomp.ObterDecomposicao(numero);
            #endregion

            #region Assert
            //Comparação do que esperamos que aconteça com o resultado do método executado
            Assert.True(decompNumero.numerosDivisores.Count > 0 ? true : false);

            Assert.Null(decompNumero.erro);

            Assert.Equal(decompNumero.numerosDivisores, listaDivisores);
            #endregion

        }

        [Fact(DisplayName = "Teste números Primos (numero 45)")]
        public void TesteNumeroPrimo()
        {
            #region Arrange                       
            //Usaremos o número 45 para testarmos.
            //Criação dos Objects e config dos números.
            //Usaremos o número 45 para testarmos.
            //int numero = 45;

            List<int> listaDivisores = new List<int> { 1, 3, 5, 9, 15, 45 };
            List<int> listaPrimos = new List<int> { 3, 5 };

            DecompNumeroServico servicoDecomp = new();
            DecompNumeroDTO decompNumero;
            #endregion

            #region Act
            //Execução do método a ser testado.
            decompNumero = servicoDecomp.ObterPrimos(listaDivisores);
            #endregion

            #region Assert
            //Comparação do que esperamos que aconteça com o resultado do método executado
            Assert.True(decompNumero.numerosPrimos.Count > 0 ? true : false);
            
            Assert.Null(decompNumero.erro);

            Assert.Equal(decompNumero.numerosPrimos, listaPrimos);
            #endregion

        }
    }
}
