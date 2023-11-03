using FizzBuzz.Core.Interfaces;
using FizzBuzz.Core.Models;

namespace FizzBuzz.Services.Services;

public class SequenceProcessing : ISequenceProcessing
{
    private readonly IListConverter _listConverter;
    private readonly ICheckSequence _checkSequence;

    public SequenceProcessing(IListConverter listConverter, ICheckSequence checkSequence)
    {
        _listConverter = listConverter; 
        _checkSequence = checkSequence;
    }

    public NumSequence Process(string sequence)
    {
        NumSequence Numbers;

        Numbers = _listConverter.ConvertToSequence(sequence);

        Numbers = _checkSequence.Check(Numbers);

        return Numbers;
    }
}
