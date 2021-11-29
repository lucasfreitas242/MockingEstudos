using Models.Interfaces;

namespace Models
{
    public class VerificadorDescricao : IVerificadorDescricao
    {
        public string VerificaDescricao(Product d)
        {
            if (d == null)
                return "Descrição inválida";
            else
                return d.Descricao;
        }
    }
}
