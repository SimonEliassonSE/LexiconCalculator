
namespace Calculator.Tests

{
    public class DoAdditionTests
    {
        [Fact]
        public void AdditionTest()
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
            decimal expected = 10;

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
}