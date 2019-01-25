using AutoFixture.Xunit2;
using Xunit;
using static Prob2.Program;

namespace Prob2.Tests
{
    public class Probab2Test
    {
        [Fact]
        public void ShouldProbAnd()
        {
            decimal a = 0.1m;
            decimal b = 0.2m;
            decimal expectedResult = 0.02m;
            Probability p = new Probability();
            p.createProb(a, b);
            Assert.Equal(expectedResult, p.probAnd());
        }
        [Fact]
        public void ShouldProbOr()
        {
            decimal a = 0.1m;
            decimal b = 0.2m;
            decimal expectedResult = 0.28m;
            Probability p = new Probability();
            p.createProb(a, b);
            Assert.Equal(expectedResult, p.probOr());
        }
        [Fact]
        public void ShouldProbNotA()
        {
            decimal expectedResult = 0.9m;
            decimal a = 0.1m;
            Probability p = new Probability();
            p.createProb(a);
            Assert.Equal(expectedResult, p.probNotA());
        }
    }
}
