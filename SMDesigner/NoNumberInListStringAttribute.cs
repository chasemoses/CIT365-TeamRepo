using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;

namespace SMDesigner
{
    public class NoNumberInListStringAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var strings = value as IEnumerable<string>;

            Regex rg = new Regex("\\d+");

            if (strings == null)
                return ValidationResult.Success;

            var invalid = strings.Select(x => rg.Matches(x)).Where(x => x.Any());



            if (invalid.Any())
                return new ValidationResult("One or more Spaekers contains numbers. Make sure all speakers have no numbers, and try again.");

            return ValidationResult.Success;
        }
    }
}
