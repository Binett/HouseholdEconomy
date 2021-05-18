﻿using HouseholdEconomy.Models;
using System;
using System.Collections.Generic;

namespace HouseholdEconomy
{
    public class Calculator
    {
        private List<EconomicObject> economicObjectList;

        public Calculator(List<EconomicObject> list)
        {
            economicObjectList = list;
        }

        public double GetTotalIncome()
        {
            double totalIncomes = 0;
            foreach (var p in economicObjectList)
            {
                if (p.Type == EconomicType.Income)
                {
                    totalIncomes += p.Amount;
                }
            }
            return totalIncomes;
        }

        public double GetTotalExpenses()
        {
            double totalExpenses = 0;
            foreach (var p in economicObjectList)
            {
                if (p.Type == EconomicType.Expense)
                {
                    totalExpenses += p.Amount;
                }
            }
            return totalExpenses;
        }

        public double GetTotalSaving()
        {
            if (IsMoreIncomeThanExpenses())
            {
                //EXEMPEL: 20% spara på income. 
                //Om totalsaving blir mer än total expenses. går ej
                //totalsaving = (income - expenses) * 0.1 (10 procent)
            }
            throw new NotImplementedException();
        }

        public double GetRemainingBalance()
        {
            if (IsMoreIncomeThanExpenses())
            {

            }
            throw new NotImplementedException();
        }

        private bool IsMoreIncomeThanExpenses() => GetTotalIncome() > GetTotalExpenses();
    }
}
