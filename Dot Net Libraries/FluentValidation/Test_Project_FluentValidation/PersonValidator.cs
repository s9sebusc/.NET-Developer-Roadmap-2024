using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace NetLibraries_FluentValidation
{
	public class PersonValidator : AbstractValidator<PersonTO>
	{
		public PersonValidator()
		{
			ConfigureDummyRuleSet1();
			ConfigureDummyRuleSet2();
			ConfigureDummyRuleSet3();
		}

		// Multi rule validation with custom message
		private void ConfigureDummyRuleSet1()
		{
			RuleFor(x => x.FirstName).NotEmpty().Length(2, 20);
			
		}

		// Cascade Mode: Don't check if of the rules if any of validation fails. Usage of a custom Validation Error Message
		private void ConfigureDummyRuleSet2()
		{
			RuleFor(x => x.LastName)
				.NotEmpty()
				.Length(2, 20)
				.WithMessage("Please provide a valid length for {PropertyName}. The current length is {TotalLength}"); // The both properties are automatically set
		}

		// Must: Define a condition for validation. Validation fails if the condition isn't fulfilled.
		private void ConfigureDummyRuleSet3()
		{
			RuleFor(x => x.Age).Must(IsAgeInValidRange).WithMessage("The age is not in valid range");
		}


		private static bool IsAgeInValidRange(int? age)
		{
			return age != null && age > 0 && age < 100;
		}

	}
}
