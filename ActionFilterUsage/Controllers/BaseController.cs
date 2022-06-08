using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActionFilterUsage.Controllers;

[ApiController]
public class BaseController : ControllerBase
{
    public int? Page { get; set; }

    public int? PageSize { get; set; }
}
