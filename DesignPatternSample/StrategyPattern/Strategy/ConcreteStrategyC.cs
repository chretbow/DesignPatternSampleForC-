using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Strategy
{
    public class ConcreteStrategyC : Strategy
    {
        public override string AlgorithmInterface()
        {
            return "實現算法C";
        }
    }
}
