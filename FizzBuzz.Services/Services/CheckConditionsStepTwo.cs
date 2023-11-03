using FizzBuzz.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Services.Services;

public class CheckConditionsStepTwo : CheckConditions, ICheckConditions
{
    protected virtual string? CheckMuzz(int number)
    {
        if (number % 4 == 0) return "Muzz";
        else return null;
    }

    protected virtual string? CheckGuzz(int number)
    {
        if (number % 7 == 0) return "Guzz";
        else return null;
    }

    public CheckConditionsStepTwo() : base()
    {
        Conditions.Add(CheckMuzz);
        Conditions.Add(CheckGuzz);
    }
}
