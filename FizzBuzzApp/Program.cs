using FizzBuzz.Core.Interfaces;
using FizzBuzz.Core.Models;
using FizzBuzz.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FizzBuzzApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
            .AddSingleton<ICheckConditions, CheckConditionsStepThree>()
            .AddSingleton<ICheckSequence, CheckSequence>()
            .AddSingleton<IListConverter, ListConverter>()
            .AddSingleton<ISequenceProcessing, SequenceProcessing>()
            .BuildServiceProvider();


            const string sequence = "1, 2, 3, 4; 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420";

            var sequenceProcessing = serviceProvider.GetService<ISequenceProcessing>();
            NumSequence Numbers = null;

            try
            {
                Numbers = sequenceProcessing.Process(sequence);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (Numbers != null)
            foreach (var number in Numbers.Sequence) 
            {
                Console.Write(number + " ");
            }
            else Console.WriteLine("Error! Incorrect input.");
        }
    }
}