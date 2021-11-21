using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Articulo.CreateArticulo
{
    public class CreateArticuloCommand : IRequest
    {
        public CreateArticuloCommand(string codigo, string descripcion, decimal precio, Guid categoriaId)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Precio = precio;
            CategoriaId = categoriaId;
        }

        public CreateArticuloCommand() { }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        public Guid CategoriaId { get; set; }
    }
}
