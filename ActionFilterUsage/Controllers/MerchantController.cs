using ActionFilterUsage.ActionFilters;
using ActionFilterUsage.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActionFilterUsage.Controllers;
[Route("api/{merchantCode}/[controller]")]
[ApiController]
public class MerchantController : BaseController
{
    [HttpGet]
    [Route("GetUsers")]
    // api/1234/Merchant/GetUsers
    public IActionResult GetUsers(string merchantCode)
    {
        return Ok($"Users returned for Merchant {merchantCode}. Page: {Page}, PageSize: {PageSize}");
    }

    [HttpPost]
    [Route("Update")]
    public IActionResult UpdateMerchant(UpdateMecrhantRequestModel reqModel)
    {
        return Ok($"Merchant updated. Name: {reqModel.Name}, Code: {reqModel.MerchantCode}");
    }
}
