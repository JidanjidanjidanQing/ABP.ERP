using System.Threading.Tasks;

namespace ERP.Data;

public interface IERPDbSchemaMigrator
{
    Task MigrateAsync();
}
