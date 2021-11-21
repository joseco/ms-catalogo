using AutoMapper;
using Domain.Persistence.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Articulo.GetArticulos
{
    public class GetArticulosHandler : IRequestHandler<GetArticulosQuery, ICollection<Dto.ArticuloDto>>
    {
        private readonly IArticuloRepository _articuloRepository;
        private readonly IMapper _mapper;

        public GetArticulosHandler(IArticuloRepository articuloRepository, IMapper mapper)
        {
            _articuloRepository = articuloRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<Dto.ArticuloDto>> Handle(GetArticulosQuery request, CancellationToken cancellationToken)
        {
            ICollection<Domain.Model.Articulo> articulos = await _articuloRepository.GetArticulos();
            ICollection<Dto.ArticuloDto> articuloDtos = _mapper.Map<ICollection<Domain.Model.Articulo>, ICollection<Dto.ArticuloDto>>(articulos);

            return articuloDtos;
        }
    }
}
