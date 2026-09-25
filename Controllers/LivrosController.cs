using Biblioteca_SENAI.Models;
using BibliotecaSenai.Models;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca_SENAI.Controllers
{
    public class LivrosController : Controller
    {
        public IActionResult Index()
        {
            var livros = LivroRepository.ObterTodos();
            return View(livros);  
        }

        public IActionResult Criar() => View();

        [HttpPost]
        public IActionResult Criar(Livro livros)
        {
            LivroRepository.Adicionar(livros);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Editar(int Id) {
            var livros = LivroRepository.ObterPorId(Id);
            return View(livros);
        }

        [HttpPost]
        public IActionResult Editar(Livro livros)
        {
            LivroRepository.Atualizar(livros);
            return View(livros);
        }

        public IActionResult Deletar(int Id)
        {
            LivroRepository.Remover(Id);
            return RedirectToAction(nameof(Deletar));
        }

       public void CarregarDropDowns()
        {
            ViewBag.Categorias = LivroRepository.ObterTodos().ToList();
            ViewBag.Autor = LivroRepository.ObterTodos().ToList();
            ViewBag.Editora = LivroRepository.ObterTodos().ToList();
        }

    }
}
