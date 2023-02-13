using _02;
using NUnit.Framework;

namespace Tests;

public class Tests02
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void CheckParenthesis_ShouldFail_WhenStrStartsWithClosingParenthesis()
    {
        // aaa
        // Arrange -> prepare test
        var str = ")asaaa";

        // Act -> execute action
        var result = Program.CheckParenthesis(str);

        // Assert -> verify (1)
        Assert.That(result, Is.EqualTo(false));
    }
    
    [Test]
    public void CheckParenthesis_ShouldFail_WhenStrHasDifferentParenthesisAmount()
    {
        // aaa
        // Arrange -> prepare test
        var str = "(()";

        // Act -> execute action
        var result = Program.CheckParenthesis(str);

        // Assert -> verify (1)
        Assert.That(result, Is.EqualTo(false));
    }
    
    [Test]
    public void CheckParenthesis_ShouldSucceed_WhenStrHasSameParenthesisAmout()
    {
        // aaa
        // Arrange -> prepare test
        var str = "()()(())";

        // Act -> execute action
        var result = Program.CheckParenthesis(str);

        // Assert -> verify (1)
        Assert.That(result, Is.EqualTo(true));
    }
    
    [Test]
    public void CheckParenthesis_ShouldSucceed_WhenStrIsEmpty()
    {
        // aaa
        // Arrange -> prepare test
        var str = string.Empty;

        // Act -> execute action
        var result = Program.CheckParenthesis(str);

        // Assert -> verify (1)
        Assert.That(result, Is.EqualTo(true));
    }
    
    [Test]
    public void CheckParenthesis_ShouldSucceed_WhenStrHasNoParenthesis()
    {
        // aaa
        // Arrange -> prepare test
        var str = "asaaa";

        // Act -> execute action
        var result = Program.CheckParenthesis(str);

        // Assert -> verify (1)
        Assert.That(result, Is.EqualTo(true));
    }
}