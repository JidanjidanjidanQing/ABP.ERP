using ERP.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ERP.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ERPController : AbpControllerBase
{
    protected ERPController()
    {
        LocalizationResource = typeof(ERPResource);
    }
}
