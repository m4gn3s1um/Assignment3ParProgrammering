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
        bs.getInt();
        Assert.That();
    }
    
    [Test]
    public void TestRemove()
    {
        Assert.Pass();
    }
    
    [Test]
    public void TestCount()
    {
        Assert.Pass();
    }
    
}