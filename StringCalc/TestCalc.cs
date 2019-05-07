using System;
using Xunit;

namespace ConsoleApp1
{
    public class TestCalc
    {

        [Fact]
        public void step1()
        {
            var test1 = "1,1,2";
            var testClass = new StringCalc();

            var output = testClass.Add(test1);

            Assert.Equal(4, output);
        }

        [Fact]
        public void step3()
        {
            var test3 = "1\n2\n3";
            var testClass3 = new StringCalc();

            var output = testClass3.Add(test3);

            Assert.Equal(6, output);
        }

        [Fact]
        public void step4()
        {
            var test4 = "//;\n1;2";
            var testClass4 = new StringCalc();

            var output = testClass4.Add(test4);

            Assert.Equal(3, output);
        }

        [Fact]
        public void step5()
        {
            var test5 = "1,4,-1";
            var testClass5 = new StringCalc();

            var ex = Assert.Throws<Exception>(() => { testClass5.Add(test5); });

            Assert.Equal("Negatives not allowed: -1", ex.Message);
        }

        [Fact]
        public void step6()
        {
            var test6 = "2,1001";
            var testClass6 = new StringCalc();

            var output = testClass6.Add(test6);

            Assert.Equal(2, output);


           
        }
    }
}
