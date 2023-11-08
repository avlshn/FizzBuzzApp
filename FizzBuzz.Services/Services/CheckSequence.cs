using FizzBuzz.Core.Interfaces;
using FizzBuzz.Core.Models;

namespace FizzBuzz.Services.Services;
/// <summary>
/// Class that checks whole sequence for conditions.
/// </summary>
public class CheckSequence : ICheckSequence
{
    private readonly ICheckConditions _checkConditions;

    /// <summary>
    /// Default DI constructor
    /// </summary>
    /// <param name="checkConditions"></param>
    public CheckSequence(ICheckConditions checkConditions)
    {
        _checkConditions = checkConditions;
    }

    /// <summary>
    /// Converts every number in sequence and checks it for every conditions using ICheckConditions
    /// </summary>
    /// <param name="numSequence"></param>
    /// <returns></returns>
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
