using Destinos.Data;
using Destinos.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Games.Controllers
{

[ApiController]
[Route("api/[Controller]")]
public class DestinoController : ControllerBase
{

    private readonly DataContext _dataContext;

    public DestinoController(DataContext dataContext){
        _dataContext = dataContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Destino>>> GetDestinos(){
        return await _dataContext.Destinos.ToListAsync();
    }

    [HttpGet("{id}")]
public async Task<ActionResult<Destino>> GetDestinoById(int id)
{
    var destino = await _dataContext.Destinos.FindAsync(id);
    if (destino == null)
    {
        return NotFound();
    }

    return Ok(destino);
}
}

}
