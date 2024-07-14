using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore.Modeling;


//实体配置
namespace ERP.MaterialTypes
{
    public class MaterialTypeEntityTypeConfigutation : IEntityTypeConfiguration<MaterialType>
    {
        public void Configure(EntityTypeBuilder<MaterialType> builder)
        {
            builder.ToTable(ERPConsts.DbTablePrefix + nameof(MaterialType));
            
            builder.Property(x => x.Name).HasMaxLength(200);

            builder.Property(x => x.Description).HasMaxLength(500);

            builder.ConfigureByConvention();
        }
    }
}
