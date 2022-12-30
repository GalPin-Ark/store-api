using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Models;
using BookStore.Domain.Interfaces;
using BookStore.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Infrastructure.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(BookStoreDbContext context) : base(context) { }

        public override async Task<List<Book>> GetAll()
        {
            return await Db.Books.AsNoTracking().Include(b => b.Category).OrderBy(b => b.Name).ToListAsync();
        }

        public override async Task<Book> GetById(int id)
        {
            return await Db.Books.AsNoTracking().Include(b => b.Category).Where(b => b.Id == id).FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<Book>> GetBooksByCategory(int categoryId)
        {
            return await Search(b => b.CategoryId == categoryId);
        }
        public async Task<IEnumerable<Book>> SearchBookWithCategory(string searchedValue)
        {
            return await Db.Books.AsNoTracking().Include(s => s.Category)
                .Where(d => d.Name.Contains(searchedValue) ||
                d.Author.Contains(searchedValue) ||
                d.Description.Contains(searchedValue) ||
                d.Category.Name.Contains(searchedValue)).ToListAsync();
        }
    }
}
