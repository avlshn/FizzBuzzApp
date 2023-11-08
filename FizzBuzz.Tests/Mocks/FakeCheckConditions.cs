using FizzBuzz.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Tests.Mocks;

public class FakeCheckConditions : ICheckConditions
{
    public List<Func<int, string?>> Conditions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public string? Check(int member)
    {
        if (member % 2 == 0) return null;
        else return "ok";
    }
}
