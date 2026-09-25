using BibliotecaSenai.Models;
using System.Xml.Linq;

namespace Biblioteca_SENAI.Models
{
    public static class LivroRepository
    {
        private static readonly List<Livro> _livros = new List<Livro>
        {
            new Livro
            {
                Id = 1,
                Titulo = "A batalha do apocalipse",
                AutorId = 1,
                Autor = new Autor { Id = 1, Nome = "Eduardo Spohr", Nacionalidade = "BR" },
                AnoPublicacao = 2007,
                Preco = 200.00m,
                EditoraId = 1,
                Editora = new Editora { Id = 1, Nome = "Todavia" },
                CategoriaId = 1,
                Categoria = new Categoria { Id = 1, Nome = "Fantasia" }
            },
            new Livro
            {
                Id = 2,
                Titulo = "O boneco de neve",
                AutorId = 2,
                Autor = new Autor { Id = 2, Nome = "Jo Nesbø", Nacionalidade = "NO" },
                AnoPublicacao = 2013,
                Preco = 250.00m,
                EditoraId = 2,
                Editora = new Editora { Id = 2, Nome = "JAMBO" },
                CategoriaId = 2,
                Categoria = new Categoria { Id = 2, Nome = "Suspense" }
            },
            new Livro
            {
                Id = 3,
                Titulo = "Tokyo Blues",
                AutorId = 3,
                Autor = new Autor { Id = 3, Nome = "Haruki Murakami", Nacionalidade = "JPN" },
                AnoPublicacao = 2005,
                Preco = 299.99m,
                EditoraId = 3,
                Editora = new Editora { Id = 3, Nome = "Objetiva" },
                CategoriaId = 3,
                Categoria = new Categoria { Id = 3, Nome = "Romance" }
            }
        };

        public static Livro? ObterPorId(int id) => _livros.FirstOrDefault(p => p.Id == id);

        private static void CarregarRelacionamentos(Livro livro)
        {
            if (livro == null) return;
            livro.Autor = AutorRepository.ObterPorId(livro.AutorId);
            livro.Categoria = CategoriaRepository.ObterPorId(livro.CategoriaId);
            livro.Editora = EditoraRepository.ObterPorId(livro.EditoraId);
        }

        public static List<Livro> ObterTodos()
        {
            foreach (var livro in _livros)
            {
                CarregarRelacionamentos(livro);
            }
            return _livros;
        }


        public static void Adicionar(Livro p)
        {
            p.Id = _livros.Count > 0 ? _livros.Max(x => x.Id) + 1 : 1;
            _livros.Add(p);
        }

        public static void Atualizar(Livro p)
        {
            var index = _livros.FindIndex(x => x.Id == p.Id);
            if (index != -1) _livros[index] = p;
        }

        public static void Remover(int id)
        {
            var livro = ObterPorId(id);
            if (livro != null) _livros.Remove(livro);
        }
    }
}