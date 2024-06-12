using FluentValidation.TestHelper;
using NetLibraries_FluentValidation;
namespace FluentValidation_Tests
{
	[TestClass]
	public class PersonValidatorTests
	{
		[TestMethod]
		public void TestValidateInvalidFirstName()
		{
			// ARRANGE
			PersonTO testPerson = new PersonTO();
			testPerson.FirstName = string.Empty;
			testPerson.LastName = "Trump";

			PersonValidator personValidator = new PersonValidator();

			// ACT
			TestValidationResult<PersonTO>? validationResult = personValidator.TestValidate(testPerson);

			// ASSERT
			Assert.AreNotEqual(0, validationResult.Errors.Count, "At least one validation error expected");
			validationResult.ShouldHaveValidationErrorFor("FirstName");
			validationResult.ShouldNotHaveValidationErrorFor("LastName");
		}

		[TestMethod]
		public void TestValidateWithoutError()
		{
			// ARRANGE
			PersonTO testPerson = new PersonTO();
			testPerson.FirstName = "Donald";
			testPerson.LastName = "Trump";
			testPerson.Age = 99;

			PersonValidator personValidator = new PersonValidator();

			// ACT
			TestValidationResult<PersonTO>? validationResult = personValidator.TestValidate(testPerson);

			// ASSERT
			validationResult.ShouldNotHaveValidationErrorFor("FirstName");
			validationResult.ShouldNotHaveValidationErrorFor("LastName");
			validationResult.ShouldNotHaveValidationErrorFor("Age");
		}
	}
}