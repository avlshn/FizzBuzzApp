using FizzBuzz.Core.Interfaces;
using FizzBuzz.Core.Models;

namespace FizzBuzz.Services.Services;

public class CheckSequence : ICheckSequence
{
    private readonly ICheckConditions _checkConditions;
    public CheckSequence(ICheckConditions checkConditions)
    {
        _checkConditions = checkConditions;
    }

    public virtual NumSequence Check(NumSequence numSequence)
    {
        for (int i = 0; i < numSequence.Sequence.Count; i++)
        {
            var checkResult = _checkConditions.Check(Int32.Parse(numSequence.Sequence[i]));
            if (checkResult != null && checkResult != "")
                numSequence.Sequence[i] = checkResult;
        }

        return numSequence;
    }

}
