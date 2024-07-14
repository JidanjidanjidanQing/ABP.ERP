using Volo.Abp.Modularity;

namespace ERP;

[DependsOn(
    typeof(ERPApplicationModule),
    typeof(ERPDomainTestModule)
)]
public class ERPApplicationTestModule : AbpModule
{

}
