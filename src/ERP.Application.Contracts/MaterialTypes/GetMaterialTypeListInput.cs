using Volo.Abp.Application.Dtos;

namespace ERP.MaterialTypes
{
    public class GetMaterialTypeListInput : PagedAndSortedResultRequestDto
    {
        public string? Name { get; set; }
    }
}
