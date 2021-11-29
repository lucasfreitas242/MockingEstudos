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
        [Trait ("Pre�o", "Correto")]
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
        [Trait("Pre�o", "Incorreto")]
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
        [Fact]
        [Trait ("Descri��o", "Correto")]
        public void ValidaDescricaoNaoVazia()
        {
            //Arrange
            Product DescricaoOK = new Product()
            {
                Descricao = "Este � um belo produto que proporciona diversos tipos de entretenimento para o comprador!"
            };
            Mock<IVerificadorDescricao> mock = new Mock<IVerificadorDescricao>();
            mock.Setup(m => m.VerificaDescricao(DescricaoOK)).Returns(DescricaoOK.Descricao);

            //Act
            var resultadoEsperado = mock.Object.VerificaDescricao(DescricaoOK);

            //Assert
            Assert.NotNull(resultadoEsperado);
        }
        [Fact]
        [Trait("Descri��o", "Incorreto")]
        public void ValidaDescricaoVazia()
        {
            //Arrange
            Product DescricaoOK = new Product()
            {
                Descricao = null
            };
            Mock<IVerificadorDescricao> mock = new Mock<IVerificadorDescricao>();
            mock.Setup(m => m.VerificaDescricao(DescricaoOK)).Returns(DescricaoOK.Descricao);

            //Act
            var resultadoEsperado = mock.Object.VerificaDescricao(DescricaoOK);

            //Assert
            Assert.NotNull(resultadoEsperado);
        }

    }
}
