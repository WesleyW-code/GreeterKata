
using NUnit.Framework;
using System;

[TestFixture]
public class GreeterTests
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual("Welcome", Kata.Greet("english"));
        
    }
    [Test]
    public void Test2()
    {
        Assert.AreEqual("Welkom", Kata.Greet("dutch"));
        
    }
    [Test]
    public void Test3()
    {
        Assert.AreEqual("Welcome", Kata.Greet("IP_ADDRESS_INVALID"));
        
    }
    [Test]
    public void Test4()
    {
        Assert.AreEqual("Welcome", Kata.Greet(""));
        
    }
    [Test]
    public void Test5()
    {
        Assert.AreEqual("Welcome", Kata.Greet("2"));
    }
}