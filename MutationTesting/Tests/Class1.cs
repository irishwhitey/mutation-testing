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
    
    [Fact]
    public void SimpleTest2()
    {
        int result = new Calculator().Add(10,2);
        Assert.Equal(8,result);
    }
}