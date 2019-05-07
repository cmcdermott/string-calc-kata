using Xunit;

namespace StringCalc
{
    public class TestCalc
    {

        [Fact]
        public void Test()
        {
            var test1 = "1,1,2";
            var testClass = new StringCalc();

            var output = testClass.Add(test1);

            Assert.Equal(4, output);
        }
    }
}
