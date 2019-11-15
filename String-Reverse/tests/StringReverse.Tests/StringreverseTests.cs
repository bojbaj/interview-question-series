using System;
using StringReverse.lib;
using Xunit;

namespace StringReverse.Tests
{
    public class StringreverseTests
    {
        [Fact]
        public void Reverse_Hello_Is_Olleh()
        {
            StringUtility util = new StringUtility();
            Assert.Equal("olleh", util.Reverse("hello"));
        }
        [Fact]
        public void Reverse_EmptyString_Is_EmptyString()
        {
            StringUtility util = new StringUtility();
            Assert.Equal("", util.Reverse(""));
        }
        [Fact]
        public void Reverse_A_Is_A()
        {
            StringUtility util = new StringUtility();
            Assert.Equal("A", util.Reverse("A"));
        }
        [Fact]
        public void Reverse_AZ_Is_ZA()
        {
            StringUtility util = new StringUtility();
            Assert.Equal("ZA", util.Reverse("AZ"));
        }
        [Fact]
        public void Reverse_XYZ_Is_ZYX()
        {
            StringUtility util = new StringUtility();
            Assert.Equal("ZYX", util.Reverse("XYZ"));
        }
        [Fact]
        public void Reverse_Book_Is_Koob()
        {
            StringUtility util = new StringUtility();
            Assert.Equal("kooB", util.Reverse("Book"));
        }
    }
}
