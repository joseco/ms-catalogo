using Domain.Persistence;
using Domain.Persistence.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Articulo.CreateArticulo
{
    public class CreateArticuloHandler : IRequestHandler<CreateArticuloCommand>
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IArticuloRepository _articuloRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateArticuloHandler(IArticuloRepository repository, ICategoriaRepository categoriaRepository, IUnitOfWork unitOfWork)
        {
            _articuloRepository = repository;
            _categoriaRepository = categoriaRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(CreateArticuloCommand request, CancellationToken cancellationToken)
        {
            Domain.Model.Categoria objCategoria = await _categoriaRepository.GetById(request.CategoriaId);

            Domain.Model.Articulo obj = new Domain.Model.Articulo(
                request.Codigo,
                request.Descripcion, 
                request.Precio, 
                objCategoria
            );

            await _articuloRepository.Insert(obj);

            await _unitOfWork.Commit(cancellationToken);

            return Unit.Value;
        }
    }
}
