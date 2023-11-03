using FizzBuzz.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Services.Services;

public class CheckConditions : ICheckConditions
{
    public List<Func<int, string?>> Conditions { get; set; }

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

    protected virtual string? CheckFizz(int number)
    {
        if (number % 3 == 0) return "Fizz";
        else return null;
    }

    protected virtual string? CheckBuzz(int number)
    {
        if (number % 5 == 0) return "Buzz";
        else return null;
    }

    //public virtual string? CheckGeneric(int number, int divider, string result) 
    //{
    //    if (number % divider == 0) return result;
    //    else return null;
    //}

    public CheckConditions()
    {
        Conditions = new List<Func<int, string?>>
        {
            CheckFizz,
            CheckBuzz
        };
    }
}
