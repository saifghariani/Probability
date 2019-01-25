using AutoFixture.Xunit2;
using Xunit;
using static Prob2.Program;

namespace Prob2.Tests
{
    public class Probab2Test
    {
        [Theory, AutoData]
        public void ShouldProbAnd(decimal a, decimal b)
        {
            Probability p = new Probability();
            p.createProb(a, b);
            Assert.Equal(a * b, p.probAnd());
        }
        [Theory, AutoData]
        public void ShouldProbOr(decimal a, decimal b)
        {
            Probability p = new Probability();
            p.createProb(a, b);
            Assert.Equal(a + b - a*b, p.probOr());
        }
        [Theory, AutoData]
        public void ShouldProbNotA(decimal a)
        {
            Probability p = new Probability();
            p.createProb(a);
            Assert.Equal(1-a, p.probNotA());
        }
    }
}
