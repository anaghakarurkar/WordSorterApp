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

    [Test]
    public void When_The_Sentence_Has_One_Word_Should_Return_Correct_Count()
    {
        _sorter.Sentence = "Hello"; 
        int count = _sorter.ArrangeWords().Count();
        count.Should().Be(1);
    }


    [Test]
    public void When_The_Sentence_Two__Words_Should_Return_Correct_Count()
    {
        _sorter.Sentence = "Hello Dear";
        int count = _sorter.ArrangeWords().Count();
        count.Should().Be(2);
    }

}