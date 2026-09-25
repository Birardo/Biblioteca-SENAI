namespace BibliotecaSenai.Models
{
    public static class CategoriaRepository
    {
        private static readonly List<Categoria> _categorias= [
            new() {Id = 1, Nome = "Fantasia"},
            new() {Id = 2, Nome = "Suspense"},
            new() {Id = 3, Nome = "Romance"}
            ];

        public static Categoria? ObterPorId(int id)
        {
            return _categorias.FirstOrDefault(c => c.Id == id);
        }

        public static List<Categoria> ObterTodas() => _categorias;
    }
}
