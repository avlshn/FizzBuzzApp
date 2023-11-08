using FizzBuzz.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Services.Services;

/// <summary>
/// Checks "cat, dog, good-boy" "muzz" and "guzz" conditions
/// </summary>
public class CheckConditionsStepThree : CheckConditionsStepTwo, ICheckConditions
{
    /// <summary>
    /// Checks for "Cat", "Dog" and "Good-Boy" conditions
    /// </summary>
    /// <param name="number">Number to check</param>
    /// <returns>String with check result or null if conditions are not met</returns>
    protected virtual string? CheckGoodBoy(int number)
    {
        if (number % 3 == 0 && number % 5 == 0) return "Good-Boy";
        else if (number % 3 == 0) return "Dog";
        else if (number % 5 == 0) return "Cat";
        else return null;
    }


    /// <summary>
    /// Default constructor. Adds Needed conditions to list.
    /// </summary>
    public CheckConditionsStepThree()
    {
        Conditions = new List<Func<int, string?>>
        {
            CheckGoodBoy,
            CheckMuzz,
            CheckGuzz,
        };
    }
}
