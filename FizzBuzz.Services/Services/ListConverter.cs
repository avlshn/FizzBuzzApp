using FizzBuzz.Core.Interfaces;
using FizzBuzz.Core.Models;

namespace FizzBuzz.Services.Services;

/// <summary>
/// Converter class. Converts string to NumSequence.
/// </summary>
public class ListConverter : IListConverter
{

    /// <summary>
    /// Converts string to NumSequence
    /// </summary>
    /// <param name="s">input string</param>
    /// <returns>NumSequence with data</returns>
    public NumSequence ConvertToSequence(string s)
    {
        s = s.Replace(" ", "");
        s = s.Replace(";", ",");
        s = s.Replace(".", ",");

        NumSequence numSequence = new NumSequence(s.Split(",").ToList());

        return numSequence;
    }
}
