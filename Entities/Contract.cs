using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExerciseCalcInstallments.Entities
{
    class Contract
    {
        public int Number { get; private set; }
        public DateTime Date { get; private set; }
        public double TotalValue { get; set; }

        List<Installment> installments = new List<Installment>();

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

        public void setInstallments(List<Installment> installments)
        {
            this.installments = installments;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Installment installment in installments)
            {
                sb.AppendLine(installment.DueDate.ToString("dd/MM/yyyy") + " - " + installment.Amount.ToString("F2", CultureInfo.InvariantCulture));
            }

            return sb.ToString();
        }
    }
}
