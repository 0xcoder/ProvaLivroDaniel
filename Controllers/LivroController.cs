using CadastroLivro.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroLivro.Controllers
{
    public class LivroController : Controller
    {

        private static IList<Livro> livros = new List<Livro>()
        {
             new Livro()
            {
                Id = 1,
                Nome = "Audi a3",
                Autor = "Azul",
                Editora = "Stadia",
                AnoPu = "1000",
                Genero = "Ação",
                Idioma = "Português",
                Sinopse = "Era uma vez....."

            }
        };


        public IActionResult Index()
    {
        return View(livros);
    }

    public IActionResult CadastroLivros()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CadastroLivros(Livro livro)
    {
        if (ModelState.IsValid)
        {
            livros.Add(livro);
            livro.Id = livros.Select(a => a.Id).Max() + 1;

            return RedirectToAction(nameof(Index));
        }
        return View(livro);
    }

}
}
