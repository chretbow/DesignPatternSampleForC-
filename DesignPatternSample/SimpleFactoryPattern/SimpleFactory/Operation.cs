namespace SimpleFactoryPattern.SimpleFactory
{
    public class Operation
    {
        private double numberA = 0;
        private double numberB = 0;

        public double NumberA
        {
            get { return numberA; }
            set { numberA = value; }
        }

        public double NumberB
        {
            get { return numberB; }
            set { numberB = value; }
        }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
}
