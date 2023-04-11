using System.ComponentModel.DataAnnotations;

namespace MyFirstBlog.Attributes
{
    public class MoreThanNWordsAttribute : ValidationAttribute
    {
        int wordCount;

        public MoreThanNWordsAttribute(int wordCount)
        {
            this.wordCount = wordCount;
        }

        protected override ValidationResult IsValid(object? value, ValidationContext _)
        {
            var input = value as string;

            if (input is null || input.Trim().Split(' ').Length < wordCount)
            {
                return new ValidationResult(ErrorMessage ?? $"Please provide at least {wordCount} word{(wordCount is 1 ? "" : "s")}.");
            }

            return ValidationResult.Success!;
        }
    }
}
