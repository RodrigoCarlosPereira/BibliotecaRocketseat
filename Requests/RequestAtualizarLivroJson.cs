using static ExercicioBiblioteca.Entity.Livro;

namespace ExercicioBiblioteca.Requests;

public class RequestAtualizarLivroJson
{
    public string Titulo { get; set; } = string.Empty;
    public string Autor { get; set; } = string.Empty;

    public decimal Preco { get; set; }

    public int QtdEstoque { get; set; }

    public Genero LivroGenero { get; set; }

}
