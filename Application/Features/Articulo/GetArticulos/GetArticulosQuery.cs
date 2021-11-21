using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Articulo.GetArticulos
{
    public class GetArticulosQuery : IRequest<ICollection<Dto.ArticuloDto>>
    {
    }
}
