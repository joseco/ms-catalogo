using CoreDDD.Core;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Persistence.Repository
{
    public interface IArticuloRepository : IRepository<Articulo, Guid>
    {
        Task Insert(Articulo obj);

        Task<ICollection<Articulo>> GetArticulos();
    }
}
