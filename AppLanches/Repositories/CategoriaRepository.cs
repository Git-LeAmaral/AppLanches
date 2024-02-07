using AppLanches.Context;
using AppLanches.Models;
using AppLanches.Repositories.Interfaces;

namespace AppLanches.Repositories;

public class CategoriaRepository : ICategoriaRepository
{
    private readonly AppDbContext _context;

    public CategoriaRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Categoria> Categorias => _context.Categorias;
}
