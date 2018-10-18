using Xunit;

namespace Linq2Ldap.Tests.Types {
    public class LDAPIntTests {

        [InlineData(new [] { "123" }, 123, true)]
        [InlineData(new [] { "123", "456" }, 567, false)]
        [InlineData(new string[] { }, 567, false)]
        [Theory]
        public void Equals_AnyEquals_True(string[] input, int toFind, bool expected) {
            var test = new LDAPInt(input);
            var actual = test == toFind;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Equals_LeftNull() {
            LDAPInt test = null;
            Assert.False(test == 456);
            Assert.True(test == null);
        }

        [InlineData(new [] { "123", "456" }, 123, false)]
        [InlineData(new [] { "123", "456" }, 567, true)]
        [InlineData(new string[] { }, 567, true)]
        [Theory]
        public void NotEquals_AnyEquals_True(string[] input, int toFind, bool expected) {
            var test = new LDAPInt(input);
            var actual = test != toFind;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NotEquals_LeftNull() {
            LDAPInt test = null;
            Assert.True(test != 456);
            Assert.False(test != null);
        }

        [InlineData(new [] { "123", "456" }, 456, false)]
        [InlineData(new [] { "123", "456" }, 123, true)]
        [InlineData(new [] { "123", "456" }, 567, false)]
        [InlineData(new string[] { }, 567, false)]
        [Theory]
        public void GreaterThanEqual_AnyGTE_True(string[] input, int toFind, bool expected) {
            var test = new LDAPInt(input);
            var actual = test >= toFind;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GreaterThanEqual_LeftNull() {
            LDAPInt test = null;
            Assert.False(test >= 456);
        }

        [InlineData(new [] { "123", "456" }, 123, true)]
        [InlineData(new [] { "123", "456" }, 12, false)]
        [InlineData(new [] { "123", "456" }, 567, true)]
        [InlineData(new string[] { }, 567, false)]
        [Theory]
        public void LessThanEqual_AnyLTE_True(string[] input, int toFind, bool expected) {
            var test = new LDAPInt(input);
            var actual = test <= toFind;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LessThanEqual_LeftNull() {
            LDAPInt test = null;
            Assert.False(test <= 456);
        }

        [InlineData(new [] { "123", "456" }, 456, true)]
        [InlineData(new [] { "123", "456" }, 123, false)]
        [InlineData(new string[] { }, 567, false)]
        [Theory]
        public void LessThan_AnyLessThan_True(string[] input, int toFind, bool expected) {
            var test = new LDAPInt(input);
            var actual = test < toFind;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LessThan_LeftNull() {
            LDAPInt test = null;
            Assert.False(test < 456);
        }

        [InlineData(new [] { "123", "456" }, 456, false)]
        [InlineData(new [] { "123", "456" }, 122, true)]
        [InlineData(new [] { "123", "456" }, 123, false)]
        [InlineData(new string[] { }, 567, false)]
        [Theory]
        public void GreaterThan_AnyLessThan_True(string[] input, int toFind, bool expected) {
            var test = new LDAPInt(input);
            var actual = test > toFind;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GreaterThan_LeftNull() {
            LDAPInt test = null;
            Assert.False(test > 456);
        }

        [InlineData(new [] { "123", "456" }, "12", true)]
        [InlineData(new [] { "123", "456" }, "1", true)]
        [InlineData(new [] { "123", "456" }, "23", false)]
        [InlineData(new [] { "123", "456" }, "4", false)]
        [InlineData(new string[] { }, "567", false)]
        [Theory]
        public void StartsWith_Any_True(string[] input, string toFind, bool expected) {
            var test = new LDAPInt(input);
            var actual = test.StartsWith(toFind);
            Assert.Equal(expected, actual);
        }

        [InlineData(new [] { "123", "456" }, "23", true)]
        [InlineData(new [] { "123", "456" }, "3", true)]
        [InlineData(new [] { "123", "456" }, "123", true)]
        [InlineData(new [] { "123", "456" }, "12", false)]
        [InlineData(new string[] { }, "567", false)]
        [Theory]
        public void EndsWith_Any_True(string[] input, string toFind, bool expected) {
            var test = new LDAPInt(input);
            var actual = test.EndsWith(toFind);
            Assert.Equal(expected, actual);
        }

        [InlineData(new [] { "123", "456" }, "12", true)]
        [InlineData(new [] { "123", "456" }, "123", true)]
        [InlineData(new [] { "123", "456" }, "23", true)]
        [InlineData(new [] { "123", "456" }, "2", true)]
        [InlineData(new [] { "123", "456" }, "1", true)]
        [InlineData(new [] { "123", "456" }, "4", false)]
        [InlineData(new string[] { }, "567", false)]
        [Theory]
        public void Contains_Any_True(string[] input, string toFind, bool expected) {
            var test = new LDAPInt(input);
            var actual = test.Contains(toFind);
            Assert.Equal(expected, actual);
        }
    }
}