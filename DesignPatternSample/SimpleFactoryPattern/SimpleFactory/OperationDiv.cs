
namespace SimpleFactoryPattern.SimpleFactory
{
    using System;
    public class OperationDiv : Operation
    {
        public override double GetResult()
        {
            try
            {
                double result = 0;

                if (NumberB.Equals(0))
                    throw new Exception("除數不能為0");

                result = NumberA / NumberB;
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
