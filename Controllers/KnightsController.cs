using Microsoft.AspNetCore.Mvc;

namespace onetomany.Controllers
{
  [Route("api/[controller]")]
  public class KnightsController : ControllerBase
  {
    [HttpGet]
    public void Get()
    {

    }

    [HttpGet("{id}")]
    public void Get(int id)
    {

    }

    [HttpPost]
    public void Create()
    {

    }

    [HttpPut("{id}")]
    public void Update(int id)
    {

    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {

    }
    // delete one



  }
}