using Xunit;

namespace ERP.EntityFrameworkCore;

[CollectionDefinition(ERPTestConsts.CollectionDefinitionName)]
public class ERPEntityFrameworkCoreCollection : ICollectionFixture<ERPEntityFrameworkCoreFixture>
{

}
