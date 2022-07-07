
namespace Calculator.Tests

{
    public class DoAdditionTests
    {

        [Fact]
        public void DoAdditionTest()
        {

            // Arrange
            decimal num1 = 10;
            decimal num2 = 20;
            decimal expected = 30;

            // Act
            decimal actual = CalculationMethodsClass.DoAddition(num1, num2);

            // Assert
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void DoAdditionNum1ZeroTest()
        {

            // Arrange
            decimal num1 = 0;
            decimal num2 = 20;
            decimal expected = 20;

            // Act
            decimal actual = CalculationMethodsClass.DoAddition(num1, num2);

            // Assert
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void DoAdditionNum2ZeroTest()
        {

            // Arrange
            decimal num1 = 10;
            decimal num2 = 0;
            decimal expected = 10;

            // Act
            decimal actual = CalculationMethodsClass.DoAddition(num1, num2);

            // Assert
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void DoAdditionArrayTest()
        {

            // Arrange
            decimal[] testContainer = new decimal[5] { 10, 1, 1, 1, 2 };
            decimal expected = 15;

            // Act

            CalculationMethodsClass calculationMethodsClass = new CalculationMethodsClass();
            decimal actual = calculationMethodsClass.DoAddition(testContainer);

            // Assert
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void DoAdditionArrayWithZeroTest()
        {

            // Arrange
            decimal[] testContainer = new decimal[5] { 10, 0, 0, 0, 2 };
            decimal expected = 12;

            // Act

            CalculationMethodsClass calculationMethodsClass = new CalculationMethodsClass();
            decimal actual = calculationMethodsClass.DoAddition(testContainer);

            // Assert
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void DoAdditionArrayOnlyZeroTest()
        {

            // Arrange
            decimal[] testContainer = new decimal[5] { 0, 0, 0, 0, 0 };
            decimal expected = 0;

            // Act

            CalculationMethodsClass calculationMethodsClass = new CalculationMethodsClass();
            decimal actual = calculationMethodsClass.DoAddition(testContainer);

            // Assert
            Assert.Equal(expected, actual);

        }
    }

    public class DoDivisionTests
    {

        [Fact]
        public void DoDivisionZeroTest()
        {

            // Arrange
            decimal num1 = 0;
            decimal num2 = 0;
            decimal expected = 0;

            // Act
            decimal actual = CalculationMethodsClass.DoDivision(num1, num2);



            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void DoDivisionNum1ZeroTest()
        {

            // Arrange
            decimal num1 = 0;
            decimal num2 = 10;
            decimal expected = 0;

            // Act
            decimal actual = CalculationMethodsClass.DoDivision(num1, num2);



            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void DoDivisionNum2ZeroTest()
        {

            // Arrange
            decimal num1 = 10;
            decimal num2 = 0;
            decimal expected = 0;

            // Act
            decimal actual = CalculationMethodsClass.DoDivision(num1, num2);



            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void DoDivisionTest()
        {

            // Arrange
            decimal num1 = 100;
            decimal num2 = 2;
            decimal expected = 50;

            // Act
            decimal actual = CalculationMethodsClass.DoDivision(num1, num2);



            // Assert
            Assert.Equal(expected, actual);

        }
    }

    public class DoSubtractionTests
    {
        [Fact]
        public void DoSubtractionTest()
        {

            // Arrange
            decimal num1 = 100;
            decimal num2 = 2;
            decimal expected = 98;

            // Act
            decimal actual = CalculationMethodsClass.DoSubtraction(num1, num2);



            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void DoSubtractionTest2()
        {

            // Arrange
            decimal num1 = 2;
            decimal num2 = 2;
            decimal expected = 0;

            // Act
            decimal actual = CalculationMethodsClass.DoSubtraction(num1, num2);



            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void DoSubtractionTest3()
        {

            // Arrange
            decimal num1 = 0;
            decimal num2 = 0;
            decimal expected = 0;

            // Act
            decimal actual = CalculationMethodsClass.DoSubtraction(num1, num2);



            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void DoSubtractionNum1ZeroTest()
        {

            // Arrange
            decimal num1 = 0;
            decimal num2 = 2;
            decimal expected = -2;

            // Act
            decimal actual = CalculationMethodsClass.DoSubtraction(num1, num2);



            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void DoSubtractionNum2ZeroTest()
        {

            // Arrange
            decimal num1 = 2;
            decimal num2 = 0;
            decimal expected = 2;

            // Act
            decimal actual = CalculationMethodsClass.DoSubtraction(num1, num2);



            // Assert
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void DoSubtractionArrayTest()
        {

            // Arrange
            decimal[] testContainer = new decimal[5] { 10, 1, 1, 1, 2 };
            decimal expected = 5;

            // Act

            CalculationMethodsClass calculationMethodsClass = new CalculationMethodsClass();
            decimal actual = calculationMethodsClass.DoSubtraction(testContainer);

            // Assert
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void DoSubtractionArrayWithZeroTest()
        {

            // Arrange
            decimal[] testContainer = new decimal[5] { 10, 0, 0, 0, 2 };
            decimal expected = 8;

            // Act

            CalculationMethodsClass calculationMethodsClass = new CalculationMethodsClass();
            decimal actual = calculationMethodsClass.DoSubtraction(testContainer);

            // Assert
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void DoSubtractionArrayOnlyZeroTest()
        {

            // Arrange
            decimal[] testContainer = new decimal[5] { 0, 0, 0, 0, 0 };
            decimal expected = 0;

            // Act

            CalculationMethodsClass calculationMethodsClass = new CalculationMethodsClass();
            decimal actual = calculationMethodsClass.DoSubtraction(testContainer);

            // Assert
            Assert.Equal(expected, actual);

        }
    }

    public class DoMultiplicationTests
    {
        [Fact]
        public void DoMultiplication10Times10Test1()
        {

            // Arrange
            decimal num1 = 10;
            decimal num2 = 10;
            decimal expected = 100;

            // Act
            decimal actual = CalculationMethodsClass.DoMultiplication(num1, num2);



            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void DoMultiplication100Times1Test2()
        {

            // Arrange
            decimal num1 = 100;
            decimal num2 = 1;
            decimal expected = 100;

            // Act
            decimal actual = CalculationMethodsClass.DoMultiplication(num1, num2);



            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void DoMultiplication1Times100Test3()
        {

            // Arrange
            decimal num1 = 1;
            decimal num2 = 100;
            decimal expected = 100;

            // Act
            decimal actual = CalculationMethodsClass.DoMultiplication(num1, num2);



            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void DoMultiplicationNum1Zero()
        {

            // Arrange
            decimal num1 = 0;
            decimal num2 = 10;
            decimal expected = 0;

            // Act
            decimal actual = CalculationMethodsClass.DoMultiplication(num1, num2);



            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void DoMultiplicationNum2Zero()
        {

            // Arrange
            decimal num1 = 100;
            decimal num2 = 0;
            decimal expected = 0;

            // Act
            decimal actual = CalculationMethodsClass.DoMultiplication(num1, num2);



            // Assert
            Assert.Equal(expected, actual);

        }
    }

    public class DoSquareRootTests
    {
        [Fact]
        public void DoSquareRoot10Test()
        {

            // Arrange
            double num1 = 10;
            double expected = 3.1622776601683795;

            // Act
            double actual = CalculationMethodsClass.DoSquareRoot(num1);



            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void DoSquareRoot4Test()
        {

            // Arrange
            double num1 = 4;
            double expected = 2;

            // Act
            double actual = CalculationMethodsClass.DoSquareRoot(num1);



            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void DoSquareRoot9Test()
        {

            // Arrange
            double num1 = 9;
            double expected = 3;

            // Act
            double actual = CalculationMethodsClass.DoSquareRoot(num1);



            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void DoSquareRoot0Test()
        {

            // Arrange
            double num1 = 0;
            double expected = 0;

            // Act
            double actual = CalculationMethodsClass.DoSquareRoot(num1);



            // Assert
            Assert.Equal(expected, actual);

        }
    }

    public class DoPowerOfTests
    {
        [Fact]
        public void Do10PowerOf2Test()
        {

            // Arrange
            double num1 = 10;
            double num2 = 2;
            double expected = 100;

            // Act
            double actual = CalculationMethodsClass.DoPowerOf(num1, num2);



            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void DoPowerOfZeroTest()
        {
            // Apperently 0 to the power of 0 is 1 according to google/wiki so seems correct 
            // Arrange
            double num1 = 0;
            double num2 = 0;
            double expected = 1;

            // Act
            double actual = CalculationMethodsClass.DoPowerOf(num1, num2);



            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void DoPowerOfNum1ZeroTest()
        {

            // Arrange
            double num1 = 0;
            double num2 = 10;
            double expected = 0;

            // Act
            double actual = CalculationMethodsClass.DoPowerOf(num1, num2);



            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void DoPowerOfNum2ZeroTest()
        {

            // Arrange
            double num1 = 10;
            double num2 = 0;
            double expected = 1;

            // Act
            double actual = CalculationMethodsClass.DoPowerOf(num1, num2);

            // Assert
            Assert.Equal(expected, actual);

        }
    }
    
    public class DoStringInputTest
    {
        //[Fact]
        public void StringIsNullTest()
        {
            //Arrange


            //Act



            //Assert 

            // https://makolyte.com/csharp-how-to-unit-test-code-that-reads-and-writes-to-the-console/
        }
    }

    
}