using Xunit;

namespace Tests;

public class Class1
{
    [Fact]
    public void SimpleTest()
    {
        int result = new Calculator().Add(1,2);
        Assert.Equal(3,result);
    }
}