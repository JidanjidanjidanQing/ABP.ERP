using Volo.Abp.Modularity;

namespace ERP;

[DependsOn(
    typeof(ERPDomainModule),
    typeof(ERPTestBaseModule)
)]
public class ERPDomainTestModule : AbpModule
{

}
