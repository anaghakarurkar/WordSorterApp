namespace WordSorter.Tests;
using FluentAssertions;

public class Tests
{
    private Sorter _sorter;
    

    [SetUp]
    public void Setup()
    {
        _sorter = new Sorter(null);
        
    }

    [Test]
    public void When_The_String_Is_Null()
    {
        _sorter.ArrangeWords().Should().BeNull();
    }
}