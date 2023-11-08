using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Core.Interfaces;

/// <summary>
/// Checks all the conditions
/// </summary>
public interface ICheckConditions
{
    /// <summary>
    /// List of delegates with all checks
    /// </summary>
    public List<Func<int, string?>> Conditions { get; set; }

    /// <summary>
    /// Checks single sequence member for every condition
    /// </summary>
    /// <param name="member">member of sequence to check</param>
    /// <returns>null if conditions aren`t met, string in opposite case</returns>
    public string? Check(int member);
}
