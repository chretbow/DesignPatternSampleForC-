using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.CashStrategy
{
    public class CashRebate : CashSuper
    {
        private double rebate = 1d;

        public CashRebate(string rebate)
        {
            this.rebate = double.Parse(rebate);
        }

        public override double AcceptCash(double money)
        {
            return money * rebate;
        }
    }
}
