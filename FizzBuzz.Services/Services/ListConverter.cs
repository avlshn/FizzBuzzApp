using FizzBuzz.Core.Interfaces;
using FizzBuzz.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Services.Services;

public class ListConverter : IListConverter
{
    public NumSequence ConvertToSequence(string s)
    {
        s = s.Replace(" ", "");
        s = s.Replace(";", ",");
        s = s.Replace(".", ",");

        NumSequence numSequence = new NumSequence(s.Split(",").ToList());

        return numSequence;
    }
}
