using Microsoft.AspNetCore.Mvc;

namespace Boredom.Industries.Intake.Service.Controllers;

[ApiController]
[Route("[controller]")]
public class IntakeController : ControllerBase
{

    public IntakeController()
    {

    }

    [HttpGet(Name = "Alive")]
    public string AmIAlive()
    {
        return "yes";
    }
}
