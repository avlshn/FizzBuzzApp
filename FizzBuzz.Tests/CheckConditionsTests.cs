using FizzBuzz.Core.Interfaces;
using FizzBuzz.Services.Services;
using NUnit.Framework;

namespace FizzBuzz.Tests;

public class CheckConditionsTests
{
    private ICheckConditions _systemUnderTests;

    [SetUp]
    public void Setup()
    {
        _systemUnderTests = new CheckConditions();
    }


    
    [TestCase(3, "Fizz")]
    [TestCase(-3, "Fizz")]
    [TestCase(9, "Fizz")]
    public void GIVEN_CheckConditions_WHEN_Check_method_is_multiple_with_3_THEN_correct_value_is_returned(int test, string expected)
    {
        var actual = _systemUnderTests.Check(test);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(5, "Buzz")]
    [TestCase(-5, "Buzz")]
    [TestCase(20, "Buzz")]
    public void GIVEN_CheckConditions_WHEN_Check_method_is_multiple_with_5_THEN_correct_value_is_returned(int test, string expected)
    {
        var actual = _systemUnderTests.Check(test);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(15, "Fizz-Buzz")]
    [TestCase(-30, "Fizz-Buzz")]
    [TestCase(45, "Fizz-Buzz")]
    public void GIVEN_CheckConditions_WHEN_Check_method_is_multiple_with_15_THEN_correct_value_is_returned(int test, string expected)
    {
        var actual = _systemUnderTests.Check(test);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(1, null)]
    [TestCase(-2, null)]
    [TestCase(4, null)]
    public void GIVEN_CheckConditions_WHEN_Check_method_is_multiple_with_7_THEN_correct_value_is_returned(int test, string expected)
    {
        var actual = _systemUnderTests.Check(test);
        Assert.That(actual, Is.EqualTo(expected));
    }

}