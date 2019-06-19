using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.CashStrategy
{
    public class CashReturn : CashSuper
    {
        private double condition = 0.0d;
        private double moneyReturn = 0.0d;

        public CashReturn(string condition, string moneyReturn)
        {
            this.condition = double.Parse(condition);
            this.moneyReturn = double.Parse(moneyReturn);
        }

        public override double AcceptCash(double money)
        {
            double result = money;

            if (money >= condition)
            {
                result = money - Math.Floor(money / condition) * moneyReturn;
            }

            return result;
        }
    }
}
