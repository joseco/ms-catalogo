using CoreDDD.Core;
using CoreDDD.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Categoria : AggregateRoot<Guid>
    {
        public string Nombre { get; private set; }

        protected Categoria() { }

        public Categoria(string nombre)
        {
            CheckRule(new StringNotNullOrEmpty(nombre));
            
            Id = Guid.NewGuid();
            Nombre = nombre;
        }

    }
}
