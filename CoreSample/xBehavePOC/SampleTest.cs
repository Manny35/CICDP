using System;
using Xbehave;
using Xunit;

namespace xBehavePOC
{
    public class Calculator
    {
        public int Add(int x, int y) => x + y;
    }

    public class SampleTest
    {

        [Scenario]
        [Example(1, 2, 3)]
        [Example(2, 3, 5)]
        public void AdditionSuccessful(int x, int y, int expectedAnswer, Calculator calculator, int answer)
        {
            $"Given the number {x}"
                .x(() => { });

            $"And the number {y}"
                .x(() => { });

            "And a calculator"
                .x(() => calculator = new Calculator());

            "When I add the numbers together"
                .x(() => answer = calculator.Add(x, y));

            $"Then the answer is {answer}"
                .x(() => Assert.Equal(expectedAnswer, answer));
        }
    }
}
