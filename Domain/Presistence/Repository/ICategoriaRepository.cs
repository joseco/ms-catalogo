using CoreDDD.Core;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Persistence.Repository
{
    public interface ICategoriaRepository : IRepository<Categoria, Guid>
    {

        Task Insert(Categoria obj);
    }
}
