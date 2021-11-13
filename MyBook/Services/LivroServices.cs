using MyBook.Data;
using MyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBook.Services
{
    public class LivroServices
    {
        private readonly MyBookContext _context;

        public LivroServices(MyBookContext context)
        {
            _context = context;
        }

        public List<Livro> FindAll()
        {
            return _context.Livro.ToList();
        }

        public void Inserir(Livro lv)
        {
            _context.Add(lv);
            _context.SaveChanges();
        }

        public async Task<Livro> EditarAsync(int? id)
        {
            Livro livro = await _context.Livro.FindAsync(id);
            return livro;
        }
    }
}
