public class Series
{
    private MultiIndex _index;
    private double[] _values;
    
    public Series(string names, object[] index, double[] data)
    {
        this._index = new MultiIndex(names, index);
        this._values = data;
    }
    
    public Series(string[] names, object[][] index, double[] data)
    {
        // Todo if index == null, auto-index as range(length)
        
        if (indexTuples.Length != values.Length)
        {
            throw new ValueErrorException("Data and index lengths do not match");
        }
        
        this._index = MultiIndex.FromTuples(names, index);
        this.values = data;
    }
}