using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ERP.Data;

/* This is used if database provider does't define
 * IERPDbSchemaMigrator implementation.
 */
public class NullERPDbSchemaMigrator : IERPDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
