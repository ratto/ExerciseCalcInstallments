using System;
using System.Globalization;
using ExerciseCalcInstallments.Entities;
using ExerciseCalcInstallments.Services;

namespace ExerciseCalcInstallments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data:");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int insNumber = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value);
            ProcessContractService processContract = new ProcessContractService(insNumber, contract);
            processContract.GenerateInstallments();

            Console.WriteLine("Installments:");

            Console.WriteLine(contract);
        }
    }
}
