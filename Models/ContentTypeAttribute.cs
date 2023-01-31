using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace eshop_srytr.Models {
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)] 
    public class ContentTypeAttribute : ValidationAttribute, IClientModelValidator {

        public string ContentType { get; set; }
        //const string ErrMessage;


        public ContentTypeAttribute(string contentType) {
            ContentType = contentType;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
            if (value == null) {
                return ValidationResult.Success;

            } else if (value is IFormFile formFile) {
                if (formFile.ContentType.ToLower().Contains(ContentType.ToLower())) {
                    return ValidationResult.Success;
                } 

                return new ValidationResult("The file doesn;t have the appropriate content!", new List<String>() { validationContext.MemberName });
            }

            throw new NotImplementedException("The validation is not supported for this type.");
        }

        public void AddValidation(ClientModelValidationContext context) {
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-filecontent", "true");
            context.Attributes.Add("data-val-filecontent-type", "ContentType");
        }
    }
}
