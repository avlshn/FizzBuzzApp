using FizzBuzz.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Services.Services;

/// <summary>
/// Checks "fizz" and "buzz" conditions
/// </summary>
public class CheckConditions : ICheckConditions
{

    /// <summary>
    /// List with delegates of all needed check functions. 
    /// </summary>
    public List<Func<int, string?>> Conditions { get; set; }


    /// <summary>
    /// Checks single sequence member for every condition
    /// </summary>
    /// <param name="member">member of sequence to check</param>
    /// <returns>Concat of condition strings with check result or null if condition is not met</returns>
    public string? Check(int member)
    {
        string? result = null;

        foreach (var condition in Conditions)
        {
            string? checkResult = condition(member);
            if (checkResult != null)
            {
                if (result == null)
                    result = checkResult;
                else
                {
                    result += "-";
                    result += checkResult;
                }
            }
        }

        return result;
    }

    /// <summary>
    /// Checks for "Fizz" condition
    /// </summary>
    /// <param name="number">Number to check</param>
    /// <returns>String with check result or null if condition is not met</returns>

    protected virtual string? CheckFizz(int number)
    {
        if (number % 3 == 0) return "Fizz";
        else return null;
    }

    /// <summary>
    /// Checks for "Buzz" condition
    /// </summary>
    /// <param name="number">Number to check</param>
    /// <returns>String with check result or null if condition is not met</returns>

    protected virtual string? CheckBuzz(int number)
    {
        if (number % 5 == 0) return "Buzz";
        else return null;
    }

    /// <summary>
    /// Default constructor. Adds Needed conditions to list.
    /// </summary>

    public CheckConditions()
    {
        Conditions = new List<Func<int, string?>>
        {
            CheckFizz,
            CheckBuzz
        };
    }

    /// <summary>
    /// Constructor that adds delegates from parameters to list.
    /// </summary>
    /// <param name="func">Conditions to check</param>
    public CheckConditions(params Func<int, string?>[] func)
    {
        Conditions = func.ToList();
    }
}
