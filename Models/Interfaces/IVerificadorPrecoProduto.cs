using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public interface IVerificadorPrecoProduto
    {
        string VerificaPrecoProduto(Product p);
    }
}
