using System;
using RectangleFinder.lib;
using Xunit;

namespace RectangleFinder.Tests
{
    public class RectangleTest
    {
        [Fact]
        public void Count_Rectangles_In_One_By_One_Matrix_Should_Return_1()
        {
            int[,] input = { { 1 } };
            int output = 0;
            RectangleCalc recObj = new RectangleCalc();
            output = recObj.CountInMatrix(input);
            Assert.Equal(1, output);
        }
        [Fact]
        public void Count_Rectangles_In_One_By_Two_Matrix_Should_Return_3()
        {
            int[,] input = { { 1, 2 } };
            int output = 0;
            RectangleCalc recObj = new RectangleCalc();
            output = recObj.CountInMatrix(input);
            Assert.Equal(3, output);
        }
        [Fact]
        public void Count_Rectangles_In_Two_By_Two_Matrix_Should_Return_9()
        {
            int[,] input = { { 1, 2 }, { 2, 4 } };
            int output = 0;
            RectangleCalc recObj = new RectangleCalc();
            output = recObj.CountInMatrix(input);
            Assert.Equal(9, output);
        }
        [Fact]
        public void Count_Rectangles_In_Two_By_Three_Matrix_Should_Return_18()
        {
            int[,] input = { { 1, 2, 3 }, { 2, 4, 5 } };
            int output = 0;
            RectangleCalc recObj = new RectangleCalc();
            output = recObj.CountInMatrix(input);
            Assert.Equal(18, output);
        }
        [Fact]
        public void Count_Rectangles_In_Three_By_Three_Matrix_Should_Return_36()
        {
            int[,] input = { { 1, 2, 3 }, { 2, 4, 5 }, { 1, 2, 3 } };
            int output = 0;
            RectangleCalc recObj = new RectangleCalc();
            output = recObj.CountInMatrix(input);
            Assert.Equal(36, output);
        }       
    }
}
