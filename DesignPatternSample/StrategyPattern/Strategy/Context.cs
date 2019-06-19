using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Strategy
{
    public class Context
    {
        private Strategy strategy;

        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public string ContextInterface()
        {
            return strategy.AlgorithmInterface();
        }
    }
}
