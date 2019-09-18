using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace ExplosiveAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class Mumble : ControllerBase
  {
    [HttpGet("{s}")]
    public ActionResult<string> GetMumble(string s)
    {
      return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
    }
  }
}