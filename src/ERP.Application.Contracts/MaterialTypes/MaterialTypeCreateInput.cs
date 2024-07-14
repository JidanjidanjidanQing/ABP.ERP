using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ERP.MaterialTypes
{
    public class MaterialTypeCreateInput:IValidatableObject
    {
        [StringLength(12)]
        public string Name {  get; set; }
        public string Description { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Name == Description)
            {
                yield return new ValidationResult("名字和描述不能一样",new string[] { nameof(Name),nameof(Description)});
            }
        }
    }
} 
