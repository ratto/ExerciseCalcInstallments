using System;

namespace ExerciseCalcInstallments.Entities
{
    class Installment
    {
        public DateTime DueDate { get; private set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }
    }
}
