namespace Assignment3ParProgrammering;

public class BagSorter : BagSortInt
{
    public List<int> intList { get; set; }
    
    public void addInt(int x)
    {
        intList.Add(x);
    }

    public int getInt()
    {
        return intList.Min();
    }

    public void removeInt()
    {
        intList.Remove(intList.Min());
    }

    public int countInt()
    {
        return intList.Count;
    }
}