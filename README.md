# Raindrops

## Project Goal

The goal of this project is to create a function that takes a number `n` as it's input and returns a string whose contents depends on the factors of `n` in a similar fashion to the common [Fizz buzz](https://en.wikipedia.org/wiki/Fizz_buzz) problem. In this case the returned string depends on whether the input number is a factor of 3, 5, 7, a combination of these, or none of these, in the following fashion.

* If 3 is a factor of the `n`, output `Pling`
* If 5 is a factor of the `n`, output `Plang`
* If 7 is a factor of the `n`, output `Plong`
* If `n` has some combination of the above conditions are met output a concatenation of the outputs, in the order they are given above.
* If none of the above apply return `n`'s digits

For example

- 28's factors are 1, 2, 4, 7, 14 and 28
  - 7 is a factor of 28
  - `n` = 28 returns the string `Plong`
- 30's factors are 1, 2, 3, 5, 6, 10, 15, 30
  - Both 3 and 5 are factors of 30
  - `n` = 30 returns the string `PlingPlang`
- 34 has four factors: 1, 2, 17, and 34
  - `n` = 34 returns the string `34`

## Architecture

There are two projects in the solution, a test project (making use of the [NUnit](https://nunit.org/) , NUnit3TestAdapter, and Microsoft.NET.Test.Sdk packages) and a class library `Raindrops`. The class library contains a single static class `Raindrops` containing a single static method `GetFactorResult` which utilises a [StringBuilder](https://docs.microsoft.com/en-us/dotnet/standard/base-types/stringbuilder). The test project contains a single class `GetFactorResultTests` composed of unit test methods for the `GetFactorResult` method. 

## Testing

The structure of the unit tests is as follows. All unit tests are contained in the `GetFactorResultTests` class. A typical unit test follows a structure like so:

```c#
[TestCase(3)]
[TestCase(36)]
[TestCase(-3)]
[TestCase(-36)]
public void GetFactorResult_NumberHasAFactorOf3_ReturnsPling(int input)
{
    var result = Raindrops.Raindrops.GetFactorResult(input);
    Assert.That(result, Is.EqualTo("Pling"));
}
```

Where the `[TestCase]` attributes parameterise the tests so that multiple values can be tested against by a single test method.

Test method names follow a [convention recommend by Microsoft](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices#naming-your-tests), in which they are split into three parts.

1. The name of the method being tested.
2. The scenario under which it's being tested.
3. The expected behaviour when the scenario is invoked.

Within `RaindropsLibraryTests.cs` an Arrange-Act-Assert (AAA) pattern has been followed to standardise the tests. Since the system being tested is a static class with a static method the Arrange step is omitted.