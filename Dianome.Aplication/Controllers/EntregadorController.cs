using Dianome.Model.Entidades;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Dianome.Aplication.Controllers;

[Route("entregador")]
[ApiController]

public class EntregradorController : ControllerBase
{
    [HttpPost()]

    public IActionResult Create([FromBody] Entregador request)
    {
        var entregador = new Entregador
        {
            Nome = request.Nome,
            Cpf = request.Cpf
        };

        return Created(string.Empty, entregador);

    }

}