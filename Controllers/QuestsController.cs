using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using onetomany.Models;

namespace onetomany.Controllers
{
  public class QuestsController : ControllerBase
  {


    [HttpGet]
    public ActionResult<IEnumerable<Quest>> Get()
    {
      // return quests array

      return Ok(new Quest[] { new Quest() });
    }

    //     [HttpGet("{id}")]
    //     public ActionResult<IEnumerable<Quest>> Get(int id)
    //     {

    //     }

    //     [HttpPost]
    //     public ActionResult<IEnumerable<Quest>> Create()
    //     {

    //     }

    //     [HttpPut("{id}")]
    //     public ActionResult<IEnumerable<Quest>> Update(int id)
    //     {

    //     }

    //     [HttpDelete("{id}")]
    //     public ActionResult<IEnumerable<Quest>> Delete(int id)
    //     {

    //     }
    //     // delete one



  }
}
