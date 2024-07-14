using ERP.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ERP.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ERPPageModel : AbpPageModel
{
    protected ERPPageModel()
    {
        LocalizationResourceType = typeof(ERPResource);
    }
}
