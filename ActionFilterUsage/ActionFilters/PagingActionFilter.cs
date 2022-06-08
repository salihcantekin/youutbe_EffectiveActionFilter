using ActionFilterUsage.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFilterUsage.ActionFilters;

public class PagingActionFilter : IAsyncActionFilter
{
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        string pageKey = "page", pageSizeKey = "pageSize";

        if (context.Controller is BaseController controller)
        {
            controller.Page = GetPageValue(context, pageKey);
            controller.PageSize = GetPageValue(context, pageSizeKey);
        }

        await next();
    }


    public static int? GetPageValue(ActionExecutingContext context, string key)
    {
        var value = context.HttpContext.Request.Query[key];

        if(!string.IsNullOrEmpty(value))
        {
            if (int.TryParse(value, out int page))
            {
                return page;
            }
        }

        return default;
    }
}
