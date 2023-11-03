using FizzBuzz.Core.Models;

namespace FizzBuzz.Core.Interfaces;

/// <summary>
/// Checking sequence interface. 
/// </summary>
public interface ICheckSequence
{
    /// <summary>
    /// Checks sequence for all the conditions
    /// </summary>
    /// <param name="numSequence">Digits sequence to check</param>
    /// <param name="checkConditions">Conditions to check</param>
    /// <returns>Changed sequence</returns>
    public NumSequence Check(NumSequence numSequence);
}
