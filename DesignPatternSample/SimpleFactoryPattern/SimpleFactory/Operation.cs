namespace SimpleFactoryPattern.SimpleFactory
{
    public abstract class Operation
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

        public abstract double GetResult();
    }
}
