using FizzBuzz.Core.Models;

namespace FizzBuzz.Core.Interfaces;

/// <summary>
/// Converts string to NumSequence
/// </summary>
public interface IListConverter
{
    /// <summary>
    /// Converts string to NumSequence
    /// </summary>
    /// <param name="s">input string</param>
    /// <returns>NumSequence with data</returns>
    public NumSequence ConvertToSequence(string s);
}
