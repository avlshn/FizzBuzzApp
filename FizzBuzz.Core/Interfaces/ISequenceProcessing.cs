using FizzBuzz.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Core.Interfaces;
/// <summary>
/// Upper level business logic interface
/// </summary>
public interface ISequenceProcessing
{
    /// <summary>
    /// Upper level business logic method
    /// </summary>
    /// <param name="sequence">String with numbers, separated by commas</param>
    /// <returns>Processed NumSequence class</returns>
    public NumSequence Process(string sequence);
}
