﻿using Microsoft.EntityFrameworkCore;
using ProjetAspCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAspCore.Repository
{
    public class BookRepository : IBookRepository
    {
        public readonly AppDbContext _appDbContext;

        public BookRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public  IEnumerable<Book> GetAllBooks()
        {
           return  _appDbContext.Books.Include(c => c.Category);
        }

        public Book GetBookById(int id)
        {
            return _appDbContext.Books.FirstOrDefault(b => b.BookId == id); 
        }
    }
}
