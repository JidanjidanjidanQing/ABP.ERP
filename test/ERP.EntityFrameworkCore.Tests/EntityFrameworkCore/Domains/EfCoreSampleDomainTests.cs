using ERP.Samples;
using Xunit;

namespace ERP.EntityFrameworkCore.Domains;

[Collection(ERPTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ERPEntityFrameworkCoreTestModule>
{

}
