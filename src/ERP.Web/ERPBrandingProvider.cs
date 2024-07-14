using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ERP.Web;

[Dependency(ReplaceServices = true)]
public class ERPBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ERP";
}
