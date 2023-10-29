using Microsoft.AspNetCore.Mvc;
namespace razorFun.Controllers;

public class PrincipalController : Controllers
{
    [HttpGet]
    [Route("")]
    public ViewResult Index()
    {
        return View(Index);
    }
}