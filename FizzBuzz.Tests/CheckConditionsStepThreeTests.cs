using FizzBuzz.Core.Interfaces;
using FizzBuzz.Services.Services;
using NUnit.Framework;

namespace FizzBuzz.Tests;

public class CheckConditionsStepThreeTests
{
    private ICheckConditions _systemUnderTests;

    [SetUp]
    public void Setup()
    {
        _systemUnderTests = new CheckConditionsStepThree();
    }


    [TestCase(3, "Dog")]
    [TestCase(6, "Dog")]
    [TestCase(9, "Dog")]
    public void GIVEN_CheckConditions_WHEN_Check_method_is_multiple_with_3_THEN_correct_value_is_returned(int test, string expected)
    {
        var actual = _systemUnderTests.Check(test);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(5, "Cat")]
    [TestCase(10, "Cat")]
    [TestCase(25, "Cat")]
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

    [TestCase(12, "Dog-Muzz")]
    [TestCase(21, "Dog-Guzz")]
    [TestCase(15, "Good-Boy")]
    [TestCase(20, "Cat-Muzz")]
    [TestCase(28, "Muzz-Guzz")]
    [TestCase(35, "Cat-Guzz")]
    [TestCase(60, "Good-Boy-Muzz")]
    [TestCase(105, "Good-Boy-Guzz")]
    [TestCase(420, "Good-Boy-Muzz-Guzz")]
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
