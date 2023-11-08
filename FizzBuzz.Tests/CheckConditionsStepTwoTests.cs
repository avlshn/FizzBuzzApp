using FizzBuzz.Core.Interfaces;
using FizzBuzz.Services.Services;
using NUnit.Framework;

namespace FizzBuzz.Tests;

public class CheckConditionsStepTwoTests
{
    private ICheckConditions _systemUnderTests;

    [SetUp]
    public void Setup()
    {
        _systemUnderTests = new CheckConditionsStepTwo();
    }


    [TestCase(3, "Fizz")]
    [TestCase(6, "Fizz")]
    [TestCase(9, "Fizz")]
    public void GIVEN_CheckConditions_WHEN_Check_method_is_multiple_with_3_THEN_correct_value_is_returned(int test, string expected)
    {
        var actual = _systemUnderTests.Check(test);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(5, "Buzz")]
    [TestCase(10, "Buzz")]
    [TestCase(25, "Buzz")]
    public void GIVEN_CheckConditions_WHEN_Check_method_is_multiple_with_5_THEN_correct_value_is_returned(int test, string expected)
    {
        var actual = _systemUnderTests.Check(test);
        Assert.That(actual, Is.EqualTo(expected));
    }



    [TestCase(7, "Guzz")]
    [TestCase(14, "Guzz")]
    [TestCase(49, "Guzz")]
    public void GIVEN_CheckConditions_WHEN_Check_method_is_multiple_with_7_THEN_correct_value_is_returned(int test, string expected)
    {
        var actual = _systemUnderTests.Check(test);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(12, "Fizz-Muzz")]
    [TestCase(21, "Fizz-Guzz")]
    [TestCase(15, "Fizz-Buzz")]
    [TestCase(20, "Buzz-Muzz")]
    [TestCase(28, "Muzz-Guzz")]
    [TestCase(35, "Buzz-Guzz")]
    [TestCase(60, "Fizz-Buzz-Muzz")]
    [TestCase(105, "Fizz-Buzz-Guzz")]
    [TestCase(420, "Fizz-Buzz-Muzz-Guzz")]
    public void GIVEN_CheckConditions_WHEN_Check_method_is_combination_THEN_correct_value_is_returned(int test, string expected)
    {
        var actual = _systemUnderTests.Check(test);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(1, null)]
    [TestCase(2, null)]
    [TestCase(13, null)]
    public void GIVEN_CheckConditions_WHEN_Check_method_out_of_conditions_THEN_correct_value_is_returned(int test, string expected)
    {
        var actual = _systemUnderTests.Check(test);
        Assert.That(actual, Is.EqualTo(expected));
    }
}
