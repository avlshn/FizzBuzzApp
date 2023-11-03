namespace FizzBuzz.Core.Models;

/// <summary>
/// Data entity
/// </summary>
public class NumSequence
{
    /// <summary>
    /// Collection with numbers
    /// </summary>
    private List<string> _sequence;

    public List<string> Sequence
    {
        get { return _sequence; }
        set { _sequence = value; }
    }


    /// <summary>
    /// Default constructor
    /// </summary>
    /// <param name="ints">Ints sequence to store in class</param>
    public NumSequence(List<string> ints)
    {
         _sequence = ints;
    }
}
