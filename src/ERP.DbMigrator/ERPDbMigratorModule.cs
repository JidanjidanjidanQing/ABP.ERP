using ERP.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ERP.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ERPEntityFrameworkCoreModule),
    typeof(ERPApplicationContractsModule)
    )]
public class ERPDbMigratorModule : AbpModule
{
}
