using FizzBuzz.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Services.Services;

public class CheckConditionsStepThree : CheckConditionsStepTwo, ICheckConditions
{
    protected virtual string? CheckGoodBoy(int number)
    {
        if (number % 3 == 0 && number % 5 == 0) return "Good-Boy";
        else if (number % 3 == 0) return "Dog";
        else if (number % 5 == 0) return "Cat";
        else return null;
    }



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
