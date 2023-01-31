using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eshop_srytr.Models.Validations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter | AttributeTargets.Field)]
    public class ContentTypeAttribute : ValidationAttribute, IClientModelValidator
    {
        public String ContentType { get; set; }
        const string ErrorMess = "The file doesn't have the appopriate content";

        public ContentTypeAttribute(string contentType)
        {
            ContentType = contentType;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }
            else if (value is IFormFile formFile)
            {
                if (formFile.ContentType.ToLower().Contains(ContentType.ToLower())){ 
                    return ValidationResult.Success;
                }
                return new ValidationResult(ErrorMess, new List<string>() {validationContext.MemberName});
            }
            throw new NotImplementedException($"The validation is not supported for this type {value.GetType()}");
        }

      public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-filecontent", ErrorMess);
            context.Attributes.Add("data-val-filecontent-type", ContentType);
        }
    }
}
