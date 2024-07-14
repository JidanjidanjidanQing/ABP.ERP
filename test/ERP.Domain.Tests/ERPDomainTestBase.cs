using Volo.Abp.Modularity;

namespace ERP;

/* Inherit from this class for your domain layer tests. */
public abstract class ERPDomainTestBase<TStartupModule> : ERPTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
