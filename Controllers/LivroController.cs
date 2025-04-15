using ExercicioBiblioteca.Entity;
using ExercicioBiblioteca.Requests;
using ExercicioBiblioteca.Response;
using Microsoft.AspNetCore.Mvc;
using static ExercicioBiblioteca.Entity.Livro;

namespace ExercicioBiblioteca.Controllers
{

    public class LivroController : BibliotecaBaseController
    {
        [HttpPost]
        [ProducesResponseType(typeof(Livro), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult Criar([FromBody] RequestCriarLivroJson request)
        {
            var response = new ResponseCriarLivroJson
            {
                Id = 01,
                Titulo = request.Titulo
            };

            return Created(string.Empty, response);
        }
        [HttpGet]
        [Route("{Id}")]
        [ProducesResponseType(typeof(Livro), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]

        public IActionResult GetById([FromRoute] int Id)
        {
            var response = new Livro
            {
                Id = 1,
                Titulo = "Joao o Grande",
                Autor = "Joao o pequeno",
                LivroGenero = Livro.Genero.Ficcao,
                Preco = 3,
                QtdEstoque = 4
            };
            return Ok(response);
        }
        [HttpGet]
        [ProducesResponseType(typeof(Livro), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult GetAll()
        {
            var response = new List<Livro>
            {

            new Livro { Autor = "João Silva", Id = 2, LivroGenero = Genero.Ficcao, Preco = 45, QtdEstoque = 5, Titulo = "A Cidade Perdida" },
            new Livro { Autor = "Maria Oliveira", Id = 3, LivroGenero = Genero.Romance, Preco = 29, QtdEstoque = 3, Titulo = "Amor Eterno" },
            new Livro { Autor = "Carlos Mendes", Id = 4, LivroGenero = Genero.Ação, Preco = 50, QtdEstoque = 8, Titulo = "Missão Impossível" },
            new Livro { Autor = "Ana Souza", Id = 5, LivroGenero = Genero.Drama, Preco = 38, QtdEstoque = 2, Titulo = "Vidas Cruzadas" }

            };
            return Ok(response);
        }

        [HttpPut]
        [ProducesResponseType(typeof(Livro), StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult Atualizar([FromBody] RequestAtualizarLivroJson request)
        {
            return NoContent();
        }
        [HttpDelete]
        [Route("{Id}")]
        [ProducesResponseType(typeof(Livro), StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult Deletar([FromRoute] int Id)
        {
            return NoContent();
        }
    }
}
