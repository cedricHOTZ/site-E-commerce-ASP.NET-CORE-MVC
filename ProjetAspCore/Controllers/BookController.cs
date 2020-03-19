using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetAspCore.Repository;
using ProjetAspCore.ViewsModels;

namespace ProjetAspCore.Controllers
{
    public class BookController : Controller
    {
        // repository de Book et Categorie pour avoir les différentes opérations
        private readonly IBookRepository _bookRepository;
        private readonly ICategoryRepository _categoryRepository;
       
        //Dépendance injectioni
        public BookController(IBookRepository bookRepository, ICategoryRepository categoryRepository)
        {
            _bookRepository = bookRepository;
            _categoryRepository = categoryRepository;
        }
        public IActionResult List()
        {
            var bookListViewModel = new BookListViewModel();
            bookListViewModel.Books = _bookRepository.GetAllBooks();
            return View(bookListViewModel);
        }

        public IActionResult Detail(int idBook)
        {
            var book = _bookRepository.GetBookById(idBook);
            if(book == null)
            {
                return NotFound();
                
            }
            return View(book);
        }
    }
}