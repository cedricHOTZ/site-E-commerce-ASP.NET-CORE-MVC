using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetAspCore.Repository;
using ProjetAspCore.ViewsModels;

namespace ProjetAspCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public HomeController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public IActionResult Index()
        {
            var listBook = new BookListViewModel();
            listBook.Books = _bookRepository.GetAllBooks().Take(3);
            return View(listBook);
        }
    }
}