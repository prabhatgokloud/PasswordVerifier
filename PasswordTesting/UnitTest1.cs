
using passwordVerifer;
namespace PasswordTesting
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Apple1235", true)]
        [InlineData("asdgajjk", false)]
        [InlineData("Prabhat6969", true)]
        [InlineData("kkkk", false)]
        [InlineData("12345",false)]
        [InlineData("",false)]
        [InlineData("   ",false)]
        [InlineData("LHFUYHJGJH",false)]
        [InlineData("Password123",true)]
        [InlineData("Gokloud123",true)]

        

        public void Test1(string password, bool expected)
        {
            var actual = verifier.VerifyPassword(password);
            Assert.Equal(actual, expected);


        }
    }
}