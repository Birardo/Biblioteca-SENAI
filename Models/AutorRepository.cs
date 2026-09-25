using BibliotecaSenai.Models;

namespace Biblioteca_SENAI.Models
{
    public static class AutorRepository
    {
        private static readonly List<Autor> _autores = [
            new () {Id = 1, Nome="Eduardo Spohr", Nacionalidade="brasileiro"},
            new () {Id = 2, Nome="Jo Nesbø", Nacionalidade="norueguês"},
            new () {Id = 3, Nome="Haruki Murakami", Nacionalidade="japonês"},
            ];

        public static Autor? ObterPorId(int id)
        {
            return _autores.FirstOrDefault(c => c.Id == id);
        }

        public static List<Autor> ObterTodas() => _autores;
    }
}
