using System;

namespace Prob2
{
    public class Program
    {
        public struct Probability
        {
            decimal a;
            decimal b;
            public void createProb(decimal a=0, decimal b=0)
            {
                this.a = a;
                this.b = b;
            }
            public decimal probAnd()
            {
                return a * b;
            }
            public decimal probOr()
            {
                return a + b - probAnd();
            }
            public decimal probNotA()
            {
                return 1 - a;
            }
        }
        static void Main(string[] args)
        {
            Probability prob = new Probability();
            prob.createProb((decimal)0.10, (decimal)0.22);
            Console.WriteLine("P(A) and P(B) = {0}", prob.probAnd());
            Console.ReadKey();
        }

    }
}
