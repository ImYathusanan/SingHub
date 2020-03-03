using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SingHub.Core.Models;
using SingHub.Core.Repositories;

namespace SingHub.Persistence.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private readonly ApplicationDbContext _context;

        public GenreRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Genre> GetGenres()
        {
           return _context.Genres.ToList();
        }
    }
}