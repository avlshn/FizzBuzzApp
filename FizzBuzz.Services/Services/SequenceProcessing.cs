using FizzBuzz.Core.Interfaces;
using FizzBuzz.Core.Models;

namespace FizzBuzz.Services.Services;


/// <summary>
/// Upper level business logic interface
/// </summary>
public class SequenceProcessing : ISequenceProcessing
{
    private readonly IListConverter _listConverter;
    private readonly ICheckSequence _checkSequence;


    /// <summary>
    /// Default DI constructor
    /// </summary>
    /// <param name="listConverter">Converter class</param>
    /// <param name="checkSequence">CheckSequence class</param>
    public SequenceProcessing(IListConverter listConverter, ICheckSequence checkSequence)
    {
        _listConverter = listConverter; 
        _checkSequence = checkSequence;
    }

    /// <summary>
    /// Upper level business logic interface
    /// </summary>
    /// <param name="sequence">String with sequence to process</param>
    /// <returns>NumSequence object with result</returns>
    public NumSequence Process(string sequence)
    {
        NumSequence Numbers;

        Numbers = _listConverter.ConvertToSequence(sequence);

        Numbers = _checkSequence.Check(Numbers);

        return Numbers;
    }
}
