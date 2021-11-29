using Models;
using Models.Interfaces;
using Moq;
using System;
using Xunit;

namespace MockingEstudos
{
    public class UnitTest1
    {
        [Fact]
        [Trait ("Categoria", "Preço Correto")]
        public void ValidaVerificadorPrecoProduto()
        {
            //Arrange
            Product ProdutoBarato = new Product()
            {
                Preco = 35
            };
            Mock<IVerificadorPrecoProduto> mock = new Mock<IVerificadorPrecoProduto>();
            mock.Setup(m => m.VerificaPrecoProduto(ProdutoBarato)).Returns("Produto barato!");
            VerificadorPrecoProduto verif = new VerificadorPrecoProduto();

            //Act
            var resultadoEsperado = mock.Object.VerificaPrecoProduto(ProdutoBarato);
            var resultado = verif.VerificaPrecoProduto(ProdutoBarato);

            //Assert
            Assert.Equal(resultado, resultadoEsperado);
        }

        [Fact]
        [Trait("Categoria", "Preço Incorreto")]
        public void ValidaVerificadorPrecoProdutoFalse()
        {
            //Arrange
            Product ProdutoBarato = new Product()
            {
                Preco = 55
            };
            Mock<IVerificadorPrecoProduto> mock = new Mock<IVerificadorPrecoProduto>();
            mock.Setup(m => m.VerificaPrecoProduto(ProdutoBarato)).Returns("Produto barato!");
            VerificadorPrecoProduto verif = new VerificadorPrecoProduto();

            //Act
            var resultadoEsperado = mock.Object.VerificaPrecoProduto(ProdutoBarato);
            var resultado = verif.VerificaPrecoProduto(ProdutoBarato);

            //Assert
            Assert.Equal(resultado, resultadoEsperado);
        }
    }
}
