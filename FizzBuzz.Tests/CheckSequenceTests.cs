using FizzBuzz.Core.Interfaces;
using FizzBuzz.Core.Models;
using FizzBuzz.Services.Services;
using FizzBuzz.Tests.Mocks;

namespace FizzBuzz.Tests;

public class CheckSequenceTests
{
    private ICheckSequence _systemUnderTests;

    private NumSequence numSequenceCorrect;

    private NumSequence numSequenceIncorrect;

    [SetUp]
    public void Setup()
    {
        FakeCheckConditions fakeCheckConditions = new FakeCheckConditions();

        _systemUnderTests = new CheckSequence(fakeCheckConditions);

        numSequenceCorrect = new NumSequence(new List<string>()
        {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"
        });

        numSequenceIncorrect = new NumSequence(new List<string>()
        {
            "1",
            "2",
            "fw",
            "4",
            "5",
            "s"
        });
    }


    [Test]
    public void GIVEN_CheckSequence_WHEN_Check_method_THEN_correct_value_is_returned()
    {
        var actual = _systemUnderTests.Check(numSequenceCorrect);

        var expected = new List<string>() { "ok", "2", "ok", "4", "ok", "6"};

        Assert.That(expected, Is.EqualTo(actual.Sequence));
    }

    [Test]
    public void GIVEN_CheckSequence_WHEN_Check_method_THEN_throws_exception()
    {
        Assert.Throws<FormatException>(() => _systemUnderTests.Check(numSequenceIncorrect));
    }
}
