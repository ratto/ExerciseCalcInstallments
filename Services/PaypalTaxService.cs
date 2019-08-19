using System;
using System.Collections.Generic;
using System.Text;
using ExerciseCalcInstallments.Interfaces;

namespace ExerciseCalcInstallments.Services
{
    class PaypalTaxService : ITaxService
    {
        public double Tax(double value, int installment)
        {
            double qValue = value + (value * (0.01 * installment));
            return qValue + qValue * 0.02;
        }
    }
}
