using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace ERP.MaterialTypes
{
    public class MaterialTypeService : ERPAppService
    {
        //public async Task<string> Greet()
        //{ 
        //    await Task.Delay(1000);

        //    return "Hello World!";
        //}
        public IRepository<MaterialType> MaterialTypeRepository { get; set; }

        public async Task Create(MaterialTypeCreateInput input)
        {
            await MaterialTypeRepository.InsertAsync(new MaterialType(input.Name, input.Description));
        }

        public async Task Update(Guid id,MaterialTypeUpdateInput input)
        {
            var materialType = await MaterialTypeRepository.GetAsync(t => t.Id == id);

            materialType.Update(input.Name, input.Description);

            //await MaterialTypeRepository.UpdateAsync(new MaterialType(input.Name, input.Description));
            await MaterialTypeRepository.UpdateAsync(materialType);

        }

        public async Task Delete(Guid id)
        {
            await MaterialTypeRepository.DeleteAsync(t => t.Id == id);
        }
        public async Task<MaterialTypeDto> Get(Guid id)
        {
            var materialType = await MaterialTypeRepository.GetAsync(t => t.Id == id);

            return ObjectMapper.Map<MaterialType, MaterialTypeDto>(materialType);
        }

        public async Task<PagedResultDto<MaterialTypeDto>> GetListAsync(GetMaterialTypeListInput input)
        {
            var queryable = (await MaterialTypeRepository.GetQueryableAsync())
                .WhereIf(!string.IsNullOrWhiteSpace(input.Name),t=>t.Name==input.Name);

            var totalCount = await AsyncExecuter.CountAsync(queryable);

            var materialTypes = await AsyncExecuter
                .ToListAsync(queryable.Skip(input.SkipCount).Take(input.MaxResultCount));

            
            return new PagedResultDto<MaterialTypeDto>(
                totalCount, 
                ObjectMapper.Map<List<MaterialType>, List<MaterialTypeDto>>(materialTypes));
        }


    }
}
