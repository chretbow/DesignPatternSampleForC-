namespace SimpleFactoryPattern.SimpleFactory
{
    using System;

    public class OperationFactory
    {
        public static Operation CreateOperate(string operate)
        {
            try
            {
                Operation oper = null;

                switch (operate)
                {
                    case "+":
                        oper = new OperationAdd();
                        break;
                    case "-":
                        oper = new OperationSub();
                        break;
                    case "*":
                        oper = new OperationMul();
                        break;
                    case "/":
                        oper = new OperationDiv();
                        break;
                    default:
                        throw new Exception("不支援此運算符號");
                }

                return oper;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
