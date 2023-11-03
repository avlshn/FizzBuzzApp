using FizzBuzz.Core.Models;

namespace FizzBuzz.Core.Interfaces;

public interface IListConverter
{
    public NumSequence ConvertToSequence(string s);
}
