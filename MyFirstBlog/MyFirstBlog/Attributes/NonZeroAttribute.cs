﻿using System.ComponentModel.DataAnnotations;

namespace MyFirstBlog.Attributes
{
    public class NonZeroAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object? value, ValidationContext _)
        {
            var input = value as int?;

            if (input is null or 0)
            {
                return new ValidationResult(ErrorMessage ?? $"Value cannot be zero.");
            }

            return ValidationResult.Success!;
        }
    }
}
