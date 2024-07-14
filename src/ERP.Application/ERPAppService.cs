using System;
using System.Collections.Generic;
using System.Text;
using ERP.Localization;
using Volo.Abp.Application.Services;

namespace ERP;

/* Inherit your application services from this class.
 */
public abstract class ERPAppService : ApplicationService
{
    protected ERPAppService()
    {
        LocalizationResource = typeof(ERPResource);
    }


}
