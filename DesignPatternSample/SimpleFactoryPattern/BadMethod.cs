namespace SimpleFactoryPattern
{
    using System;

    public class BadMethod
    {
        public double Computer(double a, double b, string opration)
        {
            try
            {
                double result = 0;
                switch (opration)
                {
                    case "+":
                        result = a + b;
                        break;
                    case "-":
                        result = a - b;
                        break;
                    case "*":
                        result = a * b;
                        break;
                    case "/":
                        if (b.Equals(0))
                        {
                            throw new Exception("除數不能為0");
                        }
                        else
                        {
                            result = a / b;
                        }
                        break;
                    default:
                        throw new Exception("不支援此運算符號");
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
