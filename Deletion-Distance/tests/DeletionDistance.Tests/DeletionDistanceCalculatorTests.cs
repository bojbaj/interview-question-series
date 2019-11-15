using System;
using DeletionDistance.lib;
using Xunit;

namespace DeletionDistance.Tests
{
    public class DeletionDistanceCalculatorTests
    {
        [Fact]
        public void Input_Dog_Frog_Output_Is_3()
        {
            DeletionDistanceCalculator calc = new DeletionDistanceCalculator();
            Assert.Equal(3, calc.CalculateDistance("dog", "frog"));
        }
        [Fact]
        public void Input_Some_Some_Output_Is_0()
        {
            DeletionDistanceCalculator calc = new DeletionDistanceCalculator();
            Assert.Equal(0, calc.CalculateDistance("some", "some"));
        }
        [Fact]
        public void Input_Some_Thing_Output_Is_9()
        {
            DeletionDistanceCalculator calc = new DeletionDistanceCalculator();
            Assert.Equal(9, calc.CalculateDistance("some", "thing"));
        }
        [Fact]
        public void Input_EmptyString_EmptyString_Output_Is_0()
        {
            DeletionDistanceCalculator calc = new DeletionDistanceCalculator();
            Assert.Equal(0, calc.CalculateDistance("", ""));
        }
        [Fact]
        public void Input_Some_Some_InCaseSensitive_Output_Is_0()
        {
            DeletionDistanceCalculator calc = new DeletionDistanceCalculator();
            Assert.Equal(2, calc.CalculateDistance("some", "Some"));
        }
    }
}
