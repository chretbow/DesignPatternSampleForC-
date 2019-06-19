using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.CashStrategy
{
    public class CashContextFactory
    {
        private CashSuper cs = null;

        public CashContextFactory(string type)
        {
            switch (type)
            {
                case "正常收費":
                    cs = new CashNormal();
                    break;
                case "滿300返100":
                    cs = new CashReturn("300", "100");
                    break;
                case "打8折":
                    cs = new CashRebate("0.8");
                    break;
                default:
                    break;
            }
        }

        public double GetResult(double money)
        {
            return cs.AcceptCash(money);
        }
    }
}
