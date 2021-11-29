using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class VerificadorPrecoProduto : IVerificadorPrecoProduto

    {
        public string VerificaPrecoProduto(Product p)
        {
            if (p.Preco > 100)
                return "Produto caro!";
            else if (p.Preco <= 100 && p.Preco > 40)
                return "Produto na média de Preço!";
            else
                return "Produto barato!";
        }
    }
}
