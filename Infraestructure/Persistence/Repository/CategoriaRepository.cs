using Domain.Model;
using Domain.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Persistence.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoriaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Categoria> GetById(Guid id)
        {
            return await _context.Categoria.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Insert(Categoria obj)
        {
            await _context.Categoria.AddAsync(obj);
        }
    }
}
