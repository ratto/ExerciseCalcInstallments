using System;
using System.Collections.Generic;
using System.Text;
using ExerciseCalcInstallments.Entities;
using ExerciseCalcInstallments.Interfaces;
using ExerciseCalcInstallments.Services;

namespace ExerciseCalcInstallments.Services
{
    class ProcessContractService
    {
        public int InstallmentCount { get; set; }
        Contract contract = null;
        

        public ProcessContractService(int installmentCount, Contract contract)
        {
            InstallmentCount = installmentCount;
            this.contract = contract;
        }

        public void GenerateInstallments()
        {
            List<Installment> installments = new List<Installment>();

            double installmentValue = contract.TotalValue / InstallmentCount;
            ITaxService taxService = new PaypalTaxService();

            for (int i = 1; i <= InstallmentCount; i++)
            {
                DateTime dueDate = contract.Date.AddMonths(i);
                double amount = taxService.Tax(installmentValue, i);
                installments.Add(new Installment(dueDate, amount));
            }

            contract.setInstallments(installments);
        }
    }
}
