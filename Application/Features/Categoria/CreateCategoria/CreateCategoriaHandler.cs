using Domain.Persistence;
using Domain.Persistence.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Categoria.CreateCategoria
{
    public class CreateCategoriaHandler : IRequestHandler<CreateCategoriaCommand>
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCategoriaHandler(ICategoriaRepository categoriaRepository, IUnitOfWork unitOfWork)
        {
            _categoriaRepository = categoriaRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(CreateCategoriaCommand request, CancellationToken cancellationToken)
        {
            Domain.Model.Categoria obj = new Domain.Model.Categoria(request.Nombre);

            await _categoriaRepository.Insert(obj);

            await _unitOfWork.Commit(cancellationToken);

            return Unit.Value;
        }
    }
}
