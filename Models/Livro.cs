namespace BibliotecaSenai.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public decimal Preco { get; set; }
        public int AnoPublicacao { get; set; }
        // Chaves Estrangeiras (Chaves de Vínculo)
        public int CategoriaId { get; set; }
        public int AutorId { get; set; }
        public int EditoraId { get; set; }
        // Propriedades de Navegação (para exibição nas Views)
        public Categoria? Categoria { get; set; }
        public Autor? Autor { get; set; }
        public Editora? Editora { get; set; }
    }
}

