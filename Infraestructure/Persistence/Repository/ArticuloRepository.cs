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
    public class ArticuloRepository : IArticuloRepository
    {
        private readonly ApplicationDbContext _context;

        public ArticuloRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Articulo>> GetArticulos()
        {
            return await _context.Articulo.ToListAsync();
        }

        public async Task<Articulo> GetById(Guid id)
        {
            return await _context.Articulo.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Insert(Articulo obj)
        {
            await _context.AddAsync(obj);
        }
    }
}
