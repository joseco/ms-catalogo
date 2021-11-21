using CoreDDD.Core;
using CoreDDD.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Articulo : AggregateRoot<Guid>
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        public Guid CategoriaId { get; set; }
        public virtual Categoria Categoria { get; private set; }

        protected Articulo() { }

        public Articulo(string codigo, string descripcion, decimal precio, Categoria categoria)
        {

            CheckRule(new StringNotNullOrEmpty(codigo));
            CheckRule(new StringNotNullOrEmpty(descripcion));
            CheckRule(new NotNullRule(categoria));

            Id = Guid.NewGuid();
            Codigo = codigo;
            Descripcion = descripcion;
            Precio = precio;
            Categoria = categoria;
            CategoriaId = categoria.Id;
        }

    }
}
