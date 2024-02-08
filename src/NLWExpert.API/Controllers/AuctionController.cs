using Microsoft.AspNetCore.Mvc;
using NLWExpert.API.Entities;
using NLWExpert.API.UseCases.Auctions.GetCurrent;

namespace NLWExpert.API.Controllers; // Mais comum utilizar o nome do prórpiop projeto
[Route("[controller]")] // Define como o end point irá se controlar
[ApiController] // Essa classe é um classe especial do tipo controller
public class AuctionController : ControllerBase // Nosso controller estar herdando métodos de ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)] // Vai devolver essa entidade com esse esse status code 
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetCurrentAuction() // IActionResult -> Status code + uma resposta
    {
        var useCase = new GetCurrentAuctionUseCase(); // Criando uma instância da classe UseCase e Armazenando na variável
        
        var result = useCase.Execute();

        if (result is null)
            return NoContent();

        
        return Ok(result);
    }
}