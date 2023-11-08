using FizzBuzz.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Services.Services;

/// <summary>
/// Checks "fizz", "buzz", "muzz" and "guzz" conditions
/// </summary>
public class CheckConditionsStepTwo : CheckConditions, ICheckConditions
{

    /// <summary>
    /// Checks for "Muzz" condition
    /// </summary>
    /// <param name="number">Number to check</param>
    /// <returns>String with check result or null if condition is not met</returns>
    protected virtual string? CheckMuzz(int number)
    {
        if (number % 4 == 0) return "Muzz";
        else return null;
    }

    /// <summary>
    /// Checks for "Guzz" condition
    /// </summary>
    /// <param name="number">Number to check</param>
    /// <returns>String with check result or null if condition is not met</returns>
    protected virtual string? CheckGuzz(int number)
    {
        if (number % 7 == 0) return "Guzz";
        else return null;
    }

    /// <summary>
    /// Default constructor. Adds Needed conditions to list.
    /// </summary>

    public CheckConditionsStepTwo() : base()
    {
        Conditions.Add(CheckMuzz);
        Conditions.Add(CheckGuzz);
    }
}
