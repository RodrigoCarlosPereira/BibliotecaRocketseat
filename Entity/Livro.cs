namespace ExercicioBiblioteca.Entity;

public class Livro
{
    public int Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Autor { get; set; } = string.Empty;

    public decimal Preco {  get; set; }
    
    public int QtdEstoque { get; set; }

    public enum Genero
    {
        Drama,
        Ficcao,
        Romance,
        Ação
    }
    public Genero LivroGenero { get; set; }
}
