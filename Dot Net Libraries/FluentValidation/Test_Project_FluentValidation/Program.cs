using FluentValidation;
using FluentValidation.Results;
using NetLibraries_FluentValidation;


// Create SUT
//PersonTO testPerson = CreatePersonWithOutOfRangeAge();
//PersonTO testPerson = CreatePersonEmptyFirstName();
PersonTO testPerson = CreatePersonWithTooLongLastName();

Validate(testPerson);


///////////////////////////////////////////////////////////////////////////////
static void Validate(PersonTO testPerson)
{
	PersonValidator personValidator = new PersonValidator();
	ValidationResult? validationResult = personValidator.Validate(testPerson);

	if (validationResult.IsValid != true)
	{
		foreach (ValidationFailure? error in validationResult.Errors)
		{
			Console.WriteLine($"Validation error: {error.ErrorMessage}. Current value: {error.AttemptedValue}");
		}
	}
	else
	{
		Console.WriteLine("Validation succeeded");
	}
}
static PersonTO CreatePersonEmptyFirstName()
{
	PersonTO testPerson = new PersonTO();
	testPerson.FirstName = string.Empty;

	return testPerson;
}

static PersonTO CreatePersonWithTooLongLastName()
{
	PersonTO testPerson = new PersonTO();
	testPerson.FirstName = "Max";
	testPerson.LastName = "A_VERY_LONG_LAST_NAME";

	return testPerson;
}

static PersonTO CreatePersonWithOutOfRangeAge()
{
	PersonTO testPerson = new PersonTO();
	testPerson.Age = -1;

	return testPerson;
}

