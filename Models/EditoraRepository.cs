using BibliotecaSenai.Models;

namespace Biblioteca_SENAI.Models
{
    public static class EditoraRepository
    {
        private static readonly List<Editora> _editoras = [
            new() {Id=1, Nome="JAMBO"},
            new() {Id=2, Nome="Todavia"},
            new() {Id=3, Nome="Objetiva"}
            ];

        public static Editora? ObterPorId(int id)
        {
            return _editoras.FirstOrDefault(c => c.Id == id);
        }

        public static List<Editora> ObterTodas() => _editoras;
    }
}
