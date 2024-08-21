using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoRecord
{
    public record ProdutoDto(Guid Id, string Descricao, string Localizacao) 
    {
    }
}
