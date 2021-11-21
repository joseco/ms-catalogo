using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Categoria.CreateCategoria
{
    public class CreateCategoriaCommand : IRequest
    {
        public string Nombre { get; set; }

        public CreateCategoriaCommand() { }

        public CreateCategoriaCommand(string nombre)
        {
            Nombre = nombre;
        }
    }
}
