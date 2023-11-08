using FizzBuzz.Core.Interfaces;
using FizzBuzz.Core.Models;
using FizzBuzz.Services.Services;
using FizzBuzz.Tests.Mocks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace FizzBuzz.Tests;

public class ListConvertersTests
{
    private IListConverter _systemUnderTests;

    const string sequenceCorrect = "1, 2, 3, 4, 5, 6, 7, 8, 9, 10";
    const string sequenceIncorrectDivider = "1; 2. 3, 4 5, 6, 7, 8, 9, 10";


    [SetUp]
    public void Setup()
    {
        _systemUnderTests = new ListConverter();
    }

    [Test]
    public void GIVEN_ListConverter_WHEN_ConvertToSequence_method_THEN_correct_value_is_returned()
    {
        var actual = _systemUnderTests.ConvertToSequence(sequenceCorrect);
        List<string> expected = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"};
        Assert.That(actual.Sequence, Is.EqualTo(expected));
    }

    [Test]
    public void GIVEN_ListConverter_WHEN_ConvertToSequence_method_alternative_divider_THEN_correct_value_is_returned()
    {
        var actual = _systemUnderTests.ConvertToSequence(sequenceIncorrectDivider);
        List<string> expected = new List<string> { "1", "2", "3", "45", "6", "7", "8", "9", "10" };
        Assert.That(actual.Sequence, Is.EqualTo(expected));
    }
}
