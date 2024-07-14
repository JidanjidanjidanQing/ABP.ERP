using Volo.Abp.Modularity;

namespace ERP;

public abstract class ERPApplicationTestBase<TStartupModule> : ERPTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
