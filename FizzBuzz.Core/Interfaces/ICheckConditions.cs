using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Core.Interfaces;

/// <summary>
/// Checking all the conditions
/// </summary>
public interface ICheckConditions
{
    /// <summary>
    /// List of delegates with all checks
    /// </summary>
    public List<Func<int, string?>> Conditions { get; set; }

    public string? Check(int member);
}
