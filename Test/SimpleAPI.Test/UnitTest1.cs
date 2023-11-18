using System;
using Xunit;
using MyApp.Namespace;


namespace SimpleAPI.Test;
public class UnitTest1
{
    ValueController controller = new ValueController();
    
    [Fact]
    public void GetReturnMyName()
    {
        var returnValue = controller.getString();
        Assert.Equal("Some result", returnValue.Value);
    }

    [Fact]
    public void Test1()
    {

    }
}