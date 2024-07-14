using ERP.Samples;
using Xunit;

namespace ERP.EntityFrameworkCore.Applications;

[Collection(ERPTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ERPEntityFrameworkCoreTestModule>
{

}
