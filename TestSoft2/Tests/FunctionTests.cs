using NUnit.Framework;
using System;

namespace TestSoft2.Tests
{
    [TestFixture]
    public class FunctionTests
    {
        private Function methods;
        [SetUp]
        public void SetUp()
        {
            this.methods = new Function();
        }
        [Test]
        public void GIVEN_Function_WHEN_Sort_method_IS_arr_1_9_5()
        {
            try 
            {
                //Arrange
                int[] nums = new int[3] { 1, 9, 5 };
                int[] answer = new int[3] { 1, 5, 9 };
                //Actual
                int[] actual = this.methods.Sort(nums);
                //Assert
                Assert.AreEqual(answer, actual);
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        [Test]
        public void GIVEN_Function_WHEN_Sort_method_IS_arr_1_9_5_7_6_2()
        {
            try
            {
                //Arrange
                int[] nums = new int[6] { 1, 9, 5, 7, 6, 2 };
                int[] answer = new int[6] { 1, 2, 5, 6, 7, 9 };
                //Actual
                int[] actual = this.methods.Sort(nums);
                //Assert
                Assert.AreEqual(answer, actual);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        [TestCase("AbdbA", true)]
        [TestCase("Gdwoj", false)]
        public void GIVEN_Function_WHEN_Palindrom_method(string str, bool answer)
        {
            try
            {
                //Arrange
                //Actual
                bool actual = this.methods.Palindrom(str);
                //Assert
                Assert.AreEqual(answer, actual);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        [TestCase(6, 720)]
        [TestCase(3, 6)]
        public void GIVEN_Function_WHEN_Factorial_method(int value, int answer)
        {
            try
            {
                //Arrange
                //Actual
                int actual = this.methods.Factorial(value);
                //Asserts
                Assert.AreEqual(answer, actual);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        [Test]
        public void GIVEN_Function_Exception_WHEN_Factorial_method()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => { this.methods.Factorial(-1); }
                );
        }
        [TestCase(0, 0)]
        [TestCase(-352, -1)]
        [TestCase(6, 8)]
        public void GIVEN_Function_WHEN_Fibonachi_method(int value, int answer)
        {
            try
            {
                //Arrange
                //Actual
                int actual = this.methods.Fibonachi(value);
                //Asserts
                Assert.AreEqual(answer, actual);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        [TestCase(0, 0, 1)]
        [TestCase(-25, 2, 625)]
        [TestCase(5, -2, -2)]
        public void GIVEN_Function_WHEN_Degree_method(int num, int deg, int answer)
        {
            try
            {
                //Arrange
                //Actual
                int actual = this.methods.Degree(num, deg);
                //Asserts
                Assert.AreEqual(answer, actual);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        [TestCase(0)]
        [TestCase(3)]
        [TestCase(5)]
        public void GIVEN_Function_WHEN_PrimeNumber_method(int value)
        {
            try
            {
                //Arrange
                int num = 8;
                bool answer = true;
                //Actual
                bool actual = this.methods.PrimeNumber(num);
                //Assert
                Assert.AreEqual(answer, actual);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
