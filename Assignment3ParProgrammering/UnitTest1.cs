using NUnit.Framework.Internal;

namespace Assignment3ParProgrammering;

public class Tests
{
    
    
    BagSorter bs = new BagSorter();
    [SetUp]
    public void Setup()
    {
        

        List<int> integers = new List<int>();
        integers.Add(12);
        integers.Add(4);
        integers.Add(17);

        bs.intList = integers;

    }

    [Test]
    public void TestAdd()
    {
        bs.addInt(3);
        
        Assert.That(bs.intList.Count == 4);
    }
    
    [Test]
    public void TestGet()
    {
        Assert.That(bs.getInt() == 4);
    }
    
    [Test]
    public void TestRemove()
    {
        bs.removeInt();
        Assert.That(bs.intList.Count == 2);
    }
    
    [Test]
    public void TestCount()
    {
        
        Assert.That(bs.countInt() == 3);
    }
    
}