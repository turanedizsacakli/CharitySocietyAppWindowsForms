using FluentValidation;
using Postgre.Business.ValidationRules.FluentValidation;
using Postgre.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.Business.Utilities
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator, object entity) 
        {
            
            var result = validator.Validate((IValidationContext)entity);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }

    }
}
