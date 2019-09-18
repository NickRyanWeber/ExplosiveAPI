using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace ExplosiveAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class Explosions : ControllerBase
  {
    [HttpGet("{s}")]
    public ActionResult<string> GetExplosion(string s)
    {
      return String.Join("", s.Select((letter, i) => String.Join("", Enumerable.Repeat(letter, (int)Char.GetNumericValue(letter)))));
    }
  }
}