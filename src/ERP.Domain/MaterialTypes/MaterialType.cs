using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace ERP.MaterialTypes
{
    public class MaterialType : FullAuditedEntity<Guid>,IMultiTenant
    {
        private MaterialType()
        {
        }

        public MaterialType(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }


        public Guid? TenantId { get; set; }

        public void Update(string name, string description)
        { 

            Name=name;

            Description=description;
        
        }
    }
}
